using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BankingApp
{
    public partial class Form1 : Form
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public Form1()
        {
            InitializeComponent();
        }
        public static string userName="";
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Enter Username And Password", "Banking App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // returns the count of rows matching the query criteria and stores in sda, if the value is 1 means theres only one record
                Conn.Open();
                SqlDataAdapter sd = new SqlDataAdapter("SELECT COUNT(*) FROM UserTbl WHERE Password='" + txtpass.Text + "' AND UserName='" + txtuser.Text + "'", Conn);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    userName = txtuser.Text;

                    UserDash ud = new UserDash();
                    ud.Show();
                    this.Hide();
                    Conn.Close();

                    ud.Left = this.Left;
                    ud.Top = this.Top;
                    
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password", "Banking App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Conn.Close();
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
            Conn.Close();

            rg.Left = this.Left;
            rg.Top = this.Top;
            rg.Size = this.Size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}