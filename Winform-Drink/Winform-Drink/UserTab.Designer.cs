namespace Winform_Drink
{
    partial class UserTab
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
            this.username = new System.Windows.Forms.TextBox();
            this.tab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.username.Location = new System.Drawing.Point(247, 26);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(461, 70);
            this.username.TabIndex = 0;
            this.username.Text = "Nathan Wilk";
            // 
            // tab
            // 
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tab.Location = new System.Drawing.Point(240, 125);
            this.tab.Multiline = true;
            this.tab.Name = "tab";
            this.tab.ReadOnly = true;
            this.tab.Size = new System.Drawing.Size(247, 71);
            this.tab.TabIndex = 1;
            this.tab.Text = "$1000.67";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label1.Location = new System.Drawing.Point(80, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tab Total:";
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(41, 207);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(667, 382);
            this.history.TabIndex = 4;
            this.history.UseCompatibleStateImageBehavior = false;
            // 
            // UserTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 601);
            this.Controls.Add(this.history);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.username);
            this.Name = "UserTab";
            this.Text = "UserTab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView history;
    }
}