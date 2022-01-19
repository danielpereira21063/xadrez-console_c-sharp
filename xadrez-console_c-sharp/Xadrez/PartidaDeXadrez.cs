using System;
using System.Collections.Generic;
using System.Text;
using TabuleiroJogo;

namespace Xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tabuleiro { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tabuleiro = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;  
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tabuleiro.RetirarPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca pecaCapturada = Tabuleiro.RetirarPeca(destino);
            Tabuleiro.ColocarPeca(p, destino);
        }

        private void ColocarPecas()
        {
            Tabuleiro.ColocarPeca(new Rei(Tabuleiro, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
            Tabuleiro.ColocarPeca(new Rei(Tabuleiro, Cor.Preta), new PosicaoXadrez('d', 3).ToPosicao());
            Tabuleiro.ColocarPeca(new Bispo(Tabuleiro, Cor.Preta), new PosicaoXadrez('f', 7).ToPosicao());
            Tabuleiro.ColocarPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('f', 3).ToPosicao());
            Tabuleiro.ColocarPeca(new Bispo(Tabuleiro, Cor.Preta), new PosicaoXadrez('f', 1).ToPosicao());
            Tabuleiro.ColocarPeca(new Bispo(Tabuleiro, Cor.Preta), new PosicaoXadrez('h', 7).ToPosicao());
        }
    }
}
