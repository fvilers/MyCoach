using System.Linq;
using MyCoach.Business.Domain.Model;
using MyCoach.Shared.Collections.Extensions;
using MyCoach.Shared.Enums;

namespace MyCoach.Data.EntityFramework.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MyCoachContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyCoachContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var dev = new ExpertiseDomain { Name = "Développement", Slug = "developpement" };
            var csharp = new ExpertiseDomain { Name = "CSharp", Slug = "c-sharp" };

            context.Keywords.AddOrUpdate(x => x.Name, dev);
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "JavaScript", Slug = "javascript" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Agile", Slug = "agile" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Scrum", Slug = "scrum" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = ".NET", Slug = "dot-net" });
            context.Keywords.AddOrUpdate(x => x.Name, csharp);
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "SQL Server", Slug = "sql-server" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Base de données", Slug = "base-de-donnees" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Web", Slug = "web" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Internet", Slug = "internet" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Design", Slug = "design" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Hardware", Slug = "hardware" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Informatique", Slug = "informatique" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "jQuery", Slug = "jquery" });
            context.SaveChanges();

            var fvilers = new Coach
            {
                UserName = "fabian@vilers.net",
                FirstName = "Fabian",
                LastName = "Vilers",
                Biography = "Je suis le meilleur",
                Price = 50,
                Currency = Currency.Euro,
                SkypeId = "fabianvilers"
            };
            fvilers.ExpertiseDomains.AddRange(dev, csharp);

            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, fvilers);
        }
    }
}
