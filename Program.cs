using System;
using System.Globalization;

namespace OrientacaoObjetosEx3
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Aluno Aluno1;



            string nome = Console.ReadLine();
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno1 = new Aluno(nome,nota1, nota2, nota3);

            double NotaFInal = (Aluno1.nota1 + Aluno1.nota2 + Aluno1.nota3);

            Console.WriteLine("NOTA FINAL = " + NotaFInal.ToString("F2", CultureInfo.InvariantCulture));

            if(NotaFInal >= 90){
                Console.WriteLine("Aprovado!");
            } else if (NotaFInal < 90){
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + (NotaFInal - 60) + " Pontos!");
            }


        }
    }
}
