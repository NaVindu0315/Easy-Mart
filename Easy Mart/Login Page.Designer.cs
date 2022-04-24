namespace Easy_Mart
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlogin = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnexit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.winsw = new Guna.UI.WinForms.GunaWinSwitch();
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtusername = new Guna.UI.WinForms.GunaTextBox();
            this.txtpwd = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(165, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(31, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "USERNAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(31, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "PASSWORD:";
            // 
            // btnlogin
            // 
            this.btnlogin.AnimationHoverSpeed = 0.07F;
            this.btnlogin.AnimationSpeed = 0.03F;
            this.btnlogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnlogin.BorderColor = System.Drawing.Color.Black;
            this.btnlogin.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnlogin.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnlogin.CheckedForeColor = System.Drawing.Color.White;
            this.btnlogin.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnlogin.CheckedImage")));
            this.btnlogin.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnlogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Image = global::Easy_Mart.Properties.Resources.login;
            this.btnlogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnlogin.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnlogin.Location = new System.Drawing.Point(160, 389);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnlogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnlogin.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnlogin.OnHoverImage = null;
            this.btnlogin.OnHoverLineColor = System.Drawing.Color.Red;
            this.btnlogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnlogin.Size = new System.Drawing.Size(100, 50);
            this.btnlogin.TabIndex = 27;
            this.btnlogin.Text = "Login";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Easy_Mart.Properties.Resources.blue_user_icon_symbol_website_admin_social_login_element_concept_white_background_3d_rendering;
            this.gunaPictureBox1.Location = new System.Drawing.Point(142, 82);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(165, 120);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 29;
            this.gunaPictureBox1.TabStop = false;
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
            this.btnexit.Location = new System.Drawing.Point(35, 473);
            this.btnexit.Name = "btnexit";
            this.btnexit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnexit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnexit.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnexit.OnHoverImage = null;
            this.btnexit.OnHoverLineColor = System.Drawing.Color.Red;
            this.btnexit.OnPressedColor = System.Drawing.Color.Black;
            this.btnexit.Size = new System.Drawing.Size(87, 34);
            this.btnexit.TabIndex = 56;
            this.btnexit.Text = "Back";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Image = global::Easy_Mart.Properties.Resources.logout;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(311, 473);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.Red;
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(87, 34);
            this.gunaAdvenceButton2.TabIndex = 57;
            this.gunaAdvenceButton2.Text = "Exit";
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // winsw
            // 
            this.winsw.BackColor = System.Drawing.Color.Transparent;
            this.winsw.BaseColor = System.Drawing.Color.AntiqueWhite;
            this.winsw.CheckedOffColor = System.Drawing.Color.RosyBrown;
            this.winsw.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.winsw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.winsw.FillColor = System.Drawing.Color.Maroon;
            this.winsw.Location = new System.Drawing.Point(192, 335);
            this.winsw.Name = "winsw";
            this.winsw.Size = new System.Drawing.Size(40, 22);
            this.winsw.TabIndex = 58;
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.gunaAnimateWindow1.Interval = 100;
            this.gunaAnimateWindow1.TargetControl = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(117, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 59;
            this.label4.Text = "Seller";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(242, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "Admin";
            // 
            // txtusername
            // 
            this.txtusername.BaseColor = System.Drawing.Color.White;
            this.txtusername.BorderColor = System.Drawing.Color.Silver;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtusername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtusername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtusername.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(205, 219);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(160, 30);
            this.txtusername.TabIndex = 61;
            // 
            // txtpwd
            // 
            this.txtpwd.BaseColor = System.Drawing.Color.White;
            this.txtpwd.BorderColor = System.Drawing.Color.Silver;
            this.txtpwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpwd.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpwd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpwd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpwd.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpwd.Location = new System.Drawing.Point(205, 266);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.SelectedText = "";
            this.txtpwd.Size = new System.Drawing.Size(160, 32);
            this.txtpwd.TabIndex = 62;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 519);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.winsw);
            this.Controls.Add(this.gunaAdvenceButton2);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaAdvenceButton btnlogin;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton btnexit;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaWinSwitch winsw;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtusername;
        private Guna.UI.WinForms.GunaTextBox txtpwd;
    }
}