namespace BOOKSTORE
{
    partial class Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1_left = new System.Windows.Forms.Panel();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btndk = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_body = new System.Windows.Forms.Panel();
            this.xuat = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvBooks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtCL = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.refesh = new System.Windows.Forms.Button();
            this.cbListFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.txtTG = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.panel1_left.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_left
            // 
            this.panel1_left.BackColor = System.Drawing.Color.Black;
            this.panel1_left.Controls.Add(this.btnBill);
            this.panel1_left.Controls.Add(this.btnlogout);
            this.panel1_left.Controls.Add(this.btndk);
            this.panel1_left.Controls.Add(this.btnuser);
            this.panel1_left.Controls.Add(this.btnhome);
            this.panel1_left.Controls.Add(this.panel3);
            this.panel1_left.Location = new System.Drawing.Point(12, 12);
            this.panel1_left.Name = "panel1_left";
            this.panel1_left.Size = new System.Drawing.Size(223, 813);
            this.panel1_left.TabIndex = 1;
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(3, 459);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(221, 46);
            this.btnBill.TabIndex = 5;
            this.btnBill.Text = "BILL";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click_1);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(-12, 539);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(250, 60);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "LOG OUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btndk
            // 
            this.btndk.BackColor = System.Drawing.Color.Black;
            this.btndk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndk.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btndk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndk.Image = ((System.Drawing.Image)(resources.GetObject("btndk.Image")));
            this.btndk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndk.Location = new System.Drawing.Point(-1, 361);
            this.btndk.Name = "btndk";
            this.btndk.Size = new System.Drawing.Size(248, 63);
            this.btndk.TabIndex = 3;
            this.btndk.Text = "DASHBOARD";
            this.btndk.UseVisualStyleBackColor = false;
            this.btndk.Click += new System.EventHandler(this.btndk_Click);
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.Color.Black;
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnuser.Image = ((System.Drawing.Image)(resources.GetObject("btnuser.Image")));
            this.btnuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.Location = new System.Drawing.Point(-1, 280);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(224, 59);
            this.btnuser.TabIndex = 2;
            this.btnuser.Text = "USERS";
            this.btnuser.UseVisualStyleBackColor = false;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Montserrat", 10F);
            this.btnhome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhome.Image = global::BOOKSTORE.Properties.Resources.icons8_book_64;
            this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhome.Location = new System.Drawing.Point(-15, 177);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(262, 66);
            this.btnhome.TabIndex = 1;
            this.btnhome.Text = "BOOKS";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 105);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BOOKSTORE.Properties.Resources.Minlogo;
            this.pictureBox2.Location = new System.Drawing.Point(75, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(44, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "BOOK SHOP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MistyRose;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1297, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.White;
            this.panel_body.Controls.Add(this.btnTimkiem);
            this.panel_body.Controls.Add(this.txtTimKiem);
            this.panel_body.Controls.Add(this.xuat);
            this.panel_body.Controls.Add(this.label10);
            this.panel_body.Controls.Add(this.btPrint);
            this.panel_body.Controls.Add(this.label8);
            this.panel_body.Controls.Add(this.dgvBooks);
            this.panel_body.Controls.Add(this.txtTenSach);
            this.panel_body.Controls.Add(this.txtCL);
            this.panel_body.Controls.Add(this.txtGia);
            this.panel_body.Controls.Add(this.btnXoa);
            this.panel_body.Controls.Add(this.btnReset);
            this.panel_body.Controls.Add(this.label7);
            this.panel_body.Controls.Add(this.refesh);
            this.panel_body.Controls.Add(this.cbListFilter);
            this.panel_body.Controls.Add(this.label6);
            this.panel_body.Controls.Add(this.label3);
            this.panel_body.Controls.Add(this.btnEdit);
            this.panel_body.Controls.Add(this.label1);
            this.panel_body.Controls.Add(this.btnSave);
            this.panel_body.Controls.Add(this.label4);
            this.panel_body.Controls.Add(this.label2);
            this.panel_body.Controls.Add(this.cbTheLoai);
            this.panel_body.Controls.Add(this.txtTG);
            this.panel_body.Location = new System.Drawing.Point(241, 11);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1320, 814);
            this.panel_body.TabIndex = 21;
            this.panel_body.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_body_Paint);
            // 
            // xuat
            // 
            this.xuat.Font = new System.Drawing.Font("Montserrat", 11F);
            this.xuat.Location = new System.Drawing.Point(818, 161);
            this.xuat.Name = "xuat";
            this.xuat.Size = new System.Drawing.Size(162, 37);
            this.xuat.TabIndex = 20;
            this.xuat.Text = "Xuat EXCEL";
            this.xuat.UseVisualStyleBackColor = true;
            this.xuat.Click += new System.EventHandler(this.xuat_Click);
            // 
            // btPrint
            // 
            this.btPrint.BackColor = System.Drawing.Color.Silver;
            this.btPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPrint.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.ForeColor = System.Drawing.SystemColors.Info;
            this.btPrint.Location = new System.Drawing.Point(688, 161);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(101, 36);
            this.btPrint.TabIndex = 19;
            this.btPrint.Text = "In an";
            this.btPrint.UseVisualStyleBackColor = false;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SlateBlue;
            this.label8.Location = new System.Drawing.Point(24, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "BANG DAU SACH";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBooks.ColumnHeadersHeight = 25;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBooks.Location = new System.Drawing.Point(-2, 313);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(1);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.RowHeadersWidth = 62;
            this.dgvBooks.RowTemplate.Height = 28;
            this.dgvBooks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBooks.Size = new System.Drawing.Size(1311, 500);
            this.dgvBooks.TabIndex = 16;
            this.dgvBooks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBooks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBooks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBooks.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBooks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBooks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBooks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBooks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBooks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBooks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBooks.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvBooks.ThemeStyle.ReadOnly = true;
            this.dgvBooks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBooks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBooks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBooks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.LimeGreen;
            this.dgvBooks.ThemeStyle.RowsStyle.Height = 28;
            this.dgvBooks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBooks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "BID";
            this.Column1.FillWeight = 27.75231F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BTitle";
            this.Column2.FillWeight = 58.71803F;
            this.Column2.HeaderText = "Tên sách";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BTACGIA";
            this.Column3.FillWeight = 130.4281F;
            this.Column3.HeaderText = "Tác giả";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "BTHELOAI";
            this.Column4.FillWeight = 89.41873F;
            this.Column4.HeaderText = "Thể loại";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "BCL";
            this.Column5.FillWeight = 123.2284F;
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "BGIA";
            this.Column6.FillWeight = 170.4546F;
            this.Column6.HeaderText = "Giá";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSach.Location = new System.Drawing.Point(20, 83);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(254, 32);
            this.txtTenSach.TabIndex = 4;
            // 
            // txtCL
            // 
            this.txtCL.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtCL.Location = new System.Drawing.Point(755, 83);
            this.txtCL.Name = "txtCL";
            this.txtCL.Size = new System.Drawing.Size(254, 32);
            this.txtCL.TabIndex = 10;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtGia.Location = new System.Drawing.Point(549, 83);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(151, 32);
            this.txtGia.TabIndex = 12;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.Info;
            this.btnXoa.Location = new System.Drawing.Point(417, 161);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 37);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "XOA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Info;
            this.btnReset.Location = new System.Drawing.Point(549, 160);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 37);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(545, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "GIA";
            // 
            // refesh
            // 
            this.refesh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refesh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refesh.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refesh.ForeColor = System.Drawing.SystemColors.Info;
            this.refesh.Location = new System.Drawing.Point(637, 248);
            this.refesh.Name = "refesh";
            this.refesh.Size = new System.Drawing.Size(131, 36);
            this.refesh.TabIndex = 15;
            this.refesh.Text = "REFRESH";
            this.refesh.UseVisualStyleBackColor = false;
            this.refesh.Click += new System.EventHandler(this.refesh_Click);
            // 
            // cbListFilter
            // 
            this.cbListFilter.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListFilter.FormattingEnabled = true;
            this.cbListFilter.Items.AddRange(new object[] {
            "Giao duc",
            "CNTT",
            "Khoa hoc",
            "Tam ly",
            "Truyen Cuoi"});
            this.cbListFilter.Location = new System.Drawing.Point(379, 248);
            this.cbListFilter.Name = "cbListFilter";
            this.cbListFilter.Size = new System.Drawing.Size(246, 36);
            this.cbListFilter.TabIndex = 11;
            this.cbListFilter.Text = "    ------Loc the loai-------------";
            this.cbListFilter.SelectionChangeCommitted += new System.EventHandler(this.cbListFilter_SelectionChangeCommitted_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(747, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "SO LUONG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(611, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "BOOKS";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEdit.Location = new System.Drawing.Point(294, 161);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 37);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "SUA";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "TEN SACH";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSave.Location = new System.Drawing.Point(151, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 37);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1043, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "THE LOAI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(306, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "TAC GIA";
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.Font = new System.Drawing.Font("Ebrima", 10F);
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Items.AddRange(new object[] {
            "Giao duc",
            "CNTT",
            "Khoa hoc",
            "Tam ly",
            "Truyen Cuoi"});
            this.cbTheLoai.Location = new System.Drawing.Point(1040, 83);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(254, 36);
            this.cbTheLoai.TabIndex = 9;
            this.cbTheLoai.Text = "    ----CHON THE LOAI---";
            // 
            // txtTG
            // 
            this.txtTG.Font = new System.Drawing.Font("Montserrat", 10F);
            this.txtTG.Location = new System.Drawing.Point(310, 83);
            this.txtTG.Name = "txtTG";
            this.txtTG.Size = new System.Drawing.Size(184, 32);
            this.txtTG.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(818, 245);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(117, 26);
            this.txtTimKiem.TabIndex = 22;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(941, 245);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 30);
            this.btnTimkiem.TabIndex = 23;
            this.btnTimkiem.Text = "button1";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1573, 837);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel1_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Books";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1_left.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_left;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btndk;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Button xuat;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtCL;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button refesh;
        private System.Windows.Forms.ComboBox cbListFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.TextBox txtTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}

