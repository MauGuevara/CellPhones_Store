using System;
using System.Collections.Generic;
using System.Text;

namespace Cell_Phones_Factory
{
    public class Concrete_Cellphone_Store : CellPhone_Store
    {
        public override ICellPhone GetCellPhone(string cellphone) {

            switch (cellphone)
            {
                case "Iphone X":
                    return new Iphone_X();
                    
                case "Samsung S10":
                    return new Samsung_S10();

                default:
                    throw new Exception(string.Format("Cellphone '{0}' cannot be created",cellphone));


            }
        }
    }
}
