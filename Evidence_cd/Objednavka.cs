using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evidence_cd
{
    public class Objednavka
    {
        public Objednavka(int final_price)
        {
            final_price = _final_price;
        }
        private int _final_price;
        public int Final_Price
        {
            get { return _final_price; }
            set { _final_price = value; }
        }
    }
}