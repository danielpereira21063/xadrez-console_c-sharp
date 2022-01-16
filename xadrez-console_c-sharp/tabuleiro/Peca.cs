using System;
using System.Collections.Generic;
using System.Text;

namespace TabuleiroJogo
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Posicao pos, Cor cor, Tabuleiro tab)
        {
            this.Posicao = pos;
            this.Cor = cor;
            this.QtdMovimentos = 0;
            this.Tabuleiro = tab;
        }
    }
}
