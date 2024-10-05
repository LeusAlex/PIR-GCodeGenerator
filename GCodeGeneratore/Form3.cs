using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace GCodeGeneratore
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void GenerateGCode_Click(object sender, EventArgs e)
        {

            bool всеTextBoxesFilled = true;

            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        всеTextBoxesFilled = false;
                        break;
                    }
                }
            }

            if (!всеTextBoxesFilled)
            {
                MessageBox.Show("Все текстовые поля должны быть заполнены");
            }
            else
            {
                // код, который будет выполнен, если все текстовые поля заполнены

                double toolDiameter = double.Parse(textBoxToolDiameter.Text);
                double toolOverlap = double.Parse(textBoxToolOverlap.Text);
                double xyFeedRate = double.Parse(textBoxXYFeedRate.Text);
                double zFeedRate = double.Parse(textBoxZFeedRate.Text);
                double centerX = double.Parse(textBoxCenterX.Text);
                double centerY = double.Parse(textBoxCenterY.Text);
                double holeDiameter = double.Parse(textBoxHoleDiameter.Text);
                double totalDepth = double.Parse(textBoxTotalDepth.Text);
                double depthPerPass = double.Parse(textBoxDepthPerPass.Text);
                double angularDepthMovementX = double.Parse(textBoxAngularDepthMovementX.Text);
                double angularDepthAngle = double.Parse(textBoxAngularDepthAngle.Text);



                // Генерируем G-код
                string gCode = GenerateGCode2(toolDiameter, toolOverlap, xyFeedRate, zFeedRate, centerX, centerY, holeDiameter, totalDepth, depthPerPass, angularDepthMovementX, angularDepthAngle);

                // Создаём файл txt и записываем G-код
                string filePath = "generated_hole_gcode.txt";
                File.WriteAllText(filePath, gCode);

                MessageBox.Show("Файл G-кода сгенерирован успешно!");
            }
        }

        //Расчет траекторий 
        private string GenerateGCode2(double toolDiameter,double toolOverlap,double xyFeedRate,double zFeedRate,double centerX,double centerY,double holeDiameter,double totalDepth,double depthPerPass,double angularDepthMovementX,double angularDepthAngle)
        {
            string gCode = "";

            // Установить единицы измерения в миллиметрах
            gCode += "G21 ; Установить единицы измерения в миллиметрах\n";

            // Абсолютный режим
            gCode += "G90 ; Абсолютный режим\n";

            // Быстрое позиционирование
            gCode += "G00 ; Быстрое позиционирование\n";

            // Рассчитать радиус отверстия
            double holeRadius = holeDiameter / 2;

            // Рассчитать количество проходов
            int numberOfPasses = (int)Math.Ceiling(totalDepth / depthPerPass);

            // Рассчитать угловое заглубление по Z 
            double angularDepthAngleRad = angularDepthAngle * Math.PI / 180;

            // Рассчитать перемещение по Z для углового заглубления
            double angularDepthMovementZActual = angularDepthMovementX * Math.Sin(angularDepthAngleRad);

            // Перейти к начальной точке
            gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n" , Math.Round(centerX, 3), Math.Round(centerY, 3), xyFeedRate);
            gCode += $"G01 Z{0} F{zFeedRate} ; Перейти к (Z0)\n";


            // Обработать каждый проход
            for (int i = 0; i < numberOfPasses - 1; i++)
            {
                // Рассчитать текущую глубину
                double currentDepth = i * depthPerPass;

                // Угловое заглубление
                for (double dZ = -currentDepth; dZ > -currentDepth - depthPerPass; dZ -= angularDepthMovementZActual)
                {
                    gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(centerX - angularDepthMovementX / 2, 3), Math.Round(centerY, 3), xyFeedRate);
                    gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} Z{2:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(centerX + angularDepthMovementX / 2, 3), Math.Round(centerY, 3), Math.Round(dZ, 3), xyFeedRate);
                   // gCode += $"G01 X{centerX - angularDepthMovementX / 2} Y{centerY} F{xyFeedRate} ; Угловое заглубление\n";
                   // gCode += $"G01 X{centerX + angularDepthMovementX / 2} Y{centerY} Z{dZ} F{xyFeedRate} ; Угловое заглубление\n";
                }
                // Перейти к начальной точке
                gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(centerX - angularDepthMovementX / 2, 3), Math.Round(centerY, 3), xyFeedRate);
                gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} Z{2:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(centerX + angularDepthMovementX / 2, 3), Math.Round(centerY, 3), Math.Round(-currentDepth - depthPerPass), xyFeedRate);
                gCode += $"G01 X{centerX} Y{centerY} F{xyFeedRate} ; Перейти к ({centerX}, {centerY})\n";

                for (double acRadius = toolOverlap; acRadius + toolDiameter/2 < holeRadius; acRadius += toolOverlap)
                {
                    // Обработать круговое движение
                    for (double angle = 0; angle < 2 * Math.PI; angle += 0.01)
                    {
                        // Рассчитать координаты точки на окружности
                        double x = Math.Round(centerX + acRadius * Math.Cos(angle), 3);
                        double y = Math.Round(centerY + acRadius * Math.Sin(angle), 3);

                        // Перейти к точке на окружности
                        gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(x, 3), Math.Round(y, 3), xyFeedRate);
                    }
                }

                // Чистовой проход по периметру отверстия 
                for (double angle = 0; angle < 2 * Math.PI; angle += 0.01)
                {
                    // Рассчитать координаты точки на окружности
                    double x = Math.Round(centerX + (holeRadius - toolDiameter / 2) * Math.Cos(angle), 4);
                    double y = Math.Round(centerY + (holeRadius - toolDiameter / 2) * Math.Sin(angle), 4);

                    // Перейти к точке на окружности
                    gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(x, 3), Math.Round(y, 3), xyFeedRate);

                }            
            }
            return gCode;
        }






        private void textBoxToolDiameter_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxToolDiameter.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxToolDiameter.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ! \nДиаметр фрезы - положительное число");
                }
            }
        }

        private void textBoxToolOverlap_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxToolOverlap.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxToolOverlap.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nЭКОНОМЬ МЕТАЛЛ!\nВведи положительное число");
                }
            }
        }

        private void textBoxXYFeedRate_TextChanged(object sender, EventArgs e)
        {
      
        string text = textBoxXYFeedRate.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxXYFeedRate.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ! \n Назад не поедем! \nВведи положительное число");
                }
            }          
        }

        private void textBoxZFeedRate_TextChanged(object sender, EventArgs e)
        {

            string text = textBoxZFeedRate.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxZFeedRate.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ! \n Назад не поедем! \nВведи положительное число");
                }
            }
        }

        private void textBoxCenterX_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxCenterX.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxCenterX.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nДавай останемся в границах станка?\nВведи положительное число");
                }
            }
        }

        private void textBoxCenterY_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxCenterY.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxCenterY.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nДавай останемся в границах станка?\nВведи положительное число");
                }
            }
        }

        private void textBoxHoleDiameter_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxHoleDiameter.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxHoleDiameter.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nНужен неотрицательный диаметр! Мы не будем делать черную дыру!\nВведи положительное число");
                }
            }
        }

        private void textBoxTotalDepth_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxTotalDepth.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxTotalDepth.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nФрезеруем сверху-вниз\nВведи положительное число");
                }
            }
        }

        private void textBoxDepthPerPass_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxDepthPerPass.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxDepthPerPass.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nВведи положительное число");
                }
            }

        }

        private void textBoxAngularDepthMovementX_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxAngularDepthMovementX.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxAngularDepthMovementX.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nВведи положительное число");
                }
            }
        }

        private void textBoxAngularDepthAngle_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxAngularDepthAngle.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxAngularDepthAngle.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nВведи положительное число");
                }
            }
        }
    }
}
