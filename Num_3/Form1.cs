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
    public partial class Form1 : Form
    {
       public string TextBox_Value
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files(*.*)|*.*|Text Files(*.txt)|*.txt";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofd.FileName, Encoding.UTF8);
                textBox.Text = reader.ReadToEnd();
                reader.Close();
                EditButton.Enabled = true;
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.Show();
        }
    }
}
