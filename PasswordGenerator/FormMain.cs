using PasswordGenerator.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class FormMain : Form
    {
        private Generator generator;

        public FormMain ()
        {
            generator = new Generator ();

            InitializeComponent ();
        }

        private void FormMain_Load (object sender, EventArgs e)
        {
            OnChangeSettingDigitalRange ();
            OnChangeSettingSymbolsRange ();
            OnChangeSettingPunctuationRange ();
            OnChangedSeparatorType ();

            textBoxCustomRange.Enabled = checkBoxCustom.Checked;
        }

        private void FormMain_Shown (object sender, EventArgs e)
        {
            OnGenerate ();
        }

        private void checkBoxStandart_CheckedChanged (object sender, EventArgs e)
        {
            bool state = checkBoxStandart.Checked;

            checkBoxDigitalRange.Enabled = state;
            checkBoxSymbolsRange.Enabled = state;
            checkBoxPunctuation.Enabled = state;

            OnChangeSettingDigitalRange ();
            OnChangeSettingSymbolsRange ();
            OnChangeSettingPunctuationRange ();

            if (checkBoxStandart.Checked)
                checkBoxCustom.Checked = false;
        }

        private void checkBoxDigitalRange_CheckedChanged (object sender, EventArgs e)
        {
            OnChangeSettingDigitalRange ();
        }

        private void radioButtonRangeBaseN_CheckedChanged (object sender, EventArgs e)
        {
            OnChangeSettingDigitalRange ();
        }

        private void checkBoxSymbolsRange_CheckedChanged (object sender, EventArgs e)
        {
            OnChangeSettingSymbolsRange ();
        }

        private void checkBoxPunctuation_CheckedChanged (object sender, EventArgs e)
        {
            OnChangeSettingPunctuationRange ();
        }

        private void checkBoxCustom_CheckedChanged (object sender, EventArgs e)
        {
            if (checkBoxCustom.Checked)
                checkBoxStandart.Checked = false;

            textBoxCustomRange.Enabled = checkBoxCustom.Checked;
        }

        private void textBoxCustomRange_TextChanged (object sender, EventArgs e)
        {
            generator.SetCustomRange (textBoxCustomRange.Text);
        }

        private void textBoxSeparator_TextChanged (object sender, EventArgs e)
        {
            generator.SetSeparator (textBoxSeparator.Text);
        }

        private void radioButtonSeparator_CheckedChanged (object sender, EventArgs e)
        {
            OnChangedSeparatorType ();
        }

        private void buttonGeneration_Click (object sender, EventArgs e)
        {
            OnGenerate ();
        }

        private void buttonQuit_Click (object sender, EventArgs e)
        {
            Application.Exit ();
        }

        private void OnChangeSettingDigitalRange ()
        {
            bool state = checkBoxStandart.Checked && checkBoxDigitalRange.Checked;

            radioButtonRangeBase2.Enabled = state;
            radioButtonRangeBase8.Enabled = state;
            radioButtonRangeBase10.Enabled = state;
            radioButtonRangeBase16.Enabled = state;
            radioButtonRangeBase64.Enabled = state;

            generator.SetDigitalRange (GetSelectDigitalRange ());
            OnChangeSettings ();
        }

        private void OnChangeSettingSymbolsRange ()
        {
            bool state = checkBoxStandart.Checked && checkBoxSymbolsRange.Checked;

            checkBoxCyrillicAlphabet.Enabled = state;
            checkBoxLatinAlphabet.Enabled = state;
            checkBoxSymbolUppers.Enabled = state;
            checkBoxSymbolLowers.Enabled = state;

            if (!checkBoxCyrillicAlphabet.Checked && !checkBoxLatinAlphabet.Checked)
                checkBoxLatinAlphabet.Checked = true;

            if (!checkBoxSymbolUppers.Checked && !checkBoxSymbolLowers.Checked)
                checkBoxSymbolLowers.Checked = true;

            generator.SetSymbolsRange (GetSelectSymbolsRange (), GetSelectRegisterRange ());
            OnChangeSettings ();
        }

        private void OnChangeSettingPunctuationRange ()
        {
            generator.SetPunctuationSymbols (checkBoxPunctuation.Checked);
            OnChangeSettings ();
        }

        private void OnChangedSeparatorType ()
        {
            if (radioButtonSeparatorSpace.Checked)
                generator.SetSeparator (" ");

            if (radioButtonSeparatorLines.Checked)
                generator.SetSeparator (Environment.NewLine);

            if (radioButtonSeparatorCustom.Checked)
                generator.SetSeparator (textBoxSeparator.Text);

            textBoxSeparator.Enabled = radioButtonSeparatorCustom.Checked;
            OnChangeSettings ();
        }

        private void OnChangeSettings ()
        {
            textBoxCustomRange.Text = generator.CurrentRange;

            if (checkBoxAutoGenerate.Checked)
                OnGenerate ();
        }

        private void OnGenerate ()
        {
            int passwordNumber = (int) numericUpDownPasswordNumbers.Value;
            int passwordLength = (int) numericUpDownPasswordLength.Value;

            textBoxOutput.Text = generator.Generate (passwordNumber, passwordLength);
        }

        private DigitalBaseType GetSelectDigitalRange ()
        {
            if (checkBoxDigitalRange.Checked)
            {
                if (radioButtonRangeBase2.Checked)
                    return DigitalBaseType.Base2;

                if (radioButtonRangeBase8.Checked)
                    return DigitalBaseType.Base8;

                if (radioButtonRangeBase10.Checked)
                    return DigitalBaseType.Base10;

                if (radioButtonRangeBase16.Checked)
                    return DigitalBaseType.Base16;

                if (radioButtonRangeBase64.Checked)
                    return DigitalBaseType.Base64;
            }

            return DigitalBaseType.None;
        }

        private SymbolAlphabetType GetSelectSymbolsRange ()
        {
            var result = SymbolAlphabetType.None;

            if (checkBoxSymbolsRange.Checked)
            {
                if (checkBoxLatinAlphabet.Checked)
                    result |= SymbolAlphabetType.Latin;

                if (checkBoxCyrillicAlphabet.Checked)
                    result |= SymbolAlphabetType.Cyrillic;
            }

            return result;
        }

        private SymbolRegisterType GetSelectRegisterRange ()
        {
            var result = SymbolRegisterType.None;

            if (checkBoxSymbolsRange.Checked)
            {
                if (checkBoxSymbolLowers.Checked)
                    result |= SymbolRegisterType.Lowers;

                if (checkBoxSymbolUppers.Checked)
                    result |= SymbolRegisterType.Uppers;
            }

            return result;
        }

        private void buttonPathFile_Click (object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog () == DialogResult.OK)
            {
                File.WriteAllText (saveFileDialog.FileName, textBoxOutput.Text);
            }
        }

        private void checkBoxAutoGenerate_CheckedChanged (object sender, EventArgs e)
        {
            buttonGeneration.Enabled = !checkBoxAutoGenerate.Checked;
        }

        private void numericUpDownPassword_ValueChanged (object sender, EventArgs e)
        {
            checkBoxAutoGenerate.Checked = numericUpDownPasswordLength.Value * numericUpDownPasswordNumbers.Value < 10000;
            OnChangeSettings ();
        }
    }
}