using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace Stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            Form3 form3 = new Form3();
            this.Hide();
            List<Checkin> checkin = context.Checkin.ToList();
            form3.SetData(checkin);
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            Form2 form2 = new Form2();
            this.Hide();
            List<Checkin> checkin = context.Checkin.ToList();

            form2.SetData(checkin);

            form2.ShowDialog();
        }
    }
}