﻿namespace DatasheetGenerator
{
    partial class frm_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Logout = new XanderUI.XUIButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_NewDatasheet = new XanderUI.XUIButton();
            this.btn_MediaLinrary = new XanderUI.XUIButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Modules = new XanderUI.XUIButton();
            this.btn_Subheaders = new XanderUI.XUIButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1528, 99);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(1214, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Datasheet Generator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1528, 3);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1528, 14);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Subheaders);
            this.panel5.Controls.Add(this.btn_Modules);
            this.panel5.Controls.Add(this.btn_Logout);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Controls.Add(this.btn_NewDatasheet);
            this.panel5.Controls.Add(this.btn_MediaLinrary);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(20, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 697);
            this.panel5.TabIndex = 6;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Logout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.btn_Logout.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Logout.ButtonImage")));
            this.btn_Logout.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Logout.ButtonText = "Logout";
            this.btn_Logout.ClickBackColor = System.Drawing.Color.White;
            this.btn_Logout.ClickTextColor = System.Drawing.Color.White;
            this.btn_Logout.CornerRadius = 5;
            this.btn_Logout.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.btn_Logout.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Logout.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Logout.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.btn_Logout.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Logout.Location = new System.Drawing.Point(21, 652);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(267, 39);
            this.btn_Logout.TabIndex = 14;
            this.btn_Logout.TextColor = System.Drawing.Color.White;
            this.btn_Logout.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.panel7.Location = new System.Drawing.Point(21, 277);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 3);
            this.panel7.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 315);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 282);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // btn_NewDatasheet
            // 
            this.btn_NewDatasheet.BackgroundColor = System.Drawing.Color.White;
            this.btn_NewDatasheet.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_NewDatasheet.ButtonImage")));
            this.btn_NewDatasheet.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_NewDatasheet.ButtonText = "New Datasheet";
            this.btn_NewDatasheet.ClickBackColor = System.Drawing.Color.Gray;
            this.btn_NewDatasheet.ClickTextColor = System.Drawing.Color.Gray;
            this.btn_NewDatasheet.CornerRadius = 5;
            this.btn_NewDatasheet.Font = new System.Drawing.Font("Roboto Slab", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewDatasheet.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_NewDatasheet.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.btn_NewDatasheet.HoverTextColor = System.Drawing.Color.White;
            this.btn_NewDatasheet.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_NewDatasheet.Location = new System.Drawing.Point(21, 18);
            this.btn_NewDatasheet.Name = "btn_NewDatasheet";
            this.btn_NewDatasheet.Size = new System.Drawing.Size(263, 50);
            this.btn_NewDatasheet.TabIndex = 0;
            this.btn_NewDatasheet.TextColor = System.Drawing.Color.Gray;
            this.btn_NewDatasheet.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_NewDatasheet.Click += new System.EventHandler(this.btn_NewDatasheet_Click);
            // 
            // btn_MediaLinrary
            // 
            this.btn_MediaLinrary.BackgroundColor = System.Drawing.Color.White;
            this.btn_MediaLinrary.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_MediaLinrary.ButtonImage")));
            this.btn_MediaLinrary.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_MediaLinrary.ButtonText = "Media Library";
            this.btn_MediaLinrary.ClickBackColor = System.Drawing.Color.Gray;
            this.btn_MediaLinrary.ClickTextColor = System.Drawing.Color.Gray;
            this.btn_MediaLinrary.CornerRadius = 5;
            this.btn_MediaLinrary.Font = new System.Drawing.Font("Roboto Slab", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MediaLinrary.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_MediaLinrary.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.btn_MediaLinrary.HoverTextColor = System.Drawing.Color.White;
            this.btn_MediaLinrary.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_MediaLinrary.Location = new System.Drawing.Point(21, 77);
            this.btn_MediaLinrary.Name = "btn_MediaLinrary";
            this.btn_MediaLinrary.Size = new System.Drawing.Size(263, 50);
            this.btn_MediaLinrary.TabIndex = 1;
            this.btn_MediaLinrary.TextColor = System.Drawing.Color.Gray;
            this.btn_MediaLinrary.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_MediaLinrary.Click += new System.EventHandler(this.btn_MediaLinrary_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(20, 813);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1528, 20);
            this.panel6.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1548, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 833);
            this.panel4.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(20, 833);
            this.panel8.TabIndex = 10;
            // 
            // btn_Modules
            // 
            this.btn_Modules.BackgroundColor = System.Drawing.Color.White;
            this.btn_Modules.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Modules.ButtonImage")));
            this.btn_Modules.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Modules.ButtonText = "Modules";
            this.btn_Modules.ClickBackColor = System.Drawing.Color.Gray;
            this.btn_Modules.ClickTextColor = System.Drawing.Color.Gray;
            this.btn_Modules.CornerRadius = 5;
            this.btn_Modules.Font = new System.Drawing.Font("Roboto Slab", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modules.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Modules.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.btn_Modules.HoverTextColor = System.Drawing.Color.White;
            this.btn_Modules.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Modules.Location = new System.Drawing.Point(21, 136);
            this.btn_Modules.Name = "btn_Modules";
            this.btn_Modules.Size = new System.Drawing.Size(263, 50);
            this.btn_Modules.TabIndex = 15;
            this.btn_Modules.TextColor = System.Drawing.Color.Gray;
            this.btn_Modules.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Modules.Click += new System.EventHandler(this.btn_Modules_Click);
            // 
            // btn_Subheaders
            // 
            this.btn_Subheaders.BackgroundColor = System.Drawing.Color.White;
            this.btn_Subheaders.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Subheaders.ButtonImage")));
            this.btn_Subheaders.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Subheaders.ButtonText = "Subheaders";
            this.btn_Subheaders.ClickBackColor = System.Drawing.Color.Gray;
            this.btn_Subheaders.ClickTextColor = System.Drawing.Color.Gray;
            this.btn_Subheaders.CornerRadius = 5;
            this.btn_Subheaders.Font = new System.Drawing.Font("Roboto Slab", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subheaders.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Subheaders.HoverBackgroundColor = System.Drawing.Color.Gray;
            this.btn_Subheaders.HoverTextColor = System.Drawing.Color.White;
            this.btn_Subheaders.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Subheaders.Location = new System.Drawing.Point(21, 195);
            this.btn_Subheaders.Name = "btn_Subheaders";
            this.btn_Subheaders.Size = new System.Drawing.Size(263, 50);
            this.btn_Subheaders.TabIndex = 16;
            this.btn_Subheaders.TextColor = System.Drawing.Color.Gray;
            this.btn_Subheaders.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Subheaders.Click += new System.EventHandler(this.btn_Subheaders_Click);
            // 
            // frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1568, 833);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1584, 872);
            this.Name = "frm_Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frm_Dashboard_Activated);
            this.Load += new System.EventHandler(this.frm_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton btn_NewDatasheet;
        private XanderUI.XUIButton btn_MediaLinrary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private XanderUI.XUIButton btn_Logout;
        private XanderUI.XUIButton btn_Subheaders;
        private XanderUI.XUIButton btn_Modules;
    }
}