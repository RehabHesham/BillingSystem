using Bill_system.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bills.UI
{
    public partial class MainForm : Form
    {
        MainForm mainForm;
        public MainForm()
        {
            InitializeComponent();
            mainForm = this;
            //home_img home = new home_img() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //mainForm.pan_content.Controls.Add(home);
            //home.Show();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Form myForm = sender as Form;
            if(myForm != mainForm)
            {
                mainForm.pan_content.Controls.Clear();
                mainForm.pan_content.Controls.Add(myForm);
                myForm.ScrollControlIntoView(label1);
                myForm.Controls[0].Select();
;               myForm.Show();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            //MainForm_Load(new home_img() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }, null);
        }

        private void btn_company_Click(object sender, EventArgs e)
        {
            //MainForm_Load(new companyForm() { Dock = DockStyle.Fill,TopLevel=false,TopMost=true}, null);
        }


        private void btn_type_Click(object sender, EventArgs e)
        {
            //MainForm_Load(new typeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }, null);
        }

        private void btn_unit_Click(object sender, EventArgs e)
        {

        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            MainForm_Load(new ItemForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoScroll = true }, null);
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
           // MainForm_Load(new clients() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoScroll = true }, null);
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
           // MainForm_Load(new invoiceForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoScroll = true }, null);
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
           // MainForm_Load(new Report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoScroll = true }, null);

        }
    }
}
