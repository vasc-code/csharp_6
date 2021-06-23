using System;

namespace _02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string alura = "Alura";
            string caelum = "Caelum";
            string casaDoCodigo = "Casa do Código";
            Console.WriteLine(alura);
            Console.WriteLine(caelum);
            Console.WriteLine(casaDoCodigo);


            //Matriz = array

            //string[] empresas = new string[3];
            //empresas[0] = alura;
            //empresas[1] = caelum;
            //empresas[2] = casaDoCodigo;

            //string[] empresas = new string[]
            //{
            //    alura,caelum, casaDoCodigo
            //};

            string[] empresas = { alura, caelum, casaDoCodigo };
            Imprimir(empresas);
            caelum = "Caelum Ensino e Inovação";

            Console.WriteLine(Array.IndexOf(empresas,"Casa do Código"));
            Console.WriteLine(Array.LastIndexOf(empresas,"Alura"));
            Array.Reverse(empresas);
            Imprimir(empresas);

            Array.Resize(ref empresas, 2);
            Imprimir(empresas);


        }

        private static void Imprimir(string[] empresas)
        {
            for (int i = 0; i < empresas.Length; i++)
            {
                Console.WriteLine(empresas[i]);
            }
        }
    }
}
