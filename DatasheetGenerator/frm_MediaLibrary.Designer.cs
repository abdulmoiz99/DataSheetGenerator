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
            this.symbolBox = new System.Windows.Forms.PictureBox();
            this.btn_AddSymbol = new XanderUI.XUIButton();
            this.btn_ReplaceSymbol = new XanderUI.XUIButton();
            this.btn_DeleteSymbol = new System.Windows.Forms.Button();
            this.txt_Symbol = new System.Windows.Forms.TextBox();
            this.btn_UpdateSymbol = new XanderUI.XUIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_UpdateImage = new XanderUI.XUIButton();
            this.txt_Image = new System.Windows.Forms.TextBox();
            this.btn_DeleteImage = new System.Windows.Forms.Button();
            this.btn_ReplaceImage = new XanderUI.XUIButton();
            this.btn_AddImage = new XanderUI.XUIButton();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_Symbol = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgv_Image = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.symbolBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Symbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 29F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 58);
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
            this.label2.Size = new System.Drawing.Size(128, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Symbols";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(406, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name of the Symbol";
            // 
            // symbolBox
            // 
            this.symbolBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.symbolBox.Image = ((System.Drawing.Image)(resources.GetObject("symbolBox.Image")));
            this.symbolBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("symbolBox.InitialImage")));
            this.symbolBox.Location = new System.Drawing.Point(427, 218);
            this.symbolBox.Name = "symbolBox";
            this.symbolBox.Size = new System.Drawing.Size(200, 200);
            this.symbolBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.symbolBox.TabIndex = 4;
            this.symbolBox.TabStop = false;
            // 
            // btn_AddSymbol
            // 
            this.btn_AddSymbol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_AddSymbol.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_AddSymbol.ButtonImage")));
            this.btn_AddSymbol.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_AddSymbol.ButtonText = "+ Add";
            this.btn_AddSymbol.ClickBackColor = System.Drawing.Color.White;
            this.btn_AddSymbol.ClickTextColor = System.Drawing.Color.White;
            this.btn_AddSymbol.CornerRadius = 5;
            this.btn_AddSymbol.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_AddSymbol.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddSymbol.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_AddSymbol.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_AddSymbol.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_AddSymbol.Location = new System.Drawing.Point(150, 133);
            this.btn_AddSymbol.Name = "btn_AddSymbol";
            this.btn_AddSymbol.Size = new System.Drawing.Size(112, 36);
            this.btn_AddSymbol.TabIndex = 6;
            this.btn_AddSymbol.TextColor = System.Drawing.Color.White;
            this.btn_AddSymbol.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddSymbol.Click += new System.EventHandler(this.xuiButton4_Click);
            // 
            // btn_ReplaceSymbol
            // 
            this.btn_ReplaceSymbol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_ReplaceSymbol.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_ReplaceSymbol.ButtonImage")));
            this.btn_ReplaceSymbol.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_ReplaceSymbol.ButtonText = "Replace the Symbol";
            this.btn_ReplaceSymbol.ClickBackColor = System.Drawing.Color.White;
            this.btn_ReplaceSymbol.ClickTextColor = System.Drawing.Color.White;
            this.btn_ReplaceSymbol.CornerRadius = 5;
            this.btn_ReplaceSymbol.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_ReplaceSymbol.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_ReplaceSymbol.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_ReplaceSymbol.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_ReplaceSymbol.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_ReplaceSymbol.Location = new System.Drawing.Point(406, 426);
            this.btn_ReplaceSymbol.Name = "btn_ReplaceSymbol";
            this.btn_ReplaceSymbol.Size = new System.Drawing.Size(245, 36);
            this.btn_ReplaceSymbol.TabIndex = 7;
            this.btn_ReplaceSymbol.TextColor = System.Drawing.Color.White;
            this.btn_ReplaceSymbol.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_ReplaceSymbol.Click += new System.EventHandler(this.btn_ReplaceSymbol_Click);
            // 
            // btn_DeleteSymbol
            // 
            this.btn_DeleteSymbol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DeleteSymbol.BackgroundImage")));
            this.btn_DeleteSymbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DeleteSymbol.FlatAppearance.BorderSize = 0;
            this.btn_DeleteSymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteSymbol.Location = new System.Drawing.Point(621, 529);
            this.btn_DeleteSymbol.Name = "btn_DeleteSymbol";
            this.btn_DeleteSymbol.Size = new System.Drawing.Size(30, 36);
            this.btn_DeleteSymbol.TabIndex = 8;
            this.btn_DeleteSymbol.UseVisualStyleBackColor = true;
            this.btn_DeleteSymbol.Click += new System.EventHandler(this.btn_DeleteSymbol_Click);
            // 
            // txt_Symbol
            // 
            this.txt_Symbol.Font = new System.Drawing.Font("Roboto Slab", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Symbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txt_Symbol.Location = new System.Drawing.Point(406, 492);
            this.txt_Symbol.Name = "txt_Symbol";
            this.txt_Symbol.Size = new System.Drawing.Size(245, 31);
            this.txt_Symbol.TabIndex = 9;
            this.txt_Symbol.TextChanged += new System.EventHandler(this.txt_Symbol_TextChanged);
            // 
            // btn_UpdateSymbol
            // 
            this.btn_UpdateSymbol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_UpdateSymbol.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_UpdateSymbol.ButtonImage")));
            this.btn_UpdateSymbol.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_UpdateSymbol.ButtonText = "Sync";
            this.btn_UpdateSymbol.ClickBackColor = System.Drawing.Color.White;
            this.btn_UpdateSymbol.ClickTextColor = System.Drawing.Color.White;
            this.btn_UpdateSymbol.CornerRadius = 5;
            this.btn_UpdateSymbol.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_UpdateSymbol.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_UpdateSymbol.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_UpdateSymbol.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_UpdateSymbol.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_UpdateSymbol.Location = new System.Drawing.Point(406, 529);
            this.btn_UpdateSymbol.Name = "btn_UpdateSymbol";
            this.btn_UpdateSymbol.Size = new System.Drawing.Size(209, 36);
            this.btn_UpdateSymbol.TabIndex = 10;
            this.btn_UpdateSymbol.TextColor = System.Drawing.Color.White;
            this.btn_UpdateSymbol.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_UpdateSymbol.Click += new System.EventHandler(this.btn_UpdateSymbol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Slab", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label4.Location = new System.Drawing.Point(29, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Symbols List";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.panel1.Location = new System.Drawing.Point(34, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1348, 3);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.panel2.Location = new System.Drawing.Point(701, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 447);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Slab", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label5.Location = new System.Drawing.Point(745, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Images List";
            // 
            // btn_UpdateImage
            // 
            this.btn_UpdateImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_UpdateImage.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_UpdateImage.ButtonImage")));
            this.btn_UpdateImage.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_UpdateImage.ButtonText = "Sync";
            this.btn_UpdateImage.ClickBackColor = System.Drawing.Color.White;
            this.btn_UpdateImage.ClickTextColor = System.Drawing.Color.White;
            this.btn_UpdateImage.CornerRadius = 5;
            this.btn_UpdateImage.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_UpdateImage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_UpdateImage.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_UpdateImage.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_UpdateImage.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_UpdateImage.Location = new System.Drawing.Point(1122, 529);
            this.btn_UpdateImage.Name = "btn_UpdateImage";
            this.btn_UpdateImage.Size = new System.Drawing.Size(209, 36);
            this.btn_UpdateImage.TabIndex = 22;
            this.btn_UpdateImage.TextColor = System.Drawing.Color.White;
            this.btn_UpdateImage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_UpdateImage.Click += new System.EventHandler(this.btn_UpdateImage_Click);
            // 
            // txt_Image
            // 
            this.txt_Image.Font = new System.Drawing.Font("Roboto Slab", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Image.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txt_Image.Location = new System.Drawing.Point(1122, 492);
            this.txt_Image.Name = "txt_Image";
            this.txt_Image.Size = new System.Drawing.Size(245, 31);
            this.txt_Image.TabIndex = 21;
            this.txt_Image.TextChanged += new System.EventHandler(this.txt_Image_TextChanged);
            // 
            // btn_DeleteImage
            // 
            this.btn_DeleteImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DeleteImage.BackgroundImage")));
            this.btn_DeleteImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DeleteImage.FlatAppearance.BorderSize = 0;
            this.btn_DeleteImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteImage.Location = new System.Drawing.Point(1337, 529);
            this.btn_DeleteImage.Name = "btn_DeleteImage";
            this.btn_DeleteImage.Size = new System.Drawing.Size(30, 36);
            this.btn_DeleteImage.TabIndex = 20;
            this.btn_DeleteImage.UseVisualStyleBackColor = true;
            this.btn_DeleteImage.Click += new System.EventHandler(this.btn_DeleteImage_Click);
            // 
            // btn_ReplaceImage
            // 
            this.btn_ReplaceImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_ReplaceImage.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_ReplaceImage.ButtonImage")));
            this.btn_ReplaceImage.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_ReplaceImage.ButtonText = "Replace the Image";
            this.btn_ReplaceImage.ClickBackColor = System.Drawing.Color.White;
            this.btn_ReplaceImage.ClickTextColor = System.Drawing.Color.White;
            this.btn_ReplaceImage.CornerRadius = 5;
            this.btn_ReplaceImage.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_ReplaceImage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_ReplaceImage.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_ReplaceImage.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btn_ReplaceImage.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_ReplaceImage.Location = new System.Drawing.Point(1122, 426);
            this.btn_ReplaceImage.Name = "btn_ReplaceImage";
            this.btn_ReplaceImage.Size = new System.Drawing.Size(245, 36);
            this.btn_ReplaceImage.TabIndex = 19;
            this.btn_ReplaceImage.TextColor = System.Drawing.Color.White;
            this.btn_ReplaceImage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_ReplaceImage.Click += new System.EventHandler(this.btn_ReplaceImage_Click);
            // 
            // btn_AddImage
            // 
            this.btn_AddImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_AddImage.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_AddImage.ButtonImage")));
            this.btn_AddImage.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_AddImage.ButtonText = "+ Add";
            this.btn_AddImage.ClickBackColor = System.Drawing.Color.White;
            this.btn_AddImage.ClickTextColor = System.Drawing.Color.White;
            this.btn_AddImage.CornerRadius = 5;
            this.btn_AddImage.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_AddImage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddImage.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_AddImage.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_AddImage.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_AddImage.Location = new System.Drawing.Point(846, 133);
            this.btn_AddImage.Name = "btn_AddImage";
            this.btn_AddImage.Size = new System.Drawing.Size(112, 36);
            this.btn_AddImage.TabIndex = 18;
            this.btn_AddImage.TextColor = System.Drawing.Color.White;
            this.btn_AddImage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddImage.Click += new System.EventHandler(this.btn_AddImage_Click);
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Image = ((System.Drawing.Image)(resources.GetObject("imageBox.Image")));
            this.imageBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageBox.InitialImage")));
            this.imageBox.Location = new System.Drawing.Point(1142, 218);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(200, 200);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 17;
            this.imageBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label6.Location = new System.Drawing.Point(1122, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Image Caption";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Slab", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(732, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 36);
            this.label7.TabIndex = 15;
            this.label7.Text = "Images";
            // 
            // dgv_Symbol
            // 
            this.dgv_Symbol.AllowUserToAddRows = false;
            this.dgv_Symbol.AllowUserToDeleteRows = false;
            this.dgv_Symbol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Symbol.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Symbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Symbol.ColumnHeadersVisible = false;
            this.dgv_Symbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.image});
            this.dgv_Symbol.Location = new System.Drawing.Point(34, 218);
            this.dgv_Symbol.MultiSelect = false;
            this.dgv_Symbol.Name = "dgv_Symbol";
            this.dgv_Symbol.ReadOnly = true;
            this.dgv_Symbol.RowHeadersVisible = false;
            this.dgv_Symbol.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto Slab Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Symbol.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.dgv_Symbol.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.dgv_Symbol.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Symbol.RowTemplate.Height = 30;
            this.dgv_Symbol.RowTemplate.ReadOnly = true;
            this.dgv_Symbol.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Symbol.Size = new System.Drawing.Size(357, 347);
            this.dgv_Symbol.TabIndex = 24;
            this.dgv_Symbol.SelectionChanged += new System.EventHandler(this.dgv_Symbol_SelectionChanged);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // image
            // 
            this.image.HeaderText = "Symbol";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.image.Visible = false;
            // 
            // dgv_Image
            // 
            this.dgv_Image.AllowUserToAddRows = false;
            this.dgv_Image.AllowUserToDeleteRows = false;
            this.dgv_Image.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Image.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Image.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Image.ColumnHeadersVisible = false;
            this.dgv_Image.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1});
            this.dgv_Image.Location = new System.Drawing.Point(750, 216);
            this.dgv_Image.MultiSelect = false;
            this.dgv_Image.Name = "dgv_Image";
            this.dgv_Image.ReadOnly = true;
            this.dgv_Image.RowHeadersVisible = false;
            this.dgv_Image.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto Slab Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Image.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.dgv_Image.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.dgv_Image.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Image.RowTemplate.Height = 30;
            this.dgv_Image.RowTemplate.ReadOnly = true;
            this.dgv_Image.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Image.Size = new System.Drawing.Size(357, 347);
            this.dgv_Image.TabIndex = 25;
            this.dgv_Image.SelectionChanged += new System.EventHandler(this.dgv_Image_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Symbol";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // dialog
            // 
            this.dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            this.dialog.RestoreDirectory = true;
            // 
            // frm_MediaLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1391, 846);
            this.Controls.Add(this.dgv_Image);
            this.Controls.Add(this.dgv_Symbol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_UpdateImage);
            this.Controls.Add(this.txt_Image);
            this.Controls.Add(this.btn_DeleteImage);
            this.Controls.Add(this.btn_ReplaceImage);
            this.Controls.Add(this.btn_AddImage);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_UpdateSymbol);
            this.Controls.Add(this.txt_Symbol);
            this.Controls.Add(this.btn_DeleteSymbol);
            this.Controls.Add(this.btn_ReplaceSymbol);
            this.Controls.Add(this.btn_AddSymbol);
            this.Controls.Add(this.symbolBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MediaLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Library";
            this.Load += new System.EventHandler(this.frm_MediaLibrary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.symbolBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Symbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox symbolBox;
        private XanderUI.XUIButton btn_AddSymbol;
        private XanderUI.XUIButton btn_ReplaceSymbol;
        private System.Windows.Forms.Button btn_DeleteSymbol;
        private System.Windows.Forms.TextBox txt_Symbol;
        private XanderUI.XUIButton btn_UpdateSymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private XanderUI.XUIButton btn_UpdateImage;
        private System.Windows.Forms.TextBox txt_Image;
        private System.Windows.Forms.Button btn_DeleteImage;
        private XanderUI.XUIButton btn_ReplaceImage;
        private XanderUI.XUIButton btn_AddImage;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridView dgv_Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.OpenFileDialog dialog;
    }
}