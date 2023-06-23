﻿using System;
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
    public partial class GoodsAddingForm : Form
    {
        public GoodsAddingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string priceText = textBoxPrice.Text;
            string quantityText = textBoxQuantity.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(quantityText))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(priceText, out int price) || !int.TryParse(quantityText, out int quantity))
            {
                MessageBox.Show("Введені значення для ціни або кількості мають бути цілими числами.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new Context())
            {
                if (context.Checkin.Any(c => c.Name == name))
                {
                    MessageBox.Show("Товар з таким ім'ям уже існує. Введіть іншу назву.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Checkin newCheckin = new Checkin
                {
                    Name = name,
                    Price = price,
                    Quantity = quantity,
                    Units = "kg",
                    LastTimeDelivery = DateTime.Now.Date
                };

                context.Checkin.Add(newCheckin);
                context.SaveChanges();
            }

            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoodsUpdatingForm goodsUpdating = new GoodsUpdatingForm();
            this.Hide();
            goodsUpdating.ShowDialog();
        }
    }
}