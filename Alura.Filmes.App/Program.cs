using System;
using Alura.Filmes.App.Dados;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContexto())
            {
                foreach (var ator in contexto.Atores)
                {
                    Console.WriteLine(ator);
                }
            }
        }
    }
}