namespace LdapTools
{
    partial class formMain
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
            this.listBoxAsrepRoastUsers = new System.Windows.Forms.ListBox();
            this.buttonLdapAsrepRoastUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAsrepRoastUsers
            // 
            this.listBoxAsrepRoastUsers.FormattingEnabled = true;
            this.listBoxAsrepRoastUsers.Location = new System.Drawing.Point(12, 12);
            this.listBoxAsrepRoastUsers.Name = "listBoxAsrepRoastUsers";
            this.listBoxAsrepRoastUsers.Size = new System.Drawing.Size(164, 433);
            this.listBoxAsrepRoastUsers.TabIndex = 0;
            // 
            // buttonLdapAsrepRoastUsers
            // 
            this.buttonLdapAsrepRoastUsers.Location = new System.Drawing.Point(12, 451);
            this.buttonLdapAsrepRoastUsers.Name = "buttonLdapAsrepRoastUsers";
            this.buttonLdapAsrepRoastUsers.Size = new System.Drawing.Size(112, 37);
            this.buttonLdapAsrepRoastUsers.TabIndex = 1;
            this.buttonLdapAsrepRoastUsers.Text = "Get ASREP Roastable Accounts";
            this.buttonLdapAsrepRoastUsers.UseVisualStyleBackColor = true;
            this.buttonLdapAsrepRoastUsers.Click += new System.EventHandler(this.buttonLdapUsers_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 495);
            this.Controls.Add(this.buttonLdapAsrepRoastUsers);
            this.Controls.Add(this.listBoxAsrepRoastUsers);
            this.Name = "formMain";
            this.Text = "LDAP Tools";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAsrepRoastUsers;
        private System.Windows.Forms.Button buttonLdapAsrepRoastUsers;
    }
}

