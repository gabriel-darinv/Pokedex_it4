using System;
using System.Collections.Generic;

namespace exec
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
            get // definir aqui a vantagem para cada tipo de pokemon
            {
                if(this.naturezas[0]==Tipo.Fogo)
                {
                    return Tipo.Grama;
                }
                else if (this.naturezas[0] == Tipo.Agua)
                {
                    return Tipo.Fogo;
                }
                else
                {
                    return Tipo.Agua;
                }
            }
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

    private Pokemon evolucao;
    public Pokemon evolucao
    {
        get
        {
            return this.evolucao;
        }
        set
        {
            
        }
    }


// ================================ SERES HUMANOS === HERANÇA ================================================ INICIO AULA 5
    public abstract class Pessoa
    {
        protected Pessoa(string nome)
        {
            this.Nome = nome;
        }
        public string Nome { get; set; }

        public List<Pokemon> Pokemons {get; set;}
        public virtual void AddPokemon(Pokemon pokemon)
        {
            if (pokemon != null)
            {
                this.Pokemons.Add(pokemon);
            }
        }

        public abstract int Treinar(Pokemon pokemon);
        // public abstract int Batalhar(Pokemon pokemon);
        public abstract int Batalhar(Pokemon pokemon);


    }

    public class Treinador : Pessoa
    {
        public Treinador(string nome) : base(nome)
        {}
        public string Insignias { get; set; }
        public override void AddPokemon(Pokemon pokemon)
        {
            if(base.Pokemons.Count >6)
            {
                Console.WriteLine("Máximo 6 Pokemons na Pokedex do Treinador!!!");
            }
            else
            {
                base.AddPokemon(pokemon);
            }
        }
        
        public override int Treinar(Pokemon pokemon)
        {
            throw new System.NotImplementedException();
        }
        public override int Batalhar(Pokemon pokemon)
        {
            throw new System.NotImplementedException();
        }
    }
    public class EnfermeiraJoy : Pessoa
    {
        public EnfermeiraJoy(string nome) : base(nome)
        {}
        public string Insignias { get; set; }
        public override void AddPokemon(Pokemon pokemon)
        {
            base.AddPokemon(pokemon);

        }
        public override int Treinar(Pokemon pokemon)
        {
            throw new System.NotImplementedException();
        }
        public override int Batalhar(Pokemon pokemon)
        {
            throw new System.NotImplementedException();
        }
    }
    public class Viloes : Pessoa
    {
        public Viloes(string nome) : base(nome)
        {}
        public string Insignias { get; set; }
        public override void AddPokemon(Pokemon pokemon)
        {
            base.AddPokemon(pokemon);

        }
        public override int Treinar(Pokemon pokemon)
        {
            throw new System.NotImplementedException();
        }
        public override int Batalhar(Pokemon pokemon)
        {
            throw new System.NotImplementedException();
        }
    }
}