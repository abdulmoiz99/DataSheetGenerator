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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MediaLibrary));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.btn_Insert = new XanderUI.XUIButton();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Clear = new XanderUI.XUIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Images = new System.Windows.Forms.DataGridView();
            this.dialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_Update = new XanderUI.XUIButton();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.cmb_Types = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Upload = new XanderUI.XUIButton();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Images)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 29F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Media Library";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Slab", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Image Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(158, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageBox.InitialImage")));
            this.imageBox.Location = new System.Drawing.Point(610, 329);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(200, 200);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 4;
            this.imageBox.TabStop = false;
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Insert.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Insert.ButtonImage")));
            this.btn_Insert.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Insert.ButtonText = "Insert";
            this.btn_Insert.ClickBackColor = System.Drawing.Color.White;
            this.btn_Insert.ClickTextColor = System.Drawing.Color.White;
            this.btn_Insert.CornerRadius = 5;
            this.btn_Insert.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_Insert.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Insert.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Insert.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Insert.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Insert.Location = new System.Drawing.Point(610, 245);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(200, 36);
            this.btn_Insert.TabIndex = 6;
            this.btn_Insert.TextColor = System.Drawing.Color.White;
            this.btn_Insert.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(780, 203);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(30, 36);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Roboto Slab", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txt_Name.Location = new System.Drawing.Point(219, 199);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(299, 29);
            this.txt_Name.TabIndex = 9;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Clear.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Clear.ButtonImage")));
            this.btn_Clear.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Clear.ButtonText = "Clear";
            this.btn_Clear.ClickBackColor = System.Drawing.Color.White;
            this.btn_Clear.ClickTextColor = System.Drawing.Color.White;
            this.btn_Clear.CornerRadius = 5;
            this.btn_Clear.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_Clear.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Clear.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Clear.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Clear.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Clear.Location = new System.Drawing.Point(610, 203);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(164, 36);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.TextColor = System.Drawing.Color.White;
            this.btn_Clear.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Slab", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label4.Location = new System.Drawing.Point(896, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Image List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.panel1.Location = new System.Drawing.Point(34, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 3);
            this.panel1.TabIndex = 13;
            // 
            // dgv_Images
            // 
            this.dgv_Images.AllowUserToAddRows = false;
            this.dgv_Images.AllowUserToDeleteRows = false;
            this.dgv_Images.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Images.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Images.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Images.ColumnHeadersVisible = false;
            this.dgv_Images.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.description,
            this.type,
            this.image});
            this.dgv_Images.Location = new System.Drawing.Point(901, 224);
            this.dgv_Images.MultiSelect = false;
            this.dgv_Images.Name = "dgv_Images";
            this.dgv_Images.ReadOnly = true;
            this.dgv_Images.RowHeadersVisible = false;
            this.dgv_Images.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto Slab Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Images.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.dgv_Images.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.dgv_Images.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Images.RowTemplate.Height = 30;
            this.dgv_Images.RowTemplate.ReadOnly = true;
            this.dgv_Images.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Images.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Images.Size = new System.Drawing.Size(357, 347);
            this.dgv_Images.TabIndex = 24;
            this.dgv_Images.SelectionChanged += new System.EventHandler(this.dgv_Images_SelectionChanged);
            // 
            // dialog
            // 
            this.dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            this.dialog.RestoreDirectory = true;
            // 
            // btn_Update
            // 
            this.btn_Update.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Update.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Update.ButtonImage")));
            this.btn_Update.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Update.ButtonText = "Update";
            this.btn_Update.ClickBackColor = System.Drawing.Color.White;
            this.btn_Update.ClickTextColor = System.Drawing.Color.White;
            this.btn_Update.CornerRadius = 5;
            this.btn_Update.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_Update.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Update.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Update.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Update.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Update.Location = new System.Drawing.Point(610, 287);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(200, 36);
            this.btn_Update.TabIndex = 25;
            this.btn_Update.TextColor = System.Drawing.Color.White;
            this.btn_Update.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_Description
            // 
            this.txt_Description.Font = new System.Drawing.Font("Roboto Slab", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txt_Description.Location = new System.Drawing.Point(219, 245);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(299, 151);
            this.txt_Description.TabIndex = 26;
            // 
            // cmb_Types
            // 
            this.cmb_Types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Types.Font = new System.Drawing.Font("Roboto Slab", 12.22642F);
            this.cmb_Types.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.cmb_Types.FormattingEnabled = true;
            this.cmb_Types.Items.AddRange(new object[] {
            "Symbol",
            "Product Image",
            "Dimension Drawing",
            "Wiring Diagram"});
            this.cmb_Types.Location = new System.Drawing.Point(219, 416);
            this.cmb_Types.Name = "cmb_Types";
            this.cmb_Types.Size = new System.Drawing.Size(299, 30);
            this.cmb_Types.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label5.Location = new System.Drawing.Point(116, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label6.Location = new System.Drawing.Point(165, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Type";
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Upload.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Upload.ButtonImage")));
            this.btn_Upload.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Upload.ButtonText = "Upload";
            this.btn_Upload.ClickBackColor = System.Drawing.Color.White;
            this.btn_Upload.ClickTextColor = System.Drawing.Color.White;
            this.btn_Upload.CornerRadius = 5;
            this.btn_Upload.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_Upload.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Upload.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Upload.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Upload.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Upload.Location = new System.Drawing.Point(610, 535);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(200, 36);
            this.btn_Upload.TabIndex = 30;
            this.btn_Upload.TextColor = System.Drawing.Color.White;
            this.btn_Upload.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("Roboto Slab", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txt_ID.Location = new System.Drawing.Point(455, 152);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(63, 29);
            this.txt_ID.TabIndex = 31;
            this.txt_ID.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // type
            // 
            this.type.DataPropertyName = "Type";
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Visible = false;
            // 
            // image
            // 
            this.image.DataPropertyName = "Image";
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.image.Visible = false;
            // 
            // frm_MediaLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1391, 846);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Types);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dgv_Images);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MediaLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Library";
            this.Load += new System.EventHandler(this.frm_MediaLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Images)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imageBox;
        private XanderUI.XUIButton btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_Name;
        private XanderUI.XUIButton btn_Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Images;
        private System.Windows.Forms.OpenFileDialog dialog;
        private XanderUI.XUIButton btn_Update;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.ComboBox cmb_Types;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private XanderUI.XUIButton btn_Upload;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}