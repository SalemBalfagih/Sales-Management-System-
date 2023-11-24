namespace مشروع_البيع
{
    partial class frmordersales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmordersales));
            this.chordersale = new System.Windows.Forms.CheckBox();
            this.dgvordersale = new System.Windows.Forms.DataGridView();
            this.cmordersale = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btndelorder = new System.Windows.Forms.Button();
            this.btnupdateorder = new System.Windows.Forms.Button();
            this.btnorderall = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnviewod = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textcountRO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordersale)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // chordersale
            // 
            this.chordersale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chordersale.AutoSize = true;
            this.chordersale.Checked = true;
            this.chordersale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chordersale.ForeColor = System.Drawing.Color.White;
            this.chordersale.Location = new System.Drawing.Point(1225, 97);
            this.chordersale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chordersale.Name = "chordersale";
            this.chordersale.Size = new System.Drawing.Size(94, 26);
            this.chordersale.TabIndex = 0;
            this.chordersale.Text = "اختيار الكل";
            this.chordersale.UseVisualStyleBackColor = true;
            this.chordersale.CheckedChanged += new System.EventHandler(this.chordersale_CheckedChanged);
            // 
            // dgvordersale
            // 
            this.dgvordersale.AllowUserToAddRows = false;
            this.dgvordersale.AllowUserToDeleteRows = false;
            this.dgvordersale.AllowUserToOrderColumns = true;
            this.dgvordersale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvordersale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvordersale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvordersale.Location = new System.Drawing.Point(17, 129);
            this.dgvordersale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvordersale.MultiSelect = false;
            this.dgvordersale.Name = "dgvordersale";
            this.dgvordersale.ReadOnly = true;
            this.dgvordersale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvordersale.RowTemplate.Height = 28;
            this.dgvordersale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvordersale.Size = new System.Drawing.Size(1308, 466);
            this.dgvordersale.TabIndex = 2;
            this.dgvordersale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvordersale_CellContentClick);
            this.dgvordersale.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvordersale_RowsAdded);
            // 
            // cmordersale
            // 
            this.cmordersale.Enabled = false;
            this.cmordersale.FormattingEnabled = true;
            this.cmordersale.Location = new System.Drawing.Point(1022, 93);
            this.cmordersale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmordersale.Name = "cmordersale";
            this.cmordersale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmordersale.Size = new System.Drawing.Size(195, 30);
            this.cmordersale.TabIndex = 2;
            this.cmordersale.SelectedIndexChanged += new System.EventHandler(this.cmordersale_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(62, 27);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 45);
            this.button3.TabIndex = 17;
            this.button3.Text = "حذف كل الفواتير";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btndelorder
            // 
            this.btndelorder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btndelorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelorder.ForeColor = System.Drawing.Color.White;
            this.btndelorder.Location = new System.Drawing.Point(261, 27);
            this.btndelorder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btndelorder.Name = "btndelorder";
            this.btndelorder.Size = new System.Drawing.Size(150, 45);
            this.btndelorder.TabIndex = 16;
            this.btndelorder.Text = "حذف فاتورة";
            this.btndelorder.UseVisualStyleBackColor = false;
            this.btndelorder.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnupdateorder
            // 
            this.btnupdateorder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnupdateorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdateorder.ForeColor = System.Drawing.Color.White;
            this.btnupdateorder.Location = new System.Drawing.Point(471, 27);
            this.btnupdateorder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnupdateorder.Name = "btnupdateorder";
            this.btnupdateorder.Size = new System.Drawing.Size(150, 45);
            this.btnupdateorder.TabIndex = 15;
            this.btnupdateorder.Text = "تعديل الفاتورة";
            this.btnupdateorder.UseVisualStyleBackColor = false;
            this.btnupdateorder.Click += new System.EventHandler(this.btnupdateorder_Click);
            // 
            // btnorderall
            // 
            this.btnorderall.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnorderall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnorderall.ForeColor = System.Drawing.Color.White;
            this.btnorderall.Location = new System.Drawing.Point(702, 29);
            this.btnorderall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnorderall.Name = "btnorderall";
            this.btnorderall.Size = new System.Drawing.Size(150, 45);
            this.btnorderall.TabIndex = 14;
            this.btnorderall.Text = "طباعة كل الفواتير";
            this.btnorderall.UseVisualStyleBackColor = false;
            this.btnorderall.Click += new System.EventHandler(this.btnorderall_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(909, 29);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 45);
            this.button5.TabIndex = 13;
            this.button5.Text = "طباعة الفاتورة";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnviewod
            // 
            this.btnviewod.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnviewod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnviewod.ForeColor = System.Drawing.Color.White;
            this.btnviewod.Location = new System.Drawing.Point(1112, 29);
            this.btnviewod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnviewod.Name = "btnviewod";
            this.btnviewod.Size = new System.Drawing.Size(161, 45);
            this.btnviewod.TabIndex = 12;
            this.btnviewod.Text = "عرض تفاصيل الفاتورة";
            this.btnviewod.UseVisualStyleBackColor = false;
            this.btnviewod.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnviewod);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btndelorder);
            this.groupBox1.Controls.Add(this.btnorderall);
            this.groupBox1.Controls.Add(this.btnupdateorder);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 601);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1312, 94);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المبيعات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(565, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 43);
            this.label1.TabIndex = 19;
            this.label1.Text = "عرض فواتير المبيعات";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(17, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 30);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::مشروع_البيع.Properties.Resources.schoology_96px;
            this.pictureBox1.Location = new System.Drawing.Point(775, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::مشروع_البيع.Properties.Resources.schoology_96px;
            this.pictureBox2.Location = new System.Drawing.Point(379, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "تحديث";
            // 
            // textcountRO
            // 
            this.textcountRO.Location = new System.Drawing.Point(922, 706);
            this.textcountRO.Name = "textcountRO";
            this.textcountRO.Size = new System.Drawing.Size(100, 29);
            this.textcountRO.TabIndex = 40;
            // 
            // frmordersales
            // 
            this.Appearance.BackColor = System.Drawing.Color.Teal;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 706);
            this.Controls.Add(this.textcountRO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chordersale);
            this.Controls.Add(this.cmordersale);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvordersale);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmordersales";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmordersales";
            this.Load += new System.EventHandler(this.frmordersales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvordersale)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chordersale;
        private System.Windows.Forms.ComboBox cmordersale;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btndelorder;
        private System.Windows.Forms.Button btnupdateorder;
        private System.Windows.Forms.Button btnorderall;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnviewod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvordersale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textcountRO;
    }
}