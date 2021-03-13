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
            this.dgv_Media = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Add = new XanderUI.XUIButton();
            this.btn_ReplaceSymbol = new XanderUI.XUIButton();
            this.symbolBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_Save = new XanderUI.XUIButton();
            this.btn_Edit = new XanderUI.XUIButton();
            this.btn_Cancel = new XanderUI.XUIButton();
            this.btn_Delete = new XanderUI.XUIButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Media)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Media
            // 
            this.dgv_Media.AllowUserToAddRows = false;
            this.dgv_Media.AllowUserToDeleteRows = false;
            this.dgv_Media.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Media.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Media.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Media.ColumnHeadersVisible = false;
            this.dgv_Media.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Description,
            this.Image});
            this.dgv_Media.Location = new System.Drawing.Point(40, 359);
            this.dgv_Media.MultiSelect = false;
            this.dgv_Media.Name = "dgv_Media";
            this.dgv_Media.ReadOnly = true;
            this.dgv_Media.RowHeadersVisible = false;
            this.dgv_Media.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto Slab Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Media.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.dgv_Media.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.dgv_Media.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Media.RowTemplate.Height = 30;
            this.dgv_Media.RowTemplate.ReadOnly = true;
            this.dgv_Media.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Media.Size = new System.Drawing.Size(581, 299);
            this.dgv_Media.TabIndex = 31;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(36, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Name";
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.btn_Add.ButtonImage = null;
            this.btn_Add.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Add.ButtonText = "Add";
            this.btn_Add.ClickBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Add.ClickTextColor = System.Drawing.Color.White;
            this.btn_Add.CornerRadius = 5;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Add.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Add.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_Add.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.btn_Add.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Add.Location = new System.Drawing.Point(3, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(209, 36);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.TextColor = System.Drawing.Color.White;
            this.btn_Add.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_ReplaceSymbol
            // 
            this.btn_ReplaceSymbol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_ReplaceSymbol.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_ReplaceSymbol.ButtonImage")));
            this.btn_ReplaceSymbol.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_ReplaceSymbol.ButtonText = "Replace";
            this.btn_ReplaceSymbol.ClickBackColor = System.Drawing.Color.White;
            this.btn_ReplaceSymbol.ClickTextColor = System.Drawing.Color.White;
            this.btn_ReplaceSymbol.CornerRadius = 5;
            this.btn_ReplaceSymbol.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_ReplaceSymbol.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_ReplaceSymbol.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_ReplaceSymbol.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_ReplaceSymbol.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_ReplaceSymbol.Location = new System.Drawing.Point(443, 307);
            this.btn_ReplaceSymbol.Name = "btn_ReplaceSymbol";
            this.btn_ReplaceSymbol.Size = new System.Drawing.Size(178, 36);
            this.btn_ReplaceSymbol.TabIndex = 27;
            this.btn_ReplaceSymbol.TextColor = System.Drawing.Color.White;
            this.btn_ReplaceSymbol.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // symbolBox
            // 
            this.symbolBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.symbolBox.Image = ((System.Drawing.Image)(resources.GetObject("symbolBox.Image")));
            this.symbolBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("symbolBox.InitialImage")));
            this.symbolBox.Location = new System.Drawing.Point(443, 128);
            this.symbolBox.Name = "symbolBox";
            this.symbolBox.Size = new System.Drawing.Size(178, 173);
            this.symbolBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.symbolBox.TabIndex = 26;
            this.symbolBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(36, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Description";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(40, 168);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(356, 25);
            this.materialSingleLineTextField1.TabIndex = 33;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.Text = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(40, 249);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(356, 25);
            this.materialSingleLineTextField2.TabIndex = 34;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.Text = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.btn_Save.ButtonImage = null;
            this.btn_Save.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.ClickBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Save.ClickTextColor = System.Drawing.Color.White;
            this.btn_Save.CornerRadius = 5;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
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
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.btn_Edit.ButtonImage = null;
            this.btn_Edit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Edit.ButtonText = "Edit";
            this.btn_Edit.ClickBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Edit.ClickTextColor = System.Drawing.Color.White;
            this.btn_Edit.CornerRadius = 5;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
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
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.btn_Cancel.ButtonImage = null;
            this.btn_Cancel.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Cancel.ButtonText = "Cancel";
            this.btn_Cancel.ClickBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Cancel.ClickTextColor = System.Drawing.Color.White;
            this.btn_Cancel.CornerRadius = 5;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
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
            this.btn_Cancel.Click += new System.EventHandler(this.xuiButton3_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.btn_Delete.ButtonImage = null;
            this.btn_Delete.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_Delete.ButtonText = "Delete";
            this.btn_Delete.ClickBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Delete.ClickTextColor = System.Drawing.Color.White;
            this.btn_Delete.CornerRadius = 5;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_Delete.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Delete.HoverBackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_Delete.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(177)))));
            this.btn_Delete.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Delete.Location = new System.Drawing.Point(3, 171);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(209, 36);
            this.btn_Delete.TabIndex = 38;
            this.btn_Delete.TextColor = System.Drawing.Color.White;
            this.btn_Delete.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Delete.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Add);
            this.flowLayoutPanel1.Controls.Add(this.btn_Edit);
            this.flowLayoutPanel1.Controls.Add(this.btn_Save);
            this.flowLayoutPanel1.Controls.Add(this.btn_Cancel);
            this.flowLayoutPanel1.Controls.Add(this.btn_Delete);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(650, 136);
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
            this.label2.Size = new System.Drawing.Size(318, 58);
            this.label2.TabIndex = 40;
            this.label2.Text = "Media Library";
            // 
            // frm_MediaLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1128, 779);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Media);
            this.Controls.Add(this.btn_ReplaceSymbol);
            this.Controls.Add(this.symbolBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MediaLibrary";
            this.Load += new System.EventHandler(this.frm_MediaLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Media)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbolBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Media;
        private XanderUI.XUIButton btn_Add;
        private XanderUI.XUIButton btn_ReplaceSymbol;
        private System.Windows.Forms.PictureBox symbolBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private XanderUI.XUIButton btn_Save;
        private XanderUI.XUIButton btn_Edit;
        private XanderUI.XUIButton btn_Cancel;
        private XanderUI.XUIButton btn_Delete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}