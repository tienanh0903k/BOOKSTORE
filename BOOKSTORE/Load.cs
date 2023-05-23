using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOOKSTORE
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }
        int startpos = 0;
        

        private void Load_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            startpos += 1;
            progressBar.Value = startpos;
            phantram.Text = startpos + "%";
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }
    }
}
