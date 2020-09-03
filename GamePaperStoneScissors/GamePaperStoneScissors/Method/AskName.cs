using System;
using System.Collections.Generic;
using System.Text;
using BackEnd;

namespace FrontEnd.Method
{
    public class AskName
    {
        public static String Name()
        {
            String name = "";
            Console.Write(Strings.AskNamePlayer);
            name = Console.ReadLine();
            return name;
        }
    }
}
