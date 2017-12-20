namespace SmamForms
{
    partial class ArticleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticleForm));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitelArticle = new System.Windows.Forms.Label();
            this.pbArticle1 = new System.Windows.Forms.PictureBox();
            this.pbArticle2 = new System.Windows.Forms.PictureBox();
            this.pbArticle3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtArticleText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(37, 37);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTitelArticle
            // 
            this.labelTitelArticle.AutoSize = true;
            this.labelTitelArticle.BackColor = System.Drawing.Color.White;
            this.labelTitelArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitelArticle.Location = new System.Drawing.Point(55, 12);
            this.labelTitelArticle.Name = "labelTitelArticle";
            this.labelTitelArticle.Size = new System.Drawing.Size(231, 37);
            this.labelTitelArticle.TabIndex = 1;
            this.labelTitelArticle.Text = "Titel van artikel";
            // 
            // pbArticle1
            // 
            this.pbArticle1.Location = new System.Drawing.Point(252, 52);
            this.pbArticle1.Name = "pbArticle1";
            this.pbArticle1.Size = new System.Drawing.Size(75, 75);
            this.pbArticle1.TabIndex = 3;
            this.pbArticle1.TabStop = false;
            // 
            // pbArticle2
            // 
            this.pbArticle2.Location = new System.Drawing.Point(252, 133);
            this.pbArticle2.Name = "pbArticle2";
            this.pbArticle2.Size = new System.Drawing.Size(75, 75);
            this.pbArticle2.TabIndex = 4;
            this.pbArticle2.TabStop = false;
            // 
            // pbArticle3
            // 
            this.pbArticle3.Location = new System.Drawing.Point(252, 214);
            this.pbArticle3.Name = "pbArticle3";
            this.pbArticle3.Size = new System.Drawing.Size(75, 75);
            this.pbArticle3.TabIndex = 5;
            this.pbArticle3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(252, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(252, 376);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(252, 457);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 75);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // txtArticleText
            // 
            this.txtArticleText.BackColor = System.Drawing.Color.White;
            this.txtArticleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArticleText.Location = new System.Drawing.Point(12, 52);
            this.txtArticleText.Multiline = true;
            this.txtArticleText.Name = "txtArticleText";
            this.txtArticleText.ReadOnly = true;
            this.txtArticleText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArticleText.Size = new System.Drawing.Size(234, 547);
            this.txtArticleText.TabIndex = 9;
            // 
            // ArticleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 611);
            this.Controls.Add(this.txtArticleText);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbArticle3);
            this.Controls.Add(this.pbArticle2);
            this.Controls.Add(this.pbArticle1);
            this.Controls.Add(this.labelTitelArticle);
            this.Controls.Add(this.buttonBack);
            this.MaximumSize = new System.Drawing.Size(355, 650);
            this.MinimumSize = new System.Drawing.Size(355, 650);
            this.Name = "ArticleForm";
            this.Text = "SMAM";
            this.Load += new System.EventHandler(this.ArticleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArticle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTitelArticle;
        private System.Windows.Forms.PictureBox pbArticle1;
        private System.Windows.Forms.PictureBox pbArticle2;
        private System.Windows.Forms.PictureBox pbArticle3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtArticleText;
    }
}