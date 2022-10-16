// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;

     List<int> Numbers = new List<int> { 30, 54, 3, 14, 25, 82, 1, 100, 23, 95, 10, 56, 34 };

            var select = Numbers.Where(x => x > 30 && x < 100);

            foreach (var s in select)
            {
                Console.Write($"{s} ");
            }
        



