namespace DatasheetGenerator
{
    partial class frm_Editor1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Editor1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_HeaderDetails = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.xuiButton5 = new XanderUI.XUIButton();
            this.btn_AddHeader = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.xuiButton6 = new XanderUI.XUIButton();
            this.xuiCheckBox4 = new XanderUI.XUICheckBox();
            this.xuiCheckBox5 = new XanderUI.XUICheckBox();
            this.xuiCheckBox10 = new XanderUI.XUICheckBox();
            this.xuiCheckBox11 = new XanderUI.XUICheckBox();
            this.xuiCheckBox12 = new XanderUI.XUICheckBox();
            this.xuiCheckBox13 = new XanderUI.XUICheckBox();
            this.flowPanel_Symbols = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lab_ProductFamily = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CopyToDraft = new XanderUI.XUIButton();
            this.btn_Save = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DownloadPDF = new XanderUI.XUIButton();
            this.btn_SaveAsDraft = new XanderUI.XUIButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowPanel_ProductImages = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowPanel_DimensionalDrawings = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.flowPanel_WiringDiagrams = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HeaderDetails)).BeginInit();
            this.xuiCustomGroupbox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowPanel_Symbols.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position.FillWeight = 30F;
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "Text";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.dgv_HeaderDetails.Location = new System.Drawing.Point(11, 27);
            this.dgv_HeaderDetails.Name = "dgv_HeaderDetails";
            this.dgv_HeaderDetails.RowHeadersVisible = false;
            this.dgv_HeaderDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_HeaderDetails.Size = new System.Drawing.Size(315, 344);
            this.dgv_HeaderDetails.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete.FillWeight = 10F;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(1152, 116);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(336, 441);
            this.xuiCustomGroupbox1.TabIndex = 5;
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
            this.xuiButton5.Location = new System.Drawing.Point(160, 389);
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
            this.btn_AddHeader.ButtonText = "Add";
            this.btn_AddHeader.ClickBackColor = System.Drawing.Color.White;
            this.btn_AddHeader.ClickTextColor = System.Drawing.Color.White;
            this.btn_AddHeader.CornerRadius = 5;
            this.btn_AddHeader.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_AddHeader.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddHeader.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_AddHeader.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_AddHeader.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_AddHeader.Location = new System.Drawing.Point(3, 389);
            this.btn_AddHeader.Name = "btn_AddHeader";
            this.btn_AddHeader.Size = new System.Drawing.Size(133, 39);
            this.btn_AddHeader.TabIndex = 19;
            this.btn_AddHeader.TextColor = System.Drawing.Color.White;
            this.btn_AddHeader.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.xuiCheckBox10.Location = new System.Drawing.Point(3, 45);
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
            this.xuiCheckBox11.Location = new System.Drawing.Point(260, 45);
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
            this.xuiCheckBox12.Location = new System.Drawing.Point(3, 87);
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
            this.xuiCheckBox13.Location = new System.Drawing.Point(260, 87);
            this.xuiCheckBox13.Name = "xuiCheckBox13";
            this.xuiCheckBox13.Size = new System.Drawing.Size(251, 36);
            this.xuiCheckBox13.TabIndex = 60;
            this.xuiCheckBox13.Text = "Optic 90 / Type V";
            this.xuiCheckBox13.TickThickness = 2;
            // 
            // flowPanel_Symbols
            // 
            this.flowPanel_Symbols.AutoScroll = true;
            this.flowPanel_Symbols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanel_Symbols.Controls.Add(this.xuiCheckBox4);
            this.flowPanel_Symbols.Controls.Add(this.xuiCheckBox5);
            this.flowPanel_Symbols.Controls.Add(this.xuiCheckBox10);
            this.flowPanel_Symbols.Controls.Add(this.xuiCheckBox11);
            this.flowPanel_Symbols.Controls.Add(this.xuiCheckBox12);
            this.flowPanel_Symbols.Controls.Add(this.xuiCheckBox13);
            this.flowPanel_Symbols.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel_Symbols.Location = new System.Drawing.Point(0, 50);
            this.flowPanel_Symbols.Name = "flowPanel_Symbols";
            this.flowPanel_Symbols.Size = new System.Drawing.Size(546, 227);
            this.flowPanel_Symbols.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowPanel_Symbols);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 277);
            this.panel2.TabIndex = 46;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1132, 752);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lab_ProductFamily
            // 
            this.lab_ProductFamily.AutoSize = true;
            this.lab_ProductFamily.Font = new System.Drawing.Font("Roboto Slab", 16F);
            this.lab_ProductFamily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lab_ProductFamily.Location = new System.Drawing.Point(253, 46);
            this.lab_ProductFamily.Name = "lab_ProductFamily";
            this.lab_ProductFamily.Size = new System.Drawing.Size(131, 32);
            this.lab_ProductFamily.TabIndex = 6;
            this.lab_ProductFamily.Text = "FL-CC-MG";
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
            this.panel1.Size = new System.Drawing.Size(1500, 100);
            this.panel1.TabIndex = 3;
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
            this.btn_CopyToDraft.Location = new System.Drawing.Point(948, 55);
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
            this.btn_Save.Location = new System.Drawing.Point(1176, 55);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(133, 39);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.TextColor = System.Drawing.Color.White;
            this.btn_Save.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Family:";
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
            this.btn_DownloadPDF.Location = new System.Drawing.Point(1315, 55);
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
            this.btn_SaveAsDraft.Location = new System.Drawing.Point(733, 55);
            this.btn_SaveAsDraft.Name = "btn_SaveAsDraft";
            this.btn_SaveAsDraft.Size = new System.Drawing.Size(209, 39);
            this.btn_SaveAsDraft.TabIndex = 2;
            this.btn_SaveAsDraft.TextColor = System.Drawing.Color.White;
            this.btn_SaveAsDraft.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewImageColumn1.FillWeight = 10F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowPanel_ProductImages);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(555, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 277);
            this.panel4.TabIndex = 50;
            // 
            // flowPanel_ProductImages
            // 
            this.flowPanel_ProductImages.AutoScroll = true;
            this.flowPanel_ProductImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanel_ProductImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel_ProductImages.Location = new System.Drawing.Point(0, 50);
            this.flowPanel_ProductImages.Name = "flowPanel_ProductImages";
            this.flowPanel_ProductImages.Size = new System.Drawing.Size(546, 227);
            this.flowPanel_ProductImages.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(546, 50);
            this.panel5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 12.90566F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 48);
            this.label6.TabIndex = 0;
            this.label6.Text = "  Product Images";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.flowPanel_DimensionalDrawings);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(3, 286);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(546, 277);
            this.panel6.TabIndex = 51;
            // 
            // flowPanel_DimensionalDrawings
            // 
            this.flowPanel_DimensionalDrawings.AutoScroll = true;
            this.flowPanel_DimensionalDrawings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanel_DimensionalDrawings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel_DimensionalDrawings.Location = new System.Drawing.Point(0, 50);
            this.flowPanel_DimensionalDrawings.Name = "flowPanel_DimensionalDrawings";
            this.flowPanel_DimensionalDrawings.Size = new System.Drawing.Size(546, 227);
            this.flowPanel_DimensionalDrawings.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(546, 50);
            this.panel7.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 12.90566F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 48);
            this.label7.TabIndex = 0;
            this.label7.Text = "  Dimensional Drawings";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.flowPanel_WiringDiagrams);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(555, 286);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(546, 277);
            this.panel8.TabIndex = 52;
            // 
            // flowPanel_WiringDiagrams
            // 
            this.flowPanel_WiringDiagrams.AutoScroll = true;
            this.flowPanel_WiringDiagrams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanel_WiringDiagrams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel_WiringDiagrams.Location = new System.Drawing.Point(0, 50);
            this.flowPanel_WiringDiagrams.Name = "flowPanel_WiringDiagrams";
            this.flowPanel_WiringDiagrams.Size = new System.Drawing.Size(546, 227);
            this.flowPanel_WiringDiagrams.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(546, 50);
            this.panel9.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Roboto Medium", 12.90566F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 48);
            this.label8.TabIndex = 0;
            this.label8.Text = "  Wiring Diagram";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_Editor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 880);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Editor1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Editor1";
            this.Load += new System.EventHandler(this.frm_Editor1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HeaderDetails)).EndInit();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowPanel_Symbols.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private XanderUI.XUIButton xuiButton5;
        private XanderUI.XUIButton btn_AddHeader;
        private System.Windows.Forms.DataGridView dgv_HeaderDetails;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private XanderUI.XUIButton xuiButton6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private XanderUI.XUICheckBox xuiCheckBox4;
        private XanderUI.XUICheckBox xuiCheckBox5;
        private XanderUI.XUICheckBox xuiCheckBox10;
        private XanderUI.XUICheckBox xuiCheckBox11;
        private XanderUI.XUICheckBox xuiCheckBox12;
        private XanderUI.XUICheckBox xuiCheckBox13;
        private System.Windows.Forms.FlowLayoutPanel flowPanel_Symbols;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lab_ProductFamily;
        private XanderUI.XUIButton btn_CopyToDraft;
        private XanderUI.XUIButton btn_Save;
        private XanderUI.XUIButton btn_DownloadPDF;
        private XanderUI.XUIButton btn_SaveAsDraft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowPanel_ProductImages;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowPanel_DimensionalDrawings;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel flowPanel_WiringDiagrams;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
    }
}