/*O DepartmentService tem como objetivo retornar uma lista do tipo Department
 com a ordenação feita pelos nomes*/

using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;

namespace SalesWebMvc.Models.Services
{
    public class DepartmentService(SalesWebMvcContext context)
    {
        private readonly SalesWebMvcContext _context = context;
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
