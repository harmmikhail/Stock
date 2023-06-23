using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace Stock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            GoodsUpdatingForm form6 = new GoodsUpdatingForm();
            this.Hide();
            List<Checkin> checkin = context.Checkin.ToList();

            form6.SetData(checkin);

            form6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            GoodsUploadForm form3 = new GoodsUploadForm();
            this.Hide();
            List<Checkin> checkin = context.Checkin.ToList();
            form3.SetData(checkin);
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            InventoryListForm form2 = new InventoryListForm();
            this.Hide();
            List<Checkin> checkin = context.Checkin.ToList();

            form2.SetData(checkin);

            form2.ShowDialog();
        }
    }
}