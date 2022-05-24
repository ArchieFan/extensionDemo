using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionDemo
{
    internal static class extension
    {

        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ','.','?' }, StringSplitOptions.RemoveEmptyEntries).Count();
        }
    }
}
