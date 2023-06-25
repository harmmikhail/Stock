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
    public partial class GoodsUploadForm : Form
    {
        public GoodsUploadForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectedName = comboBox1.SelectedItem as string;
            if (string.IsNullOrEmpty(selectedName))
            {
                MessageBox.Show("Оберіть товар зі списку або введіть правильну назву", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  

            using (var context = new Context())
            {
                var checkin = context.Checkin.FirstOrDefault(c => c.Name == selectedName);
                if (checkin == null)
                {
                    MessageBox.Show("Товар не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string inputQuantity = textBox1.Text;

                if (!int.TryParse(inputQuantity, out int quantityToAdd) || quantityToAdd < 0)
                {
                    MessageBox.Show("Введене значення не є додатнім або значення невірне. Будь ласка, спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int availableQuantity = checkin.Quantity;

                if (quantityToAdd > availableQuantity)
                {
                    MessageBox.Show("Недостатньо товару на складі.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                checkin.Quantity -= quantityToAdd;
                

                ProductInfo.AddedProducts.Add(new ProductInfo
                {
                    Name = checkin.Name,
                    Quantity = quantityToAdd,
                    Price = checkin.Price,
                });

                DialogResult result = MessageBox.Show("Ви впевнені у коректності введених даних? Ви не зможете змінити інформацію.", "Попередження", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Товар було успішно додано.", "Підтверджено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    context.SaveChanges();
                    comboBox1.SelectedIndex = -1;
                    textBox1.Text = "";
                }                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProductInfo.AddedProducts.Count == 0)
            {
                MessageBox.Show("Додайте хоча б один товар перед підтвердженням.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ExpenseNoteForm expenseNote = new ExpenseNoteForm(ProductInfo.AddedProducts);
            MainForm mainForm = new MainForm();
            this.Hide();
            expenseNote.ShowDialog();
            mainForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GoodsDeleting goodsDeleting = new GoodsDeleting();
            this.Hide();
            goodsDeleting.ShowDialog();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            using (var context = new Context())
            {
                var checkins = context.Checkin.ToList();

                foreach (var checkin in checkins)
                {
                    comboBox1.Items.Add(checkin.Name);
                }
            }
        }
    }
}
