using DigBank.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigBank.Classes
{
    public abstract class Conta : Banco, IConta
    {
        public Conta()
        {
            NumeroAgencia= "0001";
            NumeroDaContaSequencial++;
            Movimentacoes = new List<Extrato>();
        }

        public double Saldo { get; protected set; }
        public string NumeroAgencia { get; private set; }
        public string NumeroConta { get; protected set; }
        public static int NumeroDaContaSequencial { get; private set; }
        private List<Extrato> Movimentacoes;

        public double ConsultaSaldo()
        {
            return Saldo;
        }

        public void Deposita(double valor)
        {
            DateTime dataAtual = DateTime.Now;
            Movimentacoes.Add(new Extrato(dataAtual, "Deposito", valor));
            Saldo += valor;
        }

        public bool Saca(double valor)
        {
           if(valor > ConsultaSaldo())
                return false;

            DateTime dataAtual = DateTime.Now;
            Movimentacoes.Add(new Extrato(dataAtual, "Saque", -valor));

            Saldo -= valor;  
           return true;
        }

        public string GetCodigoDoBanco()
        {
            return CodigoDoBanco;
        }

        public string GetNumeroAgencia()
        {
            return NumeroAgencia;
        }

        public string GetNumeroDaConta()
        {
            return NumeroConta;
        }

        public List<Extrato> Extrato()
        {
            return Movimentacoes;
        }
    }
}
