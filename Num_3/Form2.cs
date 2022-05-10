using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_3
{
    public partial class Form2 : Form
    {
        Form1 f;
        public Form2(Form1 form)
        {
            InitializeComponent();
            f = form;
            textBox.Text = f.TextBox_Value;
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            f.TextBox_Value = textBox.Text;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(textBox.Text);
                writer.Close();
            }

            Close();
        }
    }
}
