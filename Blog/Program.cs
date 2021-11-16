using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var context = new BlogDataContext();
            // using (var context = new BlogDataContext())
            // {
            // CREATE:
            // Instancia objeto do tipo Tag passando os valores
            // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
            // var tag2 = new Tag { Name = "Python", Slug = "python" };
            // var tag3 = new Tag { Name = "C#", Slug = "csharp" };

            // context.Tags.Add(tag);
            // context.Tags.Add(tag2);
            // context.Tags.Add(tag3);

            // // Persistindo os dados no banco de fato
            // context.SaveChanges();


            // UPDATE:
            // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
            // tag.Name = ".NET";
            // tag.Slug = "dotnet";
            // context.Update(tag);
            // context.SaveChanges();


            // DELETE:
            // try
            // {
            //     var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
            //     context.Remove(tag);
            //     context.SaveChanges();
            // }
            // catch (ArgumentNullException)
            // {
            //     Console.WriteLine("This object you are trying to delete does not exists.");
            // }


            // READ:
            // var tags = context.Tags.ToList();

            // Exemplo com filtro. OBS: deixando .ToList() por último para ganho de performance.
            // var tags = context.Tags.Where(x => x.Slug.Contains("python")).ToList();

            // Usando AsNoTracking() para ter ganho de performance.
            // var tags = context
            //     .Tags
            //     .Where(x => x.Id > 1)
            //     .AsNoTracking()
            //     .ToList();

            // foreach (var tag in tags)
            // {
            //     Console.WriteLine($"Id: {tag.Id}\nName: {tag.Name}\nSlug: {tag.Slug}");
            //     Console.Write('\n');
            // }
            // }



            // Salvando de forma inteligente com apenas 1 hit no banco
            // using var context = new BlogDataContext();
            // var user = new User
            // {
            //     Name = "Marcos Allysson",
            //     Email = "marcos@gmail.com",
            //     Slug = "marcosallysson",
            //     Bio = "Web developer",
            //     Image = "https://google.com",
            //     PasswordHash = "123456"
            // };

            // var category = new Category
            // {
            //     Name = "Backend",
            //     Slug = "backend"
            // };

            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello world!</p>",
            //     Slug = "learning-ef-core",
            //     Summary = "In this article, learn ef",
            //     Title = "Starting EF",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();



            // Listagem de todos os posts de um autor de acordo com id
            // using var context = new BlogDataContext();
            // var posts = context
            //     .Posts
            //     .AsNoTracking()
            //     // .Where(x => x.AuthorId == 1)
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     .OrderByDescending(x => x.LastUpdateDate)
            //     .ToList();

            // foreach (var post in posts)
            // {
            //     Console.WriteLine($"{post.Title} written by {post.Author?.Name} in {post.Category?.Name}.");
            // }


            // UPDATE
            // using var context = new BlogDataContext();
            // var post = context
            //     .Posts
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     .OrderByDescending(x => x.LastUpdateDate)
            //     .FirstOrDefault(); // pegando primeiro item

            // post.Author.Name = "Marcos Silva";
            // context.Posts.Update(post);
            // context.SaveChanges();



            // Testando mapeamento
            // using var context = new BlogDataContext();
            // context.Users.Add(new User
            // {
            //     Name = "Marcos Silva",
            //     Email = "marcossilva@gmail.com",
            //     Slug = "marcossilva",
            //     Bio = "Developer",
            //     Image = "https://google.com",
            //     PasswordHash = "123456"
            // });

            // context.SaveChanges();

            // var user = context.Users.FirstOrDefault();
            // var post = new Post
            // {
            //     Author = user,
            //     Category = new Category
            //     {
            //         Name = "Full stack",
            //         Slug = "fullstack"
            //     },
            //     Body = "<p>Hello world!</p>",
            //     Slug = "learning-full-stack",
            //     Summary = "In this article, learn full stack",
            //     Title = "Starting Full stack",
            //     CreateDate = DateTime.Now,
            //     // LastUpdateDate = DateTime.Now
            // };
            // context.Posts.Add(post);
            // context.SaveChanges();
        }
    }
}
