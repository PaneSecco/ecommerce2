using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_ecommerce_basic.model
{
    internal class alimentari : Product
    {
        private int sconto;
        private DateTime prevDate;

        public alimentari(DateTime prevDate1)
        {

            PrevDate = prevDate;
        }

        public DateTime PrevDate
        {
            get { return prevDate; }
            set { prevDate = value; }
        }
        public int Sconto
        {
            get { return sconto; }
            set { sconto = value; }
        }
        public int sconto_(int costo_iniziale)
        {
            bool da_fare;
            var today = DateTime.Now;
            var diffOfDates = today - PrevDate;

            if (diffOfDates.Days > 7)
            {
                da_fare = true;
            }
            else
            {
                da_fare = false;
            }

            if (today.Day % 2 == 0)
            {
                da_fare = true;
            }
            else
            {
                da_fare = false;
            }

            if (da_fare == true)
            {
                int sconto = costo_iniziale / 100 * Sconto;
                return costo_iniziale - sconto;
            }
            else
            {
                return costo_iniziale;
            }
        }
    }
}
