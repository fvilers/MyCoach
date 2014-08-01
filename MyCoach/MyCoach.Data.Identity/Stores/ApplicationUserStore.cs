using System;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using MyCoach.Business.Domain.Model;
using MyCoach.Data.EntityFramework;

namespace MyCoach.Data.Identity.Stores
{
    public class ApplicationUserStore : IUserPasswordStore<ApplicationUser, int>
    {
        private readonly MyCoachContext _context = new MyCoachContext();
        private bool _disposed;

        ~ApplicationUserStore()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task CreateAsync(ApplicationUser user)
        {
            ThrowIfDisposed();
            if (user == null) throw new ArgumentNullException("user");

            _context.ApplicationUsers.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ApplicationUser user)
        {
            ThrowIfDisposed();
            if (user == null) throw new ArgumentNullException("user");

            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(ApplicationUser user)
        {
            ThrowIfDisposed();
            if (user == null) throw new ArgumentNullException("user");

            _context.ApplicationUsers.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<ApplicationUser> FindByIdAsync(int userId)
        {
            ThrowIfDisposed();

            return await FindAsync(user => user.Id == userId);
        }

        public async Task<ApplicationUser> FindByNameAsync(string userName)
        {
            ThrowIfDisposed();
            if (userName == null) throw new ArgumentNullException("userName");

            return await FindAsync(user => user.UserName.ToUpper() == userName.ToUpper());
        }

        public Task SetPasswordHashAsync(ApplicationUser user, string passwordHash)
        {
            ThrowIfDisposed();
            if (user == null) throw new ArgumentNullException("user");

            user.PasswordHash = passwordHash;
            return Task.FromResult(0);
        }

        public Task<string> GetPasswordHashAsync(ApplicationUser user)
        {
            ThrowIfDisposed();
            if (user == null) throw new ArgumentNullException("user");

            return Task.FromResult(user.PasswordHash);
        }

        public Task<bool> HasPasswordAsync(ApplicationUser user)
        {
            ThrowIfDisposed();
            if (user == null) throw new ArgumentNullException("user");

            return Task.FromResult(!String.IsNullOrWhiteSpace(user.PasswordHash));
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _context.Dispose();
            }

            _disposed = true;
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }

        private Task<ApplicationUser> FindAsync(Expression<Func<ApplicationUser, bool>> predicate)
        {
            return _context.ApplicationUsers.FirstOrDefaultAsync(predicate);
        }
    }
}
