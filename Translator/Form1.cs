using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator
{
    public partial class Form1 : Form
    {
        GoogleTranslator gt;

        public Form1()
        {
            InitializeComponent();

            gt = new GoogleTranslator();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            string source;
            string target;

            if (ukEnRadioButton.Checked == true)
            {
                source = "uk";
                target = "en";
            }
            else
            {
                source = "en";
                target = "uk";
            }

            outputTextBox.Text = gt.Translate(inputTextBox.Text, source, target);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}