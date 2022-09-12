namespace Launcher
{
    partial class OptionGeneral
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
            this.btnBackMain = new System.Windows.Forms.PictureBox();
            this.btnPrivacy = new System.Windows.Forms.PictureBox();
            this.btnShop = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrivacy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackMain
            // 
            this.btnBackMain.BackColor = System.Drawing.Color.Transparent;
            this.btnBackMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackMain.Location = new System.Drawing.Point(728, 27);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(84, 30);
            this.btnBackMain.TabIndex = 0;
            this.btnBackMain.TabStop = false;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // btnPrivacy
            // 
            this.btnPrivacy.BackColor = System.Drawing.Color.Transparent;
            this.btnPrivacy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrivacy.Location = new System.Drawing.Point(34, 301);
            this.btnPrivacy.Name = "btnPrivacy";
            this.btnPrivacy.Size = new System.Drawing.Size(112, 35);
            this.btnPrivacy.TabIndex = 1;
            this.btnPrivacy.TabStop = false;
            this.btnPrivacy.Click += new System.EventHandler(this.btnPrivacy_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.Transparent;
            this.btnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShop.Location = new System.Drawing.Point(833, 27);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(108, 30);
            this.btnShop.TabIndex = 2;
            this.btnShop.TabStop = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(1144, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1050, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(30, 30);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(1050, 354);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(30, 30);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Location = new System.Drawing.Point(965, 450);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(115, 45);
            this.btnApply.TabIndex = 7;
            this.btnApply.TabStop = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // OptionGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources.OptionGeneral;
            this.ClientSize = new System.Drawing.Size(1215, 610);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnPrivacy);
            this.Controls.Add(this.btnBackMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OptionGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.OptionGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBackMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrivacy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnApply)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBackMain;
        private System.Windows.Forms.PictureBox btnPrivacy;
        private System.Windows.Forms.PictureBox btnShop;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox btnApply;
    }
}