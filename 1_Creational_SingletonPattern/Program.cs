﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Creational_SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Singleton Design Pattern => yapı açısından basittir. bu özel bir örnekleme ve bu örnekleme başvurmanın tek yolu sağlayan static bir yönteme sahip tek bir sınıftır.

            Private işaretlenmiş bir constructor olmalıdır.
            Çünkü nesnenin dışarıdan üretilmemesi içeride tek bir sefer oluşturulup sürekli aynı nesnenin kullanılması istenir.
            Diğer bir deyişle nesnein kullanım süresi boyunca bir sefer oluşturulup çokça kullanılması mantığına dayanır.

            Singleton ile üretilen nesnenin kendine has bir yaşam döngüsü vardır bu yüzden her önümüze gelen nesneyi bu şekilde oluşturamayız. Singleton nesneler statik sınıflar gibi RAM üzerinde yaşam alanlarında biricikklerdir. Dikkatli kullanmak gerekir
             
             */
            //SingletonClass singletonClass = new SingletonClass(); private ctor olduğu için kızıyor 

            //statik işaretli oldukları için ulaşabiliyorum SingletonClass'a
            int sonuc = SingletonClass.Nesnem.Topla(4, 5);
            int sonuc1 = SingletonClass.Metodum().Topla(4, 5);

            Console.WriteLine("sonuc = >" + sonuc + "*****" + sonuc1);


            int cevap = SingletonClass2.Ozellik.Hesapla(4, 5);
            int cevap1 = SingletonClass2.Yetenek().Hesapla(4, 5);

            Console.WriteLine("sonuc = >" + cevap + "*****" + cevap1);

            Console.ReadLine();
        }
    }
}
