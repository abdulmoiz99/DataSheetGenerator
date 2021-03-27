namespace DatasheetGenerator
{
    partial class frm_MediaLibrary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MediaLibrary));
            this.dgv_Media = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_New = new XanderUI.XUIButton();
            this.btn_ReplaceImage = new XanderUI.XUIButton();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Description = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_Save = new XanderUI.XUIButton();
            this.btn_Edit = new XanderUI.XUIButton();
            this.btn_Cancel = new XanderUI.XUIButton();
            this.btn_Delete = new XanderUI.XUIButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Close = new XanderUI.XUIButton();
            this.btn_Symbol = new XanderUI.XUIButton();
            this.btn_ProductImages = new XanderUI.XUIButton();
            this.btn_DimensionalDrawings = new XanderUI.XUIButton();
            this.btnm_WiringDrawings = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Media)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Media
            // 
            this.dgv_Media.AllowUserToAddRows = false;
            this.dgv_Media.AllowUserToDeleteRows = false;
            this.dgv_Media.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Media.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.86792F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Media.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Media.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Media.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name1,
            this.Description,
            this.Image1,
            this.Type,
            this.Active});
            this.dgv_Media.Location = new System.Drawing.Point(54, 442);
            this.dgv_Media.MultiSelect = false;
            this.dgv_Media.Name = "dgv_Media";
            this.dgv_Media.ReadOnly = true;
            this.dgv_Media.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto Slab Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Media.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.dgv_Media.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.dgv_Media.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Media.RowTemplate.Height = 30;
            this.dgv_Media.RowTemplate.ReadOnly = true;
            this.dgv_Media.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Media.Size = new System.Drawing.Size(694, 299);
            this.dgv_Media.TabIndex = 31;
            this.dgv_Media.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Media_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Name1
            // 
            this.Name1.DataPropertyName = "Name";
            this.Name1.FillWeight = 101.5228F;
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 98.47716F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Image1
            // 
            this.Image1.DataPropertyName = "Image";
            this.Image1.HeaderText = "Image";
            this.Image1.Name = "Image1";
            this.Image1.ReadOnly = true;
            this.Image1.Visible = false;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(50, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Name";
            // 
            // btn_New
            // 
            this.btn_New.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(192)))));
            this.btn_New.ButtonImage = null;
            this.btn_New.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_New.ButtonText = "New";
            this.btn_New.ClickBackColor = System.Drawing.Color.Gainsboro;
            this.btn_New.ClickTextColor = System.Drawing.Color.White;
            this.btn_New.CornerRadius = 5;
            this.btn_New.Font = new System.Drawing.Font("Roboto", 14F);
            this.btn_New.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_New.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_New.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.btn_New.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_New.Location = new System.Drawing.Point(3, 3);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(209, 36);
            this.btn_New.TabIndex = 29;
            this.btn_New.TextColor = System.Drawing.Color.White;
            this.btn_New.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_ReplaceImage
            // 
            this.btn_ReplaceImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_ReplaceImage.ButtonImage = null;
            this.btn_ReplaceImage.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_ReplaceImage.ButtonText = "Replace";
            this.btn_ReplaceImage.ClickBackColor = System.Drawing.Color.White;
            this.btn_ReplaceImage.ClickTextColor = System.Drawing.Color.White;
            this.btn_ReplaceImage.CornerRadius = 5;
            this.btn_ReplaceImage.Font = new System.Drawing.Font("Roboto", 13F);
            this.btn_ReplaceImage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_ReplaceImage.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_ReplaceImage.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_ReplaceImage.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_ReplaceImage.Location = new System.Drawing.Point(570, 382);
            this.btn_ReplaceImage.Name = "btn_ReplaceImage";
            this.btn_ReplaceImage.Size = new System.Drawing.Size(178, 36);
            this.btn_ReplaceImage.TabIndex = 27;
            this.btn_ReplaceImage.TextColor = System.Drawing.Color.White;
            this.btn_ReplaceImage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_ReplaceImage.Click += new System.EventHandler(this.btn_ReplaceImage_Click);
            // 
            // pb_Image
            // 
            this.pb_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Image.Image = ((System.Drawing.Image)(resources.GetObject("pb_Image.Image")));
            this.pb_Image.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_Image.InitialImage")));
            this.pb_Image.Location = new System.Drawing.Point(570, 203);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(178, 173);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Image.TabIndex = 26;
            this.pb_Image.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(50, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Description";
            // 
            // txt_Name
            // 
            this.txt_Name.Depth = 0;
            this.txt_Name.Hint = "";
            this.txt_Name.Location = new System.Drawing.Point(54, 251);
            this.txt_Name.MaxLength = 32767;
            this.txt_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.SelectedText = "";
            this.txt_Name.SelectionLength = 0;
            this.txt_Name.SelectionStart = 0;
            this.txt_Name.Size = new System.Drawing.Size(482, 23);
            this.txt_Name.TabIndex = 1;
            this.txt_Name.TabStop = false;
            this.txt_Name.UseSystemPasswordChar = false;
            // 
            // txt_Description
            // 
            this.txt_Description.Depth = 0;
            this.txt_Description.Hint = "";
            this.txt_Description.Location = new System.Drawing.Point(54, 335);
            this.txt_Description.MaxLength = 32767;
            this.txt_Description.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.PasswordChar = '\0';
            this.txt_Description.SelectedText = "";
            this.txt_Description.SelectionLength = 0;
            this.txt_Description.SelectionStart = 0;
            this.txt_Description.Size = new System.Drawing.Size(482, 23);
            this.txt_Description.TabIndex = 2;
            this.txt_Description.TabStop = false;
            this.txt_Description.UseSystemPasswordChar = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(192)))));
            this.btn_Save.ButtonImage = null;
            this.btn_Save.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.ClickBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Save.ClickTextColor = System.Drawing.Color.White;
            this.btn_Save.CornerRadius = 5;
            this.btn_Save.Font = new System.Drawing.Font("Roboto", 14F);
            this.btn_Save.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Save.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_Save.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.btn_Save.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Save.Location = new System.Drawing.Point(3, 87);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(209, 36);
            this.btn_Save.TabIndex = 35;
            this.btn_Save.TextColor = System.Drawing.Color.White;
            this.btn_Save.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(192)))));
            this.btn_Edit.ButtonImage = null;
            this.btn_Edit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Edit.ButtonText = "Edit";
            this.btn_Edit.ClickBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Edit.ClickTextColor = System.Drawing.Color.White;
            this.btn_Edit.CornerRadius = 5;
            this.btn_Edit.Font = new System.Drawing.Font("Roboto", 14F);
            this.btn_Edit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Edit.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_Edit.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.btn_Edit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Edit.Location = new System.Drawing.Point(3, 45);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(209, 36);
            this.btn_Edit.TabIndex = 36;
            this.btn_Edit.TextColor = System.Drawing.Color.White;
            this.btn_Edit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(192)))));
            this.btn_Cancel.ButtonImage = null;
            this.btn_Cancel.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Cancel.ButtonText = "Cancel";
            this.btn_Cancel.ClickBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Cancel.ClickTextColor = System.Drawing.Color.White;
            this.btn_Cancel.CornerRadius = 5;
            this.btn_Cancel.Font = new System.Drawing.Font("Roboto", 14F);
            this.btn_Cancel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Cancel.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_Cancel.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.btn_Cancel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Cancel.Location = new System.Drawing.Point(3, 129);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(209, 36);
            this.btn_Cancel.TabIndex = 37;
            this.btn_Cancel.TextColor = System.Drawing.Color.White;
            this.btn_Cancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(192)))));
            this.btn_Delete.ButtonImage = null;
            this.btn_Delete.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Delete.ButtonText = "Delete";
            this.btn_Delete.ClickBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Delete.ClickTextColor = System.Drawing.Color.White;
            this.btn_Delete.CornerRadius = 5;
            this.btn_Delete.Font = new System.Drawing.Font("Roboto", 14F);
            this.btn_Delete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Delete.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_Delete.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(192)))));
            this.btn_Delete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Delete.Location = new System.Drawing.Point(3, 171);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(209, 36);
            this.btn_Delete.TabIndex = 38;
            this.btn_Delete.TextColor = System.Drawing.Color.White;
            this.btn_Delete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Delete.Visible = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_New);
            this.flowLayoutPanel1.Controls.Add(this.btn_Edit);
            this.flowLayoutPanel1.Controls.Add(this.btn_Save);
            this.flowLayoutPanel1.Controls.Add(this.btn_Cancel);
            this.flowLayoutPanel1.Controls.Add(this.btn_Delete);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(775, 203);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(224, 261);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Slab", 29F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(30, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 53);
            this.label2.TabIndex = 40;
            this.label2.Text = "Media Library";
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Close.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.ButtonImage")));
            this.btn_Close.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Close.ButtonText = "";
            this.btn_Close.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn_Close.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Close.CornerRadius = 5;
            this.btn_Close.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Close.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_Close.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Close.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Close.Location = new System.Drawing.Point(1013, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(39, 39);
            this.btn_Close.TabIndex = 41;
            this.btn_Close.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Close.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Symbol
            // 
            this.btn_Symbol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_Symbol.ButtonImage = null;
            this.btn_Symbol.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Symbol.ButtonText = "Symbol";
            this.btn_Symbol.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_Symbol.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_Symbol.CornerRadius = 5;
            this.btn_Symbol.Font = new System.Drawing.Font("Roboto", 13F);
            this.btn_Symbol.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Symbol.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_Symbol.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_Symbol.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Symbol.Location = new System.Drawing.Point(111, 117);
            this.btn_Symbol.Name = "btn_Symbol";
            this.btn_Symbol.Size = new System.Drawing.Size(185, 36);
            this.btn_Symbol.TabIndex = 42;
            this.btn_Symbol.TextColor = System.Drawing.Color.White;
            this.btn_Symbol.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Symbol.Click += new System.EventHandler(this.btn_Symbol_Click);
            // 
            // btn_ProductImages
            // 
            this.btn_ProductImages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_ProductImages.ButtonImage = null;
            this.btn_ProductImages.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_ProductImages.ButtonText = "Product Images";
            this.btn_ProductImages.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_ProductImages.ClickTextColor = System.Drawing.Color.White;
            this.btn_ProductImages.CornerRadius = 5;
            this.btn_ProductImages.Font = new System.Drawing.Font("Roboto", 13F);
            this.btn_ProductImages.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_ProductImages.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_ProductImages.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_ProductImages.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_ProductImages.Location = new System.Drawing.Point(521, 117);
            this.btn_ProductImages.Name = "btn_ProductImages";
            this.btn_ProductImages.Size = new System.Drawing.Size(198, 36);
            this.btn_ProductImages.TabIndex = 45;
            this.btn_ProductImages.TextColor = System.Drawing.Color.White;
            this.btn_ProductImages.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_ProductImages.Click += new System.EventHandler(this.btn_ProductImages_Click);
            // 
            // btn_DimensionalDrawings
            // 
            this.btn_DimensionalDrawings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_DimensionalDrawings.ButtonImage = null;
            this.btn_DimensionalDrawings.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_DimensionalDrawings.ButtonText = "Dimensional Drawings";
            this.btn_DimensionalDrawings.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_DimensionalDrawings.ClickTextColor = System.Drawing.Color.White;
            this.btn_DimensionalDrawings.CornerRadius = 5;
            this.btn_DimensionalDrawings.Font = new System.Drawing.Font("Roboto", 13F);
            this.btn_DimensionalDrawings.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_DimensionalDrawings.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_DimensionalDrawings.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_DimensionalDrawings.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_DimensionalDrawings.Location = new System.Drawing.Point(297, 117);
            this.btn_DimensionalDrawings.Name = "btn_DimensionalDrawings";
            this.btn_DimensionalDrawings.Size = new System.Drawing.Size(224, 36);
            this.btn_DimensionalDrawings.TabIndex = 46;
            this.btn_DimensionalDrawings.TextColor = System.Drawing.Color.White;
            this.btn_DimensionalDrawings.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_DimensionalDrawings.Click += new System.EventHandler(this.btn_DimensionalDrawings_Click);
            // 
            // btnm_WiringDrawings
            // 
            this.btnm_WiringDrawings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnm_WiringDrawings.ButtonImage = null;
            this.btnm_WiringDrawings.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnm_WiringDrawings.ButtonText = "Wiring Drawings";
            this.btnm_WiringDrawings.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnm_WiringDrawings.ClickTextColor = System.Drawing.Color.White;
            this.btnm_WiringDrawings.CornerRadius = 5;
            this.btnm_WiringDrawings.Font = new System.Drawing.Font("Roboto", 13F);
            this.btnm_WiringDrawings.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnm_WiringDrawings.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnm_WiringDrawings.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnm_WiringDrawings.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnm_WiringDrawings.Location = new System.Drawing.Point(718, 117);
            this.btnm_WiringDrawings.Name = "btnm_WiringDrawings";
            this.btnm_WiringDrawings.Size = new System.Drawing.Size(201, 36);
            this.btnm_WiringDrawings.TabIndex = 47;
            this.btnm_WiringDrawings.TextColor = System.Drawing.Color.White;
            this.btnm_WiringDrawings.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnm_WiringDrawings.Click += new System.EventHandler(this.btnm_WiringDrawings_Click);
            // 
            // frm_MediaLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1064, 779);
            this.Controls.Add(this.btnm_WiringDrawings);
            this.Controls.Add(this.btn_DimensionalDrawings);
            this.Controls.Add(this.btn_ProductImages);
            this.Controls.Add(this.btn_Symbol);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Media);
            this.Controls.Add(this.btn_ReplaceImage);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MediaLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MediaLibrary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_MediaLibrary_FormClosing);
            this.Load += new System.EventHandler(this.frm_MediaLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Media)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Media;
        private XanderUI.XUIButton btn_New;
        private XanderUI.XUIButton btn_ReplaceImage;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Name;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Description;
        private XanderUI.XUIButton btn_Save;
        private XanderUI.XUIButton btn_Edit;
        private XanderUI.XUIButton btn_Cancel;
        private XanderUI.XUIButton btn_Delete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton btn_Close;
        private XanderUI.XUIButton btn_Symbol;
        private XanderUI.XUIButton btn_ProductImages;
        private XanderUI.XUIButton btn_DimensionalDrawings;
        private XanderUI.XUIButton btnm_WiringDrawings;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewImageColumn Image1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
    }
}