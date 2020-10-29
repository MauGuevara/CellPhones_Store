using System;

namespace Cell_Phones_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            CellPhone_Store store = new Concrete_Cellphone_Store();

            ICellPhone iphone10 = store.GetCellPhone("Iphone X");
            iphone10.sell_phone("mauricio",9353864,1000);

            ICellPhone samsung = store.GetCellPhone("Samsung S10");
            samsung.sell_phone("andres",3027905,900);

            Console.ReadKey();
        }
    }
}
