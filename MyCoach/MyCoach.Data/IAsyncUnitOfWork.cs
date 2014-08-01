using System.Threading.Tasks;

namespace MyCoach.Data
{
    public interface IAsyncUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
