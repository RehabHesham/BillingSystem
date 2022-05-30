namespace Bill_system.UI
{
    partial class ItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_itemtunitname = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_itembuyingprice = new System.Windows.Forms.NumericUpDown();
            this.nud_itemsellingprice = new System.Windows.Forms.NumericUpDown();
            this.label_error = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.rtxt_itemnotes = new System.Windows.Forms.RichTextBox();
            this.txt_itemname = new System.Windows.Forms.TextBox();
            this.cb_itemtypename = new System.Windows.Forms.ComboBox();
            this.cb_itemcompanyname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_itembuyingprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_itemsellingprice)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_itemtunitname
            // 
            this.cb_itemtunitname.FormattingEnabled = true;
            this.cb_itemtunitname.Location = new System.Drawing.Point(219, 147);
            this.cb_itemtunitname.Margin = new System.Windows.Forms.Padding(2);
            this.cb_itemtunitname.Name = "cb_itemtunitname";
            this.cb_itemtunitname.Size = new System.Drawing.Size(312, 21);
            this.cb_itemtunitname.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "Unti Name :";
            // 
            // nud_itembuyingprice
            // 
            this.nud_itembuyingprice.DecimalPlaces = 3;
            this.nud_itembuyingprice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_itembuyingprice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nud_itembuyingprice.Location = new System.Drawing.Point(219, 284);
            this.nud_itembuyingprice.Margin = new System.Windows.Forms.Padding(0);
            this.nud_itembuyingprice.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_itembuyingprice.Name = "nud_itembuyingprice";
            this.nud_itembuyingprice.Size = new System.Drawing.Size(311, 27);
            this.nud_itembuyingprice.TabIndex = 36;
            // 
            // nud_itemsellingprice
            // 
            this.nud_itemsellingprice.DecimalPlaces = 3;
            this.nud_itemsellingprice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_itemsellingprice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nud_itemsellingprice.Location = new System.Drawing.Point(219, 243);
            this.nud_itemsellingprice.Margin = new System.Windows.Forms.Padding(2);
            this.nud_itemsellingprice.Name = "nud_itemsellingprice";
            this.nud_itemsellingprice.Size = new System.Drawing.Size(311, 27);
            this.nud_itemsellingprice.TabIndex = 35;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(374, 402);
            this.label_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 13);
            this.label_error.TabIndex = 34;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Location = new System.Drawing.Point(219, 454);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(113, 40);
            this.btn_cancel.TabIndex = 33;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Location = new System.Drawing.Point(432, 454);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(87, 40);
            this.btn_save.TabIndex = 32;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // rtxt_itemnotes
            // 
            this.rtxt_itemnotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_itemnotes.Location = new System.Drawing.Point(221, 331);
            this.rtxt_itemnotes.Name = "rtxt_itemnotes";
            this.rtxt_itemnotes.Size = new System.Drawing.Size(312, 104);
            this.rtxt_itemnotes.TabIndex = 31;
            this.rtxt_itemnotes.Text = "";
            // 
            // txt_itemname
            // 
            this.txt_itemname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_itemname.Location = new System.Drawing.Point(219, 191);
            this.txt_itemname.Name = "txt_itemname";
            this.txt_itemname.Size = new System.Drawing.Size(312, 27);
            this.txt_itemname.TabIndex = 30;
            // 
            // cb_itemtypename
            // 
            this.cb_itemtypename.FormattingEnabled = true;
            this.cb_itemtypename.Location = new System.Drawing.Point(219, 94);
            this.cb_itemtypename.Margin = new System.Windows.Forms.Padding(2);
            this.cb_itemtypename.Name = "cb_itemtypename";
            this.cb_itemtypename.Size = new System.Drawing.Size(312, 21);
            this.cb_itemtypename.TabIndex = 29;
            // 
            // cb_itemcompanyname
            // 
            this.cb_itemcompanyname.FormattingEnabled = true;
            this.cb_itemcompanyname.Location = new System.Drawing.Point(221, 41);
            this.cb_itemcompanyname.Margin = new System.Windows.Forms.Padding(2);
            this.cb_itemcompanyname.Name = "cb_itemcompanyname";
            this.cb_itemcompanyname.Size = new System.Drawing.Size(310, 21);
            this.cb_itemcompanyname.TabIndex = 28;
            this.cb_itemcompanyname.SelectedIndexChanged += new System.EventHandler(this.cb_itemcompanyname_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Notes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Buying Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Selling Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Item Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Type Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Company Name :";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 555);
            this.Controls.Add(this.cb_itemtunitname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nud_itembuyingprice);
            this.Controls.Add(this.nud_itemsellingprice);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.rtxt_itemnotes);
            this.Controls.Add(this.txt_itemname);
            this.Controls.Add(this.cb_itemtypename);
            this.Controls.Add(this.cb_itemcompanyname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            ((System.ComponentModel.ISupportInitialize)(this.nud_itembuyingprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_itemsellingprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_itemtunitname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_itembuyingprice;
        private System.Windows.Forms.NumericUpDown nud_itemsellingprice;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.RichTextBox rtxt_itemnotes;
        private System.Windows.Forms.TextBox txt_itemname;
        private System.Windows.Forms.ComboBox cb_itemtypename;
        private System.Windows.Forms.ComboBox cb_itemcompanyname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}