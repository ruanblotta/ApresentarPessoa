using System;

namespace ApresentarPessoa.Entidades
{
   public class Pessoa
    {
        public string Nome;
        private int _idade;
        protected string endereco;

        // construtor padrão s/ parâmetro
        public Pessoa()
        {
            Nome = "Sem nome";
            _idade = 0;
            endereco = "Endereço não especificado"; 
        }

        // Construtor com parâmetro
        public Pessoa(string nome, int idade, string endereco)
        {
            this.Nome = nome;
            _idade = idade;
            this.endereco = endereco;
        }

        // método para acessar e modificar os atributos (encapsulamento)

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public int GetIdade()
        {
            return _idade;
        }

        public void SetIdade(int idade)
        {
            _idade = idade;
        }

        // método para imprimir os detalhes da pessoa
        public void ImprimirDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {_idade}");
            Console.WriteLine($"Endereço: {endereco}");
        }
    }
}