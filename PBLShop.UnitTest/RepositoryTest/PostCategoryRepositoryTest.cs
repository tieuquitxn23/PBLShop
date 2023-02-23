using Microsoft.VisualStudio.TestTools.UnitTesting;
using PBLShop.Data.Infrastructure;
using PBLShop.Data.Repositories;
using PBLShop.Model.Models;
using System.Linq;

namespace PBLShop.UnitTest.RepositoryTest
{
    [TestClass]
    internal class PostCategoryRepositoryTest
    {
        private IDbFactory dbFactory;
        private IPostCategoryRepository objRepository;
        private IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(3,list.Count);
        }

        [TestMethod]
        public void PostCategoryRepository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test-category";
            category.Status = true;

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}