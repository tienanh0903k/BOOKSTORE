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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childform);
            panel_body.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-48I6O9GG\NTASPORT;Initial Catalog=BOOKSHOPDB;Integrated Security=True");
        private void Bill_Load(object sender, EventArgs e)
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
        private void btnSave_Click(object sender, EventArgs e)
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
        private void label8_Click(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenSach.Text = "";
            txtCL.Text = "";
            txtGia.Text = "";
            txtClient.Text = "";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("nta", 300, 800) ;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            else
            {
                if (txtClient.Text == "" )
                {
                    MessageBox.Show("Chua co thong tin");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO BillTb1 VALUES('" + username.Text + "', '" + txtClient.Text + "','" + Tongtien + "')";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Luu vao hoa don  thanh cong");
                        conn.Close();
                        //populate();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }

            
        }
        int prID, prSl, prGia, prTong, position = 60;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void btBook_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            ob.Show();
            ob.Hide();
        }

        string prName;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Bookshop", new Font("Montserrat", 12, FontStyle.Regular),Brushes.Red, new Point(120));
            e.Graphics.DrawString("ID  SACH    GIA        SL          TONG", new Font("Montserrat", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                prID = Convert.ToInt32(row.Cells["Column1"].Value);
                prName = "" + row.Cells["Column2"].Value;
                prSl = Convert.ToInt32(row.Cells["Column3"].Value);
                prGia = Convert.ToInt32(row.Cells["Column4"].Value);
                prTong = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prID, new Font("Montserrat", 12, FontStyle.Italic), Brushes.Black, new Point(26,position));
                e.Graphics.DrawString("" + prName, new Font("Montserrat", 12, FontStyle.Bold), Brushes.Black, new Point(45, position));
                e.Graphics.DrawString("" + prGia, new Font("Montserrat", 12, FontStyle.Bold), Brushes.Black, new Point(120, position));
                e.Graphics.DrawString("" + prSl, new Font("Montserrat", 12, FontStyle.Bold), Brushes.Black, new Point(170, position));
                e.Graphics.DrawString("" + prTong, new Font("Montserrat", 12, FontStyle.Bold), Brushes.Black, new Point(235, position));
                position += 20;
            }
            e.Graphics.DrawString("Tong so tien: " + SUM, new Font("Montserrat", 12, FontStyle.Bold), Brushes.Black, new Point(60, position + 50));
            e.Graphics.DrawString("---XIN CAM ON QUY KHACH --- " , new Font("Montserrat", 10, FontStyle.Bold), Brushes.Black, new Point(40, position + 85));
            dgvBill.Rows.Clear();
            dgvBill.Refresh();
            position = 100;
            SUM = 0;
        }
    }
}
