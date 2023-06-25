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
    public partial class InventoryListForm : Form
    {
        public InventoryListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form1 = new MainForm();
            this.Hide();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker.Value.Date;

            using (var context = new Context())
            {
                List<Checkin> checkin = context.Checkin
                    .Where(c => c.LastTimeDelivery.Date == selectedDate)
                    .ToList();

                dataGridView1.DataSource = checkin;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            List<Checkin> checkin = context.Checkin.ToList();
            dataGridView1.DataSource= checkin;
        }
    }
}
