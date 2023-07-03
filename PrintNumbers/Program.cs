using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            for(i=1;i<=20;i++)
            {
                //  Console.WriteLine(i);
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("OneXTel");
                }
               else if (i % 5 == 0)
                {
                    Console.WriteLine("Tel");
                }
               // Console.WriteLine(i);
              else  if(i%3== 0)
                {
                    Console.WriteLine("OneX");
                }
                else 
                {
                    Console.WriteLine(i);
                 }
            }
        }
    }
}
