using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BOOKSTORE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Ket noi co so du lieu
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-48I6O9GG\NTASPORT;Initial Catalog=BOOKSHOPDB;Integrated Security=True");
        private void Login_Load(object sender, EventArgs e)
        {

        }
        public static string Username = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DangNhap(txtadmin.Text, txtPass.Text);
        }



        private void admin_Click(object sender, EventArgs e)
        {

        }
        public bool DangNhap(string a, string b)
        {
            if (a == "" & b == "")
            {
                MessageBox.Show(" không được để trống ");
                return false;
            }
            else if (a == "" & b != "")
            {
                MessageBox.Show(" không được để trống ");
                return false;
            }
            else if (a != "" & b == "" )
            {
                MessageBox.Show(" không được để trống ");
                return false;
            }
            else if (a != null & b == null)
            {
                MessageBox.Show(" không được để trống ");
                return false;
            }
            else
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserTb1 WHERE Uname = '" + a + "' and UPass = '" + b + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Username = txtadmin.Text;
                    Books ob = new Books();
                    ob.Show();
                    this.Hide();
                    conn.Close();
                }
                return true;
            }

        }
    }
}