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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.btn_AddSubheader = new XanderUI.XUIButton();
            this.btn_Exit = new XanderUI.XUIButton();
            this.rb_DropDown = new MaterialSkin.Controls.MaterialRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_Text = new MaterialSkin.Controls.MaterialRadioButton();
            this.dgv_Preview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_SubheaderName = new SergeUtils.EasyCompletionComboBox();
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
            this.label1.Size = new System.Drawing.Size(113, 36);
            this.label1.TabIndex = 34;
            this.label1.Text = "Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(36, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
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
            this.txt_Name.Size = new System.Drawing.Size(349, 23);
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
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Name";
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 30;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // btn_AddSubheader
            // 
            this.btn_AddSubheader.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AddSubheader.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_AddSubheader.ButtonImage")));
            this.btn_AddSubheader.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btn_AddSubheader.ButtonText = "";
            this.btn_AddSubheader.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AddSubheader.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AddSubheader.CornerRadius = 50;
            this.btn_AddSubheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn_AddSubheader.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddSubheader.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_AddSubheader.HoverTextColor = System.Drawing.Color.White;
            this.btn_AddSubheader.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_AddSubheader.Location = new System.Drawing.Point(395, 224);
            this.btn_AddSubheader.Name = "btn_AddSubheader";
            this.btn_AddSubheader.Size = new System.Drawing.Size(36, 36);
            this.btn_AddSubheader.TabIndex = 38;
            this.btn_AddSubheader.TextColor = System.Drawing.Color.White;
            this.btn_AddSubheader.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_AddSubheader.Click += new System.EventHandler(this.btn_AddNewProductFamily_Click);
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
            // rb_DropDown
            // 
            this.rb_DropDown.AutoSize = true;
            this.rb_DropDown.Depth = 0;
            this.rb_DropDown.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_DropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.rb_DropDown.Location = new System.Drawing.Point(120, 311);
            this.rb_DropDown.Margin = new System.Windows.Forms.Padding(0);
            this.rb_DropDown.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_DropDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_DropDown.Name = "rb_DropDown";
            this.rb_DropDown.Ripple = true;
            this.rb_DropDown.Size = new System.Drawing.Size(96, 30);
            this.rb_DropDown.TabIndex = 39;
            this.rb_DropDown.Text = "Drop Down  ";
            this.rb_DropDown.UseVisualStyleBackColor = true;
            this.rb_DropDown.CheckedChanged += new System.EventHandler(this.rb_DropDown_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(36, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Type";
            // 
            // rb_Text
            // 
            this.rb_Text.AutoSize = true;
            this.rb_Text.Checked = true;
            this.rb_Text.Depth = 0;
            this.rb_Text.Font = new System.Drawing.Font("Roboto", 10F);
            this.rb_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.rb_Text.Location = new System.Drawing.Point(40, 311);
            this.rb_Text.Margin = new System.Windows.Forms.Padding(0);
            this.rb_Text.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_Text.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_Text.Name = "rb_Text";
            this.rb_Text.Ripple = true;
            this.rb_Text.Size = new System.Drawing.Size(56, 30);
            this.rb_Text.TabIndex = 41;
            this.rb_Text.TabStop = true;
            this.rb_Text.Text = "Text";
            this.rb_Text.UseVisualStyleBackColor = true;
            this.rb_Text.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // dgv_Preview
            // 
            this.dgv_Preview.AllowUserToAddRows = false;
            this.dgv_Preview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Preview.Location = new System.Drawing.Point(18, 42);
            this.dgv_Preview.Name = "dgv_Preview";
            this.dgv_Preview.Size = new System.Drawing.Size(646, 315);
            this.dgv_Preview.TabIndex = 42;
            this.dgv_Preview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgv_Preview.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dgv_Preview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Preview_CellValueChanged);
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
            // cmb_SubheaderName
            // 
            this.cmb_SubheaderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_SubheaderName.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmb_SubheaderName.FormattingEnabled = true;
            this.cmb_SubheaderName.Location = new System.Drawing.Point(39, 227);
            this.cmb_SubheaderName.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_SubheaderName.Name = "cmb_SubheaderName";
            this.cmb_SubheaderName.Size = new System.Drawing.Size(349, 28);
            this.cmb_SubheaderName.TabIndex = 234;
            // 
            // frm_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 776);
            this.Controls.Add(this.cmb_SubheaderName);
            this.Controls.Add(this.rb_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_DropDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_AddSubheader);
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
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Name;
        private System.Windows.Forms.Label label7;
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private XanderUI.XUIButton btn_AddSubheader;
        private XanderUI.XUIButton btn_Exit;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialRadioButton rb_DropDown;
        private MaterialSkin.Controls.MaterialRadioButton rb_Text;
        private System.Windows.Forms.DataGridView dgv_Preview;
        private System.Windows.Forms.GroupBox groupBox1;
        internal SergeUtils.EasyCompletionComboBox cmb_SubheaderName;
    }
}