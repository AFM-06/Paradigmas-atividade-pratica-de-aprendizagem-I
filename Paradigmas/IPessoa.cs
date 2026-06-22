using System;
using System.Collections.Generic;
using System.Text;

namespace Paradigmas
{
    internal interface IPessoa
    {
        public string Nome { get; set; }
        public int Idade {  get; set; }
        public void preencher();
        public void exibir();
    }
}
