using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EwalletApp.ViewModels
{
   public class ValidateData
    {
        public ValidateData()
        {

        }

        public bool VerdifyNum(string input)
        {
            if (input == null)
            {
                return false;
            }
            if (input.Length < 1)
            {
                return false;
            }
            string strRegex =
                    @"^([0-9]+)";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(input))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public string birthDateSet(string input)
        {
            if (input == null)
            {
                return "";
            }
            if (input.Length < 1)
            {
                return "";
            }
           

            char[] inputByte = input.ToCharArray();
            string formatDate = "";
            int check = input.Length;
            if(check > 10)
            {
                check = 10;
            }
            for (int i = 0; i < check; i++)
            {
                if(i== 2 && inputByte[i] != '/')
                {
                    formatDate += "/";
                }else if (i == 5 && inputByte[i] != '/')
                {
                    formatDate += "/";
                }

                formatDate += inputByte[i];
            }
           

            return formatDate;



        }

        public bool VerdifyName(string name)
        {
            if (name == null)
            {
                return false;
            }
            if (name.Length < 1)
            {
                return false;
            }
            string strRegex =
                    @"^([a-zA-Z0-9_ก-๛]+)";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
       
        public bool VerdifyEmail(string email)
        {
            if(email == null)
            {
                return false;
            }
            if (email.Length < 1)
            {
                return false;
            }
            else
            {
                string strRegex =
                    @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(email))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }



        }


    }
}
