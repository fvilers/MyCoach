using MyCoach.Business.Domain.Model;
using MyCoach.Shared.Collections.Extensions;
using MyCoach.Shared.Enums;
using MyCoach.Shared.Reflection.Extensions;
using System;

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
            var photography = new ExpertiseDomain {Name = "Photography", Slug = "photography"};
            var composition = new ExpertiseDomain { Name = "Composition", Slug = "composition" };
            
            context.Keywords.AddOrUpdate(x => x.Name, dev);
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
            context.Keywords.AddOrUpdate(x => x.Name, photography);
            context.Keywords.AddOrUpdate(x => x.Name, composition);
            context.SaveChanges();

            var terrencePicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Terrence.jpg"),
                ContentType = "image/jpeg"
            };
            var louisePicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Louise.jpg"),
                ContentType = "image/jpeg"
            };
            var brianPicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Brian.jpg"),
                ContentType = "image/jpeg"
            };
            var trinaPicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Trina.jpg"),
                ContentType = "image/jpeg"
            };
            var michaelPicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Michael.jpg"),
                ContentType = "image/jpeg"
            };
            var emiliaPicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Emilia.jpg"),
                ContentType = "image/jpeg"
            };
            var isaacPicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Isaac.jpg"),
                ContentType = "image/jpeg"
            };
            var dorothyPicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Dorothy.jpg"),
                ContentType = "image/jpeg"
            };
            var vincentPicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Vincent.jpg"),
                ContentType = "image/jpeg"
            };
            var renaPicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Rena.jpg"),
                ContentType = "image/jpeg"
            };
            var jeffreyPicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Jeffrey.jpg"),
                ContentType = "image/jpeg"
            };
            var amandaPicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Amanda.jpg"),
                ContentType = "image/jpeg"
            };
            var frederickPicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Frederick.jpg"),
                ContentType = "image/jpeg"
            };
            var janicePicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Janice.jpg"),
                ContentType = "image/jpeg"
            };
            var sylvainPicture = new Image
            {
                Content = typeof(Configuration).Assembly.GetManifestResource("MyCoach.Data.EntityFramework.Resources.Sylvain.jpg"),
                ContentType = "image/jpeg"
            };

            context.Images.Add(terrencePicture);
            context.Images.Add(louisePicture);
            context.Images.Add(brianPicture);
            context.Images.Add(trinaPicture);
            context.Images.Add(michaelPicture);
            context.Images.Add(emiliaPicture);
            context.Images.Add(isaacPicture);
            context.Images.Add(dorothyPicture);
            context.Images.Add(vincentPicture);
            context.Images.Add(renaPicture);
            context.Images.Add(jeffreyPicture);
            context.Images.Add(amandaPicture);
            context.Images.Add(frederickPicture);
            context.Images.Add(janicePicture);
            context.Images.Add(sylvainPicture);
            context.SaveChanges();

            var terrence = new Coach
            {
                UserName = "TerrenceRBlake@dayrep.com",
                FirstName = "Terrence",
                LastName = "Blake",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 30,
                Currency = Currency.Dollar,
                SkypeId = "Thoures",
                Photo = terrencePicture
            };
            terrence.ExpertiseDomains.AddRange();

            var louise = new Coach
            {
                UserName = "LouiseZBorg@rhyta.com",
                FirstName = "Louise",
                LastName = "Borg",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 19,
                Currency = Currency.Dollar,
                SkypeId = "Livize",
                Photo = louisePicture
            };
            louise.ExpertiseDomains.AddRange();

            var brian = new Coach
            {
                UserName = "BrianLPatterson@jourrapide.com",
                FirstName = "Brian",
                LastName = "Patterson",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 52,
                Currency = Currency.Dollar,
                SkypeId = "Cholove",
                Photo = brianPicture
            };
            brian.ExpertiseDomains.AddRange(photography, composition);

            var trina = new Coach
            {
                UserName = "TrinaCDavid@rhyta.com",
                FirstName = "Trina",
                LastName = "David",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 44,
                Currency = Currency.Dollar,
                SkypeId = "Threp1959",
                Photo = trinaPicture
            };
            trina.ExpertiseDomains.AddRange(photography);

            var michael = new Coach
            {
                UserName = "MichaelDMason@rhyta.com",
                FirstName = "Michael",
                LastName = "Mason",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 52,
                Currency = Currency.Dollar,
                SkypeId = "Foreasked",
                Photo = michaelPicture
            };
            michael.ExpertiseDomains.AddRange();

            var emilia = new Coach
            {
                UserName = "EmiliaDBrady@jourrapide.com",
                FirstName = "Emilia",
                LastName = "Brady",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 54,
                Currency = Currency.Dollar,
                SkypeId = "Headen",
                Photo = emiliaPicture
            };
            emilia.ExpertiseDomains.AddRange();

            var isaac = new Coach
            {
                UserName = "IsaacEWilliams@teleworm.us",
                FirstName = "Isaac",
                LastName = "Williams",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 32,
                Currency = Currency.Dollar,
                SkypeId = "Eaciall",
                Photo = isaacPicture
            };
            isaac.ExpertiseDomains.AddRange();

            var dorothy = new Coach
            {
                UserName = "DorothyJJackson@teleworm.us",
                FirstName = "Dorothy",
                LastName = "Jackson",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 19,
                Currency = Currency.Dollar,
                SkypeId = "Thout1994",
                Photo = dorothyPicture
            };
            dorothy.ExpertiseDomains.AddRange();

            var vincent = new Coach
            {
                UserName = "VincentMCampos@armyspy.com",
                FirstName = "Vincent",
                LastName = "Campos",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 35,
                Currency = Currency.Dollar,
                SkypeId = "Throom",
                Photo = vincentPicture
            };
            vincent.ExpertiseDomains.AddRange();

            var rena = new Coach
            {
                UserName = "RenaKMiller@rhyta.com",
                FirstName = "Rena",
                LastName = "Miller",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 46,
                Currency = Currency.Dollar,
                SkypeId = "Derstly",
                Photo = renaPicture
            };
            rena.ExpertiseDomains.AddRange();

            var jeffrey = new Coach
            {
                UserName = "JeffreyBowser@rhyta.com",
                FirstName = "Jeffrey",
                LastName = "Bowser",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 47,
                Currency = Currency.Dollar,
                SkypeId = "Knellf67",
                Photo = jeffreyPicture
            };
            jeffrey.ExpertiseDomains.AddRange(new ExpertiseDomain { Name = "Comedy", Slug = "comedy" });

            var amanda = new Coach
            {
                UserName = "AmandaDNelson@jourrapide.com",
                FirstName = "Amanda",
                LastName = "Nelson",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 50,
                Currency = Currency.Dollar,
                SkypeId = "Afroping1963",
                Photo = amandaPicture
            };
            amanda.ExpertiseDomains.AddRange();

            var frederick = new Coach
            {
                UserName = "FrederickLEuler@jourrapide.com",
                FirstName = "Frederick",
                LastName = "Euler",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 54,
                Currency = Currency.Dollar,
                SkypeId = "Somplet59",
                Photo = frederickPicture
            };
            frederick.ExpertiseDomains.AddRange();

            var janice = new Coach
            {
                UserName = "JaniceRNewell@jourrapide.com",
                FirstName = "Janice",
                LastName = "Newell",
                Summary = "",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 27,
                Currency = Currency.Dollar,
                SkypeId = "Youreand87",
                Photo = janicePicture
            };
            janice.ExpertiseDomains.AddRange(dev, new ExpertiseDomain { Name = "JavaScript", Slug = "javascript" });

            var sylvain = new Coach
            {
                UserName = "sylvain_guerin@yahoo.com",
                FirstName = "Sylvain",
                LastName = "Guerin",
                Summary = "I am a highly skilled and experienced consultant specialising in the technical analysis and design of software and system architecture.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 40,
                Currency = Currency.Dollar,
                SkypeId = "sylvainguerin",
                Photo = sylvainPicture,
            };
            sylvain.ExpertiseDomains.AddRange(dev, csharp, new ExpertiseDomain { Name = "Visual Basic 4", Slug = "vb4" });

            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, terrence);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, louise);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, brian);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, trina);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, michael);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, emilia);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, isaac);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, dorothy);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, vincent);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, rena);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, jeffrey);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, amanda);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, frederick);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, janice);
            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, sylvain);
            context.SaveChanges();

            var scheduleStart = DateTime.Today.AddDays(1).AddHours(8);
            var schedule1 = new Schedule { StartDateTime = scheduleStart.AddHours(1), Duration = 1 };
            var schedule2 = new Schedule { StartDateTime = scheduleStart.AddHours(2), Duration = 1 };

            context.Schedules.Add(schedule1);
            context.Schedules.Add(schedule2);
            context.SaveChanges();

            sylvain.Schedules.AddRange(schedule1, schedule2);
        }
    }
}
