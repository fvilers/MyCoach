using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace MyCoach.Business.Domain.Model
{
    public class ApplicationUser : IUser<int>
    {

        public int Id {get; set; }

        public string UserName { get; set; }
    }
}
