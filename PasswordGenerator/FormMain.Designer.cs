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
            if (disposing && (components != null))
            {
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
            this.buttonGeneration = new System.Windows.Forms.Button();
            this.buttonPathFile = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.checkBoxCustom = new System.Windows.Forms.CheckBox();
            this.checkBoxCyrillicAlphabet = new System.Windows.Forms.CheckBox();
            this.checkBoxDigitalRange = new System.Windows.Forms.CheckBox();
            this.checkBoxLatinAlphabet = new System.Windows.Forms.CheckBox();
            this.checkBoxPunctuation = new System.Windows.Forms.CheckBox();
            this.checkBoxStandart = new System.Windows.Forms.CheckBox();
            this.checkBoxSymbolLowers = new System.Windows.Forms.CheckBox();
            this.checkBoxSymbolsRange = new System.Windows.Forms.CheckBox();
            this.checkBoxSymbolUppers = new System.Windows.Forms.CheckBox();
            this.groupBoxGenerationSettings = new System.Windows.Forms.GroupBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.labelNumbersPassword = new System.Windows.Forms.Label();
            this.numericUpDownPasswordNumbers = new System.Windows.Forms.NumericUpDown();
            this.labelLengthPassword = new System.Windows.Forms.Label();
            this.numericUpDownPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.groupBoxRangeSettings = new System.Windows.Forms.GroupBox();
            this.radioButtonRangeBase64 = new System.Windows.Forms.RadioButton();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.radioButtonRangeBase16 = new System.Windows.Forms.RadioButton();
            this.radioButtonRangeBase2 = new System.Windows.Forms.RadioButton();
            this.radioButtonRangeBase8 = new System.Windows.Forms.RadioButton();
            this.radioButtonRangeBase10 = new System.Windows.Forms.RadioButton();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.groupBoxGenerationSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordLength)).BeginInit();
            this.groupBoxRangeSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGeneration
            // 
            this.buttonGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGeneration.Location = new System.Drawing.Point(297, 546);
            this.buttonGeneration.Name = "buttonGeneration";
            this.buttonGeneration.Size = new System.Drawing.Size(75, 23);
            this.buttonGeneration.TabIndex = 2;
            this.buttonGeneration.Text = "Генерация";
            this.buttonGeneration.UseVisualStyleBackColor = true;
            this.buttonGeneration.Click += new System.EventHandler(this.buttonGeneration_Click);
            // 
            // buttonPathFile
            // 
            this.buttonPathFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPathFile.Enabled = false;
            this.buttonPathFile.Location = new System.Drawing.Point(314, 72);
            this.buttonPathFile.Name = "buttonPathFile";
            this.buttonPathFile.Size = new System.Drawing.Size(27, 23);
            this.buttonPathFile.TabIndex = 6;
            this.buttonPathFile.Text = "...";
            this.buttonPathFile.UseVisualStyleBackColor = true;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuit.Location = new System.Drawing.Point(576, 546);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Выход";
            this.buttonQuit.UseVisualStyleBackColor = true;
            // 
            // checkBoxCustom
            // 
            this.checkBoxCustom.AutoSize = true;
            this.checkBoxCustom.Location = new System.Drawing.Point(9, 319);
            this.checkBoxCustom.Name = "checkBoxCustom";
            this.checkBoxCustom.Size = new System.Drawing.Size(182, 17);
            this.checkBoxCustom.TabIndex = 15;
            this.checkBoxCustom.Text = "Настроить диапазон в ручную";
            this.checkBoxCustom.UseVisualStyleBackColor = true;
            this.checkBoxCustom.CheckedChanged += new System.EventHandler(this.checkBoxCustom_CheckedChanged);
            // 
            // checkBoxCyrillicAlphabet
            // 
            this.checkBoxCyrillicAlphabet.AutoSize = true;
            this.checkBoxCyrillicAlphabet.Location = new System.Drawing.Point(42, 227);
            this.checkBoxCyrillicAlphabet.Name = "checkBoxCyrillicAlphabet";
            this.checkBoxCyrillicAlphabet.Size = new System.Drawing.Size(197, 17);
            this.checkBoxCyrillicAlphabet.TabIndex = 10;
            this.checkBoxCyrillicAlphabet.Text = "Символы кирилическго алфавита";
            this.checkBoxCyrillicAlphabet.UseVisualStyleBackColor = true;
            this.checkBoxCyrillicAlphabet.CheckedChanged += new System.EventHandler(this.checkBoxSymbolsRange_CheckedChanged);
            // 
            // checkBoxDigitalRange
            // 
            this.checkBoxDigitalRange.AutoSize = true;
            this.checkBoxDigitalRange.Checked = true;
            this.checkBoxDigitalRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDigitalRange.Location = new System.Drawing.Point(24, 43);
            this.checkBoxDigitalRange.Name = "checkBoxDigitalRange";
            this.checkBoxDigitalRange.Size = new System.Drawing.Size(139, 17);
            this.checkBoxDigitalRange.TabIndex = 1;
            this.checkBoxDigitalRange.Text = "Цифровые диапазоны";
            this.checkBoxDigitalRange.UseVisualStyleBackColor = true;
            this.checkBoxDigitalRange.CheckedChanged += new System.EventHandler(this.checkBoxDigitalRange_CheckedChanged);
            // 
            // checkBoxLatinAlphabet
            // 
            this.checkBoxLatinAlphabet.AutoSize = true;
            this.checkBoxLatinAlphabet.Checked = true;
            this.checkBoxLatinAlphabet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLatinAlphabet.Location = new System.Drawing.Point(42, 204);
            this.checkBoxLatinAlphabet.Name = "checkBoxLatinAlphabet";
            this.checkBoxLatinAlphabet.Size = new System.Drawing.Size(185, 17);
            this.checkBoxLatinAlphabet.TabIndex = 9;
            this.checkBoxLatinAlphabet.Text = "Символы латинского алфавита";
            this.checkBoxLatinAlphabet.UseVisualStyleBackColor = true;
            this.checkBoxLatinAlphabet.CheckedChanged += new System.EventHandler(this.checkBoxSymbolsRange_CheckedChanged);
            // 
            // checkBoxPunctuation
            // 
            this.checkBoxPunctuation.AutoSize = true;
            this.checkBoxPunctuation.Location = new System.Drawing.Point(24, 296);
            this.checkBoxPunctuation.Name = "checkBoxPunctuation";
            this.checkBoxPunctuation.Size = new System.Drawing.Size(119, 17);
            this.checkBoxPunctuation.TabIndex = 14;
            this.checkBoxPunctuation.Text = "Знаки пунктуации";
            this.checkBoxPunctuation.UseVisualStyleBackColor = true;
            this.checkBoxPunctuation.CheckedChanged += new System.EventHandler(this.checkBoxPunctuation_CheckedChanged);
            // 
            // checkBoxStandart
            // 
            this.checkBoxStandart.AutoSize = true;
            this.checkBoxStandart.Checked = true;
            this.checkBoxStandart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStandart.Location = new System.Drawing.Point(9, 20);
            this.checkBoxStandart.Name = "checkBoxStandart";
            this.checkBoxStandart.Size = new System.Drawing.Size(199, 17);
            this.checkBoxStandart.TabIndex = 0;
            this.checkBoxStandart.Text = "Стандартные диапазоны знакаов";
            this.checkBoxStandart.UseVisualStyleBackColor = true;
            this.checkBoxStandart.CheckedChanged += new System.EventHandler(this.checkBoxStandart_CheckedChanged);
            // 
            // checkBoxSymbolLowers
            // 
            this.checkBoxSymbolLowers.AutoSize = true;
            this.checkBoxSymbolLowers.Checked = true;
            this.checkBoxSymbolLowers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSymbolLowers.Location = new System.Drawing.Point(42, 250);
            this.checkBoxSymbolLowers.Name = "checkBoxSymbolLowers";
            this.checkBoxSymbolLowers.Size = new System.Drawing.Size(189, 17);
            this.checkBoxSymbolLowers.TabIndex = 11;
            this.checkBoxSymbolLowers.Text = "Использовать \"нижний регистр\"";
            this.checkBoxSymbolLowers.UseVisualStyleBackColor = true;
            this.checkBoxSymbolLowers.CheckedChanged += new System.EventHandler(this.checkBoxSymbolsRange_CheckedChanged);
            // 
            // checkBoxSymbolsRange
            // 
            this.checkBoxSymbolsRange.AutoSize = true;
            this.checkBoxSymbolsRange.Checked = true;
            this.checkBoxSymbolsRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSymbolsRange.Location = new System.Drawing.Point(24, 181);
            this.checkBoxSymbolsRange.Name = "checkBoxSymbolsRange";
            this.checkBoxSymbolsRange.Size = new System.Drawing.Size(148, 17);
            this.checkBoxSymbolsRange.TabIndex = 5;
            this.checkBoxSymbolsRange.Text = "Символьные диапазоны";
            this.checkBoxSymbolsRange.UseVisualStyleBackColor = true;
            this.checkBoxSymbolsRange.CheckedChanged += new System.EventHandler(this.checkBoxSymbolsRange_CheckedChanged);
            // 
            // checkBoxSymbolUppers
            // 
            this.checkBoxSymbolUppers.AutoSize = true;
            this.checkBoxSymbolUppers.Location = new System.Drawing.Point(42, 273);
            this.checkBoxSymbolUppers.Name = "checkBoxSymbolUppers";
            this.checkBoxSymbolUppers.Size = new System.Drawing.Size(200, 17);
            this.checkBoxSymbolUppers.TabIndex = 12;
            this.checkBoxSymbolUppers.Text = "Использовать \"ВЕРХНИЙ РЕГИСТР\"";
            this.checkBoxSymbolUppers.UseVisualStyleBackColor = true;
            this.checkBoxSymbolUppers.CheckedChanged += new System.EventHandler(this.checkBoxSymbolsRange_CheckedChanged);
            // 
            // groupBoxGenerationSettings
            // 
            this.groupBoxGenerationSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGenerationSettings.Controls.Add(this.buttonPathFile);
            this.groupBoxGenerationSettings.Controls.Add(this.labelFilePath);
            this.groupBoxGenerationSettings.Controls.Add(this.textBoxFilePath);
            this.groupBoxGenerationSettings.Controls.Add(this.labelNumbersPassword);
            this.groupBoxGenerationSettings.Controls.Add(this.numericUpDownPasswordNumbers);
            this.groupBoxGenerationSettings.Controls.Add(this.labelLengthPassword);
            this.groupBoxGenerationSettings.Controls.Add(this.numericUpDownPasswordLength);
            this.groupBoxGenerationSettings.Location = new System.Drawing.Point(297, 434);
            this.groupBoxGenerationSettings.Name = "groupBoxGenerationSettings";
            this.groupBoxGenerationSettings.Size = new System.Drawing.Size(352, 106);
            this.groupBoxGenerationSettings.TabIndex = 3;
            this.groupBoxGenerationSettings.TabStop = false;
            this.groupBoxGenerationSettings.Text = "Настройки генерации";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Enabled = false;
            this.labelFilePath.Location = new System.Drawing.Point(6, 76);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(84, 13);
            this.labelFilePath.TabIndex = 5;
            this.labelFilePath.Text = "Запись в файл:";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Enabled = false;
            this.textBoxFilePath.Location = new System.Drawing.Point(96, 73);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(212, 21);
            this.textBoxFilePath.TabIndex = 4;
            // 
            // labelNumbersPassword
            // 
            this.labelNumbersPassword.AutoSize = true;
            this.labelNumbersPassword.Location = new System.Drawing.Point(6, 48);
            this.labelNumbersPassword.Name = "labelNumbersPassword";
            this.labelNumbersPassword.Size = new System.Drawing.Size(71, 13);
            this.labelNumbersPassword.TabIndex = 3;
            this.labelNumbersPassword.Text = "Количество:";
            // 
            // numericUpDownPasswordNumbers
            // 
            this.numericUpDownPasswordNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPasswordNumbers.Location = new System.Drawing.Point(280, 46);
            this.numericUpDownPasswordNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPasswordNumbers.Name = "numericUpDownPasswordNumbers";
            this.numericUpDownPasswordNumbers.Size = new System.Drawing.Size(61, 21);
            this.numericUpDownPasswordNumbers.TabIndex = 2;
            this.numericUpDownPasswordNumbers.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelLengthPassword
            // 
            this.labelLengthPassword.AutoSize = true;
            this.labelLengthPassword.Location = new System.Drawing.Point(6, 21);
            this.labelLengthPassword.Name = "labelLengthPassword";
            this.labelLengthPassword.Size = new System.Drawing.Size(82, 13);
            this.labelLengthPassword.TabIndex = 1;
            this.labelLengthPassword.Text = "Длина пароля:";
            // 
            // numericUpDownPasswordLength
            // 
            this.numericUpDownPasswordLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPasswordLength.Location = new System.Drawing.Point(280, 19);
            this.numericUpDownPasswordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPasswordLength.Name = "numericUpDownPasswordLength";
            this.numericUpDownPasswordLength.Size = new System.Drawing.Size(61, 21);
            this.numericUpDownPasswordLength.TabIndex = 0;
            this.numericUpDownPasswordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // groupBoxRangeSettings
            // 
            this.groupBoxRangeSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRangeSettings.Controls.Add(this.radioButtonRangeBase64);
            this.groupBoxRangeSettings.Controls.Add(this.textBoxRange);
            this.groupBoxRangeSettings.Controls.Add(this.radioButtonRangeBase16);
            this.groupBoxRangeSettings.Controls.Add(this.checkBoxCustom);
            this.groupBoxRangeSettings.Controls.Add(this.radioButtonRangeBase2);
            this.groupBoxRangeSettings.Controls.Add(this.radioButtonRangeBase8);
            this.groupBoxRangeSettings.Controls.Add(this.checkBoxPunctuation);
            this.groupBoxRangeSettings.Controls.Add(this.radioButtonRangeBase10);
            this.groupBoxRangeSettings.Controls.Add(this.checkBoxSymbolUppers);
            this.groupBoxRangeSettings.Controls.Add(this.checkBoxSymbolLowers);
            this.groupBoxRangeSettings.Controls.Add(this.checkBoxCyrillicAlphabet);
            this.groupBoxRangeSettings.Controls.Add(this.checkBoxLatinAlphabet);
            this.groupBoxRangeSettings.Controls.Add(this.checkBoxSymbolsRange);
            this.groupBoxRangeSettings.Controls.Add(this.checkBoxDigitalRange);
            this.groupBoxRangeSettings.Controls.Add(this.checkBoxStandart);
            this.groupBoxRangeSettings.Location = new System.Drawing.Point(297, 12);
            this.groupBoxRangeSettings.Name = "groupBoxRangeSettings";
            this.groupBoxRangeSettings.Size = new System.Drawing.Size(352, 416);
            this.groupBoxRangeSettings.TabIndex = 5;
            this.groupBoxRangeSettings.TabStop = false;
            this.groupBoxRangeSettings.Text = "Настройки диапазона";
            // 
            // radioButtonRangeBase64
            // 
            this.radioButtonRangeBase64.AutoSize = true;
            this.radioButtonRangeBase64.Location = new System.Drawing.Point(42, 158);
            this.radioButtonRangeBase64.Name = "radioButtonRangeBase64";
            this.radioButtonRangeBase64.Size = new System.Drawing.Size(125, 17);
            this.radioButtonRangeBase64.TabIndex = 6;
            this.radioButtonRangeBase64.Text = "64-е числа (Base64)";
            this.radioButtonRangeBase64.UseVisualStyleBackColor = true;
            this.radioButtonRangeBase64.CheckedChanged += new System.EventHandler(this.radioButtonRangeBaseN_CheckedChanged);
            // 
            // textBoxRange
            // 
            this.textBoxRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRange.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRange.Location = new System.Drawing.Point(9, 342);
            this.textBoxRange.Multiline = true;
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.Size = new System.Drawing.Size(332, 63);
            this.textBoxRange.TabIndex = 16;
            // 
            // radioButtonRangeBase16
            // 
            this.radioButtonRangeBase16.AutoSize = true;
            this.radioButtonRangeBase16.Location = new System.Drawing.Point(42, 135);
            this.radioButtonRangeBase16.Name = "radioButtonRangeBase16";
            this.radioButtonRangeBase16.Size = new System.Drawing.Size(165, 17);
            this.radioButtonRangeBase16.TabIndex = 5;
            this.radioButtonRangeBase16.Text = "Шестнадцатиричные числа";
            this.radioButtonRangeBase16.UseVisualStyleBackColor = true;
            this.radioButtonRangeBase16.CheckedChanged += new System.EventHandler(this.radioButtonRangeBaseN_CheckedChanged);
            // 
            // radioButtonRangeBase2
            // 
            this.radioButtonRangeBase2.AutoSize = true;
            this.radioButtonRangeBase2.Location = new System.Drawing.Point(42, 66);
            this.radioButtonRangeBase2.Name = "radioButtonRangeBase2";
            this.radioButtonRangeBase2.Size = new System.Drawing.Size(107, 17);
            this.radioButtonRangeBase2.TabIndex = 2;
            this.radioButtonRangeBase2.Text = "Бинарные числа";
            this.radioButtonRangeBase2.UseVisualStyleBackColor = true;
            this.radioButtonRangeBase2.CheckedChanged += new System.EventHandler(this.radioButtonRangeBaseN_CheckedChanged);
            // 
            // radioButtonRangeBase8
            // 
            this.radioButtonRangeBase8.AutoSize = true;
            this.radioButtonRangeBase8.Location = new System.Drawing.Point(42, 89);
            this.radioButtonRangeBase8.Name = "radioButtonRangeBase8";
            this.radioButtonRangeBase8.Size = new System.Drawing.Size(130, 17);
            this.radioButtonRangeBase8.TabIndex = 3;
            this.radioButtonRangeBase8.Text = "Восьмиричные числа";
            this.radioButtonRangeBase8.UseVisualStyleBackColor = true;
            this.radioButtonRangeBase8.CheckedChanged += new System.EventHandler(this.radioButtonRangeBaseN_CheckedChanged);
            // 
            // radioButtonRangeBase10
            // 
            this.radioButtonRangeBase10.AutoSize = true;
            this.radioButtonRangeBase10.Checked = true;
            this.radioButtonRangeBase10.Location = new System.Drawing.Point(42, 112);
            this.radioButtonRangeBase10.Name = "radioButtonRangeBase10";
            this.radioButtonRangeBase10.Size = new System.Drawing.Size(132, 17);
            this.radioButtonRangeBase10.TabIndex = 4;
            this.radioButtonRangeBase10.TabStop = true;
            this.radioButtonRangeBase10.Text = "Десятиричные числа";
            this.radioButtonRangeBase10.UseVisualStyleBackColor = true;
            this.radioButtonRangeBase10.CheckedChanged += new System.EventHandler(this.radioButtonRangeBaseN_CheckedChanged);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(12, 12);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(273, 557);
            this.textBoxOutput.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 581);
            this.Controls.Add(this.groupBoxRangeSettings);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.groupBoxGenerationSettings);
            this.Controls.Add(this.buttonGeneration);
            this.Controls.Add(this.textBoxOutput);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(679, 620);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxGenerationSettings.ResumeLayout(false);
            this.groupBoxGenerationSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordLength)).EndInit();
            this.groupBoxRangeSettings.ResumeLayout(false);
            this.groupBoxRangeSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonGeneration;
        private System.Windows.Forms.GroupBox groupBoxGenerationSettings;
        private System.Windows.Forms.Label labelNumbersPassword;
        private System.Windows.Forms.NumericUpDown numericUpDownPasswordNumbers;
        private System.Windows.Forms.Label labelLengthPassword;
        private System.Windows.Forms.NumericUpDown numericUpDownPasswordLength;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonPathFile;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.GroupBox groupBoxRangeSettings;
        private System.Windows.Forms.CheckBox checkBoxSymbolsRange;
        private System.Windows.Forms.RadioButton radioButtonRangeBase10;
        private System.Windows.Forms.RadioButton radioButtonRangeBase8;
        private System.Windows.Forms.RadioButton radioButtonRangeBase2;
        private System.Windows.Forms.CheckBox checkBoxDigitalRange;
        private System.Windows.Forms.CheckBox checkBoxStandart;
        private System.Windows.Forms.CheckBox checkBoxLatinAlphabet;
        private System.Windows.Forms.RadioButton radioButtonRangeBase64;
        private System.Windows.Forms.RadioButton radioButtonRangeBase16;
        private System.Windows.Forms.TextBox textBoxRange;
        private System.Windows.Forms.CheckBox checkBoxCustom;
        private System.Windows.Forms.CheckBox checkBoxPunctuation;
        private System.Windows.Forms.CheckBox checkBoxSymbolUppers;
        private System.Windows.Forms.CheckBox checkBoxSymbolLowers;
        private System.Windows.Forms.CheckBox checkBoxCyrillicAlphabet;
    }
}

