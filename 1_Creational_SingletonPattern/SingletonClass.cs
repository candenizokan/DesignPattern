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
    }
}
