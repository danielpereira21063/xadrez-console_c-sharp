using System;
using System.Collections.Generic;
using System.Text;

namespace TabuleiroJogo
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        public Peca[,] Pecas { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca RetornarPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
    }
}
