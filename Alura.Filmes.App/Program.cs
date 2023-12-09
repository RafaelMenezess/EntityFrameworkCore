using System;
using System.Data.SqlClient;
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
                var sql = "INSERT INTO language (name) VALUES ('Teste 1'), ('Teste 1'), ('Teste 1')";
                var registros = contexto.Database.ExecuteSqlCommand(sql);
                Console.WriteLine($"O total de registros afetados é {registros}.");

                var deletSql = "DELETE FROM language WHERE name LIKE 'Teste%'";
                registros = contexto.Database.ExecuteSqlCommand(deletSql);
                Console.WriteLine($"O total de registros afetados é {registros}.");
            }

            Console.ReadKey();
        }


        private static void StoredProcedure(AluraFilmesContexto contexto)
        {
            var categ = "Action";
            var paramCateg = new SqlParameter("category_name", categ);
            var paramTotal = new SqlParameter
            {
                ParameterName = "@total_actors",
                Size = 4,
                Direction = System.Data.ParameterDirection.Output
            };

            contexto
                .Database
                .ExecuteSqlCommand("total_actors_from_given_category @category_name, @total_actors OUT",
                                    paramCateg,
                                    paramTotal);

            Console.WriteLine($"O total de atores na categoria {categ} é de {paramTotal.Value}.");
        }
    }
}