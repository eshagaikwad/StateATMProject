using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateATMProject.Model
{
    public class ATMMachine :IATMSate
    {
        IATMSate ATMSate;

        public ATMMachine()
        {
            ATMSate = new CardNotInserted();
        }
        public void InsertCard()
        {
            ATMSate.InsertCard();

            if (ATMSate is CardNotInserted)
            {
                ATMSate = new CardInserted();
                Console.WriteLine($"state Changes to: {ATMSate.GetType().Name} ");
            }
        }
        public void EjectCard()
        { 
            ATMSate.EjectCard();
            if (ATMSate is CardInserted)
            {
                ATMSate = new CardNotInserted();
                Console.WriteLine($"state Changes to: {ATMSate.GetType().Name} ");
            }
               
        }

        public void EnterPin()
        { 
        ATMSate.EnterPin();
        }

        public void withdraw()
        { 
        ATMSate.withdraw();
        
        }


    }
}
