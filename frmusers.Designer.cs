namespace مشروع_البيع
{
    partial class frmusers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmusers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnsaveuse = new System.Windows.Forms.Button();
            this.textphon = new System.Windows.Forms.TextBox();
            this.textpasso = new System.Windows.Forms.TextBox();
            this.textusername = new System.Windows.Forms.TextBox();
            this.cmvalidty = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnedituse = new System.Windows.Forms.Button();
            this.textfullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.btndeluse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadduse = new System.Windows.Forms.Button();
            this.dgvusers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textcountRU = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsaveuse
            // 
            this.btnsaveuse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsaveuse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveuse.Image = global::مشروع_البيع.Properties.Resources.save_321;
            this.btnsaveuse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsaveuse.Location = new System.Drawing.Point(89, 427);
            this.btnsaveuse.Name = "btnsaveuse";
            this.btnsaveuse.Size = new System.Drawing.Size(213, 41);
            this.btnsaveuse.TabIndex = 73;
            this.btnsaveuse.Text = "حفظ";
            this.btnsaveuse.UseVisualStyleBackColor = false;
            this.btnsaveuse.Click += new System.EventHandler(this.btnsaveuse_Click);
            // 
            // textphon
            // 
            this.textphon.AcceptsReturn = true;
            this.textphon.Cursor = System.Windows.Forms.Cursors.Default;
            this.textphon.Enabled = false;
            this.textphon.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textphon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textphon.Location = new System.Drawing.Point(352, 415);
            this.textphon.Name = "textphon";
            this.textphon.Size = new System.Drawing.Size(221, 27);
            this.textphon.TabIndex = 88;
            this.textphon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textpasso
            // 
            this.textpasso.AcceptsReturn = true;
            this.textpasso.Cursor = System.Windows.Forms.Cursors.Default;
            this.textpasso.Enabled = false;
            this.textpasso.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textpasso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textpasso.Location = new System.Drawing.Point(352, 382);
            this.textpasso.Name = "textpasso";
            this.textpasso.Size = new System.Drawing.Size(221, 27);
            this.textpasso.TabIndex = 85;
            this.textpasso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textusername
            // 
            this.textusername.AcceptsReturn = true;
            this.textusername.Cursor = System.Windows.Forms.Cursors.Default;
            this.textusername.Enabled = false;
            this.textusername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textusername.Location = new System.Drawing.Point(352, 349);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(221, 27);
            this.textusername.TabIndex = 84;
            this.textusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmvalidty
            // 
            this.cmvalidty.BackColor = System.Drawing.Color.White;
            this.cmvalidty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmvalidty.Enabled = false;
            this.cmvalidty.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmvalidty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmvalidty.FormattingEnabled = true;
            this.cmvalidty.ItemHeight = 19;
            this.cmvalidty.Items.AddRange(new object[] {
            "مدير",
            "مستخدم"});
            this.cmvalidty.Location = new System.Drawing.Point(352, 454);
            this.cmvalidty.Name = "cmvalidty";
            this.cmvalidty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmvalidty.Size = new System.Drawing.Size(221, 27);
            this.cmvalidty.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BurlyWood;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(600, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 22);
            this.label7.TabIndex = 82;
            this.label7.Text = "الصلاحيــــــات ";
            // 
            // btnedituse
            // 
            this.btnedituse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedituse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedituse.Image = ((System.Drawing.Image)(resources.GetObject("btnedituse.Image")));
            this.btnedituse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedituse.Location = new System.Drawing.Point(89, 331);
            this.btnedituse.Name = "btnedituse";
            this.btnedituse.Size = new System.Drawing.Size(213, 41);
            this.btnedituse.TabIndex = 71;
            this.btnedituse.Text = "تعديل";
            this.btnedituse.UseVisualStyleBackColor = false;
            this.btnedituse.Click += new System.EventHandler(this.btnedituse_Click);
            // 
            // textfullname
            // 
            this.textfullname.AcceptsReturn = true;
            this.textfullname.BackColor = System.Drawing.Color.White;
            this.textfullname.Cursor = System.Windows.Forms.Cursors.Default;
            this.textfullname.Enabled = false;
            this.textfullname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textfullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textfullname.Location = new System.Drawing.Point(352, 316);
            this.textfullname.Name = "textfullname";
            this.textfullname.Size = new System.Drawing.Size(221, 27);
            this.textfullname.TabIndex = 89;
            this.textfullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 79;
            this.label4.Text = "رقــــــم الهاتـف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 77;
            this.label3.Text = "اســـم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 76;
            this.label2.Text = "الاســم الكامــــل";
            // 
            // textid
            // 
            this.textid.AcceptsReturn = true;
            this.textid.BackColor = System.Drawing.Color.Silver;
            this.textid.Cursor = System.Windows.Forms.Cursors.Default;
            this.textid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textid.Location = new System.Drawing.Point(352, 283);
            this.textid.Name = "textid";
            this.textid.ReadOnly = true;
            this.textid.Size = new System.Drawing.Size(221, 27);
            this.textid.TabIndex = 75;
            this.textid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btndeluse
            // 
            this.btndeluse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeluse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeluse.Image = global::مشروع_البيع.Properties.Resources.Turbo32o80;
            this.btndeluse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeluse.Location = new System.Drawing.Point(89, 379);
            this.btndeluse.Name = "btndeluse";
            this.btndeluse.Size = new System.Drawing.Size(213, 41);
            this.btndeluse.TabIndex = 72;
            this.btndeluse.Text = "حذف";
            this.btndeluse.UseVisualStyleBackColor = false;
            this.btndeluse.Click += new System.EventHandler(this.btndeluse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(600, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 78;
            this.label5.Text = "كلمـة المـــــرور";
            // 
            // btnadduse
            // 
            this.btnadduse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadduse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduse.Image = global::مشروع_البيع.Properties.Resources.plus_6_24;
            this.btnadduse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadduse.Location = new System.Drawing.Point(89, 283);
            this.btnadduse.Name = "btnadduse";
            this.btnadduse.Size = new System.Drawing.Size(213, 41);
            this.btnadduse.TabIndex = 70;
            this.btnadduse.Text = "اضافة";
            this.btnadduse.UseVisualStyleBackColor = false;
            this.btnadduse.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvusers
            // 
            this.dgvusers.AllowUserToAddRows = false;
            this.dgvusers.AllowUserToDeleteRows = false;
            this.dgvusers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvusers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvusers.Location = new System.Drawing.Point(17, 55);
            this.dgvusers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvusers.MultiSelect = false;
            this.dgvusers.Name = "dgvusers";
            this.dgvusers.ReadOnly = true;
            this.dgvusers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvusers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvusers.RowTemplate.Height = 28;
            this.dgvusers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvusers.Size = new System.Drawing.Size(725, 211);
            this.dgvusers.TabIndex = 90;
            this.dgvusers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvusers_RowsAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 74;
            this.label1.Text = ": رقم المستخدم ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(320, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 32);
            this.label6.TabIndex = 91;
            this.label6.Text = "المستخدمين";
            // 
            // textcountRU
            // 
            this.textcountRU.AcceptsReturn = true;
            this.textcountRU.BackColor = System.Drawing.Color.White;
            this.textcountRU.Cursor = System.Windows.Forms.Cursors.Default;
            this.textcountRU.Enabled = false;
            this.textcountRU.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textcountRU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textcountRU.Location = new System.Drawing.Point(5, 501);
            this.textcountRU.Name = "textcountRU";
            this.textcountRU.Size = new System.Drawing.Size(86, 27);
            this.textcountRU.TabIndex = 92;
            this.textcountRU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmusers
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::مشروع_البيع.Properties.Resources.IMG_20220330_182039;
            this.ClientSize = new System.Drawing.Size(759, 494);
            this.Controls.Add(this.textcountRU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvusers);
            this.Controls.Add(this.btnsaveuse);
            this.Controls.Add(this.textphon);
            this.Controls.Add(this.textpasso);
            this.Controls.Add(this.textusername);
            this.Controls.Add(this.cmvalidty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnedituse);
            this.Controls.Add(this.textfullname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndeluse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnadduse);
            this.DoubleBuffered = true;
            this.Name = "frmusers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستخدمين";
            this.Load += new System.EventHandler(this.frmusers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsaveuse;
        private System.Windows.Forms.TextBox textphon;
        private System.Windows.Forms.TextBox textpasso;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnedituse;
        private System.Windows.Forms.TextBox textfullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Button btndeluse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnadduse;
        private System.Windows.Forms.DataGridView dgvusers;
        public System.Windows.Forms.ComboBox cmvalidty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textcountRU;
    }
}