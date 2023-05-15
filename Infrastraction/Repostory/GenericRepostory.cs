using Infrastraction.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastraction.Repostory
{
    public class GenericRepostory<T> : IGenericRepotrory<T> where T : class
    {
        private readonly MVContext _context;
        public GenericRepostory(MVContext context)
        {

            _context = context;

        }
        public async Task<int> Add(T item)
        {
          _context.Set<T>().Add(item);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(T item)
        {
            _context.Set<T>().Remove(item);
            return await _context.SaveChangesAsync();
        }

        public async Task<T> Get(int? Id)
        => await _context.Set<T>().FindAsync(Id);

        public async Task<IEnumerable<T>> GetAll()
       => await _context.Set<T>().ToListAsync();

        public async Task<int> Update(T item)
        {
           _context.Set<T>().Update(item);
            return await _context.SaveChangesAsync();
        }
    }
}
