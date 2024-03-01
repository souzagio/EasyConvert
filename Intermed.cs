using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyConvert
{
    internal class Intermed
    {
        // Valor de entrada
        private static Int16 _iInput = 0;
        public static Int16 iInput
        {
            get { return _iInput; }
            set { _iInput = value; }
        }

        //Método de Conversão
        public string DecToBin(int num)
        {
            List<string> result = new List<string>();
            do
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    result.Add("0");
                }
                else
                {
                    num = num - 1;
                    num = num / 2;
                    result.Add("1");
                }
            }
            while (num > 0);

            result.Reverse();
            string returnNumber = string.Join("", result);
            return returnNumber;
        }
    }
}
