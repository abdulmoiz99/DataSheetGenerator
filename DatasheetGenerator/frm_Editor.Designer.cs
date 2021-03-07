namespace DatasheetGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xuiButton2 = new XanderUI.XUIButton();
            this.xuiButton4 = new XanderUI.XUIButton();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
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
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HeaderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Family:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xuiButton2);
            this.panel1.Controls.Add(this.xuiButton4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.xuiButton3);
            this.panel1.Controls.Add(this.xuiButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1516, 100);
            this.panel1.TabIndex = 1;
            // 
            // xuiButton2
            // 
            this.xuiButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton2.ButtonImage")));
            this.xuiButton2.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton2.ButtonText = "Copy to a New Draft";
            this.xuiButton2.ClickBackColor = System.Drawing.Color.White;
            this.xuiButton2.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton2.CornerRadius = 5;
            this.xuiButton2.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.xuiButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton2.HoverBackgroundColor = System.Drawing.Color.White;
            this.xuiButton2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiButton2.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton2.Location = new System.Drawing.Point(964, 55);
            this.xuiButton2.Name = "xuiButton2";
            this.xuiButton2.Size = new System.Drawing.Size(222, 39);
            this.xuiButton2.TabIndex = 3;
            this.xuiButton2.TextColor = System.Drawing.Color.White;
            this.xuiButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton4
            // 
            this.xuiButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.xuiButton4.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton4.ButtonImage")));
            this.xuiButton4.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton4.ButtonText = "Save";
            this.xuiButton4.ClickBackColor = System.Drawing.Color.White;
            this.xuiButton4.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton4.CornerRadius = 5;
            this.xuiButton4.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.xuiButton4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton4.HoverBackgroundColor = System.Drawing.Color.White;
            this.xuiButton4.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.xuiButton4.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton4.Location = new System.Drawing.Point(1192, 55);
            this.xuiButton4.Name = "xuiButton4";
            this.xuiButton4.Size = new System.Drawing.Size(133, 39);
            this.xuiButton4.TabIndex = 5;
            this.xuiButton4.TextColor = System.Drawing.Color.White;
            this.xuiButton4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton3
            // 
            this.xuiButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiButton3.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton3.ButtonImage")));
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton3.ButtonText = "Download (pdf)";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.xuiButton3.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.xuiButton3.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(1331, 55);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(173, 39);
            this.xuiButton3.TabIndex = 4;
            this.xuiButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(115)))), ((int)(((byte)(160)))));
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton1
            // 
            this.xuiButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton1.ButtonText = "Save as a Draft";
            this.xuiButton1.ClickBackColor = System.Drawing.Color.White;
            this.xuiButton1.ClickTextColor = System.Drawing.Color.White;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.Color.White;
            this.xuiButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(749, 55);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(209, 39);
            this.xuiButton1.TabIndex = 2;
            this.xuiButton1.TextColor = System.Drawing.Color.White;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 126);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1118, 739);
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
            this.xuiButton6.Location = new System.Drawing.Point(364, 11);
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
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(1168, 178);
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
            this.xuiButton5.Location = new System.Drawing.Point(170, 505);
            this.xuiButton5.Name = "xuiButton5";
            this.xuiButton5.Size = new System.Drawing.Size(133, 39);
            this.xuiButton5.TabIndex = 20;
            this.xuiButton5.TextColor = System.Drawing.Color.White;
            this.xuiButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_AddHeader
            // 
            this.btn_AddHeader.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_AddHeader.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_AddHeader.ButtonImage")));
            this.btn_AddHeader.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_AddHeader.ButtonText = "+ Add";
            this.btn_AddHeader.ClickBackColor = System.Drawing.Color.White;
            this.btn_AddHeader.ClickTextColor = System.Drawing.Color.White;
            this.btn_AddHeader.CornerRadius = 5;
            this.btn_AddHeader.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_AddHeader.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddHeader.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_AddHeader.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_AddHeader.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_AddHeader.Location = new System.Drawing.Point(13, 505);
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
            this.Position});
            this.dgv_HeaderDetails.Location = new System.Drawing.Point(6, 39);
            this.dgv_HeaderDetails.Name = "dgv_HeaderDetails";
            this.dgv_HeaderDetails.Size = new System.Drawing.Size(324, 456);
            this.dgv_HeaderDetails.TabIndex = 1;
            this.dgv_HeaderDetails.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_HeaderDetails_CellBeginEdit);
            this.dgv_HeaderDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HeaderDetails_CellEndEdit);
            this.dgv_HeaderDetails.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_HeaderDetails_EditingControlShowing);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Text";
            this.Column1.Name = "Column1";
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // frm_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1516, 886);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Name = "frm_Editor";
            this.Text = "frm_Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frm_Editor_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HeaderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton xuiButton1;
        private XanderUI.XUIButton xuiButton2;
        private XanderUI.XUIButton xuiButton4;
        private XanderUI.XUIButton xuiButton3;
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
    }
}