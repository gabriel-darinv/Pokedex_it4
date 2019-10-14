using System;

namespace teste
{
    public class Cadastro
    {
        public string nome;
        public string telefone;
        public string email;
        public string senha;

        public virtual void printar()
        {
            Console.WriteLine(nome);
        }

    }
}