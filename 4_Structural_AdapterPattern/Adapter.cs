﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Structural_AdapterPattern
{
    //IHedef ile uyarlanacak sınıfı arasına düşündüğümüz adaptasyon sınıf, iki yapıyıda iki yapının yeteneklerini de kullanır.
    internal class Adapter
    {
        public IHedef Eleman { get; set; }// setter  inject
        private readonly IHedef _eleman;//ctor injection

        public Adapter(IHedef hedef)
        {
            _eleman = hedef;
        }

    }
}
