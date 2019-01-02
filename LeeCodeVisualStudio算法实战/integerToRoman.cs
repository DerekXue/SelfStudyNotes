using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int para = 1994;
            string answ=integerToRoman(para);
            Console.Write(answ);
            Console.ReadKey();

        }

        public static string integerToRoman(int para)
        {
            string answ = "";
            int counter = 0;
            while (para > 0)
            {
                int num = para % 10;
                string theI = "";
                string theV = "";
                string theX = "";
                if (counter==0)
                {
                    theI = "I";
                    theV = "V";
                    theX = "X";
                }
                else if (counter == 1)
                {
                    theI = "X";
                    theV = "L";
                    theX = "C";
                }
                else if (counter == 2)
                {
                    theI = "C";
                    theV = "D";
                    theX = "M";
                }
                else if(counter==3)
                {
                    theI = "M";
                }
                switch (num)
                {
                    case 1:answ = theI + answ; break;
                    case 2:answ = theI+ theI + answ;break;
                    case 3: answ = theI+ theI+ theI + answ; break;
                    case 4: answ = theI+theV + answ; break;
                    case 5: answ = theV + answ; break;
                    case 6: answ = theV+theI + answ; break;
                    case 7: answ = theV+theI+theI + answ; break;
                    case 8: answ = theV + theI + theI+theI + answ; break;
                    case 9: answ = theI+theX + answ; break;
                    case 0: answ = "" + answ; break;
                }
                para = para / 10;
                counter++;
            }
            return answ;
        }
    }
}
