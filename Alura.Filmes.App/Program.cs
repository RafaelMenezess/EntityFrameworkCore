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
                Console.WriteLine("Clientes: ");
                foreach (var cliente in contexto.Clientes)
                {
                    Console.WriteLine(cliente);
                }


                Console.WriteLine("Funcionarios: ");
                foreach (var fun in contexto.Funcionarios)
                {
                    Console.WriteLine(fun);
                }
            }

            Console.ReadKey();
        }
    }
}