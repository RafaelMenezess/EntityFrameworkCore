using System;
using System.Linq;
using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContexto())
            {
                var filme = contexto.Filmes
                    .Include(f => f.Atores)
                    .First();

                Console.WriteLine(filme);
                Console.WriteLine("Elenco");

                foreach (var item in filme.Atores)
                {
                    
                }
            }

            Console.ReadKey();
        }
    }
}