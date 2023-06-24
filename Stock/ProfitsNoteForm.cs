using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class ProfitsNoteForm : Form
    {
        private List<ProductInfo> addedProducts;

        public ProfitsNoteForm(List<ProductInfo> addedProducts)
        {
            InitializeComponent();
            this.addedProducts = addedProducts;
        }

        private void ProfitsNoteForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("NameColumn", "Назва");
            dataGridView1.Columns.Add("QuantityColumn", "Кількість");
            dataGridView1.Columns.Add("PriceColumn", "Ціна");
            dataGridView1.Columns.Add("TotalPriceColumn", "Загальна сума");

            foreach (var product in addedProducts)
            {
                int totalPrice = product.Quantity * product.Price;
                dataGridView1.Rows.Add(product.Name, product.Quantity, product.Price, totalPrice);
            }

            int totalSum = addedProducts.Sum(p => p.Quantity * p.Price);
            labelTotalSum.Text = $"Загальна сума поставок: {totalSum} грн";

            labelDate.Text = $"Дата: {DateTime.Now.Date.ToShortDateString()}";

            ProductInfo.ClearAddedProducts();
        }
    }
}