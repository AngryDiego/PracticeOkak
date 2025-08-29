using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOkak
{
    class AccountDB
    {
        // List == vector
        List<Account> Accounts { get; set; }

        public void AddAccount(Account account)
        {
            if(IsValidEmail(account) && IsValidPassword(account))
            {
                Accounts.Add(account);
            }
        }

        public bool IsValidEmail(Account account)
        {
            string mailcheck = account.Mail;
            int at = 0;
            int dot = 0;
            int atPos = 0;
            int dotPos = 0;


            for (int index = 0; index < mailcheck.Length; index++)
            {
                if ((Char.IsLetterOrDigit(mailcheck[index])))
                {  // ?
                   // "debilsim@gmail.com"
                }
                else if (mailcheck[index] == '@' && at < 1)
                {
                    at++;
                    atPos = index;    // ?
                }
                else if (mailcheck[index] == '.' && dot < 1 && index > atPos && Char.IsLetter(mailcheck[index - 1]) && Char.IsLetter(mailcheck[index + 1]))
                {
                    dot++;
                    dotPos = index;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }



        public bool IsValidPassword (Account account)
        {
            string passcheck = account.Password;

            int letters = 0;
            int symbols = 0;
            int digits = 0;
            int upercase = 0;
            int lowercase = 0;
            int whitespace = 0;

            for (int index = 0; index < passcheck.Length; index++)
            {
                if (Char.IsLetter(passcheck[index]))
                {
                    letters++;
                }
                if ((!Char.IsLetterOrDigit(passcheck[index]) && !Char.IsWhiteSpace(passcheck[index])))
                {
                    symbols++;
                }
                if (Char.IsDigit(passcheck[index]))
                {
                    digits++;
                }
                if (Char.IsUpper(passcheck[index]))
                {
                    upercase++;
                }
                if (Char.IsLower(passcheck[index]))
                {
                    lowercase++;
                }
                if (Char.IsWhiteSpace(passcheck[index]))
                {
                    whitespace++;
                }
            }

            if (letters < 7 || whitespace > 0)
            {
                //std::cout << "the password does not fall under recomended guidelines. \nPlease try to modify it." << std::endl;
                Console.WriteLine("the password does not fall under recomended guidelines. \nPlease try to modify it.");

                // метод інтерполяції
                //Console.Write($"Your password {passcheck}");
                return false;
                }
            else
                {
                    return true;
                }
        }
    }
}
