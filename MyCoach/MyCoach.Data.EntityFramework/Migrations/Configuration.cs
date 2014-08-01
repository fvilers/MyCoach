using MyCoach.Business.Domain.Model;

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

            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "Développement", Slug = "developpement" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "JavaScript", Slug = "javascript" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "Agile", Slug = "agile" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "Scrum", Slug = "scrum" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = ".NET", Slug = "dot-net" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "CSharp", Slug = "c-sharp" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "SQL Server", Slug = "sql-server" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "Base de données", Slug = "base-de-donnees" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "Web", Slug = "web" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "Internet", Slug = "internet" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "Design", Slug = "design" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "Hardware", Slug = "hardware" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "Informatique", Slug = "informatique" });
            context.Keywords.AddOrUpdate(x => x.Name, new Keyword { Name = "jQuery", Slug = "jquery" });
        }
    }
}
