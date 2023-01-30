using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_ecommerce_basic.model
{
    public class elettronica : Product
    {
        private string giorno;
        private bool da_fare;

        public elettronica()
        {
            DayOfWeek d = DateTime.Today.DayOfWeek;
            Giorno = Convert.ToString(d);

            if (Giorno == "lunedì")
            {
                Da_fare = true;
            }
            else
            {
                Da_fare = false;    
            }
        }

        public string Giorno
        {
            get { return giorno; }
            private set { giorno = value; }
        }

        public bool Da_fare
        {
            get { return da_fare; }
            private set { da_fare = value; }
        }
    }
}
