using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btvn_week3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem(txtLastname.Text);
            lv1.SubItems.Add(txtFirstname.Text);
            lv1.SubItems.Add(txtPhone.Text);
            lsvNV.Items.Add(lv1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lsvNV.SelectedItems.Count > 0)
            {
                lsvNV.Items.RemoveAt(lsvNV.SelectedItems[0].Index);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ListViewItem listviewItem = lsvNV.SelectedItems[0];
            listviewItem.SubItems[0].Text = txtLastname.Text;
            listviewItem.SubItems[1].Text = txtFirstname.Text;
            listviewItem.SubItems[2].Text = txtPhone.Text;
        }
    }
}
