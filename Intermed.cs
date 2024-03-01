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
                //else lNumero.Add("0");

                //lNumero.Reverse();
                ////Pesquisado também
                //lResult.AddRange(lNumero);
            }

            
            string result = String.Join("", lResult);
            return result;
        }
        public string BinToOcta(string num)
        {
            char[] cNum = num.ToCharArray();

            if (cNum.Length % 3 != 0)
            {
                int addZero = 3 - (cNum.Length % 3);
                char[] novoArray = new char[cNum.Length + addZero];

                for (int i = 0; i < addZero; i++)
                {
                    novoArray[i] = '0';
                }
                //Copy => (origem, índice da origem, destino, índice do destino, nº a serem copiados
                //Não sabia copiar array ':D
                Array.Copy(cNum, 0, novoArray, addZero, cNum.Length);
                //Fazer com que cNum ocupe o mesmo espaço na memória que o novoArray
                cNum = novoArray;
            }
            List<string> lOctal = new List<string>();
            List<string> lNumber = new List<string>();
            //string[] sNumber = new string[3];
            cNum.Reverse();

            foreach(char c in cNum)
            {
                string unic = c.ToString();
                lNumber.Add(unic);
                if(lNumber.Count >= 3)
                {
                    //Caso dê erro de cálculo, usar Reverse antes do Join
                    //lNumber.Reverse();
                    string item = string.Join("", lNumber);
                    string result = CheckOctal(item);
                    lOctal.Add(result);
                    lNumber.Clear();
                }
            }
            if(lNumber.Count == 1)
            {
                lNumber[0] = "00" + lNumber[0];
                string item = string.Join("", lNumber);
                string result = CheckOctal(item);
                lOctal.Add(result);
                lNumber.Clear();
            }
            else if(lNumber.Count == 2)
            {
                lNumber[0] = "0" + lNumber[0];
                string item = string.Join("", lNumber);
                string result = CheckOctal(item);
                lOctal.Add(result);
                lNumber.Clear();
            }

            string retorna = string.Join("", lOctal);
            return retorna;
        }
        public string HexToBin(string num)
        {
            char[] cNum = num.ToCharArray();
            //Array.Reverse(cNum);
            List<string> lResult = new List<string>();

            foreach (char c in cNum)
            {
                switch (c)
                {
                    case '0':
                        lResult.Add("0000");
                        break;
                    case '1':
                        lResult.Add("0001");
                        break;
                    case '2':
                        lResult.Add("0010");
                        break;
                    case '3':
                        lResult.Add("0011");
                        break;
                    case '4':
                        lResult.Add("0100");
                        break;
                    case '5':
                        lResult.Add("0101");
                        break;
                    case '6':
                        lResult.Add("0110");
                        break;
                    case '7':
                        lResult.Add("0111");
                        break;
                    case '8':
                        lResult.Add("1000");
                        break;
                    case '9':
                        lResult.Add("1001");
                        break;
                    case 'A':
                        lResult.Add("1010");
                        break;
                    case 'B':
                        lResult.Add("1011");
                        break;
                    case 'C':
                        lResult.Add("1100");
                        break;
                    case 'D':
                        lResult.Add("1101");
                        break;
                    case 'E':
                        lResult.Add("1110");
                        break;
                    case 'F':
                        lResult.Add("1111");
                        break;
                }
            }


            string result = String.Join("", lResult);
            return result;
        }
        public string BinToHex(string num)
        {
            char[] cNum = num.ToCharArray();

            if (cNum.Length % 4 != 0)
            {
                int addZero = 4 - (cNum.Length % 4);
                char[] novoArray = new char[cNum.Length + addZero];

                for (int i = 0; i < addZero; i++)
                {
                    novoArray[i] = '0';
                }
                //Copy => (origem, índice da origem, destino, índice do destino, nº a serem copiados
                //Não sabia copiar array ':D
                Array.Copy(cNum, 0, novoArray, addZero, cNum.Length);
                //Fazer com que cNum ocupe o mesmo espaço na memória que o novoArray
                cNum = novoArray;
            }
            List<string> lOctal = new List<string>();
            List<string> lNumber = new List<string>();
            //string[] sNumber = new string[3];
            cNum.Reverse();

            foreach (char c in cNum)
            {
                string unic = c.ToString();
                lNumber.Add(unic);
                if (lNumber.Count >= 4)
                {
                    //Caso dê erro de cálculo, usar Reverse antes do Join
                    //lNumber.Reverse();
                    string item = string.Join("", lNumber);
                    string result = CheckHexa(item);
                    lOctal.Add(result);
                    lNumber.Clear();
                }
            }
            if (lNumber.Count == 1)
            {
                lNumber[0] = "00" + lNumber[0];
                string item = string.Join("", lNumber);
                string result = CheckHexa(item);
                lOctal.Add(result);
                lNumber.Clear();
            }
            else if (lNumber.Count == 2)
            {
                lNumber[0] = "0" + lNumber[0];
                string item = string.Join("", lNumber);
                string result = CheckHexa(item);
                lOctal.Add(result);
                lNumber.Clear();
            }

            string retorna = string.Join("", lOctal);
            return retorna;
        }
        //Alterar binário para decimal, baseado na tabela de conversão.
        private string CheckOctal(string val)
        {
            string retVal = "";

            switch(val)
            {
                case "000":
                    retVal = "0";
                    break;
                case "001":
                    retVal = "1";
                    break;
                case "010":
                    retVal = "2";
                    break;
                case "011":
                    retVal = "3";
                    break;
                case "100":
                    retVal = "4";
                    break;
                case "101":
                    retVal = "5";
                    break;
                case "110":
                    retVal = "6";
                    break;
                case "111":
                    retVal = "7";
                    break;
            }

            return retVal;
        }
        private string CheckHexa(string val)
        {
            string retVal = "";

            switch (val)
            {
                case "0000":
                    retVal = "0";
                    break;
                case "0001":
                    retVal = "1";
                    break;
                case "0010":
                    retVal = "2";
                    break;
                case "0011":
                    retVal = "3";
                    break;
                case "0100":
                    retVal = "4";
                    break;
                case "0101":
                    retVal = "5";
                    break;
                case "0110":
                    retVal = "6";
                    break;
                case "0111":
                    retVal = "7";
                    break;
                case "1000":
                    retVal = "8";
                    break;
                case "1001":
                    retVal = "9";
                    break;
                case "1010":
                    retVal = "A";
                    break;
                case "1011":
                    retVal = "B";
                    break;
                case "1100":
                    retVal = "C";
                    break;
                case "1101":
                    retVal = "D";
                    break;
                case "1110":
                    retVal = "E";
                    break;
                case "1111":
                    retVal = "F";
                    break;
            }

            return retVal;
        }

    }
}
