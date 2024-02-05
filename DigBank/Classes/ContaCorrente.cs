using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigBank.Classes
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
            NumeroConta = "00" + Conta.NumeroDaContaSequencial; 
        }
    }
}
