﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication21
{
    public class TréMedve

    {
        public event EventHandler ordit;

        public void azonosito()
        {
            string Azonositod;

            Console.WriteLine("Add meg az azonosito szamod");

            Azonositod = Console.ReadLine();


            Console.WriteLine("azonosito:{}", Azonositod);
            Console.ReadKey();

        }
    }
}