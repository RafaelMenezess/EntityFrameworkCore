using System;
using System.IO;
using System.Linq;
using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
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
                var sql = @"select a.*
                            from actor a
                            inner join
                            (select top 5 a.actor_id, count(*) as total
                            from actor a
                            inner join film_actor fa on fa.actor_id = a.actor_id
                            group by a.actor_id
                            order by total desc) filmes on filmes.actor_id = a.actor_id";

                var atoresMaisAtuantes = contexto.Atores
                                            .FromSql(sql)
                                            .Include(a => a.Filmografia);
                    //.Include(a => a.Filmografia)
                    //.OrderByDescending(a => a.Filmografia.Count)
                    //.Take(5);

                foreach (var ator in atoresMaisAtuantes)
                {
                    Console.WriteLine($"O ator {ator.PrimeiroNome + " " + ator.UltimoNome} atuou em {ator.Filmografia.Count} filmes.");
                }
            }

            Console.ReadKey();
        }
    }
}