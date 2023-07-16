using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LdapTools
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonLdapUsers_Click(object sender, EventArgs e)
        {
            Ldap ldap = new Ldap();
            List<string> users = ldap.GetKerberoastableUsers();
            foreach (string user in users)
            {
                listBoxKerberoastableUsers.Items.Add(user);
            }
        }
    }
}
