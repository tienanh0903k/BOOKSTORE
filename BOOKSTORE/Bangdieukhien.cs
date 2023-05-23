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
    
    public partial class Bangdieukhien : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-48I6O9GG\NTASPORT;Initial Catalog=BOOKSHOPDB;Integrated Security=True");
        public Bangdieukhien()
        {
            InitializeComponent();
        }

        private void Bangdieukhien_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter ada = new SqlDataAdapter("SELECT SUM(BCL) FROM BookTb1",conn);
            DataTable dt = new DataTable();
            ada.Fill(dt);   
            slSach.Text = dt.Rows[0][0].ToString();

            SqlDataAdapter ada1 = new SqlDataAdapter("SELECT SUM(Amount) FROM BillTb1", conn);
            DataTable dt1 = new DataTable();
            ada1.Fill(dt1);
            tongTien.Text = dt1.Rows[0][0].ToString();

            SqlDataAdapter ada2 = new SqlDataAdapter("SELECT COUNT(*) FROM UserTb1", conn);
            DataTable dt2 = new DataTable();
            ada2.Fill(dt2);
            souser.Text = dt2.Rows[0][0].ToString();

            conn.Close();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Books ob = new Books();
            ob.Show();
            ob.Hide();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            Users ob = new Users();
            ob.Show();
            ob.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            ob.Show();
            ob.Hide();
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
