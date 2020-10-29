using System;
using System.Collections.Generic;
using System.Text;

namespace Cell_Phones_Factory
{
    class Iphone_X : ICellPhone
    {

        public void sell_phone(string name, int ci, int price)
        {
            Console.WriteLine("Iphone X sell to: " + name+" with ci "+ci.ToString()+" and price: "+price.ToString()+"$");
        }
    }
}
