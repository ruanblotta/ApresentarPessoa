using System;
using ApresentarPessoa.Entidades;

namespace ApresentarPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
             Pessoa pessoa = new Pessoa("Ruan", 33, "Sao Paulo");

             // Imprimindo os detalhes da pessoa
             pessoa.ImprimirDetalhes();
        }
    }
}