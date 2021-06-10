namespace DatasheetGenerator.ModuleManager
{
    partial class frm_Subheader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Subheader));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SubHeaderName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Values = new System.Windows.Forms.DataGridView();
            this.BundleDetailItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_AddValue = new XanderUI.XUIButton();
            this.btn_Delete = new XanderUI.XUIButton();
            this.btn_Exit = new XanderUI.XUIButton();
            this.btn_Save = new XanderUI.XUIButton();
            this.btn_New = new XanderUI.XUIButton();
            this.btn_Edit = new XanderUI.XUIButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Find = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_Subheader = new System.Windows.Forms.DataGridView();
            this.SubheaderMasterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubheaderMasterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubheaderMasterActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Value = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Values)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Subheader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 21.73585F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 45);
            this.label1.TabIndex = 34;
            this.label1.Text = "Subheader";
            // 
            // txt_SubHeaderName
            // 
            this.txt_SubHeaderName.Depth = 0;
            this.txt_SubHeaderName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_SubHeaderName.Hint = "";
            this.txt_SubHeaderName.Location = new System.Drawing.Point(61, 141);
            this.txt_SubHeaderName.MaxLength = 32767;
            this.txt_SubHeaderName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_SubHeaderName.Name = "txt_SubHeaderName";
            this.txt_SubHeaderName.PasswordChar = '\0';
            this.txt_SubHeaderName.SelectedText = "";
            this.txt_SubHeaderName.SelectionLength = 0;
            this.txt_SubHeaderName.SelectionStart = 0;
            this.txt_SubHeaderName.Size = new System.Drawing.Size(349, 25);
            this.txt_SubHeaderName.TabIndex = 31;
            this.txt_SubHeaderName.TabStop = false;
            this.txt_SubHeaderName.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label7.Location = new System.Drawing.Point(61, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Name";
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 30;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(61, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Value";
            // 
            // dgv_Values
            // 
            this.dgv_Values.AllowUserToAddRows = false;
            this.dgv_Values.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgv_Values.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Values.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Values.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Values.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Values.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Values.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BundleDetailItemName,
            this.Remove});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Values.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Values.Location = new System.Drawing.Point(438, 65);
            this.dgv_Values.Name = "dgv_Values";
            this.dgv_Values.ReadOnly = true;
            this.dgv_Values.RowTemplate.Height = 35;
            this.dgv_Values.Size = new System.Drawing.Size(320, 268);
            this.dgv_Values.TabIndex = 247;
            this.dgv_Values.TabStop = false;
            // 
            // BundleDetailItemName
            // 
            this.BundleDetailItemName.DataPropertyName = "BundleDetailItemName";
            this.BundleDetailItemName.FillWeight = 131.9797F;
            this.BundleDetailItemName.HeaderText = "Values";
            this.BundleDetailItemName.Name = "BundleDetailItemName";
            this.BundleDetailItemName.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.DataPropertyName = "Remove";
            this.Remove.FillWeight = 68.02031F;
            this.Remove.HeaderText = "";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // btn_AddValue
            // 
            this.btn_AddValue.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AddValue.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_AddValue.ButtonImage")));
            this.btn_AddValue.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_AddValue.ButtonText = "";
            this.btn_AddValue.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AddValue.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AddValue.CornerRadius = 50;
            this.btn_AddValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_AddValue.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddValue.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AddValue.HoverTextColor = System.Drawing.Color.White;
            this.btn_AddValue.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_AddValue.Location = new System.Drawing.Point(374, 215);
            this.btn_AddValue.Name = "btn_AddValue";
            this.btn_AddValue.Size = new System.Drawing.Size(36, 36);
            this.btn_AddValue.TabIndex = 38;
            this.btn_AddValue.TextColor = System.Drawing.Color.White;
            this.btn_AddValue.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddValue.Click += new System.EventHandler(this.btn_AddValue_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.btn_Delete.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ButtonImage")));
            this.btn_Delete.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Delete.ButtonText = "Delete";
            this.btn_Delete.ClickBackColor = System.Drawing.Color.White;
            this.btn_Delete.ClickTextColor = System.Drawing.Color.White;
            this.btn_Delete.CornerRadius = 5;
            this.btn_Delete.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_Delete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Delete.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Delete.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.btn_Delete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Delete.Location = new System.Drawing.Point(782, 238);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(160, 42);
            this.btn_Delete.TabIndex = 37;
            this.btn_Delete.TextColor = System.Drawing.Color.White;
            this.btn_Delete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.BackgroundColor = System.Drawing.Color.WhiteSmoke;
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
            this.btn_Exit.Location = new System.Drawing.Point(982, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(36, 36);
            this.btn_Exit.TabIndex = 36;
            this.btn_Exit.TextColor = System.Drawing.Color.White;
            this.btn_Exit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Save.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Save.ButtonImage")));
            this.btn_Save.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.ClickBackColor = System.Drawing.Color.White;
            this.btn_Save.ClickTextColor = System.Drawing.Color.White;
            this.btn_Save.CornerRadius = 5;
            this.btn_Save.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_Save.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Save.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Save.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Save.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Save.Location = new System.Drawing.Point(782, 190);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(160, 42);
            this.btn_Save.TabIndex = 35;
            this.btn_Save.TextColor = System.Drawing.Color.White;
            this.btn_Save.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_New.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.btn_New.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_New.ButtonImage")));
            this.btn_New.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_New.ButtonText = "New";
            this.btn_New.ClickBackColor = System.Drawing.Color.White;
            this.btn_New.ClickTextColor = System.Drawing.Color.White;
            this.btn_New.CornerRadius = 5;
            this.btn_New.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.btn_New.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_New.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_New.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.btn_New.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_New.Location = new System.Drawing.Point(782, 91);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(160, 42);
            this.btn_New.TabIndex = 248;
            this.btn_New.TextColor = System.Drawing.Color.White;
            this.btn_New.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Edit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.btn_Edit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Edit.ButtonImage")));
            this.btn_Edit.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Edit.ButtonText = "Edit";
            this.btn_Edit.ClickBackColor = System.Drawing.Color.White;
            this.btn_Edit.ClickTextColor = System.Drawing.Color.White;
            this.btn_Edit.CornerRadius = 5;
            this.btn_Edit.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.btn_Edit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Edit.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Edit.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.btn_Edit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Edit.Location = new System.Drawing.Point(782, 141);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(160, 42);
            this.btn_Edit.TabIndex = 249;
            this.btn_Edit.TextColor = System.Drawing.Color.White;
            this.btn_Edit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgv_Subheader);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.groupBox1.Location = new System.Drawing.Point(61, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 340);
            this.groupBox1.TabIndex = 250;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Existing Subheaders";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Find);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(130, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 52);
            this.groupBox2.TabIndex = 249;
            this.groupBox2.TabStop = false;
            // 
            // txt_Find
            // 
            this.txt_Find.Depth = 0;
            this.txt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Find.Hint = "";
            this.txt_Find.Location = new System.Drawing.Point(6, 23);
            this.txt_Find.MaxLength = 32767;
            this.txt_Find.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.PasswordChar = '\0';
            this.txt_Find.SelectedText = "";
            this.txt_Find.SelectionLength = 0;
            this.txt_Find.SelectionStart = 0;
            this.txt_Find.Size = new System.Drawing.Size(397, 25);
            this.txt_Find.TabIndex = 171;
            this.txt_Find.TabStop = false;
            this.txt_Find.UseSystemPasswordChar = false;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(409, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 170;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_Subheader
            // 
            this.dgv_Subheader.AllowUserToAddRows = false;
            this.dgv_Subheader.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgv_Subheader.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Subheader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Subheader.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Subheader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Subheader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubheaderMasterID,
            this.SubheaderMasterName,
            this.SubheaderMasterActive});
            this.dgv_Subheader.Location = new System.Drawing.Point(29, 86);
            this.dgv_Subheader.Name = "dgv_Subheader";
            this.dgv_Subheader.ReadOnly = true;
            this.dgv_Subheader.RowTemplate.Height = 35;
            this.dgv_Subheader.Size = new System.Drawing.Size(645, 236);
            this.dgv_Subheader.TabIndex = 248;
            this.dgv_Subheader.TabStop = false;
            this.dgv_Subheader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Subheader_CellContentClick);
            // 
            // SubheaderMasterID
            // 
            this.SubheaderMasterID.DataPropertyName = "SubheaderMasterID";
            this.SubheaderMasterID.HeaderText = "SubheaderMasterID";
            this.SubheaderMasterID.Name = "SubheaderMasterID";
            this.SubheaderMasterID.ReadOnly = true;
            this.SubheaderMasterID.Visible = false;
            // 
            // SubheaderMasterName
            // 
            this.SubheaderMasterName.DataPropertyName = "SubheaderMasterName";
            this.SubheaderMasterName.FillWeight = 131.9797F;
            this.SubheaderMasterName.HeaderText = "Subheader";
            this.SubheaderMasterName.Name = "SubheaderMasterName";
            this.SubheaderMasterName.ReadOnly = true;
            // 
            // SubheaderMasterActive
            // 
            this.SubheaderMasterActive.DataPropertyName = "SubheaderMasterActive";
            this.SubheaderMasterActive.HeaderText = "SubheaderMasterActive";
            this.SubheaderMasterActive.Name = "SubheaderMasterActive";
            this.SubheaderMasterActive.ReadOnly = true;
            this.SubheaderMasterActive.Visible = false;
            // 
            // txt_Value
            // 
            this.txt_Value.Depth = 0;
            this.txt_Value.Font = new System.Drawing.Font("Roboto", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Value.Hint = "";
            this.txt_Value.Location = new System.Drawing.Point(61, 221);
            this.txt_Value.MaxLength = 32767;
            this.txt_Value.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.PasswordChar = '\0';
            this.txt_Value.SelectedText = "";
            this.txt_Value.SelectionLength = 0;
            this.txt_Value.SelectionStart = 0;
            this.txt_Value.Size = new System.Drawing.Size(307, 25);
            this.txt_Value.TabIndex = 39;
            this.txt_Value.TabStop = false;
            this.txt_Value.UseSystemPasswordChar = false;
            // 
            // frm_Subheader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 726);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.dgv_Values);
            this.Controls.Add(this.txt_Value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SubHeaderName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_AddValue);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Subheader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Subheader";
            this.Activated += new System.EventHandler(this.frm_Subheader_Activated);
            this.Load += new System.EventHandler(this.frm_Subheader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Values)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Subheader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_SubHeaderName;
        private System.Windows.Forms.Label label7;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private XanderUI.XUIButton btn_Delete;
        private XanderUI.XUIButton btn_Exit;
        private XanderUI.XUIButton btn_Save;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton btn_AddValue;
        private System.Windows.Forms.DataGridView dgv_Values;
        private System.Windows.Forms.DataGridViewTextBoxColumn BundleDetailItemName;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private XanderUI.XUIButton btn_New;
        private XanderUI.XUIButton btn_Edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Find;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_Subheader;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubheaderMasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubheaderMasterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubheaderMasterActive;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Value;
    }
}