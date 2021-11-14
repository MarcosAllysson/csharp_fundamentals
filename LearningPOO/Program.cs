using System;
using System.Collections.Generic;
using System.Linq;
using LearningPOO.ContentContext;
using LearningPOO.SubscriptionContext;

namespace LearningPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var articles = new List<Article>();
            articles.Add(new Article("Learning POO Article", "https://poo.com.br"));
            articles.Add(new Article("Article POO Article", "https://poo.com.br"));
            articles.Add(new Article("POO Article", "https://poo.com.br"));

            // foreach (var article in articles)
            // {
            //     Console.WriteLine($"ID: {article.Id}");
            //     Console.WriteLine($"Title: {article.Title}");
            //     Console.WriteLine($"URL: {article.Url}");
            //     Console.Write("\n");
            // }

            var courses = new List<Course>();
            var courseOOP = new Course(title: "OOP Fundamentals", url: "oop-fundamentals");
            var courseCsharp = new Course(title: "C# Fundamentals", url: "csharp-fundamentals");
            var courseDotnet = new Course(title: ".NET Fundamentals", url: "dotnet-fundamentals");
            var courseBackendFundamental = new Course(title: "Backend Fundamentals", url: "backend-fundamentals");
            var courseMysql = new Course(title: "MySQL", url: "mysql");
            var courseFrontend = new Course(title: "Frontend", url: "frontend");

            var careers = new List<Carrer>();
            var carrerDotnet = new Carrer(title: "Dotnet expert", url: "dotnet-expert");
            var carrerBackend = new Carrer(title: "Backend expert", url: "backend-expert");
            var carrerFrontend = new Carrer(title: "Frontend expert", url: "frontend-expert");
            careers.Add(carrerDotnet);
            careers.Add(carrerBackend);
            careers.Add(carrerFrontend);


            var careerItem1 = new CareerItem(order: 1, title: "Learn OOP", description: "From basic to advanced in OOP", course: null);
            var careerItem2 = new CareerItem(order: 2, title: "Learn CSharp", description: "From basic to advanced in C#", course: courseCsharp);
            var careerItem3 = new CareerItem(order: 3, title: "Learn .NET", description: "From basic to advanced in .NET", course: courseDotnet);
            var careerItem4 = new CareerItem(order: 1, title: "Learn Fundamentals of Backend", description: "Learn how to became a backend developer", course: courseBackendFundamental);
            var careerItem5 = new CareerItem(order: 2, title: "Learn MySQL", description: "Work with MySQL", course: courseMysql);
            var careerItem6 = new CareerItem(order: 1, title: "Become a frontend developer", description: "Learn frontend fundamentals", course: courseFrontend);
            carrerDotnet.Items.Add(careerItem1);
            carrerDotnet.Items.Add(careerItem2);
            carrerDotnet.Items.Add(careerItem3);
            carrerBackend.Items.Add(careerItem4);
            carrerBackend.Items.Add(careerItem5);
            carrerFrontend.Items.Add(careerItem6);

            foreach (var career in careers)
            {
                Console.Write("\n");
                Console.WriteLine($"## CAREER TITLE: {career.Title}");

                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    // Console.WriteLine($"{item.Order} - {item.Title}");
                    item.CareerItemFullDetail();

                    // Iterating in every item's notifications
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.ErrorMessage}");
                    }
                }
            }

            var payPalSubscription = new PayPalSubscrition();
            var student = new Student();
            student.CreateSubscription(subscription: payPalSubscription);
        }
    }
}
