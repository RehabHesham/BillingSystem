using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bill_system.DB;
using System.ComponentModel.DataAnnotations;
namespace Bill_system.UI
{
    public partial class ItemForm : Form
    {
        Bill db;
        public ItemForm()
        {
            db = new Bill();
            InitializeComponent();
            loadCompanyName();
            loadUnitName();
        }
        private void loadCompanyName()
        {
            cb_itemcompanyname.DataSource = db.Companies.ToList();
            cb_itemcompanyname.DisplayMember = "company_name";
            cb_itemcompanyname.ValueMember = "compan_id";

        }

        private void loadTypeName()
        {
            cb_itemtypename.DataSource = db.Types.Where(type => type.company_id == (int)cb_itemcompanyname.SelectedValue).ToList();
            cb_itemtypename.DisplayMember = "typ_name";
            cb_itemtypename.ValueMember = "typ_id";

        }
        private void loadUnitName()
        {
            cb_itemtunitname.DataSource = db.Units.ToList();
            cb_itemtunitname.DisplayMember = "unt_name";
            cb_itemtunitname.ValueMember = "unt_id";

        }

        public void clearAllTexts()
        {
            txt_itemname.Text = "";
            rtxt_itemnotes.Text = "";
            nud_itembuyingprice.Value = 0;
            nud_itemsellingprice.Value = 0;
            cb_itemcompanyname.SelectedIndex = 0;
            cb_itemtunitname.SelectedIndex = 0;
            cb_itemtypename.SelectedIndex = 0;
        }

        private void cb_itemcompanyname_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTypeName();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clearAllTexts();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Item item = new Item()
            {
                item_name = txt_itemname.Text,
                item_notes = rtxt_itemnotes.Text,
                buy_price = nud_itemsellingprice.Value,
                sell_price = nud_itembuyingprice.Value,
                //company_id = (int)cb_itemcompanyname.SelectedValue,
                unit_id = (int)cb_itemtunitname.SelectedValue,
                type_id = (int)cb_itemtypename.SelectedValue,
            };
            var context = new ValidationContext(item, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(item, context, validationResults, true);
            MessageBox.Show($"{isValid}");
        }
    }
}
