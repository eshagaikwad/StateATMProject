using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateATMProject.Model
{
    public interface IATMSate
    {
        public void InsertCard();
        public void EjectCard();
        public void EnterPin();
        public void withdraw();
    }
}
