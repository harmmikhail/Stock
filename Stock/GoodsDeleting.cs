using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stock
{
    public partial class GoodsDeleting : Form
    {
        public GoodsDeleting()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoodsUploadForm goodsUpload = new GoodsUploadForm();
            this.Hide();
            goodsUpload.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedName = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedName))
            {
                MessageBox.Show("Будь ласка, виберіть назву для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmationResult = MessageBox.Show("Ви впевнені у коректності введених даних? Ви не зможете змінити інформацію.", "Попередження", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (confirmationResult == DialogResult.OK)
            {
                using (var context = new Context())
                {
                    var product = context.Checkin.FirstOrDefault(c => c.Name == selectedName);
                    if (product != null)
                    {
                        context.Checkin.Remove(product);
                        context.SaveChanges();
                        MessageBox.Show("Запис успішно видалено.", "Підтверджено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Товар з вибраною назвою не знайдений.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    comboBox1.Items.Remove(selectedName);
                    comboBox1.SelectedItem = null;
                }
            }
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
