namespace DatasheetGenerator
{
    partial class CustomMessageForm
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
            this.lab_Details = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_Details
            // 
            this.lab_Details.AutoSize = true;
            this.lab_Details.Location = new System.Drawing.Point(0, 0);
            this.lab_Details.Name = "lab_Details";
            this.lab_Details.Size = new System.Drawing.Size(41, 15);
            this.lab_Details.TabIndex = 0;
            this.lab_Details.Text = "label1";
            // 
            // CustomMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 207);
            this.Controls.Add(this.lab_Details);
            this.Name = "CustomMessageForm";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Details;
    }
}