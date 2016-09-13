namespace PasswordGenerator
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.textBoxOutput = new System.Windows.Forms.TextBox ();
            this.button1 = new System.Windows.Forms.Button ();
            this.groupBox2 = new System.Windows.Forms.GroupBox ();
            this.button3 = new System.Windows.Forms.Button ();
            this.label3 = new System.Windows.Forms.Label ();
            this.textBox1 = new System.Windows.Forms.TextBox ();
            this.label2 = new System.Windows.Forms.Label ();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown ();
            this.label1 = new System.Windows.Forms.Label ();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown ();
            this.button4 = new System.Windows.Forms.Button ();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox ();
            this.checkBox1 = new System.Windows.Forms.CheckBox ();
            this.checkBox2 = new System.Windows.Forms.CheckBox ();
            this.radioButton1 = new System.Windows.Forms.RadioButton ();
            this.radioButton2 = new System.Windows.Forms.RadioButton ();
            this.radioButton3 = new System.Windows.Forms.RadioButton ();
            this.checkBox3 = new System.Windows.Forms.CheckBox ();
            this.panel1 = new System.Windows.Forms.Panel ();
            this.radioButton5 = new System.Windows.Forms.RadioButton ();
            this.radioButton6 = new System.Windows.Forms.RadioButton ();
            this.checkBox4 = new System.Windows.Forms.CheckBox ();
            this.checkBox5 = new System.Windows.Forms.CheckBox ();
            this.checkBox6 = new System.Windows.Forms.CheckBox ();
            this.checkBox7 = new System.Windows.Forms.CheckBox ();
            this.checkBox8 = new System.Windows.Forms.CheckBox ();
            this.checkBox9 = new System.Windows.Forms.CheckBox ();
            this.checkBox10 = new System.Windows.Forms.CheckBox ();
            this.textBox2 = new System.Windows.Forms.TextBox ();
            this.groupBox2.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit ();
            this.groupBoxSettings.SuspendLayout ();
            this.panel1.SuspendLayout ();
            this.SuspendLayout ();
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point (12, 12);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size (503, 607);
            this.textBoxOutput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point (527, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size (75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Генерация";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add (this.button3);
            this.groupBox2.Controls.Add (this.label3);
            this.groupBox2.Controls.Add (this.textBox1);
            this.groupBox2.Controls.Add (this.label2);
            this.groupBox2.Controls.Add (this.numericUpDown2);
            this.groupBox2.Controls.Add (this.label1);
            this.groupBox2.Controls.Add (this.numericUpDown1);
            this.groupBox2.Location = new System.Drawing.Point (527, 484);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size (352, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки генерации";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point (314, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size (27, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point (6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Запись в файл:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point (96, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size (212, 21);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Location = new System.Drawing.Point (280, 46);
            this.numericUpDown2.Minimum = new decimal (new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size (61, 21);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal (new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина пароля:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point (280, 19);
            this.numericUpDown1.Minimum = new decimal (new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size (61, 21);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal (new int[] {
            8,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point (806, 596);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size (75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSettings.Controls.Add (this.textBox2);
            this.groupBoxSettings.Controls.Add (this.checkBox10);
            this.groupBoxSettings.Controls.Add (this.checkBox9);
            this.groupBoxSettings.Controls.Add (this.checkBox8);
            this.groupBoxSettings.Controls.Add (this.checkBox6);
            this.groupBoxSettings.Controls.Add (this.checkBox7);
            this.groupBoxSettings.Controls.Add (this.checkBox5);
            this.groupBoxSettings.Controls.Add (this.checkBox4);
            this.groupBoxSettings.Controls.Add (this.panel1);
            this.groupBoxSettings.Controls.Add (this.checkBox3);
            this.groupBoxSettings.Controls.Add (this.checkBox2);
            this.groupBoxSettings.Controls.Add (this.checkBox1);
            this.groupBoxSettings.Location = new System.Drawing.Point (527, 12);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size (352, 466);
            this.groupBoxSettings.TabIndex = 5;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Настройки диапазона";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point (9, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size (199, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Стандартные диапазоны знакаов";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point (24, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size (139, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Цифровые диапазоны";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point (3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size (107, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Бинарные числа";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point (3, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size (130, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Восьмиричные числа";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point (3, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size (132, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Десятиричные числа";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point (24, 189);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size (141, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Буквенные диапазоны";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add (this.radioButton6);
            this.panel1.Controls.Add (this.radioButton5);
            this.panel1.Controls.Add (this.radioButton1);
            this.panel1.Controls.Add (this.radioButton2);
            this.panel1.Controls.Add (this.radioButton3);
            this.panel1.Location = new System.Drawing.Point (39, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size (200, 117);
            this.panel1.TabIndex = 8;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point (3, 72);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size (165, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "Шестнадцатиричные числа";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point (3, 95);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size (125, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.Text = "64-е числа (Base64)";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point (42, 212);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size (222, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Латинские буквы \"в нижнем регистре\"";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point (42, 235);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size (233, 17);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "Латинские буквы \"В ВЕРХНЕМ РЕГИСТРЕ\"";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point (42, 281);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size (251, 17);
            this.checkBox6.TabIndex = 12;
            this.checkBox6.Text = "Кирилические буквы \"В ВЕРХНЕМ РЕГИСТРЕ\"";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point (42, 258);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size (240, 17);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.Text = "Кирилические буквы \"в нижнем регистре\"";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point (42, 304);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size (62, 17);
            this.checkBox8.TabIndex = 13;
            this.checkBox8.Text = "Цифры";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point (42, 327);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size (119, 17);
            this.checkBox9.TabIndex = 14;
            this.checkBox9.Text = "Знаки пунктуации";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point (9, 350);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size (182, 17);
            this.checkBox10.TabIndex = 15;
            this.checkBox10.Text = "Настроить диапазон в ручную";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point (9, 373);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size (332, 82);
            this.textBox2.TabIndex = 16;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (893, 631);
            this.Controls.Add (this.groupBoxSettings);
            this.Controls.Add (this.button4);
            this.Controls.Add (this.groupBox2);
            this.Controls.Add (this.button1);
            this.Controls.Add (this.textBoxOutput);
            this.Font = new System.Drawing.Font ("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler (this.FormMain_Load);
            this.groupBox2.ResumeLayout (false);
            this.groupBox2.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).EndInit ();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit ();
            this.groupBoxSettings.ResumeLayout (false);
            this.groupBoxSettings.PerformLayout ();
            this.panel1.ResumeLayout (false);
            this.panel1.PerformLayout ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}

