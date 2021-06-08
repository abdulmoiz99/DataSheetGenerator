namespace DatasheetGenerator.ModuleManager
{
    partial class frm_Module
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Module));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_SubheaderName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.btn_AddNewProductFamily = new XanderUI.XUIButton();
            this.btn_Exit = new XanderUI.XUIButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.dgv_Preview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Preview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 39);
            this.label1.TabIndex = 34;
            this.label1.Text = "Module";
            // 
            // cmb_SubheaderName
            // 
            this.cmb_SubheaderName.CausesValidation = false;
            this.cmb_SubheaderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_SubheaderName.FormattingEnabled = true;
            this.cmb_SubheaderName.Location = new System.Drawing.Point(40, 230);
            this.cmb_SubheaderName.Name = "cmb_SubheaderName";
            this.cmb_SubheaderName.Size = new System.Drawing.Size(349, 21);
            this.cmb_SubheaderName.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(36, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "SubHeader";
            // 
            // txt_Name
            // 
            this.txt_Name.Depth = 0;
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Hint = "";
            this.txt_Name.Location = new System.Drawing.Point(38, 136);
            this.txt_Name.MaxLength = 32767;
            this.txt_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PasswordChar = '\0';
            this.txt_Name.SelectedText = "";
            this.txt_Name.SelectionLength = 0;
            this.txt_Name.SelectionStart = 0;
            this.txt_Name.Size = new System.Drawing.Size(349, 25);
            this.txt_Name.TabIndex = 31;
            this.txt_Name.TabStop = false;
            this.txt_Name.UseSystemPasswordChar = false;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label7.Location = new System.Drawing.Point(36, 101);
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
            this.btn_AddNewProductFamily.Location = new System.Drawing.Point(395, 224);
            this.btn_AddNewProductFamily.Name = "btn_AddNewProductFamily";
            this.btn_AddNewProductFamily.Size = new System.Drawing.Size(36, 36);
            this.btn_AddNewProductFamily.TabIndex = 38;
            this.btn_AddNewProductFamily.TextColor = System.Drawing.Color.White;
            this.btn_AddNewProductFamily.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddNewProductFamily.Click += new System.EventHandler(this.btn_AddNewProductFamily_Click);
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
            this.btn_Exit.Location = new System.Drawing.Point(752, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(36, 36);
            this.btn_Exit.TabIndex = 36;
            this.btn_Exit.TextColor = System.Drawing.Color.White;
            this.btn_Exit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Checked = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.materialRadioButton1.Location = new System.Drawing.Point(38, 312);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(104, 30);
            this.materialRadioButton1.TabIndex = 39;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Drop Down  ";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(36, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 40;
            this.label3.Text = "Type";
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.materialRadioButton2.Location = new System.Drawing.Point(159, 312);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(59, 30);
            this.materialRadioButton2.TabIndex = 41;
            this.materialRadioButton2.Text = "Text";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // dgv_Preview
            // 
            this.dgv_Preview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Preview.Location = new System.Drawing.Point(18, 42);
            this.dgv_Preview.Name = "dgv_Preview";
            this.dgv_Preview.Size = new System.Drawing.Size(646, 315);
            this.dgv_Preview.TabIndex = 42;
            this.dgv_Preview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgv_Preview.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dgv_Preview.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dgv_Preview.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_Preview);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.groupBox1.Location = new System.Drawing.Point(40, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 377);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // frm_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 776);
            this.Controls.Add(this.materialRadioButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.materialRadioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_SubheaderName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_AddNewProductFamily);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Module";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Module";
            this.Load += new System.EventHandler(this.frm_Module_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Preview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_SubheaderName;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Name;
        private System.Windows.Forms.Label label7;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private XanderUI.XUIButton btn_AddNewProductFamily;
        private XanderUI.XUIButton btn_Exit;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private System.Windows.Forms.DataGridView dgv_Preview;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}