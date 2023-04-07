namespace Drugi__bolji_nacin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.brojeviKojiSuDeljiviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sa2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sa5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sa7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sa11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplikacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izadjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brojeviKojiSuDeljiviToolStripMenuItem,
            this.aplikacijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // brojeviKojiSuDeljiviToolStripMenuItem
            // 
            this.brojeviKojiSuDeljiviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sa2ToolStripMenuItem,
            this.sa5ToolStripMenuItem,
            this.sa7ToolStripMenuItem,
            this.sa11ToolStripMenuItem});
            this.brojeviKojiSuDeljiviToolStripMenuItem.Name = "brojeviKojiSuDeljiviToolStripMenuItem";
            this.brojeviKojiSuDeljiviToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.brojeviKojiSuDeljiviToolStripMenuItem.Text = "Brojevi koji su deljivi";
            // 
            // sa2ToolStripMenuItem
            // 
            this.sa2ToolStripMenuItem.Name = "sa2ToolStripMenuItem";
            this.sa2ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.sa2ToolStripMenuItem.Text = "sa 2";
            this.sa2ToolStripMenuItem.Click += new System.EventHandler(this.Sa2ToolStripMenuItem_Click);
            // 
            // sa5ToolStripMenuItem
            // 
            this.sa5ToolStripMenuItem.Name = "sa5ToolStripMenuItem";
            this.sa5ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.sa5ToolStripMenuItem.Text = "sa 5";
            this.sa5ToolStripMenuItem.Click += new System.EventHandler(this.Sa5ToolStripMenuItem_Click);
            // 
            // sa7ToolStripMenuItem
            // 
            this.sa7ToolStripMenuItem.Name = "sa7ToolStripMenuItem";
            this.sa7ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.sa7ToolStripMenuItem.Text = "sa 7";
            this.sa7ToolStripMenuItem.Click += new System.EventHandler(this.Sa7ToolStripMenuItem_Click);
            // 
            // sa11ToolStripMenuItem
            // 
            this.sa11ToolStripMenuItem.Name = "sa11ToolStripMenuItem";
            this.sa11ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.sa11ToolStripMenuItem.Text = "sa 11";
            this.sa11ToolStripMenuItem.Click += new System.EventHandler(this.sa11ToolStripMenuItem_Click);
            // 
            // aplikacijaToolStripMenuItem
            // 
            this.aplikacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izadjiToolStripMenuItem});
            this.aplikacijaToolStripMenuItem.Name = "aplikacijaToolStripMenuItem";
            this.aplikacijaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aplikacijaToolStripMenuItem.Text = "Aplikacija";
            // 
            // izadjiToolStripMenuItem
            // 
            this.izadjiToolStripMenuItem.Name = "izadjiToolStripMenuItem";
            this.izadjiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izadjiToolStripMenuItem.Text = "Izadji";
            this.izadjiToolStripMenuItem.Click += new System.EventHandler(this.izadjiToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Deljivost brojeva (brojevi do 30)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem brojeviKojiSuDeljiviToolStripMenuItem;
        private ToolStripMenuItem sa2ToolStripMenuItem;
        private ToolStripMenuItem sa5ToolStripMenuItem;
        private ToolStripMenuItem sa7ToolStripMenuItem;
        private ToolStripMenuItem sa11ToolStripMenuItem;
        private ToolStripMenuItem aplikacijaToolStripMenuItem;
        private ToolStripMenuItem izadjiToolStripMenuItem;
        private RichTextBox richTextBox1;
    }
}