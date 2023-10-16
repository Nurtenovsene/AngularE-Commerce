using API.Core.DbModels;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<ReadOnlyList<Product>> GetProductAsync();
    }
}
