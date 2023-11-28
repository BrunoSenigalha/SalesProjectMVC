using SalesWebMvc.Data;
/*O DepartmentService tem como objetivo retornar uma lista do tipo Department
 com a ordenação feita pelos nomes*/

namespace SalesWebMvc.Models.Services
{
    public class DepartmentService(SalesWebMvcContext context)
    {
        private readonly SalesWebMvcContext _context = context;
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
