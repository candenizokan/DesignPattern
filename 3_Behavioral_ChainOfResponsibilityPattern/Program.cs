using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Behavioral_ChainOfResponsibilityPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Chain of Responsibility - Sorumluluk Zinciri
            * Sorumluluk zincirinde temelde 3 bileşen bulunur. Uygulamaya çağrıda bulunan bir gönderici(sender), alıcı(reciver) ve zincir boyunca çalışacak bir işleyicimiz (handler) bulunur. Bu desen gelen isteği handle etmek için, işlemek için zincir boyunca ilerler.
            * 
            * Çalışma prensibine göre önce sorumluluk zinciri kurulur. Her bir halka gelen isteği işleme kapasitesindedir. Gelen istek karşılanabiliyorsa yapılır eğer o halkada o yetki yoksa diğer zincire aktarılır.
            * 
            * Sorumluluk zincirinde farklı handlerlar aynı anda çalışabilir.
            * 
            * ÖRNEĞİN: bankaya kredi çekmeye gittiğinizde 1 milyon kredi isteğiniz var. Veznedeki çalışanın bu yetkisi yoksa isteğiniz şube müdürüne, onunda yekisi yoksa bölge müdürüne ve onunda yetkisi yoksa genel müdüre aktarılır. İsteğiniz her hangi bir aşamada karşılık bulursa işlem tamamlanır ancak hiç karşılık bulmamışda olabilir.
            * 
            * ASP.NET pipeline(akış şeması) bu desen mantığında çalışır.
             
             */
        }
    }
}
