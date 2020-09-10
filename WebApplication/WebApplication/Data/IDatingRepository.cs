using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Helpers;
using WebApplication.Models;

namespace WebApplication.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<PagedList<User>> GetAllValue(UserParams userParams);
        Task<User> GetUser(int id);
    }
}