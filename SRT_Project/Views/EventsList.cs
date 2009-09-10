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
    public partial class EventsList : DevExpress.XtraEditors.XtraUserControl
    {
        public EventsList()
        {
            InitializeComponent();
            try
            {
                this.suKienTableAdapter.Fill(this.sRTDataDataSet1.SuKien);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            NewEvents ne = new NewEvents();
            ne.Show();
        }

        public void showSearch(bool showMe)
        {
            if (showMe)
                layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }


    }
}
