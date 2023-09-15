using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class Base
    {
        public static bool ToValidateNumericTextBox(char ch)
        {
            bool result = true;

            if (Char.IsDigit(ch))
            {
                result = true;
            }
            else
            {
                result = false;
            }


            return result;
        }

    }
}
