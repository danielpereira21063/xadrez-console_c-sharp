namespace TabuleiroJogo
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        public Peca[,] Pecas { get; set; }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca RetornarPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public void ColocarPeca(Peca peca, Posicao pos)
        {
            Pecas[pos.Linha, pos.Coluna] = peca;
            peca.Posicao = pos;
        }
    }
}
