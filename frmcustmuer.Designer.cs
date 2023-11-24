namespace مشروع_البيع
{
    partial class frmcustmuer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcustmuer));
            this.textsearch = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.textphone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textadderss = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btndeleteall = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textcountRC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(50, 13);
            this.textsearch.Margin = new System.Windows.Forms.Padding(4);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(659, 29);
            this.textsearch.TabIndex = 0;
            this.textsearch.Tag = "";
            this.textsearch.Text = "بحث";
            this.textsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textsearch.TextChanged += new System.EventHandler(this.textsearch_TextChanged);
            this.textsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textsearch_KeyDown);
            this.textsearch.MouseEnter += new System.EventHandler(this.textsearch_MouseEnter);
            // 
            // btnsave
            // 
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::مشروع_البيع.Properties.Resources.save_321;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(454, 538);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(222, 41);
            this.btnsave.TabIndex = 31;
            this.btnsave.Text = "حفظ";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndel
            // 
            this.btndel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Image = global::مشروع_البيع.Properties.Resources.Turbo32o80;
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(454, 427);
            this.btndel.Margin = new System.Windows.Forms.Padding(4);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(222, 47);
            this.btndel.TabIndex = 30;
            this.btndel.Text = "حذف";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click_1);
            // 
            // btnedit
            // 
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(454, 372);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(222, 44);
            this.btnedit.TabIndex = 29;
            this.btnedit.Text = "تعديل";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = global::مشروع_البيع.Properties.Resources.plus_6_24;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(454, 312);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(222, 44);
            this.btnadd.TabIndex = 28;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // textname
            // 
            this.textname.AcceptsReturn = true;
            this.textname.Cursor = System.Windows.Forms.Cursors.Default;
            this.textname.Enabled = false;
            this.textname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textname.Location = new System.Drawing.Point(23, 33);
            this.textname.Margin = new System.Windows.Forms.Padding(4);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(242, 29);
            this.textname.TabIndex = 74;
            this.textname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textname.TextChanged += new System.EventHandler(this.textname_TextChanged);
            this.textname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textname_KeyDown);
            this.textname.Validating += new System.ComponentModel.CancelEventHandler(this.textname_Validating);
            // 
            // textphone
            // 
            this.textphone.AcceptsReturn = true;
            this.textphone.Cursor = System.Windows.Forms.Cursors.Default;
            this.textphone.Enabled = false;
            this.textphone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textphone.Location = new System.Drawing.Point(23, 78);
            this.textphone.Margin = new System.Windows.Forms.Padding(4);
            this.textphone.Name = "textphone";
            this.textphone.Size = new System.Drawing.Size(242, 29);
            this.textphone.TabIndex = 72;
            this.textphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textphone.TextChanged += new System.EventHandler(this.textphone_TextChanged);
            this.textphone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textphone_KeyDown);
            this.textphone.Validating += new System.ComponentModel.CancelEventHandler(this.textphone_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(286, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 22);
            this.label9.TabIndex = 71;
            this.label9.Text = "العنوان";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 70;
            this.label4.Text = "الاسم ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 69;
            this.label5.Text = "الهاتف ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textadderss
            // 
            this.textadderss.AcceptsReturn = true;
            this.textadderss.Cursor = System.Windows.Forms.Cursors.Default;
            this.textadderss.Enabled = false;
            this.textadderss.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textadderss.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textadderss.Location = new System.Drawing.Point(23, 124);
            this.textadderss.Margin = new System.Windows.Forms.Padding(4);
            this.textadderss.Name = "textadderss";
            this.textadderss.Size = new System.Drawing.Size(242, 29);
            this.textadderss.TabIndex = 75;
            this.textadderss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textadderss.TextChanged += new System.EventHandler(this.textadderss_TextChanged);
            this.textadderss.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textadderss_KeyDown);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Tahoma", 28F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(78, 486);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(356, 93);
            this.button1.TabIndex = 76;
            this.button1.Text = "CUSTOMER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(50, 55);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(660, 249);
            this.dgv.TabIndex = 2;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            // 
            // btndeleteall
            // 
            this.btndeleteall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeleteall.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteall.Image = global::مشروع_البيع.Properties.Resources.delete_32;
            this.btndeleteall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeleteall.Location = new System.Drawing.Point(454, 482);
            this.btndeleteall.Margin = new System.Windows.Forms.Padding(4);
            this.btndeleteall.Name = "btndeleteall";
            this.btndeleteall.Size = new System.Drawing.Size(222, 48);
            this.btndeleteall.TabIndex = 77;
            this.btndeleteall.Text = "حذف الكل";
            this.btndeleteall.UseVisualStyleBackColor = false;
            this.btndeleteall.Click += new System.EventHandler(this.btndeleteall_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textphone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textadderss);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 312);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(356, 166);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الزبون";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textcountRC
            // 
            this.textcountRC.AcceptsReturn = true;
            this.textcountRC.Cursor = System.Windows.Forms.Cursors.Default;
            this.textcountRC.Enabled = false;
            this.textcountRC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcountRC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textcountRC.Location = new System.Drawing.Point(1, 571);
            this.textcountRC.Margin = new System.Windows.Forms.Padding(4);
            this.textcountRC.Name = "textcountRC";
            this.textcountRC.Size = new System.Drawing.Size(80, 29);
            this.textcountRC.TabIndex = 79;
            this.textcountRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmcustmuer
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Center;
            this.BackgroundImageStore = global::مشروع_البيع.Properties.Resources.IMG_20220330_182039;
            this.ClientSize = new System.Drawing.Size(769, 596);
            this.Controls.Add(this.textcountRC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btndeleteall);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.textsearch);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmcustmuer";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة العملاء";
            this.Load += new System.EventHandler(this.custmuer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textphone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textadderss;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndeleteall;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.TextBox textcountRC;
    }
}