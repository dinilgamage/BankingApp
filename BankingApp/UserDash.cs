using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankingApp
{
    public partial class UserDash : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public UserDash()
        {
            InitializeComponent();
            lbluser.Text = Form1.userName;

        }

        private void UserDash_Load(object sender, EventArgs e)
        {

        }
        public static string lbluserName = "", accnos = "";
        private void btncurrent_Click(object sender, EventArgs e)
        {


        }

        private void btnsavings_Click(object sender, EventArgs e)
        {
            lbluserName = Form1.userName;
            txtaccnos.Text = accnos;
            Savings sv = new Savings();
            sv.Show();
            this.Hide();


            sv.Left = this.Left;
            sv.Top = this.Top;
            sv.Size = this.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ud = new Form1();
            ud.Show();
            this.Hide();
            

            ud.Left = this.Left;
            ud.Top = this.Top;
        }
    }
}
