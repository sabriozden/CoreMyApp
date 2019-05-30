using CoreMyApp.Entities;
using CoreMyApp.Repository.Abstract;
using CoreMyApp.Repository.Base;

namespace CoreMyApp.Repository.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}