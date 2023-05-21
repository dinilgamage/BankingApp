using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Savings : Form
    {
        public Savings()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserDash ud = new UserDash();
            ud.Show();
            this.Hide();
           

            ud.Left = this.Left;
            ud.Top = this.Top;
            ud.Size = this.Size;
        }
    }
}
