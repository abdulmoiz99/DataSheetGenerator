namespace DatasheetGenerator
{
    partial class frn_TestForm
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 5;
            this.dgv.Size = new System.Drawing.Size(714, 294);
            this.dgv.TabIndex = 0;
            this.dgv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Medium", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.dgv);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(223, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1473, 799);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.TabStop = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aqua;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(723, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 294);
            this.dataGridView1.TabIndex = 1;
            // 
            // frn_TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1769, 850);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Name = "frn_TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frn_TestForm";
            this.Load += new System.EventHandler(this.frn_TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}