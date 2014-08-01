using System.Threading.Tasks;

namespace MyCoach.Data
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}
