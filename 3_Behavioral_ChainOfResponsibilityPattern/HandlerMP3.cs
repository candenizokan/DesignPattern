using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Behavioral_ChainOfResponsibilityPattern
{
    internal class HandlerMP3 : PlayerHandler
    {
        public override void Play(string fileType)//string bir dosya uzantısı alacaksın
        {
            if (fileType.EndsWith(".Mp3"))//EndsWith ilgili string ifadede sonu mp3 le bitiyor mu true yada false gelecek
            {
                Console.WriteLine("mp3 dosyası okunuyor..");
            }
            else
            {
                if (_nextPlayer !=null)
                {
                    _nextPlayer.Play(fileType);//benden sonraki player _nextPlayer boş değilse benden sonraki halkaya aktar
                }
            }
        }
    }
}
