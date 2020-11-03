using System;


namespace Exercicio4_ClassMethod_C_Sharp
{
    class Processos
    {
        public string Nome;
        public float Nota1, Nota2, Nota3;

        public float Nota_Final()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Situacao()
        {

            double result = Nota1 + Nota2 + Nota3;

            if(result >= 60)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }

        }

        public float Nota_Faltam()
        {

            return 60 - (Nota1 + Nota2 + Nota3);


        }

    }
}
