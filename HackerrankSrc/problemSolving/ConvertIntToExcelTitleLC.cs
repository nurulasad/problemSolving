using System;


namespace HackerrankSrc
{
    public class ConvertIntToExcelTitleLC
    {

        //https://leetcode.com/assessment/1/
        //https://www.rapidtables.com/convert/number/decimal-to-hex.html
        /*
         * Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.
         * 
         * it is basically converting base 10 number to base 26 number

    For example:

    A -> 1
    B -> 2
    C -> 3
    ...
    Z -> 26
    AA -> 27
    AB -> 28 
    ...


    Example 1:

    Input: columnNumber = 1
    Output: "A"
    Example 2:

    Input: columnNumber = 28
    Output: "AB"
    Example 3:

    Input: columnNumber = 701
    Output: "ZY"


    Constraints:

    1 <= columnNumber <= 231 - 1
         */


        //public string getvalue(int i)
        //{
        //    return Convert.ToChar('A' + i).ToString();
        //}
        public string ConvertToTitle(int columnNumber)
        {

            //this is same rule as converting decimal to hex, 
            //https://www.rapidtables.com/convert/number/decimal-to-hex.html


            string number = "";

            while (columnNumber > 0)
            {
                int q = (columnNumber - 1) / 26;
                int r = (columnNumber - 1) % 26;

                number = Convert.ToChar('A' + r).ToString() + number;


                columnNumber = q;

            }



            return number;
        }
    }

}
