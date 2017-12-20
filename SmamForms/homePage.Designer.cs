namespace SmamForms
{
    partial class homePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.buttonShoppingList = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip van de dag";
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new System.Drawing.Point(115, 22);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(87, 13);
            this.labelHint.TabIndex = 1;
            this.labelHint.Text = "Hier komt een tip";
            // 
            // buttonShoppingList
            // 
            this.buttonShoppingList.Location = new System.Drawing.Point(60, 259);
            this.buttonShoppingList.Name = "buttonShoppingList";
            this.buttonShoppingList.Size = new System.Drawing.Size(100, 100);
            this.buttonShoppingList.TabIndex = 2;
            this.buttonShoppingList.Text = "Boodschappen";
            this.buttonShoppingList.UseVisualStyleBackColor = true;
            this.buttonShoppingList.Click += new System.EventHandler(this.buttonShoppingList_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 3;
            this.button2.Text = "Was";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 4;
            this.button3.Text = "POI";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(60, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 100);
            this.button4.TabIndex = 5;
            this.button4.Text = "Recept";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Location = new System.Drawing.Point(60, 471);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(100, 100);
            this.buttonSetting.TabIndex = 6;
            this.buttonSetting.Text = "Settings";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 611);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonShoppingList);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.label1);
            this.Name = "homePage";
            this.Text = "homePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Button buttonShoppingList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonSetting;
    }
}