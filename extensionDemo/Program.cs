using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "Hello extension Method?";
            int iq = s.WordCount();
            Console.WriteLine($"Number of Word: {iq} ");
            Console.ReadLine();
        }
    }
}
