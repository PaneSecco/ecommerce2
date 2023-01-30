using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_ecommerce_basic.model
{
    internal class alimentari : Product
    {
        private int giorno;
        private bool da_fare;

        public alimentari(int giorno)
        {
            Giorno = giorno;
            if (Giorno % 2 == 0)
            {
                Da_fare = true;
            }
            else
            {
                Da_fare = false;
            }
        }
        public int Giorno
        {
            get { return giorno; }
            private set { giorno = value; }
        }

        public bool Da_fare
        {
            get { return da_fare; }
            private set
            { da_fare = value; }
        }
    }
}
