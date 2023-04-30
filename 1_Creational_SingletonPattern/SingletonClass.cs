using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Creational_SingletonPattern
{
    public class SingletonClass
    {
        //public SingletonClass()
        //{

        //}

        //private constructor yalnızca kendi içinde hizmet eder dışarıdan nesne talebi karşılamaz '
        //sınıf ve metod access modifierlarında dikkat.
        //private ctor olduğu için dışarıdan iş yaptıramam
        private SingletonClass()
        {

        }

        // ctor çalıştırılıp nesney, aldık lakin hala dışarıdan erişilemez bir nesne!
        private static SingletonClass _tekNesne=new SingletonClass();//ne stackte ne heapte static ramde ayrı bir alanda

        //içeridiki fieldı dışarıda kullanmak için get yapmam lazım set olmayacak
        public static SingletonClass Nesnem { get { return _tekNesne; } }// içerideki fieldın taşıdığı nesneyi dışarı çıkarmaya yarıyor. static işaretli

        //bunu metod ilede yapabilirim. fielddaki nesneyi dışarısı ile paylaşan public işaretli bir metod yada property oluşturduk ! static işaretli!
        public static SingletonClass Metodum()
        {
            return _tekNesne;
        }

        public int Topla(int sayi1, int sayi2) => sayi1 + sayi2;

    }
}
