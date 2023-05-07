using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Behavioral_ChainOfResponsibilityPattern
{
    //bu sınıftaki amaç gelen dosya uzantısı her neyse onun bir halka tarafından çalıştırılabiliyor olması
    internal abstract class PlayerHandler
    {

        //protected bu sınıfa ve bu sınıfran kalıtım alanlarda kullanılabilir.
        //buradaki amaç her playerHandler nesnesininden sonraki elemanı belirleyebilmek.
        protected PlayerHandler _nextPlayer;

        public PlayerHandler NextPlayer { set { _nextPlayer = value; } }

        // abstract sınıf içeriindeki abstract metod ezilmek zorunde bu yüzden her playerHandler nesnesi i.inde play methodu olacak.
        public abstract void Play(string fileType);
    }
}
