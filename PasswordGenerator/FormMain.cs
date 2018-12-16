using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            textBoxRange.Enabled = checkBoxCustom.Checked;
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

            textBoxRange.Enabled = checkBoxCustom.Checked;
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
            textBoxRange.Text = generator.CurrentRange;
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
            textBoxRange.Text = generator.CurrentRange;
        }

        private void OnChangeSettingPunctuationRange ()
        {
            generator.SetPunctuationSymbols (checkBoxPunctuation.Checked);
            textBoxRange.Text = generator.CurrentRange;
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

        private void buttonGeneration_Click (object sender, EventArgs e)
        {
            int passwordNumber = (int) numericUpDownPasswordNumbers.Value;
            int passwordLength = (int) numericUpDownPasswordLength.Value;

            textBoxOutput.Text = generator.Generate (passwordNumber, passwordLength);
        }
    }
}