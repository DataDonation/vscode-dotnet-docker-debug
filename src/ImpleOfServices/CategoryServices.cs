using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Models;
using webapi.Services;

namespace webapi.Services
{
    public class CategoryService : ICategoryService
    {
        public async Task<IEnumerable<Category>> ListAsync()
        {
        }
    }
}