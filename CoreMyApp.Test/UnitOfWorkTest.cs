using CoreMyApp.Repository;
using CoreMyApp.Repository.UnitOfWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreMyApp.Test
{
    [TestClass]
    public class UnitOfWorkTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitOfWork uow = new UnitOfWork(new AppDbContext());

        }
    }
}
