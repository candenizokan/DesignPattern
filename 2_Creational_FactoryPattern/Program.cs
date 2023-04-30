using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Creational_FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
             Factory Design Pattern

            Creational grubuna ait, aynı arayüzü kullanan nesnelerin üretiminden sorumlu tasarım desenidir. Kullanım oranı fazladır.

            * Bu yaratıcı desen, her hangi bir uygulamanın hedeflediği yerden kullanılabilir, bakımı yapılabilir, test edilebilir bir yapı oluşturmmamızı sağlar. Bunun günlük hayattaki en somut örnekleri fabrikalardır.
            * 
            * * Bir fabrikanın amacı bir ürün üretmektir. Örneğin telefon üreten bir fabrika olduğunu düşünelim. Tek amacı telefon üretmektir ve müşteriler yeni tüketiciler içerde işlerin nasıl yürüdüğüyle ilgilenmezler.
            * İlgilendikleri telefonu kullanabilmektir.
            * 
            * Kuvvetli bir desendir. genişletilebilir ve modifikasyon sağlayabilir ancak yapılar büyüdüğünde karmaşıklaşmaya başlar dikkatli olmak gerekir.
            * 
            * Kalıtımsal ilişkileri olan nesnelerin üretimi için esas olan 1 metod vardır ve bu metod uygulamanın ihtiyacı olan nesnelerin üretiminde sorumludur. yani fabrika görevi görür.
            * 
            * Factory ve Abstract Factory farklı desenlerdir.
            * 
            * 
            * Esas metodu barındıran sınıf
            * Uygulamanın ihtiyacı olan nesnelerin arayüzü
            * nesneler.
             */


            //AndroidApplication app = new AndroidApplication();

            MobileApplication ma = new AndroidApplication();
            MobileApplication ma1 = new IPhoneApplication();
            MobileApplication ma2 = new WindowsApplication();




            //tek nesne üzerinden fabrikadan bunları çıkarabiliyorum
            Factory factory = new Factory();

            MobileApplication app = factory.FactoryMethod(AllMobile.Android);
            MobileApplication app2 = factory.FactoryMethod(AllMobile.IPhone);
            MobileApplication app3 = factory.FactoryMethod(AllMobile.Windows);

            app.Platform();//androidin platform metodu
            app2.Platform();//IPhone platform metodu. app2. dediğim zaman iphone içinde başka metodlarda olsa onlarada erişirdim.

        }
    }
}
