﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 9;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Adrien");
            Console.ReadKey();
            Console.WriteLine("Bienvenu dans mon monde");
            Console.WriteLine("On s'écarte");
            BonjourMonde HelloWorld = new BonjourMonde("Adrien");
            Console.WriteLine(HelloWorld.Salutation());
            Console.ReadKey();
        }

   


    }
}
