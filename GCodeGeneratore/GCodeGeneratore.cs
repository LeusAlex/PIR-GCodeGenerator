using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCodeGeneratore
{
    public partial class GCodeGeneratore : Form
    {
        private Form2 form2;
        private Form3 form3;
        private Form4 form4;
        public GCodeGeneratore()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Предотвратить изменение размера Form1
            this.Text = "GCodeGeneratore";

            form2 = new Form2();
            form2.TopLevel = false;
            form2.AutoScroll = true;
            form2.FormBorderStyle = FormBorderStyle.None; // Удалить заголовок формы
            form2.Dock = DockStyle.Fill; // Заполнить всю панель
            panel1.Controls.Add(form2);

            form3 = new Form3();
            form3.TopLevel = false;
            form3.AutoScroll = true;
            form3.FormBorderStyle = FormBorderStyle.None; // Удалить заголовок формы
            form3.Dock = DockStyle.Fill; // Заполнить всю панель
            panel1.Controls.Add(form3);

            form4 = new Form4();
            form4.TopLevel = false;
            form4.AutoScroll = true;
            form4.FormBorderStyle = FormBorderStyle.None; // Удалить заголовок формы
            form4.Dock = DockStyle.Fill; // Заполнить всю панель
            panel1.Controls.Add(form4);

            string imagePath = Path.Combine(Application.StartupPath, "Images", "image1.jpg");
            if (File.Exists(imagePath))
            {
                Image image = Image.FromFile(imagePath);
                image = new Bitmap(image, new Size(180, 120));
                button1.Image = image;
                button1.ImageAlign = ContentAlignment.BottomCenter;
            }
            else
            {
                MessageBox.Show("Файл не найден: " + imagePath);
            }

            string imagePath2 = Path.Combine(Application.StartupPath, "Images", "image2.jpg");
            if (File.Exists(imagePath2))
            {
                Image image = Image.FromFile(imagePath2);
                image = new Bitmap(image, new Size(180, 120));
                button2.Image = image;
                button2.ImageAlign = ContentAlignment.BottomCenter;
            }
            else
            {
                MessageBox.Show("Файл не найден: " + imagePath2);
            }

            string imagePath3 = Path.Combine(Application.StartupPath, "Images", "image3.jpg");
            if (File.Exists(imagePath3))
            {
                Image image = Image.FromFile(imagePath3);
                image = new Bitmap(image, new Size(180, 120));
                button3.Image = image;
                button3.ImageAlign = ContentAlignment.BottomCenter;
            }
            else
            {
                MessageBox.Show("Файл не найден: " + imagePath3);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            form3.Hide();
            form4.Hide();
            labelStart.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2.Hide();
            form3.Show();
            form4.Hide();
            labelStart.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form2.Hide();
            form3.Hide();
            form4.Show();
            labelStart.Hide();
        }
    }
}
