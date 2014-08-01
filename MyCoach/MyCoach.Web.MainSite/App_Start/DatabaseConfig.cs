﻿using MyCoach.Data.EntityFramework;
using System.Data.Entity;

namespace MyCoach.Web.MainSite
{
    public static class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyCoachContext>());
        }
    }
}