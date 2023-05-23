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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-48I6O9GG\NTASPORT;Initial Catalog=BOOKSHOPDB;Integrated Security=True");
        private void Users_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM UserTb1";
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            SqlCommandBuilder bui = new SqlCommandBuilder(ad);
            var ds = new DataSet();
            ad.Fill(ds);
            dgvUser.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (txtUser.Text == "" || txtPhone.Text == "" || txtDiachi.Text == "" || txtMK.Text == "")
            //{
            //    MessageBox.Show("Chua co thong tin");
            //}
            //else
            //{
            //    try
            //    {
            //        conn.Open();
            //        string query = "INSERT INTO UserTb1 VALUES('" + txtUser.Text + "', '" + txtPhone.Text + "','" + txtDiachi.Text + "','" + txtMK.Text + "')";
            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Luu thanh cong");
            //        conn.Close();
            //        Users_Load(sender, e);


            //    }
            //    catch (Exception Ex)
            //    {
            //        MessageBox.Show(Ex.Message);
            //    }
            //}
            SaveBook(txtUser.Text, txtPhone.Text,  txtDiachi.Text, txtMK.Text);

        }
        public string MessageBoxMessage { get; set; }

        public void SaveBook(string txtUser, string txtPhone, string txtDiachi,  string txtMK)
        {
            if (string.IsNullOrEmpty(txtUser) || string.IsNullOrEmpty(txtPhone)  || string.IsNullOrEmpty(txtDiachi) || string.IsNullOrEmpty(txtMK))
            {
                MessageBox.Show("Chua co thong tin");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO UserTb1 VALUES('" + txtUser + "', '" + txtPhone + "', '" + txtDiachi + "','" + txtMK + "')";
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

        int key = 0;
        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUser.Text = dgvUser.SelectedRows[0].Cells[1].Value.ToString();
            txtPhone.Text = dgvUser.SelectedRows[0].Cells[2].Value.ToString();
            txtDiachi.Text = dgvUser.SelectedRows[0].Cells[3].Value.ToString();
            txtMK.Text = dgvUser.SelectedRows[0].Cells[4].Value.ToString();
            if (txtUser.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvUser.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtUser.Text == "" || txtPhone.Text == "" || txtDiachi.Text == "" )
            {
                MessageBox.Show("Chua co thong tin");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE UserTb1 SET Uname = '" + txtUser.Text + "',Uphone = '" + txtPhone.Text + "', UAdd = '" + txtDiachi.Text + "',UPass = '" + txtMK.Text + "' where UId = " + key + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cap nhat thanh cong");
                    conn.Close();
                    Users_Load(sender, e);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtUser.Text == "" || txtPhone.Text == "" || txtDiachi.Text == "")
            {
                MessageBox.Show("Chua co thong tin");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "delete from UserTb1 where UId = " + key + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xoa thanh cong");
                    conn.Close();
                    Users_Load(sender, e);


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }



        public bool Search_KH(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                MessageBox.Show("Nhập thông tin tìm kiếm");
                return false;
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM UserTb1 WHERE UId = @UserId OR Uname = @UserName";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Kiểm tra xem giá trị có phải là kiểu int hay không
                    int userId;
                    if (int.TryParse(a, out userId))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@UserName", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@UserId", DBNull.Value);
                        cmd.Parameters.AddWithValue("@UserName", a);
                    }

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgvUser.DataSource = dt;
                    conn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPhone.Text = "";
            txtDiachi.Text = "";
            txtMK.Text = "";
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login ob = new Login();
            ob.Show();
            ob.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
    
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            if (dgvUser.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvUser.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dgvUser.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvUser.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvUser.Columns.Count; j++)
                    {
                        XcelApp.Cells[i + 2, j + 1] = dgvUser.Rows[i].Cells[j].Value.ToString();
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            reportUsers t = new reportUsers();
            t.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
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