using System;
using System.Collections.Generic;

namespace MenorPosicao
{
    class Program
    {
        static void Main(string[] args)
        {
            var tamanhoDoArray = int.Parse(Console.ReadLine());
            string[] entrada = Console.ReadLine().Split(' ');
            int numero;

            List<int> numeros = new List<int>();
            foreach (string valor in entrada)
            {
                numero = int.Parse(valor);
                numeros.Add(numero);
            }

            int menorValor = numeros[0];
            int index = 0;

            for (int i = 1; i <= tamanhoDoArray; i++)
            {
                if (menorValor > numeros[i -1 ])
                {
                    menorValor = numeros[i -1];
                    index = i -1 ;
                }
            }
            Console.WriteLine($"Menor valor: {menorValor}");
            Console.WriteLine($"Posicao: {index}");

        }
    }

}
