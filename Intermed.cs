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
        public string BinToDec(string num)
        {
            int iexpo, iContador = 0, iresult = 0;
            char[] cNum = num.ToCharArray();
            Array.Reverse(cNum);

            foreach (char c in cNum)
            {
                if (c == '1')
                {
                    //Isso daqui eu não sabia, pensei que podia usar "^" e descobri que não.
                    iexpo = (int)Math.Pow(2, iContador);
                    iresult += iexpo;
                }
                iContador++;
            }

            string result = iresult.ToString();
            return result;
        }
        public string OctaToBin(string num)
        {
            char[] cNum = num.ToCharArray();
            //Array.Reverse(cNum);
            List<string> lResult = new List<string>();

            foreach(char c in cNum)
            {
                switch(c)
                {
                    case '0':
                        lResult.Add("000");
                        break;
                    case '1':
                        lResult.Add("001");
                        break;
                    case '2':
                        lResult.Add("010");
                        break;
                    case '3':
                        lResult.Add("011");
                        break;
                    case '4':
                        lResult.Add("100");
                        break;
                    case '5':
                        lResult.Add("101");
                        break;
                    case '6':
                        lResult.Add("110");
                        break;
                    case '7':
                        lResult.Add("111");
                        break;
                }
                //List<string> lNumero = new List<string>();
                //int i = Convert.ToInt16(c);
                //if (i >= 4)
                //{
                //    i -= 4;
                //    lNumero.Add("1");
                //}
                //else lNumero.Add("0");
                //if (i >= 2)
                //{
                //    i -= 2;
                //    lNumero.Add("1");
                //}
                //if (i == 1)
                //{
                //    lNumero.Add("1");
                //}
                //else lNumero.Add("000");

                //lNumero.Reverse();
                ////Pesquisado também
                //lResult.AddRange(lNumero);
            }

            
            string result = String.Join("", lResult);
            return result;
        }
       
    }
}
