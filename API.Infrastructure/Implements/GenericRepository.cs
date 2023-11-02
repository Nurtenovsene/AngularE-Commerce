using API.Core.DbModels;
using API.Core.Interfaces;
using API.Core.Specifications;
using API.Infrastructure.Data;
using API.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Infrastructure.Implements
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext _context;
        public GenericRepository(StoreContext context)
        {
                _context = context;
        }
        public async Task<T> GetById(int Id)
        {
            var result = await _context.Set<T>().FindAsync(Id);
            return result;
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            var resultList = await _context.Set<T>().ToListAsync();
            return resultList;
        }

        public async Task<T> GetEntityWithSpec(ISpecification<T> spec)
        {
            return await ApplySpecificiation(spec).FirstOrDefaultAsync();
        }
        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecificiation(spec).ToListAsync();
        }
        private IQueryable<T> ApplySpecificiation(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
        }
    }
}
