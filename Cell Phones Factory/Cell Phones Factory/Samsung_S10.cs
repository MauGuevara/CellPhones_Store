using System;
using System.Collections.Generic;
using System.Text;

namespace Cell_Phones_Factory
{
    class Samsung_S10 : ICellPhone
    {
        public void sell_phone(string name, int ci, int price)
        {

            Console.WriteLine("Samsung S10 sell to : " + name+" with ci "+ci.ToString()+" and price: "+price.ToString() + "$");
        }
    }
}
