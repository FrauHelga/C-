using System;
using Models;
using Repositories;
using Data;
using System.Windows.Forms;

namespace Interfases
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = LoginBox.Text;
            user.Password = PasswordBox.Text;
            UserRepository userRepository = new UserRepository();
            if (userRepository.UserLogin(user))
            {
                if(DataUser.Role == "s")
                {
                    Hide();
                    Home_page_for_student_ home = new Home_page_for_student_();
                    home.Show();
                }
                else
                {
                    Hide();
                    Home_page_for_admin_ admin = new Home_page_for_admin_();
                    admin.Show();
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
               



        }
    }
}
