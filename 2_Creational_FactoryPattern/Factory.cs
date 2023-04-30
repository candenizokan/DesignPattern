using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Creational_FactoryPattern
{
    //fabrika
    public class Factory
    {
        public MobileApplication FactoryMethod(AllMobile type)
        {
            MobileApplication app = null;

            switch (type)
            {
                case AllMobile.Android:
                    app = new AndroidApplication();
                    break;
                case AllMobile.IPhone:
                    app = new IPhoneApplication();
                    break;
                case AllMobile.Windows:
                    app = new WindowsApplication();
                    break;
            }
            return app;
        }
    }
}
