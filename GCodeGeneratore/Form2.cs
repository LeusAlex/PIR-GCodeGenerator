using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace GCodeGeneratore
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
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

                double toolDiameter = double.Parse(textBoxDiamFrez.Text);
                double toolOverlap = double.Parse(textBoxPTool.Text);
                double xLength = double.Parse(textBoxX.Text);
                double yLength = double.Parse(textBoxY.Text);
                double zHeigth = double.Parse(textBoxZ.Text);
                double zStep = double.Parse(textBoxDZ.Text);
                double xyFeedRate = double.Parse(textBoxV.Text);
                double zFeedRate = double.Parse(textBoxVZ.Text);


                // Генерируем G-код
                string gCode = GenerateGCode(toolDiameter, xLength, yLength, zHeigth, zStep, toolOverlap, xyFeedRate, zFeedRate);

                // Создаём файл txt и записываем G-код
                string filePath = "generated_gcode.txt";
                File.WriteAllText(filePath, gCode);

                MessageBox.Show("Файл G-кода сгенерирован успешно!");
            }
        }

        private string GenerateGCode(double toolDiameter, double xLength, double yLength, double zHeigth, double zStep, double toolOverlap, double xyFeedRate, double zFeedRate)
        {
            
            string gCode = "";

            // Установите единицы измерения в миллиметрах
            gCode += "G21 ; Set units to millimeters\n";

            // Установите абсолютный режим
            gCode += "G90 ; Absolute mode\n";

            // Установите режим быстрого позиционирования
            gCode += "G00 ; Rapid positioning\n";

            double xCurrent = -toolDiameter / 2;
            double yCurrent = -toolDiameter /2;
            double zCurrent = 0;
            double spiralXSize = xLength + toolDiameter;
            double spiralYSize = yLength + toolDiameter;

            while (zCurrent >= -zHeigth)
            {
                // Обработать текущую спираль
                while (xCurrent < xLength / 2 + toolOverlap && yCurrent < yLength / 2 + toolOverlap)
                {
                    // Перейти к начальной точке               
                    gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(xCurrent, 3), Math.Round(yCurrent, 3), xyFeedRate);
                    // Перейти вперед
                    gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(xCurrent + spiralXSize, 3), Math.Round(yCurrent, 3), xyFeedRate);

                    // Перейти влево
                    gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(xCurrent + spiralXSize, 3), Math.Round(yCurrent + spiralYSize, 3), xyFeedRate);

                    // Перейти назад
                    gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(xCurrent, 3), Math.Round(yCurrent + spiralYSize, 3), xyFeedRate);

                    // Перейти вправо
                    gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(xCurrent, 3), Math.Round(yCurrent, 3), xyFeedRate);


                    // Уменьшить размер спирали на значение перекрытия инструмента
                    spiralXSize -= 2 * toolOverlap;
                    spiralYSize -= 2 * toolOverlap;
                    xCurrent += toolOverlap;
                    yCurrent += toolOverlap;

                }
                // Возвращаем начальные координаты для нового уровня
                xCurrent = -toolDiameter / 2;
                yCurrent = -toolDiameter / 2;
                spiralXSize = xLength + toolDiameter;
                spiralYSize = yLength + toolDiameter;
                // Перейти к начальной точке
                gCode += string.Format(CultureInfo.InvariantCulture, "G01 X{0:F3} Y{1:F3} F{2} ; Перейти к ({0}, {1})\n", Math.Round(xCurrent, 3), Math.Round(yCurrent, 3), xyFeedRate);
                // Перейти к следующему уровню Z
                zCurrent -= zStep;
                gCode += $"G01 Z{zCurrent} F{zFeedRate} ; Перейти к Z={zCurrent}\n";
            }

            return gCode;
        }

        private void textBoxDiamFrez_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxDiamFrez.Text;

            if (!string.IsNullOrEmpty(text))
            {
                int значение;
                if (!int.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxDiamFrez.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ! \nДиаметр фрезы - целое положительное число");
                }
            }
        }

        private void textBoxPTool_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxPTool.Text;

            if (!string.IsNullOrEmpty(text))
            {
                int значение;
                if (!int.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxPTool.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ! \nПерекрытие инструмента - целое положительное число");
                }
            }
        }

        private void textBoxV_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxV.Text;

            if (!string.IsNullOrEmpty(text))
            {
                int значение;
                if (!int.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxV.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ! \nПодача - целое положительное число");
                }
            }
        }

        private void textBoxVZ_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxVZ.Text;

            if (!string.IsNullOrEmpty(text))
            {
                int значение;
                if (!int.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxVZ.Clear();
                    MessageBox.Show("УЧИ МАТЧАСТЬ! \nПодача - целое положительное число");
                }
            }
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxX.Text;

            if (!string.IsNullOrEmpty(text))
            {
                int значение;
                if (!int.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxX.Clear();
                    MessageBox.Show("Дельта - целое положительное число");
                }
            }
        }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxY.Text;

            if (!string.IsNullOrEmpty(text))
            {
                int значение;
                if (!int.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxY.Clear();
                    MessageBox.Show("Дельта - целое положительное число");
                }
            }
        }

        private void textBoxZ_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxZ.Text;

            if (!string.IsNullOrEmpty(text))
            {
                int значение;
                if (!int.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxZ.Clear();
                    MessageBox.Show("Введите целое положительное число");
                }
            }
        }

        private void textBoxDZ_TextChanged(object sender, EventArgs e)
        {
            string text = textBoxDZ.Text;

            if (!string.IsNullOrEmpty(text))
            {
                int значение;
                if (!int.TryParse(text, out значение) || значение <= 0)
                {
                    textBoxDZ.Clear();
                    MessageBox.Show("Введите целое положительное число");
                }
            }
        }
    }
}
