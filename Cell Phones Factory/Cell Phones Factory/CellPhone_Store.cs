using System;
using System.Collections.Generic;
using System.Text;

namespace Cell_Phones_Factory
{
    public abstract class CellPhone_Store
    {
        public abstract ICellPhone GetCellPhone(string cellphone);
    }
}
