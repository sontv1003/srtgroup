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
    public partial class DienBienLuong : DevExpress.XtraEditors.XtraUserControl
    {
        public DienBienLuong()
        {
            InitializeComponent();
            comboBoxEdit4.Enabled = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TimKiem tk = new TimKiem();
            tk.Show();
        }
    }
}
