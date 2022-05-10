
namespace Num_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductList = new System.Windows.Forms.ListBox();
            this.ProductStock = new System.Windows.Forms.ComboBox();
            this.PriceProduct = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddListButton = new System.Windows.Forms.Button();
            this.AllPriceProduct = new System.Windows.Forms.TextBox();
            this.PriceProductLabel = new System.Windows.Forms.Label();
            this.AllPriceProductLabel = new System.Windows.Forms.Label();
            this.LabelTovar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.HorizontalScrollbar = true;
            this.ProductList.Location = new System.Drawing.Point(298, 27);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(168, 147);
            this.ProductList.TabIndex = 0;
            // 
            // ProductStock
            // 
            this.ProductStock.FormattingEnabled = true;
            this.ProductStock.Location = new System.Drawing.Point(12, 56);
            this.ProductStock.Name = "ProductStock";
            this.ProductStock.Size = new System.Drawing.Size(134, 21);
            this.ProductStock.TabIndex = 1;
            // 
            // PriceProduct
            // 
            this.PriceProduct.Enabled = false;
            this.PriceProduct.Location = new System.Drawing.Point(13, 27);
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.ReadOnly = true;
            this.PriceProduct.Size = new System.Drawing.Size(100, 20);
            this.PriceProduct.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(31, 258);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(185, 87);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить товар";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.Location = new System.Drawing.Point(261, 258);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(185, 87);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Редактировать товар";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddListButton
            // 
            this.AddListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddListButton.Location = new System.Drawing.Point(161, 56);
            this.AddListButton.Name = "AddListButton";
            this.AddListButton.Size = new System.Drawing.Size(109, 87);
            this.AddListButton.TabIndex = 5;
            this.AddListButton.Text = "Добавть товар в список ";
            this.AddListButton.UseVisualStyleBackColor = true;
            this.AddListButton.Click += new System.EventHandler(this.AddListButton_Click);
            // 
            // AllPriceProduct
            // 
            this.AllPriceProduct.Location = new System.Drawing.Point(298, 202);
            this.AllPriceProduct.Name = "AllPriceProduct";
            this.AllPriceProduct.ReadOnly = true;
            this.AllPriceProduct.Size = new System.Drawing.Size(100, 20);
            this.AllPriceProduct.TabIndex = 6;
            this.AllPriceProduct.Visible = false;
            // 
            // PriceProductLabel
            // 
            this.PriceProductLabel.AutoSize = true;
            this.PriceProductLabel.Location = new System.Drawing.Point(119, 30);
            this.PriceProductLabel.Name = "PriceProductLabel";
            this.PriceProductLabel.Size = new System.Drawing.Size(27, 13);
            this.PriceProductLabel.TabIndex = 7;
            this.PriceProductLabel.Text = "руб.";
            this.PriceProductLabel.Visible = false;
            // 
            // AllPriceProductLabel
            // 
            this.AllPriceProductLabel.AutoSize = true;
            this.AllPriceProductLabel.Location = new System.Drawing.Point(404, 209);
            this.AllPriceProductLabel.Name = "AllPriceProductLabel";
            this.AllPriceProductLabel.Size = new System.Drawing.Size(27, 13);
            this.AllPriceProductLabel.TabIndex = 8;
            this.AllPriceProductLabel.Text = "руб.";
            // 
            // LabelTovar
            // 
            this.LabelTovar.Location = new System.Drawing.Point(295, 186);
            this.LabelTovar.Name = "LabelTovar";
            this.LabelTovar.Size = new System.Drawing.Size(129, 13);
            this.LabelTovar.TabIndex = 9;
            this.LabelTovar.Text = "Товаров в списке нет";
            this.LabelTovar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 361);
            this.Controls.Add(this.LabelTovar);
            this.Controls.Add(this.AllPriceProductLabel);
            this.Controls.Add(this.PriceProductLabel);
            this.Controls.Add(this.AllPriceProduct);
            this.Controls.Add(this.AddListButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PriceProduct);
            this.Controls.Add(this.ProductStock);
            this.Controls.Add(this.ProductList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет продаж";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.ComboBox ProductStock;
        private System.Windows.Forms.TextBox PriceProduct;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddListButton;
        private System.Windows.Forms.TextBox AllPriceProduct;
        private System.Windows.Forms.Label PriceProductLabel;
        private System.Windows.Forms.Label AllPriceProductLabel;
        private System.Windows.Forms.Label LabelTovar;
    }
}

