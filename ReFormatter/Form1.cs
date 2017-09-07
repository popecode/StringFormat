using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReFormatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] FormattedOutput;

        //Format Button
        private void button2_Click(object sender, EventArgs e)
        {
            string[] lines = textBoxInput.Lines;
            string format = textBox1.Text;
            char formatChar = textboxSplitter.Text[0];

            FormatText formatter = new FormatText(lines, format, formatChar);
            FormattedOutput = formatter.ReturnFormatedText();

            textBoxOutput.Text = "";
            foreach (var line in FormattedOutput)
            {
                textBoxOutput.Text += string.Format("{0} \r\n", line);
            }
        }

    }
}
