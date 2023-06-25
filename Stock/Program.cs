using Microsoft.VisualBasic.ApplicationServices;

namespace Stock
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var context = new Context())
            {
                List<Checkin> checkin = context.Checkin.ToList();

                int remainingAttempts = 5;

                while (remainingAttempts > 0)
                {
                    using (var authenticationForm = new AuthenticationForm())
                    {
                        if (authenticationForm.ShowDialog() == DialogResult.OK)
                        {
                            if (authenticationForm.Username == "Stock owner" && authenticationForm.Password == "123456")
                            {
                                MainForm mainForm = new MainForm();
                                mainForm.ShowDialog();
                                return;
                            }
                            else
                            {
                                remainingAttempts--;
                                if (remainingAttempts == 1)
                                {
                                    MessageBox.Show("У вас залишилася 1 спроба. Після неї у вас не буде можливості увійти.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    remainingAttempts = 0;
                                }
                                else
                                {
                                    
                                    MessageBox.Show("Невірний логін або пароль. Залишилося спроб: " + (remainingAttempts-1), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    
                                }
                            }
                        }

                        else
                        {
                            DialogResult result = MessageBox.Show("Вхід скасовано. Ви впевнені?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                return;
                            }
                        }
                    }
                }

                MessageBox.Show("Ви вичерпали ліміт спроб. Виконання програми буде припинено.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}