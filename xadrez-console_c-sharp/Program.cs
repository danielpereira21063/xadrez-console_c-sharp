using System;
using TabuleiroJogo;

namespace xadrez_console_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao pos;

            pos = new Posicao(3, 4);

            Tabuleiro tab = new Tabuleiro(8, 8);

            Console.WriteLine(pos.ToString());
        }
    }
}
