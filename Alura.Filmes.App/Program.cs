﻿using System;
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

                foreach (var filme in contexto.Filmes)
                {
                    Console.WriteLine(filme);
                }

            }

            Console.ReadKey();
        }
    }
}