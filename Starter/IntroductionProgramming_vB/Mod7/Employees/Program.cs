﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Hexagon
    {
        //public void Draw() { Console.WriteLine("Drawing a hexagon!"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            /* //TODO :Delete this line and wait for further instruction.
            // A better bonus system!




            // Ack! You can't cast frank to a Hexagon, but this compiles fine!

            */ //TODO :Delete this line and wait for further instruction.
            Console.ReadLine();
        }
        /* //TODO :Delete this line and wait for further instruction.
        #region Example of "as" keyword in action
        private static void ArrayObjectObjects()
        {
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";

            foreach (object item in things)
            {
                Hexagon h = item as Hexagon;
                if (h == null)
                    Console.WriteLine("Item is not a hexagon");
                else
                {
                    h.Draw();
                }
            }
        }
        #endregion

        #region Casting examples
        static void CastingExamples()
        {
            // A Manager "is-a" System.Object, so we can
            // store a Manager reference in an object variable just fine.
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);

            // A Manager "is-an" Employee too.
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);

            // A PTSalesPerson "is-a" SalesPerson.
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jill);
        }
        #endregion

        #region Example of "is" keyword in action
        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);

            if (emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} sale(s)!", emp.Name,
                  ((SalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }
            if (emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock options...", emp.Name,
                  ((Manager)emp).StockOptions);
                Console.WriteLine();
            }
        }
        #endregion
        */ //TODO :Delete this line and wait for further instruction.
    }
}
