using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yilan2
{
    public partial class frm_snakegame : Form
    {
        public frm_snakegame()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            frm_snakegame frm = new frm_snakegame();
            frm.ShowDialog();
            
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }
    }
}
