using System.Data.Entity;

namespace MyCoach.Data.EntityFramework
{
    public abstract class ContextBase : DbContext
    {
        protected ContextBase()
            : base("MyCoach")
        {
        }
    }
}