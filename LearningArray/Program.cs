using System;

namespace LearningArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var array = new int[10];
            // var array = new int[5] { 1, 2, 3, 4, 5 }; // inicializando
            // var arrayString = new String[2] { "Marcos", "Allysson" };

            // var array = new int[5] { 1, 2, 3, 4, 5 };

            // for (var i = 0; i < array.Length; i++)
            // {
            //     array[i] = (int)Math.Pow(i, 10);
            //     Console.WriteLine(array[i]);
            // }

            // foreach (var index in array)
            // {
            //     Console.WriteLine(index);
            // }

            var employees = new CompanyEmployee[3];

            employees[0] = new CompanyEmployee(name: "Marcos", age: 24, company: "iBR Tecnologia", programmingLanguage: EProgrammingLanguage.Python);
            employees[1] = new CompanyEmployee(name: "Silva", age: 23, company: "iBR", programmingLanguage: EProgrammingLanguage.CSharp);
            employees[2] = new CompanyEmployee(name: "Allysson", age: 24, company: "Tecnologia", programmingLanguage: EProgrammingLanguage.JavaScript);

            foreach (var employee in employees)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine($"Employee's name is: {employee.GetName()}");
                Console.WriteLine($"He/she is {employee.GetAge()} years old.");
                Console.WriteLine($"Works at a company called: {employee.GetCompany()}");
                Console.WriteLine($"And its favorite programming language is: {employee.GetProgrammingLanguage()}");
                Console.WriteLine("--------------------------");
                Console.Write("\n");
            }
        }

    }
}
