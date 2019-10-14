using System;
using System.Collections.Generic;
using exec;
using teste;


namespace it4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon charmander = new Pokemon(4, "Charmander", "Fogo no rabo");
            Console.WriteLine(charmander.Nome);

            // Cadastro gabriel = new Cadastro();
            // gabriel.nome = "Gabriel Darin Verga";
            // gabriel.telefone = "11984370080";
            // gabriel.email = "gabrieldarin@hotmail.com";
            // gabriel.senha = "1234";
        }
    }
}
