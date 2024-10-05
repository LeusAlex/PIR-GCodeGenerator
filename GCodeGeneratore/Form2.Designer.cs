namespace GCodeGeneratore
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDiamFrez = new System.Windows.Forms.TextBox();
            this.Diametr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDZ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVZ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPTool = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDiamFrez
            // 
            this.textBoxDiamFrez.Location = new System.Drawing.Point(241, 121);
            this.textBoxDiamFrez.Name = "textBoxDiamFrez";
            this.textBoxDiamFrez.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiamFrez.TabIndex = 0;
            this.textBoxDiamFrez.TextChanged += new System.EventHandler(this.textBoxDiamFrez_TextChanged);
            // 
            // Diametr
            // 
            this.Diametr.AutoSize = true;
            this.Diametr.Location = new System.Drawing.Point(72, 125);
            this.Diametr.Name = "Diametr";
            this.Diametr.Size = new System.Drawing.Size(118, 13);
            this.Diametr.TabIndex = 1;
            this.Diametr.Text = "Диаметр фрезы, мм: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дельта по Х, мм:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(612, 121);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 3;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxX_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дельта по У, мм:";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(612, 161);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 5;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxY_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Глубина обработки, мм:";
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(612, 226);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxZ.TabIndex = 7;
            this.textBoxZ.TextChanged += new System.EventHandler(this.textBoxZ_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Шаг по Z, мм:";
            // 
            // textBoxDZ
            // 
            this.textBoxDZ.Location = new System.Drawing.Point(612, 268);
            this.textBoxDZ.Name = "textBoxDZ";
            this.textBoxDZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxDZ.TabIndex = 9;
            this.textBoxDZ.TextChanged += new System.EventHandler(this.textBoxDZ_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Подача по XY, мм/мин:";
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(241, 226);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(100, 20);
            this.textBoxV.TabIndex = 11;
            this.textBoxV.TextChanged += new System.EventHandler(this.textBoxV_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Подача по Z, мм/мин:";
            // 
            // textBoxVZ
            // 
            this.textBoxVZ.Location = new System.Drawing.Point(240, 268);
            this.textBoxVZ.Name = "textBoxVZ";
            this.textBoxVZ.Size = new System.Drawing.Size(100, 20);
            this.textBoxVZ.TabIndex = 13;
            this.textBoxVZ.TextChanged += new System.EventHandler(this.textBoxVZ_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Перекрытие инструмента, мм:";
            // 
            // textBoxPTool
            // 
            this.textBoxPTool.Location = new System.Drawing.Point(241, 164);
            this.textBoxPTool.Name = "textBoxPTool";
            this.textBoxPTool.Size = new System.Drawing.Size(100, 20);
            this.textBoxPTool.TabIndex = 15;
            this.textBoxPTool.TextChanged += new System.EventHandler(this.textBoxPTool_TextChanged);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate.Location = new System.Drawing.Point(470, 310);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(300, 120);
            this.buttonGenerate.TabIndex = 16;
            this.buttonGenerate.Text = "Сгенерировать G-код";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(74, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Параметры фрезерования:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(479, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Геометрия обработки:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(60, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(301, 26);
            this.label10.TabIndex = 19;
            this.label10.Text = "Фрезерование плоскости ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxPTool);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxVZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Diametr);
            this.Controls.Add(this.textBoxDiamFrez);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDiamFrez;
        private System.Windows.Forms.Label Diametr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPTool;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}