﻿using System;
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
                var livre = ClassificacaoIndicativa.Livre;

                Console.WriteLine(livre.ParaString());

                Console.WriteLine("G".ParaValor());


                //var filme = new Filme();
                //filme.Titulo = "Senhor dos Anéis";
                //filme.Duracao = 120;
                //filme.AnoLancamento = "2000";
                //filme.Classificacao = ClassificacaoIndicativa.Livre;
                //filme.IdiomaFalado = contexto.Idiomas.FirstOrDefault();

                //contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;

                //contexto.Filmes.Add(filme);
                //contexto.SaveChanges();
            }

            Console.ReadKey();
        }
    }
}