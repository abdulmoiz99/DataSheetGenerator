﻿namespace DatasheetGenerator
{
    partial class frm_Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Editor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_ProductFamily = new System.Windows.Forms.Label();
            this.btn_CopyToDraft = new XanderUI.XUIButton();
            this.btn_Save = new XanderUI.XUIButton();
            this.btn_DownloadPDF = new XanderUI.XUIButton();
            this.btn_SaveAsDraft = new XanderUI.XUIButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.xuiCheckBox4 = new XanderUI.XUICheckBox();
            this.xuiCheckBox5 = new XanderUI.XUICheckBox();
            this.xuiCheckBox9 = new XanderUI.XUICheckBox();
            this.xuiCheckBox10 = new XanderUI.XUICheckBox();
            this.xuiCheckBox11 = new XanderUI.XUICheckBox();
            this.xuiCheckBox12 = new XanderUI.XUICheckBox();
            this.xuiCheckBox13 = new XanderUI.XUICheckBox();
            this.xuiCheckBox16 = new XanderUI.XUICheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.xuiButton6 = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.xuiButton5 = new XanderUI.XUIButton();
            this.btn_AddHeader = new XanderUI.XUIButton();
            this.dgv_HeaderDetails = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HeaderName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_AddNewHeader = new XanderUI.XUIButton();
            this.btn_Exit = new XanderUI.XUIButton();
            this.btn_Cancel = new XanderUI.XUIButton();
            this.pnl_AddHeader = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HeaderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_AddHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Family:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lab_ProductFamily);
            this.panel1.Controls.Add(this.btn_CopyToDraft);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_DownloadPDF);
            this.panel1.Controls.Add(this.btn_SaveAsDraft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1552, 100);
            this.panel1.TabIndex = 1;
            // 
            // lab_ProductFamily
            // 
            this.lab_ProductFamily.AutoSize = true;
            this.lab_ProductFamily.Font = new System.Drawing.Font("Roboto Slab", 16F);
            this.lab_ProductFamily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lab_ProductFamily.Location = new System.Drawing.Point(253, 41);
            this.lab_ProductFamily.Name = "lab_ProductFamily";
            this.lab_ProductFamily.Size = new System.Drawing.Size(131, 32);
            this.lab_ProductFamily.TabIndex = 6;
            this.lab_ProductFamily.Text = "FL-CC-MG";
            // 
            // btn_CopyToDraft
            // 
            this.btn_CopyToDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CopyToDraft.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_CopyToDraft.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_CopyToDraft.ButtonImage")));
            this.btn_CopyToDraft.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_CopyToDraft.ButtonText = "Copy to a New Draft";
            this.btn_CopyToDraft.ClickBackColor = System.Drawing.Color.White;
            this.btn_CopyToDraft.ClickTextColor = System.Drawing.Color.White;
            this.btn_CopyToDraft.CornerRadius = 5;
            this.btn_CopyToDraft.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.btn_CopyToDraft.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_CopyToDraft.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_CopyToDraft.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_CopyToDraft.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_CopyToDraft.Location = new System.Drawing.Point(1000, 50);
            this.btn_CopyToDraft.Name = "btn_CopyToDraft";
            this.btn_CopyToDraft.Size = new System.Drawing.Size(222, 39);
            this.btn_CopyToDraft.TabIndex = 3;
            this.btn_CopyToDraft.TextColor = System.Drawing.Color.White;
            this.btn_CopyToDraft.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Save.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.ButtonImage")));
            this.btn_Save.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.ClickBackColor = System.Drawing.Color.White;
            this.btn_Save.ClickTextColor = System.Drawing.Color.White;
            this.btn_Save.CornerRadius = 5;
            this.btn_Save.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.btn_Save.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Save.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Save.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Save.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Save.Location = new System.Drawing.Point(1228, 50);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(133, 39);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.TextColor = System.Drawing.Color.White;
            this.btn_Save.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_DownloadPDF
            // 
            this.btn_DownloadPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DownloadPDF.BackgroundColor = System.Drawing.Color.White;
            this.btn_DownloadPDF.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_DownloadPDF.ButtonImage")));
            this.btn_DownloadPDF.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_DownloadPDF.ButtonText = "Download (pdf)";
            this.btn_DownloadPDF.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.btn_DownloadPDF.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.btn_DownloadPDF.CornerRadius = 5;
            this.btn_DownloadPDF.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.btn_DownloadPDF.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_DownloadPDF.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.btn_DownloadPDF.HoverTextColor = System.Drawing.Color.White;
            this.btn_DownloadPDF.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_DownloadPDF.Location = new System.Drawing.Point(1367, 50);
            this.btn_DownloadPDF.Name = "btn_DownloadPDF";
            this.btn_DownloadPDF.Size = new System.Drawing.Size(173, 39);
            this.btn_DownloadPDF.TabIndex = 4;
            this.btn_DownloadPDF.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.btn_DownloadPDF.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_SaveAsDraft
            // 
            this.btn_SaveAsDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveAsDraft.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_SaveAsDraft.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_SaveAsDraft.ButtonImage")));
            this.btn_SaveAsDraft.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_SaveAsDraft.ButtonText = "Save as a Draft";
            this.btn_SaveAsDraft.ClickBackColor = System.Drawing.Color.White;
            this.btn_SaveAsDraft.ClickTextColor = System.Drawing.Color.White;
            this.btn_SaveAsDraft.CornerRadius = 5;
            this.btn_SaveAsDraft.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.btn_SaveAsDraft.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_SaveAsDraft.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_SaveAsDraft.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_SaveAsDraft.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_SaveAsDraft.Location = new System.Drawing.Point(785, 50);
            this.btn_SaveAsDraft.Name = "btn_SaveAsDraft";
            this.btn_SaveAsDraft.Size = new System.Drawing.Size(209, 39);
            this.btn_SaveAsDraft.TabIndex = 2;
            this.btn_SaveAsDraft.TextColor = System.Drawing.Color.White;
            this.btn_SaveAsDraft.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1154, 739);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 277);
            this.panel2.TabIndex = 46;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.xuiCheckBox4);
            this.flowLayoutPanel2.Controls.Add(this.xuiCheckBox5);
            this.flowLayoutPanel2.Controls.Add(this.xuiCheckBox9);
            this.flowLayoutPanel2.Controls.Add(this.xuiCheckBox10);
            this.flowLayoutPanel2.Controls.Add(this.xuiCheckBox11);
            this.flowLayoutPanel2.Controls.Add(this.xuiCheckBox12);
            this.flowLayoutPanel2.Controls.Add(this.xuiCheckBox13);
            this.flowLayoutPanel2.Controls.Add(this.xuiCheckBox16);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(546, 227);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // xuiCheckBox4
            // 
            this.xuiCheckBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xuiCheckBox4.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox4.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiCheckBox4.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox4.CheckboxStyle = XanderUI.XUICheckBox.Style.iOS;
            this.xuiCheckBox4.Checked = false;
            this.xuiCheckBox4.Font = new System.Drawing.Font("Roboto Medium", 10.18868F);
            this.xuiCheckBox4.ForeColor = System.Drawing.Color.DimGray;
            this.xuiCheckBox4.Location = new System.Drawing.Point(3, 3);
            this.xuiCheckBox4.Name = "xuiCheckBox4";
            this.xuiCheckBox4.Size = new System.Drawing.Size(251, 36);
            this.xuiCheckBox4.TabIndex = 54;
            this.xuiCheckBox4.Text = "Optic 90 / Type V";
            this.xuiCheckBox4.TickThickness = 2;
            // 
            // xuiCheckBox5
            // 
            this.xuiCheckBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xuiCheckBox5.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox5.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiCheckBox5.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox5.CheckboxStyle = XanderUI.XUICheckBox.Style.iOS;
            this.xuiCheckBox5.Checked = false;
            this.xuiCheckBox5.Font = new System.Drawing.Font("Roboto Medium", 10.18868F);
            this.xuiCheckBox5.ForeColor = System.Drawing.Color.DimGray;
            this.xuiCheckBox5.Location = new System.Drawing.Point(260, 3);
            this.xuiCheckBox5.Name = "xuiCheckBox5";
            this.xuiCheckBox5.Size = new System.Drawing.Size(251, 36);
            this.xuiCheckBox5.TabIndex = 55;
            this.xuiCheckBox5.Text = "Optic 90 / Type V";
            this.xuiCheckBox5.TickThickness = 2;
            // 
            // xuiCheckBox9
            // 
            this.xuiCheckBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xuiCheckBox9.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox9.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiCheckBox9.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox9.CheckboxStyle = XanderUI.XUICheckBox.Style.iOS;
            this.xuiCheckBox9.Checked = false;
            this.xuiCheckBox9.Font = new System.Drawing.Font("Roboto Medium", 10.18868F);
            this.xuiCheckBox9.ForeColor = System.Drawing.Color.DimGray;
            this.xuiCheckBox9.Location = new System.Drawing.Point(3, 45);
            this.xuiCheckBox9.Name = "xuiCheckBox9";
            this.xuiCheckBox9.Size = new System.Drawing.Size(251, 36);
            this.xuiCheckBox9.TabIndex = 56;
            this.xuiCheckBox9.Text = "Optic 90 / Type V";
            this.xuiCheckBox9.TickThickness = 2;
            // 
            // xuiCheckBox10
            // 
            this.xuiCheckBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xuiCheckBox10.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox10.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiCheckBox10.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox10.CheckboxStyle = XanderUI.XUICheckBox.Style.iOS;
            this.xuiCheckBox10.Checked = false;
            this.xuiCheckBox10.Font = new System.Drawing.Font("Roboto Medium", 10.18868F);
            this.xuiCheckBox10.ForeColor = System.Drawing.Color.DimGray;
            this.xuiCheckBox10.Location = new System.Drawing.Point(260, 45);
            this.xuiCheckBox10.Name = "xuiCheckBox10";
            this.xuiCheckBox10.Size = new System.Drawing.Size(251, 36);
            this.xuiCheckBox10.TabIndex = 57;
            this.xuiCheckBox10.Text = "Optic 90 / Type V";
            this.xuiCheckBox10.TickThickness = 2;
            // 
            // xuiCheckBox11
            // 
            this.xuiCheckBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xuiCheckBox11.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox11.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiCheckBox11.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox11.CheckboxStyle = XanderUI.XUICheckBox.Style.iOS;
            this.xuiCheckBox11.Checked = false;
            this.xuiCheckBox11.Font = new System.Drawing.Font("Roboto Medium", 10.18868F);
            this.xuiCheckBox11.ForeColor = System.Drawing.Color.DimGray;
            this.xuiCheckBox11.Location = new System.Drawing.Point(3, 87);
            this.xuiCheckBox11.Name = "xuiCheckBox11";
            this.xuiCheckBox11.Size = new System.Drawing.Size(251, 36);
            this.xuiCheckBox11.TabIndex = 58;
            this.xuiCheckBox11.Text = "Optic 90 / Type V";
            this.xuiCheckBox11.TickThickness = 2;
            // 
            // xuiCheckBox12
            // 
            this.xuiCheckBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xuiCheckBox12.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox12.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiCheckBox12.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox12.CheckboxStyle = XanderUI.XUICheckBox.Style.iOS;
            this.xuiCheckBox12.Checked = false;
            this.xuiCheckBox12.Font = new System.Drawing.Font("Roboto Medium", 10.18868F);
            this.xuiCheckBox12.ForeColor = System.Drawing.Color.DimGray;
            this.xuiCheckBox12.Location = new System.Drawing.Point(260, 87);
            this.xuiCheckBox12.Name = "xuiCheckBox12";
            this.xuiCheckBox12.Size = new System.Drawing.Size(251, 36);
            this.xuiCheckBox12.TabIndex = 59;
            this.xuiCheckBox12.Text = "Optic 90 / Type V";
            this.xuiCheckBox12.TickThickness = 2;
            // 
            // xuiCheckBox13
            // 
            this.xuiCheckBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xuiCheckBox13.CheckboxCheckColor = System.Drawing.Color.White;
            this.xuiCheckBox13.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiCheckBox13.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox13.CheckboxStyle = XanderUI.XUICheckBox.Style.iOS;
            this.xuiCheckBox13.Checked = false;
            this.xuiCheckBox13.Font = new System.Drawing.Font("Roboto Medium", 10.18868F);
            this.xuiCheckBox13.ForeColor = System.Drawing.Color.DimGray;
            this.xuiCheckBox13.Location = new System.Drawing.Point(3, 129);
            this.xuiCheckBox13.Name = "xuiCheckBox13";
            this.xuiCheckBox13.Size = new System.Drawing.Size(251, 36);
            this.xuiCheckBox13.TabIndex = 60;
            this.xuiCheckBox13.Text = "Optic 90 / Type V";
            this.xuiCheckBox13.TickThickness = 2;
            // 
            // xuiCheckBox16
            // 
            this.xuiCheckBox16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xuiCheckBox16.CheckboxCheckColor = System.Drawing.Color.WhiteSmoke;
            this.xuiCheckBox16.CheckboxColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiCheckBox16.CheckboxHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.xuiCheckBox16.CheckboxStyle = XanderUI.XUICheckBox.Style.iOS;
            this.xuiCheckBox16.Checked = false;
            this.xuiCheckBox16.Font = new System.Drawing.Font("Roboto Medium", 10.18868F);
            this.xuiCheckBox16.ForeColor = System.Drawing.Color.DimGray;
            this.xuiCheckBox16.Location = new System.Drawing.Point(260, 129);
            this.xuiCheckBox16.Name = "xuiCheckBox16";
            this.xuiCheckBox16.Size = new System.Drawing.Size(251, 36);
            this.xuiCheckBox16.TabIndex = 61;
            this.xuiCheckBox16.Text = "Optic 90 / Type V";
            this.xuiCheckBox16.TickThickness = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.xuiButton6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 50);
            this.panel3.TabIndex = 0;
            // 
            // xuiButton6
            // 
            this.xuiButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiButton6.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton6.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton6.ButtonImage")));
            this.xuiButton6.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton6.ButtonText = "+ Add a New Symbol";
            this.xuiButton6.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiButton6.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiButton6.CornerRadius = 5;
            this.xuiButton6.Font = new System.Drawing.Font("Roboto Slab", 9F);
            this.xuiButton6.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton6.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiButton6.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton6.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton6.Location = new System.Drawing.Point(364, 6);
            this.xuiButton6.Name = "xuiButton6";
            this.xuiButton6.Size = new System.Drawing.Size(177, 31);
            this.xuiButton6.TabIndex = 46;
            this.xuiButton6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiButton6.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12.90566F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "  Symbols";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.xuiButton5);
            this.xuiCustomGroupbox1.Controls.Add(this.btn_AddHeader);
            this.xuiCustomGroupbox1.Controls.Add(this.dgv_HeaderDetails);
            this.xuiCustomGroupbox1.Font = new System.Drawing.Font("Roboto Slab Medium", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(1204, 173);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(336, 555);
            this.xuiCustomGroupbox1.TabIndex = 2;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Headers";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            // 
            // xuiButton5
            // 
            this.xuiButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiButton5.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton5.ButtonImage")));
            this.xuiButton5.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton5.ButtonText = "Update";
            this.xuiButton5.ClickBackColor = System.Drawing.Color.White;
            this.xuiButton5.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton5.CornerRadius = 5;
            this.xuiButton5.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.xuiButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.HoverBackgroundColor = System.Drawing.Color.White;
            this.xuiButton5.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiButton5.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton5.Location = new System.Drawing.Point(170, 500);
            this.xuiButton5.Name = "xuiButton5";
            this.xuiButton5.Size = new System.Drawing.Size(133, 39);
            this.xuiButton5.TabIndex = 20;
            this.xuiButton5.TextColor = System.Drawing.Color.White;
            this.xuiButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.Click += new System.EventHandler(this.xuiButton5_Click_1);
            // 
            // btn_AddHeader
            // 
            this.btn_AddHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_AddHeader.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_AddHeader.ButtonImage")));
            this.btn_AddHeader.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_AddHeader.ButtonText = "Add";
            this.btn_AddHeader.ClickBackColor = System.Drawing.Color.White;
            this.btn_AddHeader.ClickTextColor = System.Drawing.Color.White;
            this.btn_AddHeader.CornerRadius = 5;
            this.btn_AddHeader.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_AddHeader.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddHeader.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_AddHeader.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_AddHeader.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_AddHeader.Location = new System.Drawing.Point(13, 500);
            this.btn_AddHeader.Name = "btn_AddHeader";
            this.btn_AddHeader.Size = new System.Drawing.Size(133, 39);
            this.btn_AddHeader.TabIndex = 19;
            this.btn_AddHeader.TextColor = System.Drawing.Color.White;
            this.btn_AddHeader.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddHeader.Click += new System.EventHandler(this.btn_AddHeader_Click);
            // 
            // dgv_HeaderDetails
            // 
            this.dgv_HeaderDetails.AllowUserToAddRows = false;
            this.dgv_HeaderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HeaderDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgv_HeaderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HeaderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Position,
            this.Delete});
            this.dgv_HeaderDetails.Location = new System.Drawing.Point(6, 34);
            this.dgv_HeaderDetails.Name = "dgv_HeaderDetails";
            this.dgv_HeaderDetails.RowHeadersVisible = false;
            this.dgv_HeaderDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HeaderDetails.Size = new System.Drawing.Size(324, 456);
            this.dgv_HeaderDetails.TabIndex = 1;
            this.dgv_HeaderDetails.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_HeaderDetails_CellBeginEdit);
            this.dgv_HeaderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HeaderDetails_CellClick);
            this.dgv_HeaderDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HeaderDetails_CellEndEdit);
            this.dgv_HeaderDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HeaderDetails_CellValueChanged);
            this.dgv_HeaderDetails.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_HeaderDetails_EditingControlShowing);
            this.dgv_HeaderDetails.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv_HeaderDetails_UserDeletingRow);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "Text";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position.FillWeight = 30F;
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.FillWeight = 10F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn1.FillWeight = 10F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(19, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 119);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Slab", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(186, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 39);
            this.label3.TabIndex = 23;
            this.label3.Text = "Add Header";
            // 
            // txt_HeaderName
            // 
            this.txt_HeaderName.Depth = 0;
            this.txt_HeaderName.Font = new System.Drawing.Font("Roboto Slab", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HeaderName.ForeColor = System.Drawing.Color.Coral;
            this.txt_HeaderName.Hint = "";
            this.txt_HeaderName.Location = new System.Drawing.Point(186, 87);
            this.txt_HeaderName.MaxLength = 32767;
            this.txt_HeaderName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_HeaderName.Name = "txt_HeaderName";
            this.txt_HeaderName.PasswordChar = '\0';
            this.txt_HeaderName.SelectedText = "";
            this.txt_HeaderName.SelectionLength = 0;
            this.txt_HeaderName.SelectionStart = 0;
            this.txt_HeaderName.Size = new System.Drawing.Size(257, 25);
            this.txt_HeaderName.TabIndex = 24;
            this.txt_HeaderName.TabStop = false;
            this.txt_HeaderName.Text = "Header Name";
            this.txt_HeaderName.UseSystemPasswordChar = false;
            // 
            // btn_AddNewHeader
            // 
            this.btn_AddNewHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_AddNewHeader.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_AddNewHeader.ButtonImage")));
            this.btn_AddNewHeader.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_AddNewHeader.ButtonText = "+ Add";
            this.btn_AddNewHeader.ClickBackColor = System.Drawing.Color.White;
            this.btn_AddNewHeader.ClickTextColor = System.Drawing.Color.White;
            this.btn_AddNewHeader.CornerRadius = 5;
            this.btn_AddNewHeader.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_AddNewHeader.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddNewHeader.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_AddNewHeader.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_AddNewHeader.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_AddNewHeader.Location = new System.Drawing.Point(186, 133);
            this.btn_AddNewHeader.Name = "btn_AddNewHeader";
            this.btn_AddNewHeader.Size = new System.Drawing.Size(123, 36);
            this.btn_AddNewHeader.TabIndex = 25;
            this.btn_AddNewHeader.TextColor = System.Drawing.Color.White;
            this.btn_AddNewHeader.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddNewHeader.Click += new System.EventHandler(this.btn_AddNewHeader_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundColor = System.Drawing.Color.White;
            this.btn_Exit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ButtonImage")));
            this.btn_Exit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Exit.ButtonText = "";
            this.btn_Exit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exit.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exit.CornerRadius = 50;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Exit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Exit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exit.HoverTextColor = System.Drawing.Color.White;
            this.btn_Exit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Exit.Location = new System.Drawing.Point(497, 7);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(36, 36);
            this.btn_Exit.TabIndex = 26;
            this.btn_Exit.TextColor = System.Drawing.Color.White;
            this.btn_Exit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.btn_Cancel.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ButtonImage")));
            this.btn_Cancel.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Cancel.ButtonText = "Cancel";
            this.btn_Cancel.ClickBackColor = System.Drawing.Color.White;
            this.btn_Cancel.ClickTextColor = System.Drawing.Color.White;
            this.btn_Cancel.CornerRadius = 5;
            this.btn_Cancel.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_Cancel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Cancel.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Cancel.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.btn_Cancel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Cancel.Location = new System.Drawing.Point(315, 133);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(123, 36);
            this.btn_Cancel.TabIndex = 27;
            this.btn_Cancel.TextColor = System.Drawing.Color.White;
            this.btn_Cancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // pnl_AddHeader
            // 
            this.pnl_AddHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_AddHeader.Controls.Add(this.btn_Cancel);
            this.pnl_AddHeader.Controls.Add(this.btn_Exit);
            this.pnl_AddHeader.Controls.Add(this.btn_AddNewHeader);
            this.pnl_AddHeader.Controls.Add(this.txt_HeaderName);
            this.pnl_AddHeader.Controls.Add(this.label3);
            this.pnl_AddHeader.Controls.Add(this.pictureBox1);
            this.pnl_AddHeader.Location = new System.Drawing.Point(1179, 342);
            this.pnl_AddHeader.Name = "pnl_AddHeader";
            this.pnl_AddHeader.Size = new System.Drawing.Size(545, 203);
            this.pnl_AddHeader.TabIndex = 3;
            this.pnl_AddHeader.Visible = false;
            this.pnl_AddHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_AddHeader_Paint);
            // 
            // frm_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1552, 886);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnl_AddHeader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Editor";
            this.Activated += new System.EventHandler(this.frm_Editor_Activated);
            this.Load += new System.EventHandler(this.frm_Editor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Editor_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HeaderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_AddHeader.ResumeLayout(false);
            this.pnl_AddHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btn_SaveAsDraft;
        private XanderUI.XUIButton btn_CopyToDraft;
        private XanderUI.XUIButton btn_Save;
        private XanderUI.XUIButton btn_DownloadPDF;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private System.Windows.Forms.DataGridView dgv_HeaderDetails;
        private XanderUI.XUIButton xuiButton5;
        private XanderUI.XUIButton btn_AddHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private XanderUI.XUICheckBox xuiCheckBox4;
        private XanderUI.XUICheckBox xuiCheckBox5;
        private XanderUI.XUICheckBox xuiCheckBox9;
        private XanderUI.XUICheckBox xuiCheckBox10;
        private XanderUI.XUICheckBox xuiCheckBox11;
        private XanderUI.XUICheckBox xuiCheckBox12;
        private XanderUI.XUICheckBox xuiCheckBox13;
        private XanderUI.XUICheckBox xuiCheckBox16;
        private System.Windows.Forms.Panel panel3;
        private XanderUI.XUIButton xuiButton6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lab_ProductFamily;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_HeaderName;
        private XanderUI.XUIButton btn_AddNewHeader;
        private XanderUI.XUIButton btn_Exit;
        private XanderUI.XUIButton btn_Cancel;
        private System.Windows.Forms.Panel pnl_AddHeader;
    }
}