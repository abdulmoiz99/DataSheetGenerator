namespace DatasheetGenerator
{
    partial class frm_CreateDatasheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CreateDatasheet));
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmb_ProductFamily = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.btn_Cancel = new XanderUI.XUIButton();
            this.btn_Exit = new XanderUI.XUIButton();
            this.btn_Create = new XanderUI.XUIButton();
            this.btn_AddNewProductFamily = new XanderUI.XUIButton();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label7.Location = new System.Drawing.Point(52, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(52, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Product Family";
            // 
            // txt_Name
            // 
            this.txt_Name.Depth = 0;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Hint = "";
            this.txt_Name.Location = new System.Drawing.Point(54, 126);
            this.txt_Name.MaxLength = 32767;
            this.txt_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.SelectedText = "";
            this.txt_Name.SelectionLength = 0;
            this.txt_Name.SelectionStart = 0;
            this.txt_Name.Size = new System.Drawing.Size(349, 25);
            this.txt_Name.TabIndex = 22;
            this.txt_Name.TabStop = false;
            this.txt_Name.UseSystemPasswordChar = false;
            this.txt_Name.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // cmb_ProductFamily
            // 
            this.cmb_ProductFamily.CausesValidation = false;
            this.cmb_ProductFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_ProductFamily.FormattingEnabled = true;
            this.cmb_ProductFamily.Location = new System.Drawing.Point(56, 220);
            this.cmb_ProductFamily.Name = "cmb_ProductFamily";
            this.cmb_ProductFamily.Size = new System.Drawing.Size(349, 27);
            this.cmb_ProductFamily.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(47, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 39);
            this.label1.TabIndex = 25;
            this.label1.Text = "New Datasheet";
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 30;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
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
            this.btn_Cancel.Location = new System.Drawing.Point(243, 271);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(160, 42);
            this.btn_Cancel.TabIndex = 28;
            this.btn_Cancel.TextColor = System.Drawing.Color.White;
            this.btn_Cancel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Exit
            // 
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
            this.btn_Exit.Location = new System.Drawing.Point(447, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(36, 36);
            this.btn_Exit.TabIndex = 27;
            this.btn_Exit.TextColor = System.Drawing.Color.White;
            this.btn_Exit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Create.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Create.ButtonImage")));
            this.btn_Create.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Create.ButtonText = "Create";
            this.btn_Create.ClickBackColor = System.Drawing.Color.White;
            this.btn_Create.ClickTextColor = System.Drawing.Color.White;
            this.btn_Create.CornerRadius = 5;
            this.btn_Create.Font = new System.Drawing.Font("Roboto Slab", 12F);
            this.btn_Create.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Create.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Create.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(184)))), ((int)(((byte)(79)))));
            this.btn_Create.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Create.Location = new System.Drawing.Point(56, 271);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(160, 42);
            this.btn_Create.TabIndex = 26;
            this.btn_Create.TextColor = System.Drawing.Color.White;
            this.btn_Create.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_AddNewProductFamily
            // 
            this.btn_AddNewProductFamily.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AddNewProductFamily.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_AddNewProductFamily.ButtonImage")));
            this.btn_AddNewProductFamily.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_AddNewProductFamily.ButtonText = "";
            this.btn_AddNewProductFamily.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AddNewProductFamily.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AddNewProductFamily.CornerRadius = 50;
            this.btn_AddNewProductFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_AddNewProductFamily.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddNewProductFamily.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AddNewProductFamily.HoverTextColor = System.Drawing.Color.White;
            this.btn_AddNewProductFamily.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_AddNewProductFamily.Location = new System.Drawing.Point(411, 214);
            this.btn_AddNewProductFamily.Name = "btn_AddNewProductFamily";
            this.btn_AddNewProductFamily.Size = new System.Drawing.Size(36, 36);
            this.btn_AddNewProductFamily.TabIndex = 29;
            this.btn_AddNewProductFamily.TextColor = System.Drawing.Color.White;
            this.btn_AddNewProductFamily.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddNewProductFamily.Click += new System.EventHandler(this.btn_AddNewProductFamily_Click);
            // 
            // frm_CreateDatasheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(495, 356);
            this.Controls.Add(this.btn_AddNewProductFamily);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ProductFamily);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Roboto", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_CreateDatasheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CreateDatasheet";
            this.Load += new System.EventHandler(this.frm_CreateDatasheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Name;
        private System.Windows.Forms.ComboBox cmb_ProductFamily;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIButton btn_Cancel;
        private XanderUI.XUIButton btn_Exit;
        private XanderUI.XUIButton btn_Create;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private XanderUI.XUIButton btn_AddNewProductFamily;
    }
}