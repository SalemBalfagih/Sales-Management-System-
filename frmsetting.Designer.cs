namespace مشروع_البيع
{
    partial class frmsetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkspeed = new System.Windows.Forms.CheckBox();
            this.chkrepeat = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkspeed);
            this.groupBox1.Controls.Add(this.chkrepeat);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(260, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الإعدادات";
            // 
            // chkspeed
            // 
            this.chkspeed.AutoSize = true;
            this.chkspeed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkspeed.ForeColor = System.Drawing.Color.White;
            this.chkspeed.Location = new System.Drawing.Point(54, 89);
            this.chkspeed.Name = "chkspeed";
            this.chkspeed.Size = new System.Drawing.Size(200, 23);
            this.chkspeed.TabIndex = 1;
            this.chkspeed.Text = "البيع سريع بدون التكرار ";
            this.chkspeed.UseVisualStyleBackColor = true;
            this.chkspeed.CheckedChanged += new System.EventHandler(this.chkspeed_CheckedChanged);
            // 
            // chkrepeat
            // 
            this.chkrepeat.AutoSize = true;
            this.chkrepeat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkrepeat.ForeColor = System.Drawing.Color.White;
            this.chkrepeat.Location = new System.Drawing.Point(99, 46);
            this.chkrepeat.Name = "chkrepeat";
            this.chkrepeat.Size = new System.Drawing.Size(155, 23);
            this.chkrepeat.TabIndex = 0;
            this.chkrepeat.Text = "البيع بتكرار المنتج";
            this.chkrepeat.UseVisualStyleBackColor = true;
            this.chkrepeat.CheckedChanged += new System.EventHandler(this.chkrepeat_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(87, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "حفط الاعدادات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmsetting
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmsetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الضبط";
            this.Load += new System.EventHandler(this.frmsetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkspeed;
        private System.Windows.Forms.CheckBox chkrepeat;
        private System.Windows.Forms.Button button1;
    }
}