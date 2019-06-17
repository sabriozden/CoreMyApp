using App.Core.Repository.Base;
using CoreMyApp.Entities;
using CoreMyApp.Repository.Abstract;

namespace CoreMyApp.Repository.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(AppDbContext dbContext)
            : base(dbContext)
        {
        }

        public void Test()
        {
        }
    }
}