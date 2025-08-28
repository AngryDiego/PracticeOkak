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
            labelERRLogin.Visible = false;
            labelERRPassword.Visible = false;

            string userLogin = textBoxLogin.Text; // text from TB
            string userPassword = textBoxPassword.Text;

            string validLogin = "On";
            string validPassword = "yak";

            if (userLogin == validLogin)
            {
                if (userPassword == validPassword)
                {
                    MessageBox.Show("Password ok", "On yak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    labelERRPassword.Text = "Invalid password (ti degenerator)";
                    labelERRPassword.Visible = true;
                }
            }
            else
            {
                labelERRLogin.Text = "Invalid login (tut nemae komentarya)";
                labelERRLogin.Visible = true;
            }

        }
    }
}
