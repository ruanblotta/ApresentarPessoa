using System;

namespace ApresentarPessoa
{
   public class Pessoa
    {
        public string Nome{get; set;}
        public int Idade{get; set;}
        public double Altura{get; set;}

        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Prazer eu sou o {Nome}, tenho {Idade} anos e tenho {Altura} de altura.");
        }
    }
}