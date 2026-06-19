using System;
using System.Collections.Generic;
using System.Text;

namespace Paradigmas
{
    public interface IPessoa
    {
        string Nome { get; set; }
        int Idade {  get; set; }
        void preencher();
    }
}
