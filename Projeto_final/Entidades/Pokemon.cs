using System.Collections.Generic;

namespace Entidades
{
    public class Pokemon
    {
        public string Descricao { get; set; }

        public string Nome { get; set; }

        public int Id { get; set; }

        public int Ataque { get; set; }

        public int Hp { get; set; }

        public int Defesa { get; set; }

        private List<Natureza> naturezas = new List<Natureza>();


        // ienumerable é uma lista Read Only (somente leitura)
        public IEnumerable<Natureza> Naturezas 
        {
            get
            {
                return this.naturezas;
            }
        }

        public void SetNatureza(Natureza natureza)
        {

        }

        public IEnumerable<Natureza> Fraquezas
        {
            get
            {
                return null;
            }
        }
    }

    public enum Natureza
    {
        Fogo = 1, // desv agua 
        Agua = 2, // desv eletrico grama
        Grama = 3, // desv fogo
        Eletrico = 4, // desv rocha
        Rocha = 5 // desv agua
     }

     public class Ataque
     {
        public string Nome { get; set; }  
        public int Dano { get; set; }
        public Natureza Natureza { get; set; }
        public int LimiteDeUso { get; set; }

     }
     

}