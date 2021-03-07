namespace DatasheetGenerator
{
    partial class frm_AddHeaderPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddHeaderPopup));
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_HeaderName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_Add = new XanderUI.XUIButton();
            this.btn_Exit = new XanderUI.XUIButton();
            this.btn_Cancel = new XanderUI.XUIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 20;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(193, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Header";
            // 
            // txt_HeaderName
            // 
            this.txt_HeaderName.Depth = 0;
            this.txt_HeaderName.Font = new System.Drawing.Font("Roboto Slab", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HeaderName.ForeColor = System.Drawing.Color.Coral;
            this.txt_HeaderName.Hint = "";
            this.txt_HeaderName.Location = new System.Drawing.Point(193, 85);
            this.txt_HeaderName.MaxLength = 32767;
            this.txt_HeaderName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_HeaderName.Name = "txt_HeaderName";
            this.txt_HeaderName.PasswordChar = '\0';
            this.txt_HeaderName.SelectedText = "";
            this.txt_HeaderName.SelectionLength = 0;
            this.txt_HeaderName.SelectionStart = 0;
            this.txt_HeaderName.Size = new System.Drawing.Size(257, 23);
            this.txt_HeaderName.TabIndex = 11;
            this.txt_HeaderName.TabStop = false;
            this.txt_HeaderName.Text = "Header Name";
            this.txt_HeaderName.UseSystemPasswordChar = false;
            this.txt_HeaderName.Click += new System.EventHandler(this.txt_HeaderName_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Add.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Add.ButtonImage")));
            this.btn_Add.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Add.ButtonText = "+ Add";
            this.btn_Add.ClickBackColor = System.Drawing.Color.White;
            this.btn_Add.ClickTextColor = System.Drawing.Color.White;
            this.btn_Add.CornerRadius = 5;
            this.btn_Add.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_Add.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Add.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Add.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Add.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Add.Location = new System.Drawing.Point(193, 131);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(123, 36);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.TextColor = System.Drawing.Color.White;
            this.btn_Add.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
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
            this.btn_Exit.Location = new System.Drawing.Point(497, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(36, 36);
            this.btn_Exit.TabIndex = 20;
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
            this.btn_Cancel.Location = new System.Drawing.Point(322, 131);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(123, 36);
            this.btn_Cancel.TabIndex = 21;
            this.btn_Cancel.TextColor = System.Drawing.Color.White;
            this.btn_Cancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_AddHeaderPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(545, 203);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_HeaderName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AddHeaderPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddHeaderPopup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_HeaderName;
        private XanderUI.XUIButton btn_Add;
        private XanderUI.XUIButton btn_Exit;
        private XanderUI.XUIButton btn_Cancel;
    }
}