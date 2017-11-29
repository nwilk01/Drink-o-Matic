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
            this.DrinkHistory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.username.Location = new System.Drawing.Point(240, 34);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Size = new System.Drawing.Size(461, 62);
            this.username.TabIndex = 0;
            this.username.Text = "Joseph Szczechowicz";
            // 
            // tab
            // 
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.tab.Location = new System.Drawing.Point(240, 129);
            this.tab.Multiline = true;
            this.tab.Name = "tab";
            this.tab.ReadOnly = true;
            this.tab.Size = new System.Drawing.Size(247, 54);
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
            this.history.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DrinkHistory});
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.history.Location = new System.Drawing.Point(41, 207);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(667, 382);
            this.history.TabIndex = 4;
            this.history.UseCompatibleStateImageBehavior = false;
            // 
            // DrinkHistory
            // 
            this.DrinkHistory.Text = "Drinks Ordered";
            this.DrinkHistory.Width = 382;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 601);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.ColumnHeader DrinkHistory;
        private System.Windows.Forms.Button button1;
    }
}