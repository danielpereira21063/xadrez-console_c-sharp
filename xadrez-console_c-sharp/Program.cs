using System;
using tabuleiro;

namespace xadrez_console_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine(P.ToString());
        }
    }
}
