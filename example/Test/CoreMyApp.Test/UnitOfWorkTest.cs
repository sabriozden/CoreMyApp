using App.Core.Repository.UnitOfWork;
using CoreMyApp.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreMyApp.Test
{
    [TestClass]
    public class UnitOfWorkTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IUnitOfWork uow = new UnitOfWork(new AppDbContext());

        }
    }
}
