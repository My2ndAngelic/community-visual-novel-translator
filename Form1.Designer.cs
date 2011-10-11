namespace Community_Novel_Translator
{
    partial class BTTranslator
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTTranslator));
            this.RTBOriginale = new System.Windows.Forms.RichTextBox();
            this.BTOttieni = new System.Windows.Forms.Button();
            this.RTBTraduzione = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BTTradotto = new System.Windows.Forms.Button();
            this.BTReset = new System.Windows.Forms.Button();
            this.PBDown = new System.Windows.Forms.ProgressBar();
            this.BTExit = new System.Windows.Forms.Button();
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // RTBOriginale
            // 
            this.RTBOriginale.Location = new System.Drawing.Point(12, 158);
            this.RTBOriginale.Name = "RTBOriginale";
            this.RTBOriginale.ReadOnly = true;
            this.RTBOriginale.Size = new System.Drawing.Size(456, 406);
            this.RTBOriginale.TabIndex = 0;
            this.RTBOriginale.Text = "";
            // 
            // BTOttieni
            // 
            this.BTOttieni.Location = new System.Drawing.Point(144, 574);
            this.BTOttieni.Name = "BTOttieni";
            this.BTOttieni.Size = new System.Drawing.Size(158, 21);
            this.BTOttieni.TabIndex = 5;
            this.BTOttieni.Text = "Get lines to translate";
            this.BTOttieni.UseVisualStyleBackColor = true;
            this.BTOttieni.Click += new System.EventHandler(this.BTOttieni_Click);
            // 
            // RTBTraduzione
            // 
            this.RTBTraduzione.Location = new System.Drawing.Point(474, 158);
            this.RTBTraduzione.Name = "RTBTraduzione";
            this.RTBTraduzione.Size = new System.Drawing.Size(498, 406);
            this.RTBTraduzione.TabIndex = 0;
            this.RTBTraduzione.Text = "";
            // 
            // BTTradotto
            // 
            this.BTTradotto.Location = new System.Drawing.Point(649, 578);
            this.BTTradotto.Name = "BTTradotto";
            this.BTTradotto.Size = new System.Drawing.Size(172, 20);
            this.BTTradotto.TabIndex = 6;
            this.BTTradotto.Text = "Send translation!";
            this.BTTradotto.UseVisualStyleBackColor = true;
            this.BTTradotto.Click += new System.EventHandler(this.BTTradotto_Click);
            // 
            // BTReset
            // 
            this.BTReset.Location = new System.Drawing.Point(427, 574);
            this.BTReset.Name = "BTReset";
            this.BTReset.Size = new System.Drawing.Size(103, 28);
            this.BTReset.TabIndex = 7;
            this.BTReset.TabStop = false;
            this.BTReset.Text = "Reset";
            this.BTReset.UseVisualStyleBackColor = true;
            this.BTReset.Click += new System.EventHandler(this.BTReset_Click);
            // 
            // PBDown
            // 
            this.PBDown.Location = new System.Drawing.Point(31, 615);
            this.PBDown.Name = "PBDown";
            this.PBDown.Size = new System.Drawing.Size(379, 35);
            this.PBDown.TabIndex = 8;
            // 
            // BTExit
            // 
            this.BTExit.Location = new System.Drawing.Point(427, 614);
            this.BTExit.Name = "BTExit";
            this.BTExit.Size = new System.Drawing.Size(103, 36);
            this.BTExit.TabIndex = 9;
            this.BTExit.Text = "Close and clear temporary data";
            this.BTExit.UseVisualStyleBackColor = true;
            this.BTExit.Click += new System.EventHandler(this.BTExit_Click);
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.Transparent;
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(984, 24);
            this.TopMenu.TabIndex = 10;
            this.TopMenu.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(935, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "-->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTExit);
            this.Controls.Add(this.PBDown);
            this.Controls.Add(this.BTReset);
            this.Controls.Add(this.BTTradotto);
            this.Controls.Add(this.BTOttieni);
            this.Controls.Add(this.RTBTraduzione);
            this.Controls.Add(this.RTBOriginale);
            this.Controls.Add(this.TopMenu);
            this.MainMenuStrip = this.TopMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 711);
            this.MinimumSize = new System.Drawing.Size(1000, 711);
            this.Name = "BTTranslator";
            this.Text = "Key Visual Arts Visual Novel Community Translator";
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBOriginale;
        private System.Windows.Forms.Button BTOttieni;
        private System.Windows.Forms.RichTextBox RTBTraduzione;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BTTradotto;
        private System.Windows.Forms.Button BTReset;
        private System.Windows.Forms.ProgressBar PBDown;
        private System.Windows.Forms.Button BTExit;
        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

