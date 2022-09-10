using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AzZazi!";
            Console.ForegroundColor = ConsoleColor.Green;
            //////////////////////////////////////////////////

            Cash C = new Cash();
            MasterCard M = new MasterCard();
            Debit D = new Debit();
            Visa V = new Visa();

            Cashier Cash = new Cashier(C);
            Cashier Cash1 = new Cashier(M);
            Cashier Cash2 = new Cashier(D);
            Cashier Cash3 = new Cashier(V);
            /// <summary>
            /// Or Cashier Cash = new Cashier(new Cash); //Directly Like Anonymous Object.
            /// </summary>
            Cash.CheckPayment(99999.94m);
            Cash1.CheckPayment(99999.94m);
            Cash2.CheckPayment(99999.94m);
            Cash3.CheckPayment(99999.94m);
        }
    }
}
