using System;
namespace EXERCISE_03___OOP{
    class Program{
        //-----> INICIO
        ////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Student Stdt = new Student();

            Console.Write("Digite o Nome do aluno: "); Stdt.Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite as 3 notas do aluno: ");
            Stdt.Grade1 = double.Parse(Console.ReadLine());
            Stdt.Grade2 = double.Parse(Console.ReadLine());
            Stdt.Grade3 = double.Parse(Console.ReadLine());
            Console.WriteLine("NOTA FINAL= " + Stdt.FinalGrade().ToString("F2"));
            if (Stdt.Approved()){
                Console.WriteLine("APROVADO");
            }

        }
        ////////////////////////////////////////////////////////////////////////////////////////////
        //-----> FIM
    }
}
