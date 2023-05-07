using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Behavioral_ChainOfResponsibilityPattern
{
    internal class HandleMP4 : PlayerHandler
    {
        public override void Play(string fileType)
        {
            if (fileType.EndsWith(".Mp4"))//EndsWith ilgili string ifadede sonu mp4 le bitiyor mu true yada false gelecek
            {
                Console.WriteLine("mp4 dosyası okunuyor..");
            }
            else
            {
                if (_nextPlayer != null)
                {
                    _nextPlayer.Play(fileType);//benden sonraki player _nextPlayer boş değilse benden sonraki halkaya aktar
                }
            }
        }
    }
}
