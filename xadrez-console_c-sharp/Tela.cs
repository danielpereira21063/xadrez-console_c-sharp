using System;
using TabuleiroJogo;

namespace xadrez_console_c_sharp
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.RetornarPeca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.RetornarPeca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
