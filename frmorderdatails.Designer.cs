namespace مشروع_البيع
{
    partial class frmorderdatails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbnum = new System.Windows.Forms.Label();
            this.dgvorderdatails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdatails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnum
            // 
            this.lbnum.AutoSize = true;
            this.lbnum.BackColor = System.Drawing.Color.Transparent;
            this.lbnum.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.lbnum.ForeColor = System.Drawing.Color.White;
            this.lbnum.Location = new System.Drawing.Point(442, 33);
            this.lbnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnum.Name = "lbnum";
            this.lbnum.Size = new System.Drawing.Size(156, 35);
            this.lbnum.TabIndex = 0;
            this.lbnum.Text = "  رقم الفاتورة ";
            this.lbnum.Click += new System.EventHandler(this.lbnum_Click);
            // 
            // dgvorderdatails
            // 
            this.dgvorderdatails.AllowUserToAddRows = false;
            this.dgvorderdatails.AllowUserToDeleteRows = false;
            this.dgvorderdatails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorderdatails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvorderdatails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvorderdatails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvorderdatails.Location = new System.Drawing.Point(34, 89);
            this.dgvorderdatails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvorderdatails.Name = "dgvorderdatails";
            this.dgvorderdatails.ReadOnly = true;
            this.dgvorderdatails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvorderdatails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvorderdatails.RowTemplate.Height = 30;
            this.dgvorderdatails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvorderdatails.Size = new System.Drawing.Size(944, 426);
            this.dgvorderdatails.TabIndex = 1;
            // 
            // frmorderdatails
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundImageStore = global::مشروع_البيع.Properties.Resources.IMG_20220330_183815;
            this.ClientSize = new System.Drawing.Size(1005, 575);
            this.Controls.Add(this.dgvorderdatails);
            this.Controls.Add(this.lbnum);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmorderdatails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل الفاتورة";
            ((System.ComponentModel.ISupportInitialize)(this.dgvorderdatails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbnum;
        public System.Windows.Forms.DataGridView dgvorderdatails;
    }
}