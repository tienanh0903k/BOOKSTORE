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
    public partial class Books : Form
    {
        public Books()
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
        private void Form1_Load(object sender, EventArgs e)
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
        public void btnSave_Click(object sender, EventArgs e)
        {
            
            SaveBook(txtTenSach.Text, txtTG.Text, cbTheLoai.SelectedItem.ToString(), int.Parse(txtCL.Text), int.Parse(txtGia.Text));

        }



        public void SaveBook(string txtTenSach, string txtTG, string cbTheLoai, int txtCL, int txtGia)
        {
            if (string.IsNullOrEmpty(txtTenSach) || string.IsNullOrEmpty(txtTG) || txtCL == 0 || txtGia == 0 || string.IsNullOrEmpty(cbTheLoai))
            {
                MessageBox.Show("Chua co thong tin");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO BookTb1 VALUES('" + txtTenSach + "', '" + txtTG + "', '" + cbTheLoai + "','" + txtCL + "','" + txtGia + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBoxMessage = "Luu thanh cong";
                    MessageBox.Show("Thanh cong");
                    conn.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }


        public bool Search_KH(string a)
        {

            if (a == "")
            {
                MessageBox.Show(" Nhập thông tin tìm kiếm");
                return false;
            }
            else
            {
                conn.Open();
                string Query = "select*from BookTb1 where BId='" + txtTimKiem.Text + "'or BTitle='" + txtTimKiem.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvBooks.DataSource = dt;
                conn.Close();
                return true;
            }
        }


        private void Filter(ComboBox x)
        {
            if (x.SelectedIndex == -1)
            {
                return;
            }

            conn.Open();
            string query = "SELECT * FROM BookTb1 WHERE BTHELOAI = '" + x.SelectedItem.ToString() + "' ";
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            SqlCommandBuilder bui = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            dgvBooks.DataSource = ds.Tables[0];
            conn.Close();


        }

        private void refesh_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        int key = 0;

        public string MessageBoxMessage { get; set; }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSach.Text = dgvBooks.SelectedRows[0].Cells[1].Value.ToString();
            txtTG.Text = dgvBooks.SelectedRows[0].Cells[2].Value.ToString();
            cbTheLoai.SelectedItem = dgvBooks.SelectedRows[0].Cells[3].Value.ToString();
            txtCL.Text = dgvBooks.SelectedRows[0].Cells[4].Value.ToString();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "" || txtTG.Text == "" || txtCL.Text == "" || txtGia.Text == "" || cbTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Chua co thong tin");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE BookTb1 set BTitle = '" + txtTenSach.Text + "',BTACGIA = '"+ txtTG.Text+"', BTHELOAI = '"+cbTheLoai.SelectedItem.ToString()+"', BCL = '"+txtCL.Text+"',BGIA = "+txtGia.Text +" where BID = '"+key+"'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cap nhat thanh cong");
                    conn.Close();
                    Form1_Load(sender, e);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "" || txtTG.Text == "" || txtCL.Text == "" || txtGia.Text == "" || cbTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Chua co thong tin");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "delete from BookTb1 where BID = " + key + ";";                        
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoa thanh cong");
                    conn.Close();
                    Form1_Load(sender, e);


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenSach.Text = "";
            txtCL.Text = "";
            txtGia.Text = "";
            txtTG.Text = "";
        }

        private void cbListFilter_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Filter(cbListFilter);
        }
       
        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login t = new Login();
            t.Show();
            this.Hide();
            
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users());
        }

        private void btndk_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bangdieukhien());
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void BTNBILL_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.Show();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Books());       
        }
        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btPrint_Click(object sender, EventArgs e)
        {          
            reportBooks rp = new reportBooks();
            rp.ShowDialog();
        }

        private void xuat_Click(object sender, EventArgs e)
        {
            if (dgvBooks.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvBooks.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvBooks.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvBooks.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvBooks.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dgvBooks.Rows[i].Cells[j].Value.ToString();
                    }
                }           
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users());
        }

        private void btnBill_Click_1(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.ShowDialog();
        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                Search_KH(txtTimKiem.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Accer Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
