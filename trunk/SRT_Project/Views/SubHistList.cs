using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SRT_Project.Forms;

namespace SRT_Project.Views
{
    public partial class SubHistList : DevExpress.XtraEditors.XtraUserControl
    {
        public SubHistList()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NewSubHist nSH = new NewSubHist();
            nSH.Show();
        }
    }
}
