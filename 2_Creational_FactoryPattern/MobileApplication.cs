using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Creational_FactoryPattern
{
    //oluşturacağım nesnelerin kullancağı / kalıtımsal olarak kullandığı arayüz
    public abstract class MobileApplication
    {
        public abstract void Platform();
    }
}
