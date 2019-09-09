using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaCorrente : Conta
    {

        //override indica que o	método está	sobrescrevendo um método da	classe pai. 
        public override void Saca(double valorOperacao)
        {
            base.Saca(valorOperacao + 0.10);
        }

        public override void Deposita(double valorOperacao)
        {
            base.Deposita(valorOperacao + 0.05);
        }
    }
}
