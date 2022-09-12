namespace Launcher
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDiscord = new System.Windows.Forms.PictureBox();
            this.btnTs = new System.Windows.Forms.PictureBox();
            this.btbWebsite = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnShop = new System.Windows.Forms.PictureBox();
            this.btnOptions = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnDiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbWebsite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDiscord
            // 
            this.btnDiscord.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscord.Location = new System.Drawing.Point(12, 179);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Size = new System.Drawing.Size(160, 59);
            this.btnDiscord.TabIndex = 0;
            this.btnDiscord.TabStop = false;
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            // 
            // btnTs
            // 
            this.btnTs.BackColor = System.Drawing.Color.Transparent;
            this.btnTs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTs.Location = new System.Drawing.Point(12, 269);
            this.btnTs.Name = "btnTs";
            this.btnTs.Size = new System.Drawing.Size(192, 59);
            this.btnTs.TabIndex = 1;
            this.btnTs.TabStop = false;
            this.btnTs.Click += new System.EventHandler(this.btnTs_Click);
            // 
            // btbWebsite
            // 
            this.btbWebsite.BackColor = System.Drawing.Color.Transparent;
            this.btbWebsite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbWebsite.Location = new System.Drawing.Point(12, 359);
            this.btbWebsite.Name = "btbWebsite";
            this.btbWebsite.Size = new System.Drawing.Size(160, 56);
            this.btbWebsite.TabIndex = 2;
            this.btbWebsite.TabStop = false;
            this.btbWebsite.Click += new System.EventHandler(this.btbWebsite_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Location = new System.Drawing.Point(553, 446);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(167, 56);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(1144, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.Transparent;
            this.btnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShop.Location = new System.Drawing.Point(831, 24);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(109, 36);
            this.btnShop.TabIndex = 6;
            this.btnShop.TabStop = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptions.Location = new System.Drawing.Point(962, 24);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(163, 36);
            this.btnOptions.TabIndex = 7;
            this.btnOptions.TabStop = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(94, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "NightLifeRP";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources.Main_png;
            this.ClientSize = new System.Drawing.Size(1215, 610);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btbWebsite);
            this.Controls.Add(this.btnTs);
            this.Controls.Add(this.btnDiscord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbWebsite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnDiscord;
        private System.Windows.Forms.PictureBox btnTs;
        private System.Windows.Forms.PictureBox btbWebsite;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnShop;
        private System.Windows.Forms.PictureBox btnOptions;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}

