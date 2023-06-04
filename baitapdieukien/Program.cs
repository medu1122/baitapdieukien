using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.Write("n : ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0 || n > 999)
        {
            Console.WriteLine("Số không hợp lệ!");
        }
        else
        {
            Console.WriteLine(ChuyenSOsangchu(n));
        }
    }

    static string ChuyenSOsangchu(int n)
    {
        if (n == 0)
        {
            return "zero";
        }

        string result = "";

        if (n >= 100)
        {
            int hundreds = n / 100;
            result += name(hundreds) + " hundred ";
            n %= 100;
        }

        // Xử lý hàng chục và đơn vị
        if (n > 0)
        {
            if (result != "")
            {
                result += "and ";
            }

            if (n < 20)
            {
                result += name(n);
            }
            else
            {
                int tens = n / 10;
                result += GetTensName(tens);

                int units = n % 10;
                if (units > 0)
                {
                    result += " " + name(units);
                }
            }
        }

        return result;
    }

    static string name(int number)
    {
        switch (number)
        {
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            case 13: return "thirteen";
            case 14: return "fourteen";
            case 15: return "fifteen";
            case 16: return "sixteen";
            case 17: return "seventeen";
            case 18: return "eighteen";
            case 19: return "nineteen";
            default: return "";
        }
    }

    static string GetTensName(int n)
    {
        switch (n)
        {
            case 2: return "twenty";
            case 3: return "thirty";
            case 4: return "forty";
            case 5: return "fifty";
            case 6: return "sixty";
            case 7: return "seventy";
            case 8: return "eighty";
            case 9: return "ninety";
            default: return "";
        }
    }
}
