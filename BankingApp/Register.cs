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

namespace BankingApp
{
    
    public partial class Register : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conn.Open();
            SqlDataAdapter sd = new SqlDataAdapter("SELECT COUNT(*) FROM UserTbl WHERE Password='" + txtpass.Text + "' OR UserName='" + txtuser.Text + "'", Conn);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows[0][0].ToString() != "0")
            {
                MessageBox.Show("The Username or Password Already Exists", "Banking App", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (txtuser.Text == "" || txtpass.Text == "" || txtnic.Text == "")
                {
                    MessageBox.Show("Please Add The Missing Information", "Banking App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO UserTbl (UserName, Password, DOB, NIC) VALUES (@u,@p,@d,@n)", Conn);
                        //add parameter with name and value pairs and passed through to the sql query
                        cmd.Parameters.AddWithValue("@u", txtuser.Text);
                        cmd.Parameters.AddWithValue("@p", txtpass.Text);
                        cmd.Parameters.AddWithValue("@d", dtpdob.Text);
                        cmd.Parameters.AddWithValue("@n", txtnic.Text);
                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Account Created!", "Banking App", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch
                    {
                        MessageBox.Show("Please Enter the Correct Details", "Banking App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            Conn.Close();

        }
    }
}
