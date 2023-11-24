namespace مشروع_البيع
{
    partial class frmsearch
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
            this.textsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvprosearch = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprosearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "البحث عن المنتجات";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textsearch
            // 
            this.textsearch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textsearch.Location = new System.Drawing.Point(33, 102);
            this.textsearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textsearch.Name = "textsearch";
            this.textsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textsearch.Size = new System.Drawing.Size(1117, 24);
            this.textsearch.TabIndex = 1;
            this.textsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1158, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "البحث";
            // 
            // dgvprosearch
            // 
            this.dgvprosearch.AllowUserToAddRows = false;
            this.dgvprosearch.AllowUserToDeleteRows = false;
            this.dgvprosearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvprosearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprosearch.Location = new System.Drawing.Point(33, 155);
            this.dgvprosearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvprosearch.Name = "dgvprosearch";
            this.dgvprosearch.ReadOnly = true;
            this.dgvprosearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvprosearch.RowHeadersVisible = false;
            this.dgvprosearch.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvprosearch.RowTemplate.Height = 28;
            this.dgvprosearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprosearch.Size = new System.Drawing.Size(1189, 417);
            this.dgvprosearch.TabIndex = 3;
            this.dgvprosearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvprosearch.Click += new System.EventHandler(this.dgvprosearch_Click);
            this.dgvprosearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dgvprosearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvprosearch_MouseDoubleClick);
            this.dgvprosearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvprosearch_MouseDown);
            this.dgvprosearch.MouseEnter += new System.EventHandler(this.dgvprosearch_MouseEnter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmsearch
            // 
            this.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::مشروع_البيع.Properties.Resources.IMG_20220330_182039;
            this.ClientSize = new System.Drawing.Size(1265, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvprosearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmsearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmsearch";
            this.Load += new System.EventHandler(this.frmsearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprosearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvprosearch;
        private System.Windows.Forms.Button button1;
    }
}