using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormAlura
{
    class Cliente
    {

        public String nome;

        public String numeroCPF;

        public String endereco;

        public int idade;

        public bool EhMaiorDeIdade()
        {
           return this.idade >= 18;
        }

    }


}
