using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Behavioral_ChainOfResponsibilityPattern
{
    internal class HandlerAVI : PlayerHandler
    {
        public override void Play(string fileType)
        {
            if (fileType.EndsWith(".Avi"))//EndsWith ilgili string ifadede sonu AVI le bitiyor mu true yada false gelecek
            {
                Console.WriteLine("Avi dosyası okunuyor..");
            }
            else
            {
                Console.WriteLine("Benim için geçersiz dosya formatı...");
            }
        }
    }
}
