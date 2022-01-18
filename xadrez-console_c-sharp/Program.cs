using System;
using TabuleiroJogo;
using Xadrez;

namespace xadrez_console_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Tabuleiro tab = new Tabuleiro(8, 8);

                //tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                //tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 0));
                //tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

                //Tela.ImprimirTabuleiro(tab);

                PosicaoXadrez pos = new PosicaoXadrez('e', 1);

                Console.WriteLine(pos.ToPosicao());

                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
