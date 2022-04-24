namespace Easy_Mart
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vegetablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beverageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnexit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnupfood = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "BEVERAGE INVENTORY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(544, 252);
            this.dataGridView1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.inventoryReportToolStripMenuItem,
            this.purchasesToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // inventoryReportToolStripMenuItem
            // 
            this.inventoryReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodToolStripMenuItem,
            this.vegetablesToolStripMenuItem,
            this.beverageToolStripMenuItem});
            this.inventoryReportToolStripMenuItem.Name = "inventoryReportToolStripMenuItem";
            this.inventoryReportToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.inventoryReportToolStripMenuItem.Text = "Inventory Report";
            this.inventoryReportToolStripMenuItem.Click += new System.EventHandler(this.inventoryReportToolStripMenuItem_Click);
            // 
            // foodToolStripMenuItem
            // 
            this.foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            this.foodToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.foodToolStripMenuItem.Text = "Food";
            this.foodToolStripMenuItem.Click += new System.EventHandler(this.foodToolStripMenuItem_Click);
            // 
            // vegetablesToolStripMenuItem
            // 
            this.vegetablesToolStripMenuItem.Name = "vegetablesToolStripMenuItem";
            this.vegetablesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.vegetablesToolStripMenuItem.Text = "Vegetables";
            this.vegetablesToolStripMenuItem.Click += new System.EventHandler(this.vegetablesToolStripMenuItem_Click);
            // 
            // beverageToolStripMenuItem
            // 
            this.beverageToolStripMenuItem.Name = "beverageToolStripMenuItem";
            this.beverageToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.beverageToolStripMenuItem.Text = "Beverage";
            this.beverageToolStripMenuItem.Click += new System.EventHandler(this.beverageToolStripMenuItem_Click);
            // 
            // purchasesToolStripMenuItem
            // 
            this.purchasesToolStripMenuItem.Name = "purchasesToolStripMenuItem";
            this.purchasesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.purchasesToolStripMenuItem.Text = "Purchases";
            this.purchasesToolStripMenuItem.Click += new System.EventHandler(this.purchasesToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeDetailsToolStripMenuItem,
            this.enrollNewEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // employeeDetailsToolStripMenuItem
            // 
            this.employeeDetailsToolStripMenuItem.Name = "employeeDetailsToolStripMenuItem";
            this.employeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.employeeDetailsToolStripMenuItem.Text = "Employee Details";
            this.employeeDetailsToolStripMenuItem.Click += new System.EventHandler(this.employeeDetailsToolStripMenuItem_Click);
            // 
            // enrollNewEmployeeToolStripMenuItem
            // 
            this.enrollNewEmployeeToolStripMenuItem.Name = "enrollNewEmployeeToolStripMenuItem";
            this.enrollNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.enrollNewEmployeeToolStripMenuItem.Text = "Enroll New Employee";
            this.enrollNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.enrollNewEmployeeToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleReportToolStripMenuItem,
            this.saleFormToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // saleReportToolStripMenuItem
            // 
            this.saleReportToolStripMenuItem.Name = "saleReportToolStripMenuItem";
            this.saleReportToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saleReportToolStripMenuItem.Text = "Sale Report";
            this.saleReportToolStripMenuItem.Click += new System.EventHandler(this.saleReportToolStripMenuItem_Click);
            // 
            // saleFormToolStripMenuItem
            // 
            this.saleFormToolStripMenuItem.Name = "saleFormToolStripMenuItem";
            this.saleFormToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saleFormToolStripMenuItem.Text = "Sale Form";
            this.saleFormToolStripMenuItem.Click += new System.EventHandler(this.saleFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.DarkOliveGreen;
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = global::Easy_Mart.Properties.Resources.refresh;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(181, 373);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(180, 42);
            this.gunaAdvenceButton2.TabIndex = 57;
            this.gunaAdvenceButton2.Text = "Show Report";
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Image = global::Easy_Mart.Properties.Resources.logout;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(600, 451);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Red;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(87, 34);
            this.gunaAdvenceButton1.TabIndex = 56;
            this.gunaAdvenceButton1.Text = "Exit";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // btnexit
            // 
            this.btnexit.AnimationHoverSpeed = 0.07F;
            this.btnexit.AnimationSpeed = 0.03F;
            this.btnexit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnexit.BorderColor = System.Drawing.Color.Black;
            this.btnexit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnexit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnexit.CheckedForeColor = System.Drawing.Color.White;
            this.btnexit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnexit.CheckedImage")));
            this.btnexit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnexit.FocusedColor = System.Drawing.Color.Empty;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Image = global::Easy_Mart.Properties.Resources.bck;
            this.btnexit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnexit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnexit.Location = new System.Drawing.Point(39, 451);
            this.btnexit.Name = "btnexit";
            this.btnexit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnexit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnexit.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnexit.OnHoverImage = null;
            this.btnexit.OnHoverLineColor = System.Drawing.Color.Red;
            this.btnexit.OnPressedColor = System.Drawing.Color.Black;
            this.btnexit.Size = new System.Drawing.Size(87, 34);
            this.btnexit.TabIndex = 55;
            this.btnexit.Text = "Back";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnupfood
            // 
            this.btnupfood.AnimationHoverSpeed = 0.07F;
            this.btnupfood.AnimationSpeed = 0.03F;
            this.btnupfood.BaseColor = System.Drawing.Color.DarkOliveGreen;
            this.btnupfood.BorderColor = System.Drawing.Color.Black;
            this.btnupfood.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnupfood.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnupfood.CheckedForeColor = System.Drawing.Color.White;
            this.btnupfood.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnupfood.CheckedImage")));
            this.btnupfood.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnupfood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupfood.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnupfood.FocusedColor = System.Drawing.Color.Empty;
            this.btnupfood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnupfood.ForeColor = System.Drawing.Color.White;
            this.btnupfood.Image = global::Easy_Mart.Properties.Resources.beverages;
            this.btnupfood.ImageSize = new System.Drawing.Size(40, 20);
            this.btnupfood.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnupfood.Location = new System.Drawing.Point(397, 373);
            this.btnupfood.Name = "btnupfood";
            this.btnupfood.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnupfood.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnupfood.OnHoverForeColor = System.Drawing.Color.White;
            this.btnupfood.OnHoverImage = null;
            this.btnupfood.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnupfood.OnPressedColor = System.Drawing.Color.Black;
            this.btnupfood.Size = new System.Drawing.Size(207, 42);
            this.btnupfood.TabIndex = 54;
            this.btnupfood.Text = "Update Beverage Inventory";
            this.btnupfood.Click += new System.EventHandler(this.btnupfood_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 531);
            this.Controls.Add(this.gunaAdvenceButton2);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnupfood);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beverage Inventory";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vegetablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beverageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btnexit;
        private Guna.UI.WinForms.GunaAdvenceButton btnupfood;
    }
}