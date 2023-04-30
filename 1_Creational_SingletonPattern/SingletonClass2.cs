using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Creational_SingletonPattern
{
    public class SingletonClass2
    {
        //private ctor
        //private static field
        // sınıf içinde oluşan nesneyi paylaşarak public property / metod
        private SingletonClass2()
        {

        }

        private static SingletonClass2 _nesne;

        public static SingletonClass2 Yetenek()
        {
            if( _nesne == null)
            {
                _nesne = new SingletonClass2();

            }
            return _nesne;
            
        }

        public static SingletonClass2 Ozellik
        {
            get
            {
                if (_nesne == null) _nesne = new SingletonClass2();
                return (_nesne);
               
            }
        }

        public int Hesapla(int s1, int s2) => s1 + s2;
    }
}
