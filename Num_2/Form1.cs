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
    public partial class Form1 : Form
    {
        double AllPrice = 0;
        string tovar;
        List<Tovar> tovars = null;
        public Form1()
        {
            InitializeComponent();
            tovars = new List<Tovar>();
            ProductStock.SelectedIndexChanged += ProductStock_SelectedIndexChanged;
        }
        private void ProductStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriceProduct.Text = ((Tovar)ProductStock.Items[ProductStock.SelectedIndex]).Price.ToString();
        }
        private void AddListButton_Click(object sender, EventArgs e)
        {
            if (ProductStock.Text != "")
            {
                tovar = "Товар: " + ((Tovar)ProductStock.Items[ProductStock.SelectedIndex]).Name + ", " +
                   "Xарактеристика: " + ((Tovar)ProductStock.Items[ProductStock.SelectedIndex]).Specification + ", " +
                    "Описание: " + ((Tovar)ProductStock.Items[ProductStock.SelectedIndex]).Description;
                ProductList.Items.Add(tovar);

                AllPrice += ((Tovar)ProductStock.Items[ProductStock.SelectedIndex]).Price;
                if (ProductList.Items.Count > 0)
                {
                    LabelTovar.Text = "Цена товаров в списке:";
                    AllPriceProductLabel.Visible = true;
                    AllPriceProduct.Visible = true;
                }
                AllPriceProduct.Text = AllPrice.ToString();
            }
            else
                MessageBox.Show("Вы не выбрали товар!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            tovars.Add(new Tovar());
            Form2 f = new Form2(tovars[tovars.Count - 1], true);
            if (f.ShowDialog() == DialogResult.OK)
            {
                ProductStock.Items.Add(tovars[tovars.Count - 1]);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ProductStock.SelectedIndex == -1)
            {
                MessageBox.Show("Товар не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n = ProductStock.SelectedIndex;
            Tovar tovar = (Tovar)ProductStock.Items[n];
            Form2 f = new Form2(tovar, false);
            f.ShowDialog();
            ProductStock.Items.RemoveAt(n);
            ProductStock.Items.Insert(n, tovar);
            ProductStock.SelectedIndex = n;
        }
    }
}
