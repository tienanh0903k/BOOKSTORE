﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;


namespace BOOKSTORE
{
    public partial class reportUsers : Form
    {
        public reportUsers()
        {
            InitializeComponent();
        }

        private void reportUsers_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-48I6O9GG\NTASPORT;Initial Catalog=BOOKSHOPDB;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM UserTb1", conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1_Report", dt);
            reportViewer1.LocalReport.ReportPath = @"D:\Winform C#\Bookstore\BOOKSTORE\BOOKSTORE\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
