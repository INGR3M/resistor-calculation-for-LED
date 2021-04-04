namespace project1
{
    partial class LedCalculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.I_led = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.U_led = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.U_sourse = new System.Windows.Forms.TextBox();
            this.K_res = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.R_res = new System.Windows.Forms.TextBox();
            this.P_res = new System.Windows.Forms.TextBox();
            this.calc = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iпрям светодиода:";
            // 
            // I_led
            // 
            this.I_led.Location = new System.Drawing.Point(203, 50);
            this.I_led.Name = "I_led";
            this.I_led.Size = new System.Drawing.Size(114, 23);
            this.I_led.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Uпит светодиода:";
            // 
            // U_led
            // 
            this.U_led.Location = new System.Drawing.Point(203, 79);
            this.U_led.Name = "U_led";
            this.U_led.Size = new System.Drawing.Size(114, 23);
            this.U_led.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Uпит источ:";
            // 
            // U_sourse
            // 
            this.U_sourse.Location = new System.Drawing.Point(203, 108);
            this.U_sourse.Name = "U_sourse";
            this.U_sourse.Size = new System.Drawing.Size(114, 23);
            this.U_sourse.TabIndex = 5;
            // 
            // K_res
            // 
            this.K_res.Location = new System.Drawing.Point(203, 137);
            this.K_res.Name = "K_res";
            this.K_res.Size = new System.Drawing.Size(114, 23);
            this.K_res.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Коэф надеж:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rрасч резистора:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pрасч резистора:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "mA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "V";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "%";
            // 
            // R_res
            // 
            this.R_res.Location = new System.Drawing.Point(200, 231);
            this.R_res.Name = "R_res";
            this.R_res.Size = new System.Drawing.Size(117, 23);
            this.R_res.TabIndex = 14;
            // 
            // P_res
            // 
            this.P_res.Location = new System.Drawing.Point(200, 260);
            this.P_res.Name = "P_res";
            this.P_res.Size = new System.Drawing.Size(117, 23);
            this.P_res.TabIndex = 15;
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(149, 182);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(105, 28);
            this.calc.TabIndex = 16;
            this.calc.Text = "Рассчитать";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ohm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "W";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LedCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 345);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.P_res);
            this.Controls.Add(this.R_res);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.K_res);
            this.Controls.Add(this.U_sourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.U_led);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.I_led);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LedCalculator";
            this.Text = "Рассчет резистора для светодиодов";
            this.Load += new System.EventHandler(this.LedCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox I_led;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox U_led;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox U_sourse;
        private System.Windows.Forms.TextBox K_res;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox R_res;
        private System.Windows.Forms.TextBox P_res;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

