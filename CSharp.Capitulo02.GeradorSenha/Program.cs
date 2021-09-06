﻿using System;

namespace CSharp.Capitulo02.GeradorSenha
{
    class Program
    {
        static void Main(string[] args)
        {            
            int quantidadeDigitos;
            //Console.Write("Informe a quantidade de dígitos da senha (entre 4 e 10): ");

            //var quantidadeDigitos = 0;

            //while (quantidadeDigitos == 0)
            //{
            //    quantidadeDigitos = ObterQuantidaDigitos();
            //}

            //var quantidadeDigitos = Convert.ToInt32(Console.ReadLine());

            //if(quantidadeDigitos < 4 || quantidadeDígitos > 10 || quantidadeDígitos % 2 != 0)



            do
            {
                Console.Write("Informe a quantidade de dígitos da senha (entre 4 e 10): ");
                quantidadeDigitos = ObterQuantidaDigitos();
            } while (quantidadeDigitos == 0);

            var senha = string.Empty;
            var randomico = new Random();

            for (int i = 0; i < quantidadeDigitos; i++)
            {
                var digito = randomico.Next(10);

                senha += digito;
            }

            Console.WriteLine($"Senha gerada: {senha}");
        }

        private static int ObterQuantidaDigitos()
        {
            int.TryParse(Console.ReadLine(), out int quantidadeDigitos);

            if (quantidadeDigitos is < 4 or > 10 || quantidadeDigitos % 2 != 0)
            {
                Console.WriteLine($"A quantidade de dígitos {quantidadeDigitos} é inválida de acordo com as regras.");
                quantidadeDigitos = 0;
            }

            return quantidadeDigitos;
        }

    }
}
