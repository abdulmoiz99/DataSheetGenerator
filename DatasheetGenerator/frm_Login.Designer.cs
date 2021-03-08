namespace DatasheetGenerator
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.xuiObjectEllipse1 = new XanderUI.XUIObjectEllipse();
            this.txt_Username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_Passoword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_Login = new XanderUI.XUIButton();
            this.xuiButton1 = new XanderUI.XUIButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new XanderUI.XUIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiObjectEllipse1
            // 
            this.xuiObjectEllipse1.CornerRadius = 30;
            this.xuiObjectEllipse1.EffectedControl = this;
            this.xuiObjectEllipse1.EffectedForm = this;
            // 
            // txt_Username
            // 
            this.txt_Username.Depth = 0;
            this.txt_Username.Font = new System.Drawing.Font("Roboto", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Hint = "";
            this.txt_Username.Location = new System.Drawing.Point(52, 133);
            this.txt_Username.MaxLength = 32767;
            this.txt_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.SelectedText = "";
            this.txt_Username.SelectionLength = 0;
            this.txt_Username.SelectionStart = 0;
            this.txt_Username.Size = new System.Drawing.Size(344, 25);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.TabStop = false;
            this.txt_Username.UseSystemPasswordChar = false;
            // 
            // txt_Passoword
            // 
            this.txt_Passoword.Depth = 0;
            this.txt_Passoword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Passoword.Hint = "";
            this.txt_Passoword.Location = new System.Drawing.Point(52, 221);
            this.txt_Passoword.MaxLength = 32767;
            this.txt_Passoword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Passoword.Name = "txt_Passoword";
            this.txt_Passoword.PasswordChar = '•';
            this.txt_Passoword.SelectedText = "";
            this.txt_Passoword.SelectionLength = 0;
            this.txt_Passoword.SelectionStart = 0;
            this.txt_Passoword.Size = new System.Drawing.Size(344, 25);
            this.txt_Passoword.TabIndex = 2;
            this.txt_Passoword.TabStop = false;
            this.txt_Passoword.UseSystemPasswordChar = false;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(127)))), ((int)(((byte)(69)))));
            this.btn_Login.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Login.ButtonImage")));
            this.btn_Login.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.btn_Login.ButtonText = "Login";
            this.btn_Login.ClickBackColor = System.Drawing.Color.White;
            this.btn_Login.ClickTextColor = System.Drawing.Color.White;
            this.btn_Login.CornerRadius = 5;
            this.btn_Login.Font = new System.Drawing.Font("Roboto Slab", 13F);
            this.btn_Login.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Login.HoverBackgroundColor = System.Drawing.Color.White;
            this.btn_Login.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(127)))), ((int)(((byte)(69)))));
            this.btn_Login.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn_Login.Location = new System.Drawing.Point(267, 261);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(129, 39);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.TextColor = System.Drawing.Color.White;
            this.btn_Login.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // xuiButton1
            // 
            this.xuiButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiButton1.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton1.ButtonImage")));
            this.xuiButton1.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton1.ButtonText = "More";
            this.xuiButton1.ClickBackColor = System.Drawing.SystemColors.WindowFrame;
            this.xuiButton1.ClickTextColor = System.Drawing.SystemColors.WindowFrame;
            this.xuiButton1.CornerRadius = 5;
            this.xuiButton1.Font = new System.Drawing.Font("Roboto Slab", 11F);
            this.xuiButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton1.HoverBackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.xuiButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiButton1.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton1.Location = new System.Drawing.Point(327, 650);
            this.xuiButton1.Name = "xuiButton1";
            this.xuiButton1.Size = new System.Drawing.Size(102, 31);
            this.xuiButton1.TabIndex = 7;
            this.xuiButton1.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.xuiButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 26F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome To ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 25.81132F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(252, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "DataSheet Generator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Log in to access your account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(436, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 722);
            this.panel1.TabIndex = 11;
            // 
            // btn_Close
            // 
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
            this.btn_Close.Location = new System.Drawing.Point(690, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(49, 50);
            this.btn_Close.TabIndex = 17;
            this.btn_Close.TextColor = System.Drawing.Color.DodgerBlue;
            this.btn_Close.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label4.Location = new System.Drawing.Point(12, 637);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Warning!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label5.Location = new System.Drawing.Point(12, 662);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "This is just the demo version of the software";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label6.Location = new System.Drawing.Point(48, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label7.Location = new System.Drawing.Point(48, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label8.Location = new System.Drawing.Point(48, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Create New Account";
            this.label8.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            this.label8.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 722);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiButton1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Passoword);
            this.Controls.Add(this.txt_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private XanderUI.XUIObjectEllipse xuiObjectEllipse1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Username;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Passoword;
        private XanderUI.XUIButton btn_Login;
        private XanderUI.XUIButton xuiButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private XanderUI.XUIButton btn_Close;
    }
}