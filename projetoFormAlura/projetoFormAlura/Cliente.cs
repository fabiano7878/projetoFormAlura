using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormAlura
{
   class Cliente
    {

        public String Nome {get; set;}

        public String NumeroCPF { get; set; }

        public String Endereco { get; set; }

        public int Idade { get; set; }

        public Cliente()
        {

        }
        public Cliente(String nome)
        {
            this.Nome = nome;
        }


        public bool EhMaiorDeIdade
        {
            get
            {
                return this.Idade >= 18;
            }

        }
    }


}
