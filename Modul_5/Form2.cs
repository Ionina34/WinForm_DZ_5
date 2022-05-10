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

namespace Modul_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text != "")
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        string mask = textBox.Text;
                        if (!(mask.Contains("*.")))
                            mask = "*." + mask;
                        if ((!(mask.Contains("*"))) && mask.Contains("."))
                            mask = "*" + mask;

                        var files = Directory.GetFiles(fbd.SelectedPath, mask, SearchOption.AllDirectories);
                        listBox.Items.Clear();
                        if (files.Length != 0)
                            foreach (var file in files)
                                listBox.Items.Add(file);
                        else MessageBox.Show($"Файлов не найдено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else MessageBox.Show("Ввeдите маску поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form2_Shown(object sender, EventArgs e)
        {
            textBox.Focus();

        }
    }
}
