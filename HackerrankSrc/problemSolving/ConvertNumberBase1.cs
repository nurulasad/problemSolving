using System;

namespace HackerrankSrc
{
    public class ConvertNumberBase1
    {


        /*
         * Convert a decimal number to base <n> number
         * 
         * for hex:  
        */


        //private string Getvalue(int i)
        //{
        //    return Convert.ToChar('A' + i).ToString();
        //}

        public string ConvertNumberBase(int number, int fromBase)
        {

            //this is same rule as converting decimal to hex, 
            //https://www.rapidtables.com/convert/number/decimal-to-hex.html


            string convertedNumber = "";

            while (number > 0)
            {
                int q = number / fromBase;
                int r = number % fromBase;

                convertedNumber = (r < 10 ? ("" + r) : Convert.ToChar('A' + r - 10).ToString()) + convertedNumber;


                number = q;

            }



            return convertedNumber;
        }

        public string ConvertHex(int src)
        {
            var s = ConvertNumberBase(src, 16);
            return s;
        }

        public string ConvertBase26(int src)
        {
            //ConvertIntToExcelTitleLC

            var s = ConvertNumberBase(src, 26);
            return s;
        }
    }

}