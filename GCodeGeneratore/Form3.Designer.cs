namespace GCodeGeneratore
{
    partial class Form3
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
            this.label9 = new System.Windows.Forms.Label();
            this.GenerateGCode = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxToolDiameter = new System.Windows.Forms.TextBox();
            this.textBoxToolOverlap = new System.Windows.Forms.TextBox();
            this.textBoxXYFeedRate = new System.Windows.Forms.TextBox();
            this.textBoxZFeedRate = new System.Windows.Forms.TextBox();
            this.textBoxAngularDepthMovementX = new System.Windows.Forms.TextBox();
            this.textBoxAngularDepthAngle = new System.Windows.Forms.TextBox();
            this.textBoxCenterX = new System.Windows.Forms.TextBox();
            this.textBoxCenterY = new System.Windows.Forms.TextBox();
            this.textBoxHoleDiameter = new System.Windows.Forms.TextBox();
            this.textBoxTotalDepth = new System.Windows.Forms.TextBox();
            this.textBoxDepthPerPass = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диаметр фрезы, мм:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Перекрытие инструмента, мм:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Поадча по ХУ, мм/мин:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(57, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Параметры углового заглубления фрезы:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Перемещение по Х за проход, мм:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Угол заглубления, градусов:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(466, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Геометрия отверстия:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(57, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Параметры фрезерования:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Подача по Z, мм/мин:";
            // 
            // GenerateGCode
            // 
            this.GenerateGCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateGCode.Location = new System.Drawing.Point(470, 310);
            this.GenerateGCode.Name = "GenerateGCode";
            this.GenerateGCode.Size = new System.Drawing.Size(300, 120);
            this.GenerateGCode.TabIndex = 9;
            this.GenerateGCode.Text = "Сгенерировать G-код";
            this.GenerateGCode.UseVisualStyleBackColor = true;
            this.GenerateGCode.Click += new System.EventHandler(this.GenerateGCode_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(467, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Координаты центра отверстия:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "По X, мм:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(483, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "По У, мм:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(465, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Диаметр отверстия, мм:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(465, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Глубина отверстия, мм:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(465, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Глубина за проход, мм:";
            // 
            // textBoxToolDiameter
            // 
            this.textBoxToolDiameter.Location = new System.Drawing.Point(237, 104);
            this.textBoxToolDiameter.Name = "textBoxToolDiameter";
            this.textBoxToolDiameter.Size = new System.Drawing.Size(100, 20);
            this.textBoxToolDiameter.TabIndex = 16;
            this.textBoxToolDiameter.TextChanged += new System.EventHandler(this.textBoxToolDiameter_TextChanged);
            // 
            // textBoxToolOverlap
            // 
            this.textBoxToolOverlap.Location = new System.Drawing.Point(237, 133);
            this.textBoxToolOverlap.Name = "textBoxToolOverlap";
            this.textBoxToolOverlap.Size = new System.Drawing.Size(100, 20);
            this.textBoxToolOverlap.TabIndex = 17;
            this.textBoxToolOverlap.TextChanged += new System.EventHandler(this.textBoxToolOverlap_TextChanged);
            // 
            // textBoxXYFeedRate
            // 
            this.textBoxXYFeedRate.Location = new System.Drawing.Point(237, 175);
            this.textBoxXYFeedRate.Name = "textBoxXYFeedRate";
            this.textBoxXYFeedRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxXYFeedRate.TabIndex = 18;
            this.textBoxXYFeedRate.TextChanged += new System.EventHandler(this.textBoxXYFeedRate_TextChanged);
            // 
            // textBoxZFeedRate
            // 
            this.textBoxZFeedRate.Location = new System.Drawing.Point(237, 205);
            this.textBoxZFeedRate.Name = "textBoxZFeedRate";
            this.textBoxZFeedRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxZFeedRate.TabIndex = 19;
            this.textBoxZFeedRate.TextChanged += new System.EventHandler(this.textBoxZFeedRate_TextChanged);
            // 
            // textBoxAngularDepthMovementX
            // 
            this.textBoxAngularDepthMovementX.Location = new System.Drawing.Point(248, 316);
            this.textBoxAngularDepthMovementX.Name = "textBoxAngularDepthMovementX";
            this.textBoxAngularDepthMovementX.Size = new System.Drawing.Size(100, 20);
            this.textBoxAngularDepthMovementX.TabIndex = 20;
            this.textBoxAngularDepthMovementX.TextChanged += new System.EventHandler(this.textBoxAngularDepthMovementX_TextChanged);
            // 
            // textBoxAngularDepthAngle
            // 
            this.textBoxAngularDepthAngle.Location = new System.Drawing.Point(248, 344);
            this.textBoxAngularDepthAngle.Name = "textBoxAngularDepthAngle";
            this.textBoxAngularDepthAngle.Size = new System.Drawing.Size(100, 20);
            this.textBoxAngularDepthAngle.TabIndex = 21;
            this.textBoxAngularDepthAngle.TextChanged += new System.EventHandler(this.textBoxAngularDepthAngle_TextChanged);
            // 
            // textBoxCenterX
            // 
            this.textBoxCenterX.Location = new System.Drawing.Point(547, 133);
            this.textBoxCenterX.Name = "textBoxCenterX";
            this.textBoxCenterX.Size = new System.Drawing.Size(100, 20);
            this.textBoxCenterX.TabIndex = 22;
            this.textBoxCenterX.TextChanged += new System.EventHandler(this.textBoxCenterX_TextChanged);
            // 
            // textBoxCenterY
            // 
            this.textBoxCenterY.Location = new System.Drawing.Point(547, 158);
            this.textBoxCenterY.Name = "textBoxCenterY";
            this.textBoxCenterY.Size = new System.Drawing.Size(100, 20);
            this.textBoxCenterY.TabIndex = 23;
            this.textBoxCenterY.TextChanged += new System.EventHandler(this.textBoxCenterY_TextChanged);
            // 
            // textBoxHoleDiameter
            // 
            this.textBoxHoleDiameter.Location = new System.Drawing.Point(605, 193);
            this.textBoxHoleDiameter.Name = "textBoxHoleDiameter";
            this.textBoxHoleDiameter.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoleDiameter.TabIndex = 24;
            this.textBoxHoleDiameter.TextChanged += new System.EventHandler(this.textBoxHoleDiameter_TextChanged);
            // 
            // textBoxTotalDepth
            // 
            this.textBoxTotalDepth.Location = new System.Drawing.Point(605, 221);
            this.textBoxTotalDepth.Name = "textBoxTotalDepth";
            this.textBoxTotalDepth.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalDepth.TabIndex = 25;
            this.textBoxTotalDepth.TextChanged += new System.EventHandler(this.textBoxTotalDepth_TextChanged);
            // 
            // textBoxDepthPerPass
            // 
            this.textBoxDepthPerPass.Location = new System.Drawing.Point(605, 252);
            this.textBoxDepthPerPass.Name = "textBoxDepthPerPass";
            this.textBoxDepthPerPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepthPerPass.TabIndex = 26;
            this.textBoxDepthPerPass.TextChanged += new System.EventHandler(this.textBoxDepthPerPass_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(60, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(293, 26);
            this.label16.TabIndex = 27;
            this.label16.Text = "Фрезерование отверстия";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxDepthPerPass);
            this.Controls.Add(this.textBoxTotalDepth);
            this.Controls.Add(this.textBoxHoleDiameter);
            this.Controls.Add(this.textBoxCenterY);
            this.Controls.Add(this.textBoxCenterX);
            this.Controls.Add(this.textBoxAngularDepthAngle);
            this.Controls.Add(this.textBoxAngularDepthMovementX);
            this.Controls.Add(this.textBoxZFeedRate);
            this.Controls.Add(this.textBoxXYFeedRate);
            this.Controls.Add(this.textBoxToolOverlap);
            this.Controls.Add(this.textBoxToolDiameter);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GenerateGCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button GenerateGCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxToolDiameter;
        private System.Windows.Forms.TextBox textBoxToolOverlap;
        private System.Windows.Forms.TextBox textBoxXYFeedRate;
        private System.Windows.Forms.TextBox textBoxZFeedRate;
        private System.Windows.Forms.TextBox textBoxAngularDepthMovementX;
        private System.Windows.Forms.TextBox textBoxAngularDepthAngle;
        private System.Windows.Forms.TextBox textBoxCenterX;
        private System.Windows.Forms.TextBox textBoxCenterY;
        private System.Windows.Forms.TextBox textBoxHoleDiameter;
        private System.Windows.Forms.TextBox textBoxTotalDepth;
        private System.Windows.Forms.TextBox textBoxDepthPerPass;
        private System.Windows.Forms.Label label16;
    }
}