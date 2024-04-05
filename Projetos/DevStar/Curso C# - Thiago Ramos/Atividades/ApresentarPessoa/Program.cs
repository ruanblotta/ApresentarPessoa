using System;

namespace ApresentarPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
             Pessoa apresentar = new Pessoa("Ruan", 33, 1.78);

             apresentar.Apresentar();
        }
    }
}