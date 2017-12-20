namespace SmamForms
{
    partial class POI
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
            this.webBrowserPOI = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserPOI
            // 
            this.webBrowserPOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserPOI.Location = new System.Drawing.Point(0, 0);
            this.webBrowserPOI.MaximumSize = new System.Drawing.Size(340, 309);
            this.webBrowserPOI.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserPOI.Name = "webBrowserPOI";
            this.webBrowserPOI.ScrollBarsEnabled = false;
            this.webBrowserPOI.Size = new System.Drawing.Size(339, 309);
            this.webBrowserPOI.TabIndex = 0;
            this.webBrowserPOI.Url = new System.Uri("http://google.nl", System.UriKind.Absolute);
            // 
            // POI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 611);
            this.Controls.Add(this.webBrowserPOI);
            this.Name = "POI";
            this.Text = "POI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserPOI;
    }
}