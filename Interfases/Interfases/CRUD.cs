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
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            CRUD_student crud1 = new CRUD_student();
            crud1.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            CRUD_items crud1 = new CRUD_items();
            crud1.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            CRUD_professor crud2 = new CRUD_professor();
            crud2.ShowDialog();
            Close();
        }
    }
}
