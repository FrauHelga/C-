using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfases
{
    public partial class Home_page_for_student_ : Form
    {
        public Home_page_for_student_()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Account_for_student_ student = new Account_for_student_();
            student.ShowDialog();
            Close();
        }
    }
}
