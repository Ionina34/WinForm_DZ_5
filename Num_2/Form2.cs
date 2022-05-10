using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Num_2
{
    public partial class Form2 : Form
    {
        Tovar t;
        bool addnew;
        public Form2(Tovar t,bool addnew)
        {
            InitializeComponent();
            this.t = t;
            this.addnew = addnew;
            if (addnew == false)
            {
                Text = "Редактирование товар";
                NameBox.Text = t.Name;
                SpecificalBox.Text = t.Specification;
                DescripBox.Text = t.Description;
                PriceBox.Text = t.Price.ToString();
            }
            else Text = "Добавление товара";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(NameBox.Text==""||SpecificalBox.Text==""|| DescripBox.Text=="" ||PriceBox.Text=="")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (t == null) t = new Tovar();
            t.Name = NameBox.Text;
            t.Specification = SpecificalBox.Text;
            t.Description = DescripBox.Text;
            try
            {
                t.Price = Convert.ToDouble(PriceBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Цена указана не верно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
