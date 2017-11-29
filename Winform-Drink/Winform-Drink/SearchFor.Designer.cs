namespace Winform_Drink
{
    partial class SearchFor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.searchall = new System.Windows.Forms.TabPage();
            this.searchliquor = new System.Windows.Forms.TabPage();
            this.searchmixer = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.searchall);
            this.tabControl1.Controls.Add(this.searchliquor);
            this.tabControl1.Controls.Add(this.searchmixer);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // searchall
            // 
            this.searchall.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.searchall.Location = new System.Drawing.Point(4, 22);
            this.searchall.Name = "searchall";
            this.searchall.Padding = new System.Windows.Forms.Padding(3);
            this.searchall.Size = new System.Drawing.Size(656, 388);
            this.searchall.TabIndex = 0;
            this.searchall.Text = "Search All Drinks";
            this.searchall.UseVisualStyleBackColor = true;
            // 
            // searchliquor
            // 
            this.searchliquor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.searchliquor.Location = new System.Drawing.Point(4, 34);
            this.searchliquor.Name = "searchliquor";
            this.searchliquor.Padding = new System.Windows.Forms.Padding(3);
            this.searchliquor.Size = new System.Drawing.Size(656, 376);
            this.searchliquor.TabIndex = 1;
            this.searchliquor.Text = " Search By Liquor";
            this.searchliquor.UseVisualStyleBackColor = true;
            // 
            // searchmixer
            // 
            this.searchmixer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.searchmixer.Location = new System.Drawing.Point(4, 34);
            this.searchmixer.Name = "searchmixer";
            this.searchmixer.Size = new System.Drawing.Size(656, 376);
            this.searchmixer.TabIndex = 2;
            this.searchmixer.Text = "Search By Mixer";
            this.searchmixer.UseVisualStyleBackColor = true;
            // 
            // SearchFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 438);
            this.Controls.Add(this.tabControl1);
            this.Name = "SearchFor";
            this.Text = "SearchFor";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage searchall;
        private System.Windows.Forms.TabPage searchliquor;
        private System.Windows.Forms.TabPage searchmixer;
    }
}