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
            var dev = new ExpertiseDomain { Name = "Development", Slug = "development" };
            var csharp = new ExpertiseDomain { Name = "CSharp", Slug = "c-sharp" };

            context.Keywords.AddOrUpdate(x => x.Name, dev);
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "JavaScript", Slug = "javascript" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Agile", Slug = "agile" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Scrum", Slug = "scrum" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = ".NET", Slug = "dot-net" });
            context.Keywords.AddOrUpdate(x => x.Name, csharp);
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "SQL Server", Slug = "sql-server" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "RDBMS", Slug = "rdbms" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Web", Slug = "web" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Internet", Slug = "internet" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Design", Slug = "design" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Hardware", Slug = "hardware" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "IT", Slug = "it" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "jQuery", Slug = "jquery" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Fashion", Slug = "fashion" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Branding", Slug = "branding" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Planning", Slug = "planning" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Gardening", Slug = "gardening" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Self development", Slug = "self-development" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Financial", Slug = "financial" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Music", Slug = "music" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Guitar", Slug = "guitar" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Piano", Slug = "piano" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Drums", Slug = "drums" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Sport", Slug = "sport" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Running", Slug = "running" });
            context.Keywords.AddOrUpdate(x => x.Name, new ExpertiseDomain { Name = "Business process", Slug = "business-process" });
            context.SaveChanges();

            var fvilers = new Coach
            {
                UserName = "fabian@vilers.net",
                FirstName = "Fabian",
                LastName = "Vilers",
                Summary = "Je suis le meilleur",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 50,
                Currency = Currency.Euro,
                SkypeId = "fabianvilers"
            };
            fvilers.ExpertiseDomains.AddRange(dev, csharp);

            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, fvilers);
        }
    }
}
