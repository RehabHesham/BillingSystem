namespace Bills.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pan_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_aside = new System.Windows.Forms.Panel();
            this.pan_content = new System.Windows.Forms.Panel();
            this.btn_sales = new System.Windows.Forms.Button();
            this.btn_invoice = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.btn_item = new System.Windows.Forms.Button();
            this.btn_unit = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_type = new System.Windows.Forms.Button();
            this.btn_company = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pan_header.SuspendLayout();
            this.pan_aside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_header
            // 
            this.pan_header.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pan_header.Controls.Add(this.label1);
            this.pan_header.Controls.Add(this.pictureBox1);
            this.pan_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_header.Location = new System.Drawing.Point(0, 0);
            this.pan_header.Name = "pan_header";
            this.pan_header.Size = new System.Drawing.Size(800, 46);
            this.pan_header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Univers 55", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "BILL SYSTEM";
            // 
            // pan_aside
            // 
            this.pan_aside.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pan_aside.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_aside.Controls.Add(this.btn_sales);
            this.pan_aside.Controls.Add(this.btn_invoice);
            this.pan_aside.Controls.Add(this.btn_client);
            this.pan_aside.Controls.Add(this.btn_item);
            this.pan_aside.Controls.Add(this.btn_unit);
            this.pan_aside.Controls.Add(this.btn_home);
            this.pan_aside.Controls.Add(this.btn_type);
            this.pan_aside.Controls.Add(this.btn_company);
            this.pan_aside.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_aside.Location = new System.Drawing.Point(0, 46);
            this.pan_aside.Name = "pan_aside";
            this.pan_aside.Size = new System.Drawing.Size(215, 404);
            this.pan_aside.TabIndex = 1;
            // 
            // pan_content
            // 
            this.pan_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_content.Location = new System.Drawing.Point(215, 46);
            this.pan_content.Margin = new System.Windows.Forms.Padding(0);
            this.pan_content.Name = "pan_content";
            this.pan_content.Size = new System.Drawing.Size(585, 404);
            this.pan_content.TabIndex = 2;
            // 
            // btn_sales
            // 
            this.btn_sales.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_sales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sales.FlatAppearance.BorderSize = 0;
            this.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sales.Font = new System.Drawing.Font("Univers 55", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_sales.Location = new System.Drawing.Point(17, 342);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(181, 38);
            this.btn_sales.TabIndex = 7;
            this.btn_sales.UseVisualStyleBackColor = false;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_invoice
            // 
            this.btn_invoice.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_invoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_invoice.FlatAppearance.BorderSize = 0;
            this.btn_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_invoice.Font = new System.Drawing.Font("Univers 55", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_invoice.Location = new System.Drawing.Point(17, 298);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(181, 38);
            this.btn_invoice.TabIndex = 6;
            this.btn_invoice.UseVisualStyleBackColor = false;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // btn_client
            // 
            this.btn_client.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_client.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_client.FlatAppearance.BorderSize = 0;
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_client.Font = new System.Drawing.Font("Univers 55", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_client.Location = new System.Drawing.Point(17, 254);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(181, 38);
            this.btn_client.TabIndex = 5;
            this.btn_client.UseVisualStyleBackColor = false;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // btn_item
            // 
            this.btn_item.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_item.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_item.FlatAppearance.BorderSize = 0;
            this.btn_item.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_item.Font = new System.Drawing.Font("Univers 55", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_item.Location = new System.Drawing.Point(17, 210);
            this.btn_item.Name = "btn_item";
            this.btn_item.Size = new System.Drawing.Size(181, 38);
            this.btn_item.TabIndex = 4;
            this.btn_item.UseVisualStyleBackColor = false;
            this.btn_item.Click += new System.EventHandler(this.btn_item_Click);
            // 
            // btn_unit
            // 
            this.btn_unit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_unit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_unit.FlatAppearance.BorderSize = 0;
            this.btn_unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_unit.Font = new System.Drawing.Font("Univers 55", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_unit.Location = new System.Drawing.Point(17, 166);
            this.btn_unit.Name = "btn_unit";
            this.btn_unit.Size = new System.Drawing.Size(181, 38);
            this.btn_unit.TabIndex = 3;
            this.btn_unit.UseVisualStyleBackColor = false;
            this.btn_unit.Click += new System.EventHandler(this.btn_unit_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_home.Font = new System.Drawing.Font("Univers 55", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_home.Location = new System.Drawing.Point(17, 20);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(181, 39);
            this.btn_home.TabIndex = 0;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_type
            // 
            this.btn_type.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_type.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_type.FlatAppearance.BorderSize = 0;
            this.btn_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_type.Font = new System.Drawing.Font("Univers 55", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_type.Location = new System.Drawing.Point(17, 122);
            this.btn_type.Name = "btn_type";
            this.btn_type.Size = new System.Drawing.Size(181, 38);
            this.btn_type.TabIndex = 2;
            this.btn_type.UseVisualStyleBackColor = false;
            this.btn_type.Click += new System.EventHandler(this.btn_type_Click);
            // 
            // btn_company
            // 
            this.btn_company.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_company.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_company.FlatAppearance.BorderSize = 0;
            this.btn_company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_company.Font = new System.Drawing.Font("Univers 55", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_company.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_company.Location = new System.Drawing.Point(17, 79);
            this.btn_company.Margin = new System.Windows.Forms.Padding(0);
            this.btn_company.Name = "btn_company";
            this.btn_company.Size = new System.Drawing.Size(181, 38);
            this.btn_company.TabIndex = 1;
            this.btn_company.UseVisualStyleBackColor = false;
            this.btn_company.Click += new System.EventHandler(this.btn_company_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pan_content);
            this.Controls.Add(this.pan_aside);
            this.Controls.Add(this.pan_header);
            this.Font = new System.Drawing.Font("Univers 55", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pan_header.ResumeLayout(false);
            this.pan_header.PerformLayout();
            this.pan_aside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan_aside;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_type;
        private System.Windows.Forms.Button btn_company;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Button btn_invoice;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Button btn_item;
        private System.Windows.Forms.Button btn_unit;
        private System.Windows.Forms.Panel pan_content;
    }
}