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
            this.listBoxKerberoastableUsers = new System.Windows.Forms.ListBox();
            this.buttonLdapKerberoastableUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxKerberoastableUsers
            // 
            this.listBoxKerberoastableUsers.FormattingEnabled = true;
            this.listBoxKerberoastableUsers.Location = new System.Drawing.Point(12, 12);
            this.listBoxKerberoastableUsers.Name = "listBoxKerberoastableUsers";
            this.listBoxKerberoastableUsers.Size = new System.Drawing.Size(164, 433);
            this.listBoxKerberoastableUsers.TabIndex = 0;
            // 
            // buttonLdapKerberoastableUsers
            // 
            this.buttonLdapKerberoastableUsers.Location = new System.Drawing.Point(12, 451);
            this.buttonLdapKerberoastableUsers.Name = "buttonLdapKerberoastableUsers";
            this.buttonLdapKerberoastableUsers.Size = new System.Drawing.Size(112, 37);
            this.buttonLdapKerberoastableUsers.TabIndex = 1;
            this.buttonLdapKerberoastableUsers.Text = "Get Kerberoastable";
            this.buttonLdapKerberoastableUsers.UseVisualStyleBackColor = true;
            this.buttonLdapKerberoastableUsers.Click += new System.EventHandler(this.buttonLdapUsers_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 495);
            this.Controls.Add(this.buttonLdapKerberoastableUsers);
            this.Controls.Add(this.listBoxKerberoastableUsers);
            this.Name = "formMain";
            this.Text = "LDAP Tools";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKerberoastableUsers;
        private System.Windows.Forms.Button buttonLdapKerberoastableUsers;
    }
}

