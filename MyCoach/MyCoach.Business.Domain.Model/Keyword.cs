﻿
namespace MyCoach.Business.Domain.Model
{
    public class Keyword : Entity<Keyword>
    {
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}