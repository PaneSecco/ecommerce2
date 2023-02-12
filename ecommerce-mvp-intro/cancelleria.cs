﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_ecommerce_basic.model
{
    public class cancelleria : Product
    {
        public cancelleria()
        {

        }

        public override float sconto_()
        {
            var today = DateTime.Now;

            if (today.Day % 2 == 0)
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
