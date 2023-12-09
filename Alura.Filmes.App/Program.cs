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

            Console.ReadKey();
        }
    }
}