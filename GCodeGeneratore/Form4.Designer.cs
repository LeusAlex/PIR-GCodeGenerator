namespace GCodeGeneratore
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GenerateGCodeThread = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbMillingDirection = new System.Windows.Forms.ComboBox();
            this.cmbThreadDirection = new System.Windows.Forms.ComboBox();
            this.textBoxToolDiameter = new System.Windows.Forms.TextBox();
            this.textBoxXYFeedRate = new System.Windows.Forms.TextBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.textBoxZFeedRate = new System.Windows.Forms.TextBox();
            this.textBoxCenterX = new System.Windows.Forms.TextBox();
            this.textBoxCenterY = new System.Windows.Forms.TextBox();
            this.textBoxThreadDiameter = new System.Windows.Forms.TextBox();
            this.textBoxTotalDepth = new System.Windows.Forms.TextBox();
            this.textBoxThreadStep = new System.Windows.Forms.TextBox();
            this.textBoxNumberThread = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры фрезерования:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(531, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Геометрия резьбы: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Диаметр фрезы, мм:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Подача по ХУ, мм/мин:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Наружный диаметр резьбы, мм:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Шаг резьбы, мм:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Координаты центра отверстия под резьбу: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "По Х, мм:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "По У, мм:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Направление резьбы:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Кол-во заходов резьбы:";
            // 
            // GenerateGCodeThread
            // 
            this.GenerateGCodeThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateGCodeThread.Location = new System.Drawing.Point(470, 310);
            this.GenerateGCodeThread.Name = "GenerateGCodeThread";
            this.GenerateGCodeThread.Size = new System.Drawing.Size(300, 120);
            this.GenerateGCodeThread.TabIndex = 11;
            this.GenerateGCodeThread.Text = "Сгенерировать G-код ";
            this.GenerateGCodeThread.UseVisualStyleBackColor = true;
            this.GenerateGCodeThread.Click += new System.EventHandler(this.GenerateGCodeThread_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Направление фрезерования:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(481, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Глубина резьбы, мм:";
            // 
            // cmbMillingDirection
            // 
            this.cmbMillingDirection.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbMillingDirection.FormattingEnabled = true;
            this.cmbMillingDirection.Location = new System.Drawing.Point(232, 290);
            this.cmbMillingDirection.Name = "cmbMillingDirection";
            this.cmbMillingDirection.Size = new System.Drawing.Size(121, 21);
            this.cmbMillingDirection.TabIndex = 14;
            // 
            // cmbThreadDirection
            // 
            this.cmbThreadDirection.FormattingEnabled = true;
            this.cmbThreadDirection.Location = new System.Drawing.Point(232, 329);
            this.cmbThreadDirection.Name = "cmbThreadDirection";
            this.cmbThreadDirection.Size = new System.Drawing.Size(121, 21);
            this.cmbThreadDirection.TabIndex = 15;
            // 
            // textBoxToolDiameter
            // 
            this.textBoxToolDiameter.Location = new System.Drawing.Point(191, 116);
            this.textBoxToolDiameter.Name = "textBoxToolDiameter";
            this.textBoxToolDiameter.Size = new System.Drawing.Size(100, 20);
            this.textBoxToolDiameter.TabIndex = 16;
            this.textBoxToolDiameter.TextChanged += new System.EventHandler(this.textBoxToolDiameter_TextChanged);
            // 
            // textBoxXYFeedRate
            // 
            this.textBoxXYFeedRate.Location = new System.Drawing.Point(191, 147);
            this.textBoxXYFeedRate.Name = "textBoxXYFeedRate";
            this.textBoxXYFeedRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxXYFeedRate.TabIndex = 17;
            this.textBoxXYFeedRate.TextChanged += new System.EventHandler(this.textBoxXYFeedRate_TextChanged);
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(57, 185);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(119, 13);
            this.lab1.TabIndex = 18;
            this.lab1.Text = "Подача по Z, мм/мин:";
            // 
            // textBoxZFeedRate
            // 
            this.textBoxZFeedRate.Location = new System.Drawing.Point(191, 182);
            this.textBoxZFeedRate.Name = "textBoxZFeedRate";
            this.textBoxZFeedRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxZFeedRate.TabIndex = 19;
            this.textBoxZFeedRate.TextChanged += new System.EventHandler(this.textBoxZFeedRate_TextChanged);
            // 
            // textBoxCenterX
            // 
            this.textBoxCenterX.Location = new System.Drawing.Point(568, 135);
            this.textBoxCenterX.Name = "textBoxCenterX";
            this.textBoxCenterX.Size = new System.Drawing.Size(100, 20);
            this.textBoxCenterX.TabIndex = 20;
            this.textBoxCenterX.TextChanged += new System.EventHandler(this.textBoxCenterX_TextChanged);
            // 
            // textBoxCenterY
            // 
            this.textBoxCenterY.Location = new System.Drawing.Point(568, 156);
            this.textBoxCenterY.Name = "textBoxCenterY";
            this.textBoxCenterY.Size = new System.Drawing.Size(100, 20);
            this.textBoxCenterY.TabIndex = 21;
            this.textBoxCenterY.TextChanged += new System.EventHandler(this.textBoxCenterY_TextChanged);
            // 
            // textBoxThreadDiameter
            // 
            this.textBoxThreadDiameter.Location = new System.Drawing.Point(664, 218);
            this.textBoxThreadDiameter.Name = "textBoxThreadDiameter";
            this.textBoxThreadDiameter.Size = new System.Drawing.Size(100, 20);
            this.textBoxThreadDiameter.TabIndex = 22;
            this.textBoxThreadDiameter.TextChanged += new System.EventHandler(this.textBoxThreadDiameter_TextChanged);
            // 
            // textBoxTotalDepth
            // 
            this.textBoxTotalDepth.Location = new System.Drawing.Point(664, 190);
            this.textBoxTotalDepth.Name = "textBoxTotalDepth";
            this.textBoxTotalDepth.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalDepth.TabIndex = 23;
            this.textBoxTotalDepth.TextChanged += new System.EventHandler(this.textBoxTotalDepth_TextChanged);
            // 
            // textBoxThreadStep
            // 
            this.textBoxThreadStep.Location = new System.Drawing.Point(664, 243);
            this.textBoxThreadStep.Name = "textBoxThreadStep";
            this.textBoxThreadStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxThreadStep.TabIndex = 24;
            this.textBoxThreadStep.TextChanged += new System.EventHandler(this.textBoxThreadStep_TextChanged);
            // 
            // textBoxNumberThread
            // 
            this.textBoxNumberThread.Location = new System.Drawing.Point(232, 371);
            this.textBoxNumberThread.Name = "textBoxNumberThread";
            this.textBoxNumberThread.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberThread.TabIndex = 25;
            this.textBoxNumberThread.TextChanged += new System.EventHandler(this.textBoxNumberThread_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(60, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(260, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Дополнительные параметры:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(60, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(255, 26);
            this.label15.TabIndex = 27;
            this.label15.Text = "Резьбофрезерование";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxNumberThread);
            this.Controls.Add(this.textBoxThreadStep);
            this.Controls.Add(this.textBoxTotalDepth);
            this.Controls.Add(this.textBoxThreadDiameter);
            this.Controls.Add(this.textBoxCenterY);
            this.Controls.Add(this.textBoxCenterX);
            this.Controls.Add(this.textBoxZFeedRate);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.textBoxXYFeedRate);
            this.Controls.Add(this.textBoxToolDiameter);
            this.Controls.Add(this.cmbThreadDirection);
            this.Controls.Add(this.cmbMillingDirection);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.GenerateGCodeThread);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button GenerateGCodeThread;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbMillingDirection;
        private System.Windows.Forms.ComboBox cmbThreadDirection;
        private System.Windows.Forms.TextBox textBoxToolDiameter;
        private System.Windows.Forms.TextBox textBoxXYFeedRate;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.TextBox textBoxZFeedRate;
        private System.Windows.Forms.TextBox textBoxCenterX;
        private System.Windows.Forms.TextBox textBoxCenterY;
        private System.Windows.Forms.TextBox textBoxThreadDiameter;
        private System.Windows.Forms.TextBox textBoxTotalDepth;
        private System.Windows.Forms.TextBox textBoxThreadStep;
        private System.Windows.Forms.TextBox textBoxNumberThread;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}