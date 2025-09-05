using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeOkak
{
    public partial class RegistrationForm: Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            
            labelEmailERR.Visible = false;
            labelLoginERR.Visible = false;

            string userLogin = textBoxLogin.Text; // text from TB
            string userEmail = textBoxEmail.Text;
            string userPassword = textBoxPass1.Text;
            string userConfPass = textBoxPass2.Text;


            if (userPassword == userConfPass && userPassword != "")
            {
                Account account = new Account(userLogin, userEmail, userPassword);

                if(AccountDB.IsValidEmail(account) && AccountDB.IsValidPassword(account))
                {
                AccountDB.Accounts.Add(account);
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                }
               
            }





        }
    }
}
