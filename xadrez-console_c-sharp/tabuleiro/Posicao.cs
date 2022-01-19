namespace TabuleiroJogo
{
    class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public void DefinirValores(int linha, int coluna)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public override string ToString()
        {
            return $"Linha:{ Linha }\nColuna: {Coluna}";
        }
    }
}
