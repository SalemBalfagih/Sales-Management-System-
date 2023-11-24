namespace مشروع_البيع
{
    partial class frmprodact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprodact));
            this.gcprodact = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgvpro = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.textcode = new System.Windows.Forms.TextBox();
            this.textsell = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textstore = new System.Windows.Forms.TextBox();
            this.textear = new System.Windows.Forms.TextBox();
            this.textbuy = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.cmitem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnview = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.texttotalRB = new System.Windows.Forms.TextBox();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.textcountRP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gcprodact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcprodact
            // 
            this.gcprodact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcprodact.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcprodact.Location = new System.Drawing.Point(0, 0);
            this.gcprodact.MainView = this.gridView1;
            this.gcprodact.Name = "gcprodact";
            this.gcprodact.Size = new System.Drawing.Size(1297, 287);
            this.gcprodact.TabIndex = 46;
            this.gcprodact.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcprodact.Click += new System.EventHandler(this.gcprodact_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.EvenRow.Options.UseFont = true;
            this.gridView1.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.FilterPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FilterPanel.Options.UseFont = true;
            this.gridView1.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridView1.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 14F);
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 18F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gridView1.Appearance.HeaderPanel.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.GridControl = this.gcprodact;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // dgvpro
            // 
            this.dgvpro.AllowUserToAddRows = false;
            this.dgvpro.AllowUserToDeleteRows = false;
            this.dgvpro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgvpro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpro.Location = new System.Drawing.Point(541, 712);
            this.dgvpro.Name = "dgvpro";
            this.dgvpro.ReadOnly = true;
            this.dgvpro.Size = new System.Drawing.Size(231, 82);
            this.dgvpro.TabIndex = 48;
            this.dgvpro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpro_CellContentClick);
            this.dgvpro.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvpro_RowsAdded);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.BackgroundImage = global::مشروع_البيع.Properties.Resources.IMG_20220330_182039;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.gBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.btnedit); 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnview);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(43, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1278, 327);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "----";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gBox
            // 
            this.gBox.BackColor = System.Drawing.Color.White;
            this.gBox.BackgroundImage = global::مشروع_البيع.Properties.Resources.IMG_20220330_182039;
            this.gBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gBox.Controls.Add(this.textcode);
            this.gBox.Controls.Add(this.textsell);
            this.gBox.Controls.Add(this.label10);
            this.gBox.Controls.Add(this.textstore);
            this.gBox.Controls.Add(this.textear);
            this.gBox.Controls.Add(this.textbuy);
            this.gBox.Controls.Add(this.textname);
            this.gBox.Controls.Add(this.cmitem);
            this.gBox.Controls.Add(this.label7);
            this.gBox.Controls.Add(this.label8);
            this.gBox.Controls.Add(this.label9);
            this.gBox.Controls.Add(this.label4);
            this.gBox.Controls.Add(this.label5);
            this.gBox.Controls.Add(this.label3);
            this.gBox.Controls.Add(this.label2);
            this.gBox.Controls.Add(this.textid);
            this.gBox.Controls.Add(this.label1);
            this.gBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.gBox.Enabled = false;
            this.gBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.gBox.Location = new System.Drawing.Point(835, 0);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(443, 327);
            this.gBox.TabIndex = 45;
            this.gBox.TabStop = false;
            this.gBox.Text = "بيانات المنتجات";
            this.gBox.Enter += new System.EventHandler(this.gBox_Enter);
            // 
            // textcode
            // 
            this.textcode.AcceptsReturn = true;
            this.textcode.BackColor = System.Drawing.Color.White;
            this.textcode.Cursor = System.Windows.Forms.Cursors.Default;
            this.textcode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textcode.Location = new System.Drawing.Point(53, 66);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(221, 27);
            this.textcode.TabIndex = 69;
            this.textcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textcode.TextChanged += new System.EventHandler(this.textcode_TextChanged_1);
            this.textcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textcode_KeyDown);
            this.textcode.Move += new System.EventHandler(this.textcode_Move);
            // 
            // textsell
            // 
            this.textsell.AcceptsReturn = true;
            this.textsell.Cursor = System.Windows.Forms.Cursors.Default;
            this.textsell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textsell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textsell.Location = new System.Drawing.Point(53, 165);
            this.textsell.Name = "textsell";
            this.textsell.Size = new System.Drawing.Size(221, 27);
            this.textsell.TabIndex = 68;
            this.textsell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textsell.TextChanged += new System.EventHandler(this.textsell_TextChanged);
            this.textsell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textsell_KeyDown);
            this.textsell.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textsell_MouseDown);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(327, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 22);
            this.label10.TabIndex = 67;
            this.label10.Text = "بيانات المنتجات";
            // 
            // textstore
            // 
            this.textstore.AcceptsReturn = true;
            this.textstore.Cursor = System.Windows.Forms.Cursors.Default;
            this.textstore.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textstore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textstore.Location = new System.Drawing.Point(53, 233);
            this.textstore.Name = "textstore";
            this.textstore.Size = new System.Drawing.Size(221, 27);
            this.textstore.TabIndex = 66;
            this.textstore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textear
            // 
            this.textear.AcceptsReturn = true;
            this.textear.BackColor = System.Drawing.Color.Silver;
            this.textear.Cursor = System.Windows.Forms.Cursors.Default;
            this.textear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textear.Location = new System.Drawing.Point(53, 201);
            this.textear.Name = "textear";
            this.textear.ReadOnly = true;
            this.textear.Size = new System.Drawing.Size(221, 27);
            this.textear.TabIndex = 65;
            this.textear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textear.TextChanged += new System.EventHandler(this.textear_TextChanged);
            this.textear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textear_KeyDown);
            // 
            // textbuy
            // 
            this.textbuy.AcceptsReturn = true;
            this.textbuy.Cursor = System.Windows.Forms.Cursors.Default;
            this.textbuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textbuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textbuy.Location = new System.Drawing.Point(53, 132);
            this.textbuy.Name = "textbuy";
            this.textbuy.Size = new System.Drawing.Size(221, 27);
            this.textbuy.TabIndex = 63;
            this.textbuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbuy.TextChanged += new System.EventHandler(this.textsell_TextChanged);
            this.textbuy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbuy_KeyDown);
            // 
            // textname
            // 
            this.textname.AcceptsReturn = true;
            this.textname.Cursor = System.Windows.Forms.Cursors.Default;
            this.textname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textname.Location = new System.Drawing.Point(53, 99);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(221, 27);
            this.textname.TabIndex = 62;
            this.textname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textname_KeyDown);
            // 
            // cmitem
            // 
            this.cmitem.BackColor = System.Drawing.Color.White;
            this.cmitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmitem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmitem.FormattingEnabled = true;
            this.cmitem.Location = new System.Drawing.Point(53, 269);
            this.cmitem.Name = "cmitem";
            this.cmitem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmitem.Size = new System.Drawing.Size(221, 24);
            this.cmitem.TabIndex = 60;
            this.cmitem.SelectedIndexChanged += new System.EventHandler(this.cmitem_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(290, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 59;
            this.label7.Text = " الصنــــــــــف :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(286, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 22);
            this.label8.TabIndex = 58;
            this.label8.Text = "الكمية المخزنة :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(286, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 22);
            this.label9.TabIndex = 57;
            this.label9.Text = "المكســــــــــب :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(286, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 56;
            this.label4.Text = "سعـر البيــــــع :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(286, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 55;
            this.label5.Text = "سعــر الشــراء :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(286, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "الاســــــــــــــــم :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(286, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 53;
            this.label2.Text = "الكــــــــــــــــود :";
            // 
            // textid
            // 
            this.textid.AcceptsReturn = true;
            this.textid.BackColor = System.Drawing.Color.Silver;
            this.textid.Cursor = System.Windows.Forms.Cursors.Default;
            this.textid.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textid.Location = new System.Drawing.Point(53, 33);
            this.textid.Name = "textid";
            this.textid.ReadOnly = true;
            this.textid.Size = new System.Drawing.Size(221, 27);
            this.textid.TabIndex = 52;
            this.textid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textid.TextChanged += new System.EventHandler(this.textid_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 41);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 51;
            this.label1.Text = ": رقـــــم المنتــــج ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(279, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 51;
            this.button2.Text = "حذف الصورة ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(69, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 33);
            this.button1.TabIndex = 50;
            this.button1.Text = " عرض صورة المنتج المحدد";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = global::مشروع_البيع.Properties.Resources.plus_6_24;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(574, 48);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(213, 41);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = "اضافة";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(28, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(234, 185);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnedit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(574, 107);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(213, 41);
            this.btnedit.TabIndex = 25;
            this.btnedit.Text = "تعديل";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(226, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "صورة المنتج";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(279, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.SteelBlue;
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnview.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(390, 243);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(133, 33);
            this.btnview.TabIndex = 44;
            this.btnview.Text = "أضافة صورة جديدة";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.SteelBlue;
            this.btndel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.White;
            this.btndel.Image = global::مشروع_البيع.Properties.Resources.Turbo32o80;
            this.btndel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel.Location = new System.Drawing.Point(574, 164);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(213, 41);
            this.btndel.TabIndex = 26;
            this.btndel.Text = "حذف";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.Enabled = false;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = global::مشروع_البيع.Properties.Resources.save_321;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(574, 227);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(213, 41);
            this.btnsave.TabIndex = 27;
            this.btnsave.Text = "حفظ";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.TabIndexChanged += new System.EventHandler(this.btnsave_TabIndexChanged);
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.MouseEnter += new System.EventHandler(this.btnsave_MouseEnter);
            // 
            // texttotalRB
            // 
            this.texttotalRB.Location = new System.Drawing.Point(156, 693);
            this.texttotalRB.Name = "texttotalRB";
            this.texttotalRB.Size = new System.Drawing.Size(108, 23);
            this.texttotalRB.TabIndex = 71;
            this.texttotalRB.Validating += new System.ComponentModel.CancelEventHandler(this.texttotalRB_Validating);
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSplitContainer1.Grid = this.gcprodact;
            this.gridSplitContainer1.Location = new System.Drawing.Point(43, 32);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gcprodact);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1297, 287);
            this.gridSplitContainer1.TabIndex = 53;
            // 
            // textcountRP
            // 
            this.textcountRP.AcceptsReturn = true;
            this.textcountRP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textcountRP.BackColor = System.Drawing.Color.White;
            this.textcountRP.Cursor = System.Windows.Forms.Cursors.Default;
            this.textcountRP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textcountRP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textcountRP.Location = new System.Drawing.Point(12, 694);
            this.textcountRP.Name = "textcountRP";
            this.textcountRP.Size = new System.Drawing.Size(66, 27);
            this.textcountRP.TabIndex = 70;
            this.textcountRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmprodact
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::مشروع_البيع.Properties.Resources.IMG_20220330_182039;
            this.ClientSize = new System.Drawing.Size(1384, 689);
            this.Controls.Add(this.texttotalRB);
            this.Controls.Add(this.dgvpro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textcountRP);
            this.Controls.Add(this.gridSplitContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmprodact";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المنتجات";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmprodact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcprodact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgvpro;
        public DevExpress.XtraGrid.GridControl gcprodact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.TextBox textsell;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textstore;
        private System.Windows.Forms.TextBox textear;
        private System.Windows.Forms.TextBox textbuy;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.ComboBox cmitem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnview;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        public System.Windows.Forms.TextBox textcountRP;
        public System.Windows.Forms.TextBox texttotalRB;
    }
}