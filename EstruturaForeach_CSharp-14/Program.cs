using System;

namespace EstruturaForeach_CSharp_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para trabalhar com vetores e matrizes

            string[] nomes = new string[] { "Maria", "João", "Joaquina", "Pedro" };

            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
