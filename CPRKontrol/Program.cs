using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRKontrol
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Indtast CPR nummer:");
                Console.WriteLine("(ved blank stopper koden)");
                Console.WriteLine();
                Console.Write("CPR: ");
                string CPR = Console.ReadLine();
                if (CPR == "")
                    exit = true;
                else
                {
                    bool svar = true;
                    if (CPR.Length == 11)
                    {
                        int aSum = 0;
                        if (StringExt.IsNumeric(CPR.Substring(0,1)))
                            aSum += int.Parse(CPR.Substring(0, 1)) *4;
                        else
                            svar = false;
                        if (StringExt.IsNumeric(CPR.Substring(1, 1)))
                            aSum += int.Parse(CPR.Substring(1, 1)) *3;
                        else
                            svar = false;
                        if (StringExt.IsNumeric(CPR.Substring(2, 1)))
                            aSum += int.Parse(CPR.Substring(2, 1)) *2;
                        else
                            svar = false;
                        if (StringExt.IsNumeric(CPR.Substring(3, 1)))
                            aSum += int.Parse(CPR.Substring(3, 1)) *7;
                        else
                            svar = false;
                        if (StringExt.IsNumeric(CPR.Substring(4, 1)))
                            aSum += int.Parse(CPR.Substring(4, 1)) *6;
                        else
                            svar = false;
                        if (StringExt.IsNumeric(CPR.Substring(5, 1)))
                            aSum += int.Parse(CPR.Substring(5, 1)) *5;
                        else
                            svar = false;
                        if (StringExt.IsNumeric(CPR.Substring(7, 1)))
                            aSum += int.Parse(CPR.Substring(7, 1)) *4;
                        else
                            svar = false;
                        if (StringExt.IsNumeric(CPR.Substring(8, 1)))
                            aSum += int.Parse(CPR.Substring(8, 1)) *3;
                        else
                            svar = false;
                        if (StringExt.IsNumeric(CPR.Substring(9, 1)))
                            aSum += int.Parse(CPR.Substring(9, 1))*2;
                        else
                            svar = false;
                        if (StringExt.IsNumeric(CPR.Substring(10, 1)))
                            aSum += int.Parse(CPR.Substring(10, 1)) *1;
                        else
                            svar = false;
                        if (svar)
                        {
                            svar = aSum % 11 == 0;
                        }
                    }
                    else
                    {
                        svar = false;
                    }

                    Console.WriteLine();
                    Console.WriteLine(svar?"OK!":"Falsk!");
                    Console.WriteLine();
                    Console.WriteLine("Tryk 'Enter' for at komme tilbage.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

    }

    public static class StringExt
    {
        public static bool IsNumeric(this string text)
        {
            return int.TryParse(text, out int test);
        }
    }
}
