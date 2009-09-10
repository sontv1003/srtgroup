using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SRT_Project.Views
{
    public partial class HeSoLuong : DevExpress.XtraEditors.XtraUserControl
    {
        public HeSoLuong()
        {
            InitializeComponent();
            layoutControl4.Visible = false;
            layoutControl6.Visible = false;
            layoutControl8.Visible = false;
        }
        private bool testNV = true;
        private void btnNV_Click(object sender, EventArgs e)
        {

            if (testNV == true)
            {
                cbxNV.Enabled = false;

                layoutControl4.Visible = true;
                layoutControl6.Visible = true;
                layoutControl8.Visible = true;
                layoutControl5.Visible = false;
                layoutControl7.Visible = false;

                this.testNV = false;
            }
            else if (testNV == false)
            {
                cbxNV.Enabled = true;
                cbxNL.Enabled = true;
                cbxBL.Enabled = true;

                layoutControl4.Visible = false;
                layoutControl6.Visible = false;
                layoutControl8.Visible = false;
                layoutControl5.Visible = true;
                layoutControl7.Visible = true;

                this.testNV = true;

            }


        }
        private bool testNL = true;
        private void btnNL_Click(object sender, EventArgs e)
        {
            if (testNL == true)
            {
                cbxNL.Enabled = false;

                layoutControl4.Visible = false;
                layoutControl6.Visible = true;
                layoutControl8.Visible = true;

                layoutControl7.Visible = false;

                this.testNL = false;
            }
            else if (testNL == false)
            {
                cbxNL.Enabled = true;
                cbxBL.Enabled = true;

                layoutControl4.Visible = false;
                layoutControl6.Visible = false;
                layoutControl8.Visible = false;

                layoutControl7.Visible = true;

                this.testNL = true;

            }
        }
        private bool testBL = true;
        private void btnBL_Click(object sender, EventArgs e)
        {
            if (testBL == true)
            {
                cbxBL.Enabled = false;

                layoutControl4.Visible = false;
                layoutControl6.Visible = false;
                layoutControl8.Visible = true;

                layoutControl7.Visible = true;

                this.testBL = false;
            }
            else if (testBL == false)
            {
                cbxBL.Enabled = true;

                layoutControl4.Visible = false;
                layoutControl6.Visible = false;
                layoutControl8.Visible = false;

                layoutControl7.Visible = true;

                this.testBL = true;

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           /* if (cbxNV.Enabled == false)
            {
                dgwQLHSL.(txtNNV.Text, txtNNL.Text, txtNBL.Text, txtHSL.Text, cbxTT.Text, txtTNV.Text, txtTNL.Text, txtTBL.Text);
            }
            if (cbxNL.Enabled == false)
            {
                dgwQLHSL(cbxNV.Text, txtNNL.Text, txtNBL.Text, txtHSL.Text, cbxTT.Text, " ", txtTNL.Text, txtTBL.Text);
            }
            if (cbxBL.Enabled == false)
            {
                dgwQLHSL(cbxNV.Text, cbxNL.Text, txtNBL.Text, txtHSL.Text, cbxTT.Text, " ", " ", txtTBL.Text);
            }
            else if (cbxNV.Enabled == true && cbxNL.Enabled == true && cbxBL.Enabled == true)
            {
                dgwQLHSL(cbxNV.Text, cbxNL.Text, cbxBL.Text, txtHSL.Text, cbxTT.Text, "", "", "");
            }*/
        }
    }
}