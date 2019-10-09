using System;

namespace code2
{
    public class Pokemon
    {
        public Pokemon(int id, string nome, string descricao)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public string Nome { get; set; }
        private string nome;
        public string descricao;
        public int Id;

        private Tipo[] naturezas;
        public Tipo[] Naturezas 
        {
            get 
            {
                return this.naturezas; 
            }
            set
            {
                if(value.Length > 2)
                {
                    return;
                }
                naturezas = value;
            }
        }

        public Tipo Vantagens
        {
            get; // definir aqui a vantagem para cada tipo de pokemon
            set;
        }
        public Tipo Desvantagens
        {
            get; // definir aqui a desvantagem para cada tipo de pokemon
            set;
        }

    }

    public enum Tipo
    {
        Normal = 1,
        Fogo = 2,
        Agua = 3, 
        Eletrico = 4,
        Grama = 5,
        Gelo = 6,
        Lutador = 7,
        Venenoso = 8, 
        Terra = 9, 
        Voador = 10, 
        Psiquico = 11, 
        Inseto = 12, 
        Pedra = 13, 
        Fantasma = 14, 
        Dragao = 15, 
        Noturno = 16, 
        Aco = 17
    }

    public class Ataque
    {
        public string Nome { get; set; }
        public int Dano { get; set; }
        public Tipo Natureza { get; set; }
    }

    public abstract class Pessoa
    {
        protected Pessoa(string nome)
        {
            this.Nome = nome;
        }
        public string Nome { get; set; }

        public List<Pokemon> Pokemons {get; set;}

    }
}