using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCoach.Business.Domain.Model;

namespace MyCoach.Data.EntityFramework
{
    //public class ApplicationUserStore : IUserPasswordStore<ApplicationUser, int>
    //{
    //    private readonly MyDoctorContext _context = new MyDoctorContext();
    //    private bool _disposed;

    //    ~DoctorUserStore()
    //    {
    //        Dispose(false);
    //    }

    //    public void Dispose()
    //    {
    //        Dispose(true);
    //        GC.SuppressFinalize(this);
    //    }

    //    public async Task CreateAsync(Doctor user)
    //    {
    //        ThrowIfDisposed();
    //        if (user == null) throw new ArgumentNullException("user");

    //        _context.Doctors.Add(user);
    //        await _context.SaveChangesAsync();
    //    }

    //    public async Task UpdateAsync(Doctor user)
    //    {
    //        ThrowIfDisposed();
    //        if (user == null) throw new ArgumentNullException("user");

    //        _context.Entry(user).State = EntityState.Modified;
    //        await _context.SaveChangesAsync();
    //    }

    //    public async Task DeleteAsync(Doctor user)
    //    {
    //        ThrowIfDisposed();
    //        if (user == null) throw new ArgumentNullException("user");

    //        _context.Doctors.Remove(user);
    //        await _context.SaveChangesAsync();
    //    }

    //    public async Task<Doctor> FindByIdAsync(int userId)
    //    {
    //        ThrowIfDisposed();

    //        return await FindAsync(doctor => doctor.Id == userId);
    //    }

    //    public async Task<Doctor> FindByNameAsync(string userName)
    //    {
    //        ThrowIfDisposed();
    //        if (userName == null) throw new ArgumentNullException("userName");

    //        return await FindAsync(doctor => doctor.UserName.ToUpper() == userName.ToUpper());
    //    }

    //    public Task SetPasswordHashAsync(Doctor user, string passwordHash)
    //    {
    //        ThrowIfDisposed();
    //        if (user == null) throw new ArgumentNullException("user");

    //        user.Password.Hash = passwordHash;
    //        return Task.FromResult(0);
    //    }

    //    public Task<string> GetPasswordHashAsync(Doctor user)
    //    {
    //        ThrowIfDisposed();
    //        if (user == null) throw new ArgumentNullException("user");

    //        return Task.FromResult(user.Password.Hash);
    //    }

    //    public Task<bool> HasPasswordAsync(Doctor user)
    //    {
    //        ThrowIfDisposed();
    //        if (user == null) throw new ArgumentNullException("user");

    //        return Task.FromResult(!String.IsNullOrWhiteSpace(user.Password.Hash));
    //    }

    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (_disposed)
    //        {
    //            return;
    //        }

    //        if (disposing)
    //        {
    //            _context.Dispose();
    //        }

    //        _disposed = true;
    //    }

    //    private void ThrowIfDisposed()
    //    {
    //        if (_disposed)
    //        {
    //            throw new ObjectDisposedException(GetType().Name);
    //        }
    //    }

    //    private Task<Doctor> FindAsync(Expression<Func<Doctor, bool>> predicate)
    //    {
    //        return _context.Doctors.FirstOrDefaultAsync(predicate);
    //    }
    //}
}
