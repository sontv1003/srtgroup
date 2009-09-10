using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SRT_Project.Views;

namespace SRT_Project
{
    public partial class frmMain : Form
    {
        EventsList el = new EventsList();
        bool showSearch = false;
        QuyetDinh qd = new QuyetDinh();
        public frmMain()
        {
            InitializeComponent();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            //EventsList el = new EventsList();
            el.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(el);
            btnSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            HeSoLuong hsl = new HeSoLuong(); 
            hsl.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(hsl);
            btnSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            EmpsList eL = new EmpsList();
            eL.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(eL);
            btnSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            ChinhSach cs = new ChinhSach();
            cs.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(cs);
            btnSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            SubHistList sHL = new SubHistList();
            sHL.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(sHL);
            btnSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            SubList sL = new SubList();
            sL.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(sL);
            btnSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }
        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            DienBienLuong dbl = new DienBienLuong();
            dbl.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(dbl);
            btnSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }


        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            qd.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(qd);
            btnSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }

        private void btnSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!showSearch)
            {
                showSearch = true;
                el.showSearch(showSearch);
            }
            else
            {
                showSearch = false;
                el.showSearch(showSearch);
            }
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            CerOfEmpList cOE = new CerOfEmpList();
            cOE.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(cOE);
            btnSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            FamList fL = new FamList();
            fL.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(fL);
            btnSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            JobList jL = new JobList();
            jL.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(jL);
            btnSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            EmpHistList eHL = new EmpHistList();
            eHL.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(eHL);
            btnSearch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }
        

        
    }
}
