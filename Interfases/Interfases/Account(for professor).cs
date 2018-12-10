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
    public partial class Account_for_professor_ : Form
    {
        public Account_for_professor_()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Home_page_for_professor_ Главное_меню = new Home_page_for_professor_();
            Главное_меню.ShowDialog();
            Close();
        }
    }
}
