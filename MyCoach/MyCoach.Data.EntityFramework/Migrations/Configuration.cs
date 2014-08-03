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
            var photography = new ExpertiseDomain { Name = "Photography", Slug = "photography" };
            var composition = new ExpertiseDomain { Name = "Composition", Slug = "composition" };
            var agile = new ExpertiseDomain { Name = "Agile", Slug = "agile" };
            var scrum = new ExpertiseDomain { Name = "Scrum", Slug = "scrum" };
            var it = new ExpertiseDomain { Name = "IT", Slug = "it" };
            var dotNet = new ExpertiseDomain { Name = ".NET", Slug = "dot-net" };
            var sqlServer = new ExpertiseDomain { Name = "SQL Server", Slug = "sql-server" };
            var rdbms = new ExpertiseDomain { Name = "RDBMS", Slug = "rdbms" };
            var design = new ExpertiseDomain { Name = "Design", Slug = "design" };
            var music = new ExpertiseDomain { Name = "Music", Slug = "music" };
            var guitar = new ExpertiseDomain { Name = "Guitar", Slug = "guitar" };
            var piano = new ExpertiseDomain { Name = "Piano", Slug = "piano" };
            var drums = new ExpertiseDomain { Name = "Drums", Slug = "drums" };
            var gardening = new ExpertiseDomain { Name = "Planning", Slug = "planning" };
            var sport = new ExpertiseDomain { Name = "Sport", Slug = "sport" };
            var running = new ExpertiseDomain { Name = "Running", Slug = "running" };
            var seflDevelopment = new ExpertiseDomain { Name = "Self development", Slug = "self-development" };
            var web = new ExpertiseDomain { Name = "Web", Slug = "web" };
            var branding = new ExpertiseDomain { Name = "Branding", Slug = "branding" };
            var internet = new ExpertiseDomain { Name = "Internet", Slug = "internet" };
            var health = new ExpertiseDomain { Name = "Health", Slug = "health" };
            var comedy = new ExpertiseDomain { Name = "Comedy", Slug = "comedy" };
            var spinning = new ExpertiseDomain { Name = "Spinning", Slug = "spinnig" };
            var businessProcess = new ExpertiseDomain {Name = "Business process", Slug = "business-process"};
            var financial = new ExpertiseDomain {Name = "Financial", Slug = "financial"};
            var businessModel = new ExpertiseDomain {Name = "Business Model", Slug = "business-model"};
            var javascript = new ExpertiseDomain {Name = "JavaScript", Slug = "javascript"};

            context.Keywords.AddOrUpdate(x => x.Name, dev, agile, scrum, dotNet, csharp, sqlServer, rdbms, web, internet, design, it, branding, gardening, seflDevelopment, financial, music, guitar, piano, drums, sport, running, businessProcess, photography, comedy, health, composition, spinning, businessModel, javascript);
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

            context.Images.AddOrUpdate(terrencePicture, louisePicture, brianPicture, trinaPicture, michaelPicture, emiliaPicture, isaacPicture, dorothyPicture, vincentPicture, renaPicture, jeffreyPicture, amandaPicture, frederickPicture, janicePicture, sylvainPicture);
            context.SaveChanges();

            var terrence = new Coach
            {
                UserName = "TerrenceRBlake@dayrep.com",
                FirstName = "Terrence",
                LastName = "Blake",
                Summary = "I'm a .NET developer and want to help you to undestand the fundamental of programming.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 30,
                Currency = Currency.Dollar,
                SkypeId = "Thoures",
                Photo = terrencePicture
            };
            terrence.ExpertiseDomains.AddRange(dotNet, csharp, dev);

            var louise = new Coach
            {
                UserName = "LouiseZBorg@rhyta.com",
                FirstName = "Louise",
                LastName = "Borg",
                Summary = "As a convinced agilist, I'm here to teach you about Agile methodology and Scrum in particular.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 19,
                Currency = Currency.Dollar,
                SkypeId = "Livize",
                Photo = louisePicture
            };
            louise.ExpertiseDomains.AddRange(agile, scrum, it);

            var brian = new Coach
            {
                UserName = "BrianLPatterson@jourrapide.com",
                FirstName = "Brian",
                LastName = "Patterson",
                Summary = "I can give you great tips about photography and music composition.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 52,
                Currency = Currency.Dollar,
                SkypeId = "Cholove",
                Photo = brianPicture
            };
            brian.ExpertiseDomains.AddRange(photography, composition, guitar);

            var trina = new Coach
            {
                UserName = "TrinaCDavid@rhyta.com",
                FirstName = "Trina",
                LastName = "David",
                Summary = "I have 3 passions I'd like to share with you: photography, comedy and taking care of your health.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 44,
                Currency = Currency.Dollar,
                SkypeId = "Threp1959",
                Photo = trinaPicture
            };
            trina.ExpertiseDomains.AddRange(photography, comedy, health);

            var michael = new Coach
            {
                UserName = "MichaelDMason@rhyta.com",
                FirstName = "Michael",
                LastName = "Mason",
                Summary = "As an SQL Server certified Microsoft trainer, I'm here to help you to design and build your database.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 52,
                Currency = Currency.Dollar,
                SkypeId = "Foreasked",
                Photo = michaelPicture
            };
            michael.ExpertiseDomains.AddRange(sqlServer, rdbms, design);

            var emilia = new Coach
            {
                UserName = "EmiliaDBrady@jourrapide.com",
                FirstName = "Emilia",
                LastName = "Brady",
                Summary = "I'm a music teacher and excited to give you piano and/or guitar lessons.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 54,
                Currency = Currency.Dollar,
                SkypeId = "Headen",
                Photo = emiliaPicture
            };
            emilia.ExpertiseDomains.AddRange(music, piano, guitar);

            var isaac = new Coach
            {
                UserName = "IsaacEWilliams@teleworm.us",
                FirstName = "Isaac",
                LastName = "Williams",
                Summary = "Would you like to learn about drums? Let's go and rock the casbah!",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 32,
                Currency = Currency.Dollar,
                SkypeId = "Eaciall",
                Photo = isaacPicture
            };
            isaac.ExpertiseDomains.AddRange(music, drums, gardening);

            var dorothy = new Coach
            {
                UserName = "DorothyJJackson@teleworm.us",
                FirstName = "Dorothy",
                LastName = "Jackson",
                Summary = "I have taken part of several marathons, I want to give you the best advices on how to be prepared for running long distances.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 19,
                Currency = Currency.Dollar,
                SkypeId = "Thout1994",
                Photo = dorothyPicture
            };
            dorothy.ExpertiseDomains.AddRange(sport, running, seflDevelopment);

            var vincent = new Coach
            {
                UserName = "VincentMCampos@armyspy.com",
                FirstName = "Vincent",
                LastName = "Campos",
                Summary = "I will give you guidance on how to grow your business and taking the most of internet.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 35,
                Currency = Currency.Dollar,
                SkypeId = "Throom",
                Photo = vincentPicture
            };
            vincent.ExpertiseDomains.AddRange(web, branding, internet);

            var rena = new Coach
            {
                UserName = "RenaKMiller@rhyta.com",
                FirstName = "Rena",
                LastName = "Miller",
                Summary = "I'm growing my own vegetables and I can help you make your own.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 46,
                Currency = Currency.Dollar,
                SkypeId = "Derstly",
                Photo = renaPicture
            };
            rena.ExpertiseDomains.AddRange(gardening);

            var jeffrey = new Coach
            {
                UserName = "JeffreyBowser@rhyta.com",
                FirstName = "Jeffrey",
                LastName = "Bowser",
                Summary = "I'm a spinning freak and I can coach you for improving your stamina.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 47,
                Currency = Currency.Dollar,
                SkypeId = "Knellf67",
                Photo = jeffreyPicture
            };
            jeffrey.ExpertiseDomains.AddRange(comedy, sport, spinning);

            var amanda = new Coach
            {
                UserName = "AmandaDNelson@jourrapide.com",
                FirstName = "Amanda",
                LastName = "Nelson",
                Summary = "World-class CEO, I'm here to share my experience about business and financial theory.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 500,
                Currency = Currency.Dollar,
                SkypeId = "Afroping1963",
                Photo = amandaPicture
            };
            amanda.ExpertiseDomains.AddRange(businessProcess, financial, businessModel);

            var frederick = new Coach
            {
                UserName = "FrederickLEuler@jourrapide.com",
                FirstName = "Frederick",
                LastName = "Euler",
                Summary = "As a sport doctor, I provide guidance about health and sport performance.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 54,
                Currency = Currency.Dollar,
                SkypeId = "Somplet59",
                Photo = frederickPicture
            };
            frederick.ExpertiseDomains.AddRange(running, sport, health);

            var janice = new Coach
            {
                UserName = "JaniceRNewell@jourrapide.com",
                FirstName = "Janice",
                LastName = "Newell",
                Summary = "As a seasoned developer, I love to teach newbies about JavaScript best practices.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 27,
                Currency = Currency.Dollar,
                SkypeId = "Youreand87",
                Photo = janicePicture
            };
            janice.ExpertiseDomains.AddRange(dev, javascript, design);

            var sylvain = new Coach
            {
                UserName = "sylvain_guerin@yahoo.com",
                FirstName = "Sylvain",
                LastName = "Guerin",
                Summary = "I am a highly skilleable and experienced consultant specialising in the technical analysis and design of software and system architecture.",
                Biography = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sit amet lectus fermentum, faucibus nunc eu, ornare urna. Sed cursus fermentum velit, vel rutrum velit ornare in. Phasellus quam mi, sollicitudin at volutpat sit amet, luctus id nunc. Maecenas sit amet est sapien. Ut eget consectetur enim, eget ultrices velit. Donec tempor congue sapien, adipiscing tempor sapien eleifend non. Duis et tincidunt magna, sit amet iaculis orci. Sed lacinia consequat elit eget mattis. Cras blandit adipiscing vestibulum. In lobortis enim imperdiet, condimentum augue eu, tristique orci. Sed iaculis accumsan diam id consectetur. Donec cursus ac ipsum vitae mattis. Nunc in arcu elit. Vestibulum id justo viverra, lobortis justo et, pellentesque nisl. Nullam sit amet dolor magna. Nunc tempor est sed eleifend mattis.",
                Price = 40,
                Currency = Currency.Dollar,
                SkypeId = "sylvainguerin",
                Photo = sylvainPicture,
            };
            sylvain.ExpertiseDomains.AddRange(dev, csharp, new ExpertiseDomain { Name = "Visual Basic 4", Slug = "vb4" });

            context.ApplicationUsers.AddOrUpdate(x => new { x.UserName }, terrence, louise, brian, trina, michael, emilia, isaac, dorothy, vincent, rena, jeffrey, amanda, frederick, janice, sylvain);
            context.SaveChanges();

            var scheduleStart = DateTime.Today.AddDays(1).AddHours(8);
            var schedule1 = new Schedule { StartDateTime = DateTime.Today.AddHours(15), Duration = 4 };
            var schedule2 = new Schedule { StartDateTime = scheduleStart.AddHours(2), Duration = 2 };
            var schedule3 = new Schedule { StartDateTime = scheduleStart.AddHours(2), Duration = 2 };

            context.Schedules.AddOrUpdate(schedule1, schedule2, schedule3);
            context.SaveChanges();

            sylvain.Schedules.AddRange(schedule1, schedule2, schedule3);
        }
    }
}
