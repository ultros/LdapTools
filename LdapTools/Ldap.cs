using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;

namespace LdapTools
{
    internal class Ldap
    {
        public List<string> GetKerberoastableUsers()
        {
            List<string> users = new List<string>();
            DirectoryEntry myLdapCon = CreateDirectoryEntry();

            DirectorySearcher searcher = new DirectorySearcher(myLdapCon);
            searcher.Filter = "(&(objectclass=user)(objectcategory=user)" +
                "(useraccountcontrol:1.2.840.113556.1.4.803:=4194304))";

            SearchResultCollection result = searcher.FindAll();

            foreach (SearchResult user in result)
            {
                users.Add(user.Properties["samaccountname"].OfType<string>().FirstOrDefault());
            }
            return users;
        }

        public DirectoryEntry CreateDirectoryEntry()
        {
            DirectoryEntry ldapConnection = new DirectoryEntry();

            ldapConnection.Username = "j.hammond";
            ldapConnection.Password = "P@ssw0rd";
            ldapConnection.Path = "LDAP://dc01.testnet.local/CN=Users,DC=testnet,DC=local";
            ldapConnection.AuthenticationType = AuthenticationTypes.Secure;

            return ldapConnection;
        }
    }
}
