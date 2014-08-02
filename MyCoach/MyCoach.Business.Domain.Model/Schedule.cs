
using System;

namespace MyCoach.Business.Domain.Model
{
    public class Schedule : Entity<Schedule>
    {
        public DateTime StartDateTime { get; set; }
        public int Duration { get; set; }
    }
}
