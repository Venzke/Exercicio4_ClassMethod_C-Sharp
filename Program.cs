using System;


namespace Exercicio4_ClassMethod_C_Sharp
{
    class Program
    {
        static void Main()
        {
            Processos p = new Processos();

            Console.Write("Nome do aluno: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Insira as notas do aluno.");
            Console.Write("Nota 1: ");
            p.Nota1 = float.Parse(Console.ReadLine());
            
            Console.Write("Nota 2: ");
            p.Nota2 = float.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            p.Nota3 = float.Parse(Console.ReadLine());

            
            double Nota_Max = p.Nota_Final();
            Console.WriteLine("Nota final: {0}", Nota_Max);

            string Resultado = p.Situacao();

            if (Resultado == "Reprovado")
            {
                Console.WriteLine();
                Console.WriteLine("{0}", Resultado);

                float Notas_Faltam = p.Nota_Faltam();

                Console.WriteLine("Faltaram {0} pontos.", Notas_Faltam);

            }
            else
            {
                Console.WriteLine("{0}", Resultado);
            }


            Console.Read();
        }
    }
}
