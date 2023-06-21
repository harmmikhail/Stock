using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Stock
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedName = comboBox1.SelectedItem as string;
            if (string.IsNullOrEmpty(selectedName))
            {
                MessageBox.Show("Оберіть товар зі списку або введіть правильну назву", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string input = textBox1.Text;

            if (!int.TryParse(input, out int quantityToAdd))
            {
                MessageBox.Show("Введене значення не є числом. Будь ласка спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime selectedDate = dateTimePicker1.Value.Date;

            if (selectedDate < DateTime.Now.Date)
            {
                MessageBox.Show("Обрана дата не може бути меншою за сьогоднішню.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                checkin.Quantity += quantityToAdd;
                checkin.LastTimeDelivery = selectedDate;
                context.SaveChanges();
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.ShowDialog();
        }
    }
}
