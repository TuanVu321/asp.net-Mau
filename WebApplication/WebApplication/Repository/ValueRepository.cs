using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public class ValueRepository:ICRUD
    {
        private readonly DataContext _context;

        public ValueRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<IEnumerable<Value>> GetAllValue()
        {
            var values =await _context.Values.ToListAsync();
            return values;
        }

        public async Task<Value> GetValueById(int id)
        {
            var value = await _context.Values.FindAsync(id);
            return value;
        }
        
        
    }
}