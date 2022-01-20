using TabuleiroJogo;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);

            return matriz;

            //acima
            pos.DefinirValores(pos.Linha - 1, pos.Coluna);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if(Tabuleiro.RetornarPeca(pos) != null && Tabuleiro.RetornarPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha -= 1;
            }

            //abaixo
            pos.DefinirValores(pos.Linha + 1, pos.Coluna);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.RetornarPeca(pos) != null && Tabuleiro.RetornarPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Linha += 1;
            }

            //direita
            pos.DefinirValores(pos.Linha, pos.Coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.RetornarPeca(pos) != null && Tabuleiro.RetornarPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna += 1;
            }

            //esquerda
            pos.DefinirValores(pos.Linha, pos.Coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && PodeMover(pos))
            {
                matriz[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.RetornarPeca(pos) != null && Tabuleiro.RetornarPeca(pos).Cor != Cor)
                {
                    break;
                }
                pos.Coluna -= 1;
            }
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tabuleiro.RetornarPeca(pos);

            return p == null || p.Cor != Cor;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
