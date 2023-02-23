using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PBLShop.Data.Infrastructure;
using PBLShop.Data.Repositories;
using PBLShop.Model.Models;
using PBLShop.Service;
using System.Collections.Generic;

namespace PBLShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory() {ID = 1, Name = "DM1",Status = true},
                new PostCategory() {ID = 2, Name = "DM2",Status = true},
                new PostCategory() { ID = 3, Name = "DM3", Status = true },
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            // Setup Method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);

            // Call Action
            var result = _categoryService.GetAll() as List<PostCategory>;

            // Compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test";
            category.Alias = "test";
            category.Status = true;

            _mockRepository.Setup(m => m.Add(category)).Returns((PostCategory p) =>
              {
                  p.ID = 1;
                  return p;
              });

            var result = _categoryService.Add(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}