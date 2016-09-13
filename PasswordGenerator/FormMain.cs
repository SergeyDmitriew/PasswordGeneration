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


        public FormMain ()
        {
            InitializeComponent ();
        }

        private void FormMain_Load (object sender, EventArgs e)
        {
            checkBoxStandart_CheckedChanged (checkBoxStandart, null);
        }

        private void checkBoxStandart_CheckedChanged (object sender, EventArgs e)
        {
            textBoxRange.Enabled = false;
            checkBoxCustom.Checked = false;
        }

        private void checkBoxDigitalRange_CheckedChanged (object sender, EventArgs e)
        {

        }

        private void radioButtonRangeBase2_CheckedChanged (object sender, EventArgs e)
        {
            textBoxRange.Text = Generator.RangeBase2;
        }

        private void radioButtonRangeBas8_CheckedChanged (object sender, EventArgs e)
        {
            textBoxRange.Text = Generator.RangeBase8;
        }

        private void radioButtonRangeBase10_CheckedChanged (object sender, EventArgs e)
        {
            textBoxRange.Text = Generator.RangeBase10;
        }

        private void radioButtonRangeBase16_CheckedChanged (object sender, EventArgs e)
        {
            textBoxRange.Text = Generator.RangeBase16;
        }

        private void radioButtonRangeBase64_CheckedChanged (object sender, EventArgs e)
        {
            textBoxRange.Text = Generator.RangeBase64;
        }
    }
}