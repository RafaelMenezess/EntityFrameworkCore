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

                var atores = contexto.Atores
                    .OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                    .Take(10);

                foreach (var a in atores)
                {
                    Console.WriteLine(a + " - " + contexto.Entry(a).Property("last_update").CurrentValue);
                }

            }

            Console.ReadKey();
        }
    }
}