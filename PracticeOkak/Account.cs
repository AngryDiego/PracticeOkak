using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PracticeOkak
{
    public class Account
    {
        // properties
        // fields

        // properties Name {get; set;}
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        // constructor
        public Account(string n, string m, string p )
        {
            Username = n;
            Mail = m;
            Password = p;
        }
    }
}
