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
            this.textBoxRange = new System.Windows.Forms.TextBox ();
            this.checkBoxCustom = new System.Windows.Forms.CheckBox ();
            this.checkBoxPunctuation = new System.Windows.Forms.CheckBox ();
            this.checkBoxDigital = new System.Windows.Forms.CheckBox ();
            this.checkBoxCyrillicUp = new System.Windows.Forms.CheckBox ();
            this.checkBoxCyrillicDown = new System.Windows.Forms.CheckBox ();
            this.checkBoxLatinUp = new System.Windows.Forms.CheckBox ();
            this.checkBoxLatinDown = new System.Windows.Forms.CheckBox ();
            this.radioButtonRangeBase64 = new System.Windows.Forms.RadioButton ();
            this.radioButtonRangeBase16 = new System.Windows.Forms.RadioButton ();
            this.radioButtonRangeBase2 = new System.Windows.Forms.RadioButton ();
            this.radioButtonRangeBas8 = new System.Windows.Forms.RadioButton ();
            this.radioButtonRangeBase10 = new System.Windows.Forms.RadioButton ();
            this.checkBox3 = new System.Windows.Forms.CheckBox ();
            this.checkBoxDigitalRange = new System.Windows.Forms.CheckBox ();
            this.checkBoxStandart = new System.Windows.Forms.CheckBox ();
            this.groupBox2.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown2)).BeginInit ();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit ();
            this.groupBoxSettings.SuspendLayout ();
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
            this.groupBoxSettings.Controls.Add (this.radioButtonRangeBase64);
            this.groupBoxSettings.Controls.Add (this.textBoxRange);
            this.groupBoxSettings.Controls.Add (this.radioButtonRangeBase16);
            this.groupBoxSettings.Controls.Add (this.checkBoxCustom);
            this.groupBoxSettings.Controls.Add (this.radioButtonRangeBase2);
            this.groupBoxSettings.Controls.Add (this.radioButtonRangeBas8);
            this.groupBoxSettings.Controls.Add (this.checkBoxPunctuation);
            this.groupBoxSettings.Controls.Add (this.radioButtonRangeBase10);
            this.groupBoxSettings.Controls.Add (this.checkBoxDigital);
            this.groupBoxSettings.Controls.Add (this.checkBoxCyrillicUp);
            this.groupBoxSettings.Controls.Add (this.checkBoxCyrillicDown);
            this.groupBoxSettings.Controls.Add (this.checkBoxLatinUp);
            this.groupBoxSettings.Controls.Add (this.checkBoxLatinDown);
            this.groupBoxSettings.Controls.Add (this.checkBox3);
            this.groupBoxSettings.Controls.Add (this.checkBoxDigitalRange);
            this.groupBoxSettings.Controls.Add (this.checkBoxStandart);
            this.groupBoxSettings.Location = new System.Drawing.Point (527, 12);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size (352, 466);
            this.groupBoxSettings.TabIndex = 5;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Настройки диапазона";
            // 
            // textBoxRange
            // 
            this.textBoxRange.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRange.Location = new System.Drawing.Point (9, 365);
            this.textBoxRange.Multiline = true;
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.Size = new System.Drawing.Size (332, 90);
            this.textBoxRange.TabIndex = 16;
            // 
            // checkBoxCustom
            // 
            this.checkBoxCustom.AutoSize = true;
            this.checkBoxCustom.Location = new System.Drawing.Point (9, 342);
            this.checkBoxCustom.Name = "checkBoxCustom";
            this.checkBoxCustom.Size = new System.Drawing.Size (182, 17);
            this.checkBoxCustom.TabIndex = 15;
            this.checkBoxCustom.Text = "Настроить диапазон в ручную";
            this.checkBoxCustom.UseVisualStyleBackColor = true;
            // 
            // checkBoxPunctuation
            // 
            this.checkBoxPunctuation.AutoSize = true;
            this.checkBoxPunctuation.Location = new System.Drawing.Point (42, 319);
            this.checkBoxPunctuation.Name = "checkBoxPunctuation";
            this.checkBoxPunctuation.Size = new System.Drawing.Size (119, 17);
            this.checkBoxPunctuation.TabIndex = 14;
            this.checkBoxPunctuation.Text = "Знаки пунктуации";
            this.checkBoxPunctuation.UseVisualStyleBackColor = true;
            // 
            // checkBoxDigital
            // 
            this.checkBoxDigital.AutoSize = true;
            this.checkBoxDigital.Checked = true;
            this.checkBoxDigital.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDigital.Location = new System.Drawing.Point (42, 296);
            this.checkBoxDigital.Name = "checkBoxDigital";
            this.checkBoxDigital.Size = new System.Drawing.Size (62, 17);
            this.checkBoxDigital.TabIndex = 13;
            this.checkBoxDigital.Text = "Цифры";
            this.checkBoxDigital.UseVisualStyleBackColor = true;
            // 
            // checkBoxCyrillicUp
            // 
            this.checkBoxCyrillicUp.AutoSize = true;
            this.checkBoxCyrillicUp.Location = new System.Drawing.Point (42, 273);
            this.checkBoxCyrillicUp.Name = "checkBoxCyrillicUp";
            this.checkBoxCyrillicUp.Size = new System.Drawing.Size (251, 17);
            this.checkBoxCyrillicUp.TabIndex = 12;
            this.checkBoxCyrillicUp.Text = "Кирилические буквы \"В ВЕРХНЕМ РЕГИСТРЕ\"";
            this.checkBoxCyrillicUp.UseVisualStyleBackColor = true;
            // 
            // checkBoxCyrillicDown
            // 
            this.checkBoxCyrillicDown.AutoSize = true;
            this.checkBoxCyrillicDown.Location = new System.Drawing.Point (42, 250);
            this.checkBoxCyrillicDown.Name = "checkBoxCyrillicDown";
            this.checkBoxCyrillicDown.Size = new System.Drawing.Size (240, 17);
            this.checkBoxCyrillicDown.TabIndex = 11;
            this.checkBoxCyrillicDown.Text = "Кирилические буквы \"в нижнем регистре\"";
            this.checkBoxCyrillicDown.UseVisualStyleBackColor = true;
            // 
            // checkBoxLatinUp
            // 
            this.checkBoxLatinUp.AutoSize = true;
            this.checkBoxLatinUp.Location = new System.Drawing.Point (42, 227);
            this.checkBoxLatinUp.Name = "checkBoxLatinUp";
            this.checkBoxLatinUp.Size = new System.Drawing.Size (233, 17);
            this.checkBoxLatinUp.TabIndex = 10;
            this.checkBoxLatinUp.Text = "Латинские буквы \"В ВЕРХНЕМ РЕГИСТРЕ\"";
            this.checkBoxLatinUp.UseVisualStyleBackColor = true;
            // 
            // checkBoxLatinDown
            // 
            this.checkBoxLatinDown.AutoSize = true;
            this.checkBoxLatinDown.Checked = true;
            this.checkBoxLatinDown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLatinDown.Location = new System.Drawing.Point (42, 204);
            this.checkBoxLatinDown.Name = "checkBoxLatinDown";
            this.checkBoxLatinDown.Size = new System.Drawing.Size (222, 17);
            this.checkBoxLatinDown.TabIndex = 9;
            this.checkBoxLatinDown.Text = "Латинские буквы \"в нижнем регистре\"";
            this.checkBoxLatinDown.UseVisualStyleBackColor = true;
            // 
            // radioButtonRangeBase64
            // 
            this.radioButtonRangeBase64.AutoSize = true;
            this.radioButtonRangeBase64.Location = new System.Drawing.Point (42, 158);
            this.radioButtonRangeBase64.Name = "radioButtonRangeBase64";
            this.radioButtonRangeBase64.Size = new System.Drawing.Size (125, 17);
            this.radioButtonRangeBase64.TabIndex = 6;
            this.radioButtonRangeBase64.Text = "64-е числа (Base64)";
            this.radioButtonRangeBase64.UseVisualStyleBackColor = true;
            this.radioButtonRangeBase64.CheckedChanged += new System.EventHandler (this.radioButtonRangeBase64_CheckedChanged);
            // 
            // radioButtonRangeBase16
            // 
            this.radioButtonRangeBase16.AutoSize = true;
            this.radioButtonRangeBase16.Location = new System.Drawing.Point (42, 135);
            this.radioButtonRangeBase16.Name = "radioButtonRangeBase16";
            this.radioButtonRangeBase16.Size = new System.Drawing.Size (165, 17);
            this.radioButtonRangeBase16.TabIndex = 5;
            this.radioButtonRangeBase16.Text = "Шестнадцатиричные числа";
            this.radioButtonRangeBase16.UseVisualStyleBackColor = true;
            this.radioButtonRangeBase16.CheckedChanged += new System.EventHandler (this.radioButtonRangeBase16_CheckedChanged);
            // 
            // radioButtonRangeBase2
            // 
            this.radioButtonRangeBase2.AutoSize = true;
            this.radioButtonRangeBase2.Location = new System.Drawing.Point (42, 66);
            this.radioButtonRangeBase2.Name = "radioButtonRangeBase2";
            this.radioButtonRangeBase2.Size = new System.Drawing.Size (107, 17);
            this.radioButtonRangeBase2.TabIndex = 2;
            this.radioButtonRangeBase2.Text = "Бинарные числа";
            this.radioButtonRangeBase2.UseVisualStyleBackColor = true;
            this.radioButtonRangeBase2.CheckedChanged += new System.EventHandler (this.radioButtonRangeBase2_CheckedChanged);
            // 
            // radioButtonRangeBas8
            // 
            this.radioButtonRangeBas8.AutoSize = true;
            this.radioButtonRangeBas8.Location = new System.Drawing.Point (42, 89);
            this.radioButtonRangeBas8.Name = "radioButtonRangeBas8";
            this.radioButtonRangeBas8.Size = new System.Drawing.Size (130, 17);
            this.radioButtonRangeBas8.TabIndex = 3;
            this.radioButtonRangeBas8.Text = "Восьмиричные числа";
            this.radioButtonRangeBas8.UseVisualStyleBackColor = true;
            this.radioButtonRangeBas8.CheckedChanged += new System.EventHandler (this.radioButtonRangeBas8_CheckedChanged);
            // 
            // radioButtonRangeBase10
            // 
            this.radioButtonRangeBase10.AutoSize = true;
            this.radioButtonRangeBase10.Checked = true;
            this.radioButtonRangeBase10.Location = new System.Drawing.Point (42, 112);
            this.radioButtonRangeBase10.Name = "radioButtonRangeBase10";
            this.radioButtonRangeBase10.Size = new System.Drawing.Size (132, 17);
            this.radioButtonRangeBase10.TabIndex = 4;
            this.radioButtonRangeBase10.TabStop = true;
            this.radioButtonRangeBase10.Text = "Десятиричные числа";
            this.radioButtonRangeBase10.UseVisualStyleBackColor = true;
            this.radioButtonRangeBase10.CheckedChanged += new System.EventHandler (this.radioButtonRangeBase10_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point (24, 181);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size (148, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Символьные диапазоны";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBoxDigitalRange
            // 
            this.checkBoxDigitalRange.AutoSize = true;
            this.checkBoxDigitalRange.Location = new System.Drawing.Point (24, 43);
            this.checkBoxDigitalRange.Name = "checkBoxDigitalRange";
            this.checkBoxDigitalRange.Size = new System.Drawing.Size (139, 17);
            this.checkBoxDigitalRange.TabIndex = 1;
            this.checkBoxDigitalRange.Text = "Цифровые диапазоны";
            this.checkBoxDigitalRange.UseVisualStyleBackColor = true;
            this.checkBoxDigitalRange.CheckedChanged += new System.EventHandler (this.checkBoxDigitalRange_CheckedChanged);
            // 
            // checkBoxStandart
            // 
            this.checkBoxStandart.AutoSize = true;
            this.checkBoxStandart.Checked = true;
            this.checkBoxStandart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStandart.Location = new System.Drawing.Point (9, 20);
            this.checkBoxStandart.Name = "checkBoxStandart";
            this.checkBoxStandart.Size = new System.Drawing.Size (199, 17);
            this.checkBoxStandart.TabIndex = 0;
            this.checkBoxStandart.Text = "Стандартные диапазоны знакаов";
            this.checkBoxStandart.UseVisualStyleBackColor = true;
            this.checkBoxStandart.CheckedChanged += new System.EventHandler (this.checkBoxStandart_CheckedChanged);
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
        private System.Windows.Forms.RadioButton radioButtonRangeBase10;
        private System.Windows.Forms.RadioButton radioButtonRangeBas8;
        private System.Windows.Forms.RadioButton radioButtonRangeBase2;
        private System.Windows.Forms.CheckBox checkBoxDigitalRange;
        private System.Windows.Forms.CheckBox checkBoxStandart;
        private System.Windows.Forms.CheckBox checkBoxLatinDown;
        private System.Windows.Forms.RadioButton radioButtonRangeBase64;
        private System.Windows.Forms.RadioButton radioButtonRangeBase16;
        private System.Windows.Forms.TextBox textBoxRange;
        private System.Windows.Forms.CheckBox checkBoxCustom;
        private System.Windows.Forms.CheckBox checkBoxPunctuation;
        private System.Windows.Forms.CheckBox checkBoxDigital;
        private System.Windows.Forms.CheckBox checkBoxCyrillicUp;
        private System.Windows.Forms.CheckBox checkBoxCyrillicDown;
        private System.Windows.Forms.CheckBox checkBoxLatinUp;
    }
}

