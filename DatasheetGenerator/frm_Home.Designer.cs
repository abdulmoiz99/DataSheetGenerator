namespace DatasheetGenerator
{
    partial class frm_Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.datasheetPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lab_ProductFamily = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 29F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "The Latest Datasheets";
            // 
            // datasheetPanel
            // 
            this.datasheetPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datasheetPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.datasheetPanel.Location = new System.Drawing.Point(49, 134);
            this.datasheetPanel.Name = "datasheetPanel";
            this.datasheetPanel.Size = new System.Drawing.Size(1148, 655);
            this.datasheetPanel.TabIndex = 3;
            this.datasheetPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.datasheetPanel_Paint);
            // 
            // lab_ProductFamily
            // 
            this.lab_ProductFamily.AutoSize = true;
            this.lab_ProductFamily.Font = new System.Drawing.Font("Roboto Slab", 14F);
            this.lab_ProductFamily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lab_ProductFamily.Location = new System.Drawing.Point(45, 92);
            this.lab_ProductFamily.Name = "lab_ProductFamily";
            this.lab_ProductFamily.Size = new System.Drawing.Size(313, 28);
            this.lab_ProductFamily.TabIndex = 8;
            this.lab_ProductFamily.Text = "Format: Date | Datasheet Name";
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 847);
            this.Controls.Add(this.lab_ProductFamily);
            this.Controls.Add(this.datasheetPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_Home";
            this.Text = "frm_Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel datasheetPanel;
        private System.Windows.Forms.Label lab_ProductFamily;
    }
}