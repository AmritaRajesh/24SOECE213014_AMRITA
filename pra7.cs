﻿//7. Predict and write the output of the given code.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE213014_AMRITA
{
    internal class pra7
    {
        static void Main(string[] args)
        {
            int num1, res, i;

            Console.Write("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            i = 1; //Initialization

            //Check whether condition matches or not
            while (i <= 10)
            {
                res = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, res);
                i++; //Increment by one
            }
            Console.ReadLine();
        }
    }
}
