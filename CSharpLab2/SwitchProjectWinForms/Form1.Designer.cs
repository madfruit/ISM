namespace SwitchProjectWinForms
{
    partial class Form1
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
            this.buttonweek = new System.Windows.Forms.Button();
            this.buttonmonth = new System.Windows.Forms.Button();
            this.buttonoperations = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelanswer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonweek
            // 
            this.buttonweek.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonweek.ForeColor = System.Drawing.Color.Yellow;
            this.buttonweek.Location = new System.Drawing.Point(25, 36);
            this.buttonweek.Name = "buttonweek";
            this.buttonweek.Size = new System.Drawing.Size(144, 95);
            this.buttonweek.TabIndex = 0;
            this.buttonweek.Text = "Расшифровка дня недели";
            this.buttonweek.UseVisualStyleBackColor = false;
            this.buttonweek.Click += new System.EventHandler(this.buttonweek_Click);
            // 
            // buttonmonth
            // 
            this.buttonmonth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonmonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonmonth.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonmonth.Location = new System.Drawing.Point(217, 36);
            this.buttonmonth.Name = "buttonmonth";
            this.buttonmonth.Size = new System.Drawing.Size(144, 95);
            this.buttonmonth.TabIndex = 1;
            this.buttonmonth.Text = "Расшифровка месяца";
            this.buttonmonth.UseVisualStyleBackColor = false;
            this.buttonmonth.Click += new System.EventHandler(this.buttonmonth_Click);
            // 
            // buttonoperations
            // 
            this.buttonoperations.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonoperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonoperations.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonoperations.Location = new System.Drawing.Point(402, 38);
            this.buttonoperations.Name = "buttonoperations";
            this.buttonoperations.Size = new System.Drawing.Size(144, 95);
            this.buttonoperations.TabIndex = 2;
            this.buttonoperations.Text = "Выполнение операций над числами";
            this.buttonoperations.UseVisualStyleBackColor = false;
            this.buttonoperations.Click += new System.EventHandler(this.buttonoperations_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.Red;
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonexit.ForeColor = System.Drawing.Color.Green;
            this.buttonexit.Location = new System.Drawing.Point(587, 38);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(144, 95);
            this.buttonexit.TabIndex = 3;
            this.buttonexit.Text = "Выход";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(217, 202);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(329, 49);
            this.textBox.TabIndex = 4;
            // 
            // labelanswer
            // 
            this.labelanswer.AutoSize = true;
            this.labelanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelanswer.Location = new System.Drawing.Point(291, 304);
            this.labelanswer.Name = "labelanswer";
            this.labelanswer.Size = new System.Drawing.Size(0, 31);
            this.labelanswer.TabIndex = 5;
            this.labelanswer.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(217, 389);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 49);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-4, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Только для вычислений =>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(213, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Второе число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Первое число";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(653, 243);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 49);
            this.textBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(659, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Действие";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelanswer);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonoperations);
            this.Controls.Add(this.buttonmonth);
            this.Controls.Add(this.buttonweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonweek;
        private System.Windows.Forms.Button buttonmonth;
        private System.Windows.Forms.Button buttonoperations;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelanswer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}

