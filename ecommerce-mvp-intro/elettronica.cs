using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_ecommerce_basic.model
{
    public class elettronica : Product
    {
        public elettronica() 
        {
            
        }

        public override float sconto_()
        {
            DayOfWeek d = DateTime.Today.DayOfWeek;
            string giorno = Convert.ToString(d);

            if (giorno == "Lunedì")
            {
                float sconto = Price / 100 * Sconto;
                return Price - sconto;
            }
            else
            {
                return this._price;
            }
        }
    }
}
