using System;
using System.Text;

namespace SpellNumber
{
    public class Program
    {
        private static string[] one = {"", "one ", "two ", "three ", "four ",
                    "five ", "six ", "seven ", "eight ",
                    "nine ", "ten ", "eleven ", "twelve ",
                    "thirteen ", "fourteen ", "fifteen ",
                    "sixteen ", "seventeen ", "eighteen ",
                    "nineteen "};
        private static string[] ten = {"", "", "twenty ", "thirty ", "forty ",
                    "fifty ", "sixty ", "seventy ", "eighty ",
                    "ninety "};


        private static string NumToWords(int n, string s)
        {
            StringBuilder str = new StringBuilder();

            if (n > 19)
            {
                str.Append(ten[n / 10] + one[n % 10]);
            }
            else
            {
                str.Append(one[n]);
            }

            if (n != 0)
            {
                str.Append(s);
            }

            return str.ToString();
        }

        public static string ConvertToWords(long n)
        {
            if (n == default(long))
                return "";

            StringBuilder sb = new StringBuilder();

            sb.Append(NumToWords((int)(n / 10000000),
                                        "crore "));

            sb.Append(NumToWords((int)((n / 100000) % 100),
                                                "lakh "));

            sb.Append(NumToWords((int)((n / 1000) % 100),
                                        "thousand "));

            sb.Append(NumToWords((int)((n / 100) % 10),
                                        "hundred "));

            if (n > 100 && n % 100 > 0)
            {
                sb.Append("and ");
            }

            sb.Append(NumToWords((int)(n % 100), ""));
            return sb.ToString().Trim();
        }


        static void Main(string[] args)
        {
            long number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(ConvertToWords(number));
            Console.Read();
        }
    }
}
