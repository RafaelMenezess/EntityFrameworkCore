using System;
using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Negocio;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContexto())
            {
                var ator = new Ator();
                ator.PrimeiroNome = "Tom";
                ator.UltimoNome = "Hancks";
                contexto.Entry(ator).Property("last_update").CurrentValue = DateTime.Now;

                contexto.Atores.Add(ator);
                contexto.SaveChanges();

            }

            Console.ReadKey();
        }
    }
}