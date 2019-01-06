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
            this.textBoxSeparator = new System.Windows.Forms.TextBox();
            this.radioButtonSeparatorCustom = new System.Windows.Forms.RadioButton();
            this.radioButtonSeparatorLines = new System.Windows.Forms.RadioButton();
            this.radioButtonSeparatorSpace = new System.Windows.Forms.RadioButton();
            this.labelNumbersPassword = new System.Windows.Forms.Label();
            this.numericUpDownPasswordNumbers = new System.Windows.Forms.NumericUpDown();
            this.labelLengthPassword = new System.Windows.Forms.Label();
            this.numericUpDownPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.groupBoxRangeSettings = new System.Windows.Forms.GroupBox();
            this.radioButtonRangeBase64 = new System.Windows.Forms.RadioButton();
            this.textBoxCustomRange = new System.Windows.Forms.TextBox();
            this.radioButtonRangeBase16 = new System.Windows.Forms.RadioButton();
            this.radioButtonRangeBase2 = new System.Windows.Forms.RadioButton();
            this.radioButtonRangeBase8 = new System.Windows.Forms.RadioButton();
            this.radioButtonRangeBase10 = new System.Windows.Forms.RadioButton();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.checkBoxAutoGenerate = new System.Windows.Forms.CheckBox();
            this.checkBoxOtherSettings = new System.Windows.Forms.CheckBox();
            this.buttonOtherSettings = new System.Windows.Forms.Button();
            this.groupBoxGenerationSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordLength)).BeginInit();
            this.groupBoxRangeSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGeneration
            // 
            this.buttonGeneration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGeneration.Location = new System.Drawing.Point(281, 628);
            this.buttonGeneration.Name = "buttonGeneration";
            this.buttonGeneration.Size = new System.Drawing.Size(100, 23);
            this.buttonGeneration.TabIndex = 2;
            this.buttonGeneration.Text = "Генерация";
            this.buttonGeneration.UseVisualStyleBackColor = true;
            this.buttonGeneration.Click += new System.EventHandler(this.buttonGeneration_Click);
            // 
            // buttonPathFile
            // 
            this.buttonPathFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPathFile.Location = new System.Drawing.Point(407, 628);
            this.buttonPathFile.Name = "buttonPathFile";
            this.buttonPathFile.Size = new System.Drawing.Size(100, 23);
            this.buttonPathFile.TabIndex = 6;
            this.buttonPathFile.Text = "Сохранить";
            this.buttonPathFile.UseVisualStyleBackColor = true;
            this.buttonPathFile.Click += new System.EventHandler(this.buttonPathFile_Click);
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
            this.checkBoxCyrillicAlphabet.Size = new System.Drawing.Size(144, 17);
            this.checkBoxCyrillicAlphabet.TabIndex = 10;
            this.checkBoxCyrillicAlphabet.Text = "Кирилические символы";
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
            this.checkBoxLatinAlphabet.Size = new System.Drawing.Size(126, 17);
            this.checkBoxLatinAlphabet.TabIndex = 9;
            this.checkBoxLatinAlphabet.Text = "Латинские символы";
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
            this.checkBoxSymbolLowers.Size = new System.Drawing.Size(115, 17);
            this.checkBoxSymbolLowers.TabIndex = 11;
            this.checkBoxSymbolLowers.Text = "Регистр \"нижний\"";
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
            this.checkBoxSymbolUppers.Size = new System.Drawing.Size(122, 17);
            this.checkBoxSymbolUppers.TabIndex = 12;
            this.checkBoxSymbolUppers.Text = "Регистр \"ВЕРХНИЙ\"";
            this.checkBoxSymbolUppers.UseVisualStyleBackColor = true;
            this.checkBoxSymbolUppers.CheckedChanged += new System.EventHandler(this.checkBoxSymbolsRange_CheckedChanged);
            // 
            // groupBoxGenerationSettings
            // 
            this.groupBoxGenerationSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGenerationSettings.Controls.Add(this.textBoxSeparator);
            this.groupBoxGenerationSettings.Controls.Add(this.radioButtonSeparatorCustom);
            this.groupBoxGenerationSettings.Controls.Add(this.radioButtonSeparatorLines);
            this.groupBoxGenerationSettings.Controls.Add(this.radioButtonSeparatorSpace);
            this.groupBoxGenerationSettings.Controls.Add(this.labelNumbersPassword);
            this.groupBoxGenerationSettings.Controls.Add(this.numericUpDownPasswordNumbers);
            this.groupBoxGenerationSettings.Controls.Add(this.labelLengthPassword);
            this.groupBoxGenerationSettings.Controls.Add(this.numericUpDownPasswordLength);
            this.groupBoxGenerationSettings.Location = new System.Drawing.Point(273, 442);
            this.groupBoxGenerationSettings.Name = "groupBoxGenerationSettings";
            this.groupBoxGenerationSettings.Size = new System.Drawing.Size(234, 156);
            this.groupBoxGenerationSettings.TabIndex = 3;
            this.groupBoxGenerationSettings.TabStop = false;
            this.groupBoxGenerationSettings.Text = "Настройки генерации";
            // 
            // textBoxSeparator
            // 
            this.textBoxSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSeparator.Enabled = false;
            this.textBoxSeparator.Location = new System.Drawing.Point(142, 122);
            this.textBoxSeparator.Name = "textBoxSeparator";
            this.textBoxSeparator.Size = new System.Drawing.Size(81, 21);
            this.textBoxSeparator.TabIndex = 10;
            this.textBoxSeparator.Text = " ";
            this.textBoxSeparator.TextChanged += new System.EventHandler(this.textBoxSeparator_TextChanged);
            // 
            // radioButtonSeparatorCustom
            // 
            this.radioButtonSeparatorCustom.AutoSize = true;
            this.radioButtonSeparatorCustom.Location = new System.Drawing.Point(9, 123);
            this.radioButtonSeparatorCustom.Name = "radioButtonSeparatorCustom";
            this.radioButtonSeparatorCustom.Size = new System.Drawing.Size(131, 17);
            this.radioButtonSeparatorCustom.TabIndex = 9;
            this.radioButtonSeparatorCustom.Text = "Другой разделитель";
            this.radioButtonSeparatorCustom.UseVisualStyleBackColor = true;
            this.radioButtonSeparatorCustom.CheckedChanged += new System.EventHandler(this.radioButtonSeparator_CheckedChanged);
            // 
            // radioButtonSeparatorLines
            // 
            this.radioButtonSeparatorLines.AutoSize = true;
            this.radioButtonSeparatorLines.Checked = true;
            this.radioButtonSeparatorLines.Location = new System.Drawing.Point(9, 100);
            this.radioButtonSeparatorLines.Name = "radioButtonSeparatorLines";
            this.radioButtonSeparatorLines.Size = new System.Drawing.Size(103, 17);
            this.radioButtonSeparatorLines.TabIndex = 8;
            this.radioButtonSeparatorLines.TabStop = true;
            this.radioButtonSeparatorLines.Text = "С новой строки";
            this.radioButtonSeparatorLines.UseVisualStyleBackColor = true;
            this.radioButtonSeparatorLines.CheckedChanged += new System.EventHandler(this.radioButtonSeparator_CheckedChanged);
            // 
            // radioButtonSeparatorSpace
            // 
            this.radioButtonSeparatorSpace.AutoSize = true;
            this.radioButtonSeparatorSpace.Location = new System.Drawing.Point(9, 77);
            this.radioButtonSeparatorSpace.Name = "radioButtonSeparatorSpace";
            this.radioButtonSeparatorSpace.Size = new System.Drawing.Size(136, 17);
            this.radioButtonSeparatorSpace.TabIndex = 7;
            this.radioButtonSeparatorSpace.Text = "Разделять пробелами";
            this.radioButtonSeparatorSpace.UseVisualStyleBackColor = true;
            this.radioButtonSeparatorSpace.CheckedChanged += new System.EventHandler(this.radioButtonSeparator_CheckedChanged);
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
            this.numericUpDownPasswordNumbers.Location = new System.Drawing.Point(162, 46);
            this.numericUpDownPasswordNumbers.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPasswordNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPasswordNumbers.Name = "numericUpDownPasswordNumbers";
            this.numericUpDownPasswordNumbers.Size = new System.Drawing.Size(61, 21);
            this.numericUpDownPasswordNumbers.TabIndex = 2;
            this.numericUpDownPasswordNumbers.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownPasswordNumbers.ValueChanged += new System.EventHandler(this.numericUpDownPassword_ValueChanged);
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
            this.numericUpDownPasswordLength.Location = new System.Drawing.Point(162, 19);
            this.numericUpDownPasswordLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPasswordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPasswordLength.Name = "numericUpDownPasswordLength";
            this.numericUpDownPasswordLength.Size = new System.Drawing.Size(61, 21);
            this.numericUpDownPasswordLength.TabIndex = 0;
            this.numericUpDownPasswordLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownPasswordLength.ValueChanged += new System.EventHandler(this.numericUpDownPassword_ValueChanged);
            // 
            // groupBoxRangeSettings
            // 
            this.groupBoxRangeSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRangeSettings.Controls.Add(this.buttonOtherSettings);
            this.groupBoxRangeSettings.Controls.Add(this.checkBoxOtherSettings);
            this.groupBoxRangeSettings.Controls.Add(this.radioButtonRangeBase64);
            this.groupBoxRangeSettings.Controls.Add(this.textBoxCustomRange);
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
            this.groupBoxRangeSettings.Location = new System.Drawing.Point(273, 12);
            this.groupBoxRangeSettings.Name = "groupBoxRangeSettings";
            this.groupBoxRangeSettings.Size = new System.Drawing.Size(234, 424);
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
            // textBoxCustomRange
            // 
            this.textBoxCustomRange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCustomRange.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCustomRange.Location = new System.Drawing.Point(9, 342);
            this.textBoxCustomRange.Multiline = true;
            this.textBoxCustomRange.Name = "textBoxCustomRange";
            this.textBoxCustomRange.Size = new System.Drawing.Size(214, 41);
            this.textBoxCustomRange.TabIndex = 16;
            this.textBoxCustomRange.TextChanged += new System.EventHandler(this.textBoxCustomRange_TextChanged);
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
            this.textBoxOutput.AcceptsReturn = true;
            this.textBoxOutput.AcceptsTab = true;
            this.textBoxOutput.AllowDrop = true;
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(12, 12);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(255, 639);
            this.textBoxOutput.TabIndex = 0;
            // 
            // checkBoxAutoGenerate
            // 
            this.checkBoxAutoGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAutoGenerate.AutoSize = true;
            this.checkBoxAutoGenerate.Checked = true;
            this.checkBoxAutoGenerate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoGenerate.Location = new System.Drawing.Point(282, 604);
            this.checkBoxAutoGenerate.Name = "checkBoxAutoGenerate";
            this.checkBoxAutoGenerate.Size = new System.Drawing.Size(104, 17);
            this.checkBoxAutoGenerate.TabIndex = 11;
            this.checkBoxAutoGenerate.Text = "Автогенерация";
            this.checkBoxAutoGenerate.UseVisualStyleBackColor = true;
            // 
            // checkBoxOtherSettings
            // 
            this.checkBoxOtherSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxOtherSettings.AutoSize = true;
            this.checkBoxOtherSettings.Location = new System.Drawing.Point(9, 393);
            this.checkBoxOtherSettings.Name = "checkBoxOtherSettings";
            this.checkBoxOtherSettings.Size = new System.Drawing.Size(118, 17);
            this.checkBoxOtherSettings.TabIndex = 17;
            this.checkBoxOtherSettings.Text = "Дополнительно...";
            this.checkBoxOtherSettings.UseVisualStyleBackColor = true;
            this.checkBoxOtherSettings.CheckedChanged += new System.EventHandler(this.checkBoxOtherSettings_CheckedChanged);
            // 
            // buttonOtherSettings
            // 
            this.buttonOtherSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOtherSettings.Enabled = false;
            this.buttonOtherSettings.Location = new System.Drawing.Point(148, 389);
            this.buttonOtherSettings.Name = "buttonOtherSettings";
            this.buttonOtherSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonOtherSettings.TabIndex = 18;
            this.buttonOtherSettings.Text = "Прочее";
            this.buttonOtherSettings.UseVisualStyleBackColor = true;
            this.buttonOtherSettings.Click += new System.EventHandler(this.buttonOtherSettings_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 663);
            this.Controls.Add(this.checkBoxAutoGenerate);
            this.Controls.Add(this.groupBoxRangeSettings);
            this.Controls.Add(this.groupBoxGenerationSettings);
            this.Controls.Add(this.buttonGeneration);
            this.Controls.Add(this.buttonPathFile);
            this.Controls.Add(this.textBoxOutput);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(535, 680);
            this.Name = "FormMain";
            this.Text = "Генератор паролей";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
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
        private System.Windows.Forms.Button buttonPathFile;
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
        private System.Windows.Forms.TextBox textBoxCustomRange;
        private System.Windows.Forms.CheckBox checkBoxCustom;
        private System.Windows.Forms.CheckBox checkBoxPunctuation;
        private System.Windows.Forms.CheckBox checkBoxSymbolUppers;
        private System.Windows.Forms.CheckBox checkBoxSymbolLowers;
        private System.Windows.Forms.CheckBox checkBoxCyrillicAlphabet;
        private System.Windows.Forms.TextBox textBoxSeparator;
        private System.Windows.Forms.RadioButton radioButtonSeparatorCustom;
        private System.Windows.Forms.RadioButton radioButtonSeparatorLines;
        private System.Windows.Forms.RadioButton radioButtonSeparatorSpace;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.CheckBox checkBoxAutoGenerate;
        private System.Windows.Forms.Button buttonOtherSettings;
        private System.Windows.Forms.CheckBox checkBoxOtherSettings;
    }
}

