﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoFormAlura
{
    class Banco
    {
        private Conta[] contas = new Conta[10];

        private int quantidade;

        public void Adiciona(Conta conta)
        {
            this.contas[this.quantidade] = conta;
            this.quantidade++;
        }

    }
}
