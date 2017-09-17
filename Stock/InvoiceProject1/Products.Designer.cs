namespace InvoiceProject1
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.productcodetextBox1 = new System.Windows.Forms.TextBox();
            this.productnametextBox2 = new System.Windows.Forms.TextBox();
            this.productdeletebutton1 = new System.Windows.Forms.Button();
            this.productaddbutton2 = new System.Windows.Forms.Button();
            this.productcodelabel = new System.Windows.Forms.Label();
            this.Productnamelabel = new System.Windows.Forms.Label();
            this.Statuslabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1status = new System.Windows.Forms.ComboBox();
            this.toolTip1_info = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // productcodetextBox1
            // 
            this.productcodetextBox1.Location = new System.Drawing.Point(25, 60);
            this.productcodetextBox1.Name = "productcodetextBox1";
            this.productcodetextBox1.Size = new System.Drawing.Size(103, 20);
            this.productcodetextBox1.TabIndex = 0;
            // 
            // productnametextBox2
            // 
            this.productnametextBox2.Location = new System.Drawing.Point(134, 60);
            this.productnametextBox2.Name = "productnametextBox2";
            this.productnametextBox2.Size = new System.Drawing.Size(259, 20);
            this.productnametextBox2.TabIndex = 1;
            // 
            // productdeletebutton1
            // 
            this.productdeletebutton1.Location = new System.Drawing.Point(539, 58);
            this.productdeletebutton1.Name = "productdeletebutton1";
            this.productdeletebutton1.Size = new System.Drawing.Size(75, 23);
            this.productdeletebutton1.TabIndex = 5;
            this.productdeletebutton1.Text = "Delete";
            this.toolTip1_info.SetToolTip(this.productdeletebutton1, resources.GetString("productdeletebutton1.ToolTip"));
            this.productdeletebutton1.UseVisualStyleBackColor = true;
            this.productdeletebutton1.Click += new System.EventHandler(this.productdeletebutton1_Click);
            // 
            // productaddbutton2
            // 
            this.productaddbutton2.Location = new System.Drawing.Point(620, 58);
            this.productaddbutton2.Name = "productaddbutton2";
            this.productaddbutton2.Size = new System.Drawing.Size(75, 23);
            this.productaddbutton2.TabIndex = 4;
            this.productaddbutton2.Text = "Add/Update";
            this.toolTip1_info.SetToolTip(this.productaddbutton2, resources.GetString("productaddbutton2.ToolTip"));
            this.productaddbutton2.UseVisualStyleBackColor = true;
            this.productaddbutton2.Click += new System.EventHandler(this.productaddbutton2_Click);
            // 
            // productcodelabel
            // 
            this.productcodelabel.AutoSize = true;
            this.productcodelabel.Location = new System.Drawing.Point(22, 44);
            this.productcodelabel.Name = "productcodelabel";
            this.productcodelabel.Size = new System.Drawing.Size(72, 13);
            this.productcodelabel.TabIndex = 5;
            this.productcodelabel.Text = "Product Code";
            // 
            // Productnamelabel
            // 
            this.Productnamelabel.AutoSize = true;
            this.Productnamelabel.Location = new System.Drawing.Point(131, 44);
            this.Productnamelabel.Name = "Productnamelabel";
            this.Productnamelabel.Size = new System.Drawing.Size(75, 13);
            this.Productnamelabel.TabIndex = 6;
            this.Productnamelabel.Text = "Product Name";
            // 
            // Statuslabel
            // 
            this.Statuslabel.AutoSize = true;
            this.Statuslabel.Location = new System.Drawing.Point(396, 44);
            this.Statuslabel.Name = "Statuslabel";
            this.Statuslabel.Size = new System.Drawing.Size(37, 13);
            this.Statuslabel.TabIndex = 7;
            this.Statuslabel.Text = "Status";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(25, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(670, 273);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            // 
            // comboBox1status
            // 
            this.comboBox1status.FormattingEnabled = true;
            this.comboBox1status.Items.AddRange(new object[] {
            "Activate",
            "Deactivate"});
            this.comboBox1status.Location = new System.Drawing.Point(399, 58);
            this.comboBox1status.Name = "comboBox1status";
            this.comboBox1status.Size = new System.Drawing.Size(134, 21);
            this.comboBox1status.TabIndex = 10;
            this.comboBox1status.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // toolTip1_info
            // 
            this.toolTip1_info.AutomaticDelay = 400;
            this.toolTip1_info.AutoPopDelay = 40000;
            this.toolTip1_info.InitialDelay = 400;
            this.toolTip1_info.ReshowDelay = 80;
            this.toolTip1_info.ShowAlways = true;
            this.toolTip1_info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 387);
            this.Controls.Add(this.comboBox1status);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Statuslabel);
            this.Controls.Add(this.Productnamelabel);
            this.Controls.Add(this.productcodelabel);
            this.Controls.Add(this.productaddbutton2);
            this.Controls.Add(this.productdeletebutton1);
            this.Controls.Add(this.productnametextBox2);
            this.Controls.Add(this.productcodetextBox1);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productcodetextBox1;
        private System.Windows.Forms.TextBox productnametextBox2;
        private System.Windows.Forms.Button productdeletebutton1;
        private System.Windows.Forms.Button productaddbutton2;
        private System.Windows.Forms.Label productcodelabel;
        private System.Windows.Forms.Label Productnamelabel;
        private System.Windows.Forms.Label Statuslabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox comboBox1status;
        private System.Windows.Forms.ToolTip toolTip1_info;
    }
}