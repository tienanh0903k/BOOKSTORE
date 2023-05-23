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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-48I6O9GG\NTASPORT;Initial Catalog=BOOKSHOPDB;Integrated Security=True");
        private void Billing_Load(object sender, EventArgs e)
        {
            username.Text = Login.Username;
            conn.Open();
            string query = "SELECT * FROM BookTb1";
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            SqlCommandBuilder bui = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            dgvBooks.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void populate()
        {
            conn.Open();
            string query = "SELECT * FROM BookTb1";
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            SqlCommandBuilder bui = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            dgvBooks.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void UpdateBook()
        {
            try
            {
                conn.Open();
                string query = "UPDATE BookTb1 set BCL = '" + txtCL.Text + "' where BID = '" + key + "'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cap nhat thanh cong");
                conn.Close();
                populate();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }


        int n = 0;
        int SUM = 0;
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(txtCL.Text) * Convert.ToInt32(txtGia.Text);
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvBill);
            r.Cells[0].Value = n + 1;
            r.Cells[1].Value = txtTenSach.Text;
            r.Cells[2].Value = txtGia.Text;
            r.Cells[3].Value = txtCL.Text;
            r.Cells[4].Value = total;
            dgvBill.Rows.Add(r);
            n++;
            UpdateBook();
            SUM = SUM + total;
            Tongtien.Text = "" + SUM;
        }
        


        int key = 0;
        private void dgvBooks_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSach.Text = dgvBooks.SelectedRows[0].Cells[1].Value.ToString();
            //txtCL.Text = dgvBooks.SelectedRows[0].Cells[4].Value.ToString();
            txtGia.Text = dgvBooks.SelectedRows[0].Cells[5].Value.ToString();
            if (txtTenSach.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value.ToString());
            }

        }



        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtTenSach.Text = "";
            txtCL.Text = "";
            txtGia.Text = "";
            txtClient.Text = "";
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            reportBooks rp = new reportBooks();
            rp.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
