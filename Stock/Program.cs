using Microsoft.VisualBasic.ApplicationServices;

namespace Stock
{
    public static class Program
    {        
        static void Main()
        {
            using (var context = new Context())
            {
                List<Checkin> checkin = context.Checkin.ToList();
                Form1 mainForm = new Form1();
                mainForm.ShowDialog();
            }

        }
    }
}