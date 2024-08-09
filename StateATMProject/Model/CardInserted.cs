using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateATMProject.Model
{
    internal class CardInserted : IATMSate
    {
        public void InsertCard()
        {
            Console.WriteLine("YOU CANNOT INSERT THE CARD");
        }
        public void EjectCard()
        {
            Console.WriteLine("YOU CAN REMOVE THE CARD");
        }

        public void EnterPin()
        {
            Console.WriteLine("YOU CAN ENTER THE PIN");
        }

        public void withdraw()
        {
            Console.WriteLine("YOU CAN WITHDRAW THE MONEY");
        
        }
    }
}
