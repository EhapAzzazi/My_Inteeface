using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    class Cashier
    {
        private IPayment Payment { get; set; }
        public Cashier(IPayment _payment)
        {
            this.Payment = _payment;
        }
        public void CheckPayment(decimal _cash)
        {
            Payment.Pay(_cash);
        }
    }
    class Cash : IPayment
    {
        public void Pay(decimal _cash)
        {
            Console.WriteLine($"{this.GetType().Name} Payment: {Math.Round(_cash, 2):N0}");
        }
    }
    class Visa : IPayment
    {
        public void Pay(decimal _cash)
        {
            Console.WriteLine($"{this.GetType().Name} Payment: {Math.Round(_cash, 2):N0}");
        }
    }
    class MasterCard : IPayment
    {
        public void Pay(decimal _cash)
        {
            Console.WriteLine($"{this.GetType().Name} Payment: {Math.Round(_cash, 2):N0}");
        }
    }
    class Debit : IPayment
    {
        public void Pay(decimal _cash)
        {
            Console.WriteLine($"{this.GetType().Name} Payment: {Math.Round(_cash, 2):N0}");
        }
    }
}
