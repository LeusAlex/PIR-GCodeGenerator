using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCodeGeneratore
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            cmbMillingDirection.Items.Add("Снизу-вверх");
            cmbMillingDirection.Items.Add("Сверху-вниз");
            cmbMillingDirection.SelectedIndex = 1; // выбрать "Сверху-вниз" по умолчанию

            cmbThreadDirection.Items.Add("Левое");
            cmbThreadDirection.Items.Add("Правое");
            cmbThreadDirection.SelectedIndex = 1; // выбрать "Правое" по умолчанию

        }
        private void cmbMillingDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbThreadDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GenerateGCodeThread_Click(object sender, EventArgs e)
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

                double toolRadius = double.Parse(textBoxToolDiameter.Text) / 2;
                double xyFeedRate = double.Parse(textBoxXYFeedRate.Text);
                double zFeedRate = double.Parse(textBoxZFeedRate.Text);
                double centerX = double.Parse(textBoxCenterX.Text);
                double centerY = double.Parse(textBoxCenterY.Text);
                double threadDiameter = double.Parse(textBoxThreadDiameter.Text);
                double totalDepth = double.Parse(textBoxTotalDepth.Text);
                double threadStep = double.Parse(textBoxThreadStep.Text);
                int numberThread = int.Parse(textBoxNumberThread.Text);
                string millingDirection = cmbMillingDirection.SelectedItem.ToString();
                string threadDirection = cmbThreadDirection.SelectedItem.ToString();

                // Генерация G-кода
                string gCode = GenerateGCode3(millingDirection, threadDirection, totalDepth, threadStep, toolRadius, threadDiameter, xyFeedRate, zFeedRate, centerX, centerY, numberThread);
                string filePath = "generated_thread_gcode.txt";
                File.WriteAllText(filePath, gCode);
                MessageBox.Show("Файл G-кода сгенерирован успешно!");
            }
        }

        //Расчет траектории
        private string GenerateGCode3(string millingDirection, string threadDirection, double totalDepth, double threadStep, double toolRadius, double threadDiameter, double xyFeedRate, double zFeedRate, double centerX, double centerY, int numberThread)
        {
            
             string gCode = "";

             // Заголовок
             gCode += "; Сгенерированный G-код\n";
             gCode += "G21 ; Установка единиц измерения в миллиметрах\n";
             gCode += "G90 ; Абсолютный режим\n";

            // Расчет для спиральной траектории
            double circleRadius = threadDiameter/2 - toolRadius;
            double z = 0;
            double dAngle = 0;
            double zStep = 0;
            double def = 1;


            //Выбираем направление траектории
            if (millingDirection == "Сверху-вниз")
                {
                z = 0 + threadStep;
                zStep = -threadStep / 360;
                }
            if (millingDirection == "Снизу-вверх")
                {
                z = -totalDepth;
                zStep = threadStep / 360;
                def = -1;
                }
            //Выбираем направление резьбы
            if (threadDirection == "Правое")
            { dAngle = -1 * def; ; }
            if (threadDirection == "Левое")
            { dAngle = 1 * def; ; }

            //Делаем проходы
            for (int i = 0; i < numberThread; i++)
            {
                gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(centerX, 3), Math.Round(centerY, 3), xyFeedRate);
                gCode += string.Format(CultureInfo.InvariantCulture, "G01 Z{0:F3} F{1} ; Перейти к (Z{0}) \n", Math.Round(z, 3), zFeedRate);
                double actZ = z;
                // + i * 360 / numberThread
                for (double angle = dAngle * i * 360 / numberThread; Math.Abs(angle) <= Math.Abs(totalDepth / threadStep * 360 + i * 360 / numberThread + 360); angle += dAngle)
                {
                    double x = centerX + circleRadius * Math.Cos(Math.PI * angle / 180);
                    double y = centerY + circleRadius * Math.Sin(Math.PI * angle / 180);
                    gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} Z{2:F3} F{3} ; Спиральная траектория)\n", Math.Round(x, 3), Math.Round(y, 3), Math.Round(actZ, 3), Math.Round(xyFeedRate, 1));
                    actZ += zStep;
                }

            }
            // Footer
            gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(centerX, 3), Math.Round(centerY, 3), xyFeedRate);
            gCode += "G00 Z2 ; Перемещение на безопасную высоту Z\n";
            gCode += "M02 ; Конец программы\n";

            // Вывод сгенерированного G-кода
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

        private void textBoxXYFeedRate_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxXYFeedRate.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxXYFeedRate.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nПоедем вперед!\nвведи положительное число");
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
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nВведи положительное число");
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
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nСоблюдай границы!\nВведи положительное число");
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
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nСоблюдай границы!\nВведи положительное число");
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
                    MessageBox.Show("УЧИ МАТЧАСТЬ!\nВведи положительное число");
                }
            }
        }

        private void textBoxThreadDiameter_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxThreadDiameter.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxThreadDiameter.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ! \nДиаметр - положительное число");
                }
            }
        }

        private void textBoxThreadStep_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxThreadStep.Text;

            if (!string.IsNullOrEmpty(text))
            {
                double значение;
                if (!double.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxThreadStep.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ! \nШаг резьбы - положительное число");
                }
            }
        }

        private void textBoxNumberThread_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxNumberThread.Text;

            if (!string.IsNullOrEmpty(text))
            {
                int значение;
                if (!int.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxNumberThread.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ! \nМногозаходность - целое положительное число");
                }
            }
        }
    }
}
