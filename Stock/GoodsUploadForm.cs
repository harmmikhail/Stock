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

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedName = comboBox1.SelectedItem as string;
            if (string.IsNullOrEmpty(selectedName))
            {
                MessageBox.Show("Оберіть товар зі списку або введіть правильну назву.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string removeQuantityText = textBox1.Text;
            if (string.IsNullOrEmpty(removeQuantityText))
            {
                MessageBox.Show("Введіть кількість товару.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(removeQuantityText, out int removeQuantity))
            {
                MessageBox.Show("Введене значення кількості повинно бути цілим числом.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                int updatedQuantity = checkin.Quantity - removeQuantity;

                if (updatedQuantity < 0)
                {
                    MessageBox.Show("На складі недостатньо товару, змініть кількість для вигрузки.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                checkin.Quantity = updatedQuantity;
                context.SaveChanges();
                textBox1.Text = "";

                ExpenseNoteForm expenseNoteForm = new ExpenseNoteForm();
                this.Hide();
                expenseNoteForm.ShowDialog();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            this.Hide();
            form1.ShowDialog();
        }

        private void comboBox1_Click(object sender, EventArgs e)
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
