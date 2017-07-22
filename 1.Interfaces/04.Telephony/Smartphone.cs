using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Telephony
{
    public class Smartphone : ICall,IBrowse
    {
        public string Browse(string hostName)
        {
            if (IsContainsDigit(hostName))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {hostName}!";
        }

        private bool IsContainsDigit(string hostName)
        {
            foreach (char ch in hostName)
            {
                if (Char.IsDigit(ch))
                {
                    return true;
                }           
            }
            return false;
        }

        public string Call(string phoneNumber)
        {
            if (!IsContainsDigit(phoneNumber))
            {
                return "Invalid number!";
            }
            return $"Calling... {phoneNumber}";
        }
    }
}
