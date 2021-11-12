using System;

namespace LearningArray
{
    public static class Employee { }

    struct CompanyEmployee
    {
        public CompanyEmployee(string name, int age, string company, EProgrammingLanguage programmingLanguage)
        {
            Name = name;
            Age = age;
            Company = company;
            ProgrammingLanguage = programmingLanguage;
        }

        public string Name;
        public int Age;
        public string Company;
        public EProgrammingLanguage ProgrammingLanguage;

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public string GetCompany()
        {
            return Company;
        }

        public string GetProgrammingLanguage()
        {
            return ProgrammingLanguage.ToString();
        }
    }

    enum EProgrammingLanguage
    {
        Python = 1,
        CSharp = 2,
        JavaScript = 3,
        Java = 4
    }
}