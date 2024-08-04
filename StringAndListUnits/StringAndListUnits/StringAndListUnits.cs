    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndListUnits
{
    public class StringValidator
    {
        public static bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }


        public static bool IsPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 10 && phoneNumber.All(char.IsDigit);
        }
    }

    public class ListManipulator
    {
        public static int FindMax(List<int> numbers)
        {
            return numbers.Max();
        }


        public static List<int> RemoveDuplicates(List<int> numbers)
        {
            return numbers.Distinct().ToList();
        }
    }

}
