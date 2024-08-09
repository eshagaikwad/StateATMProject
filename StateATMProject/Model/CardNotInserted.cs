using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateATMProject.Model
{
    internal class CardNotInserted:IATMSate
    {
        public void InsertCard()
        {
            Console.WriteLine("YOU CAN INSERT THE CARD");
        }
        public void EjectCard()
        {
            Console.WriteLine("YOU CANNOT REMOVE THE CARD");
        }
        public void EnterPin()
        {
            Console.WriteLine("YOU CANNOT ENTER THE PIN");
        }

        public void withdraw()
        {
            Console.WriteLine("YOU CANNOT WITHDRAW THE MONEY");
        }
    }
}
