using EmployeeManagement.API.Controllers;
using EmployeeManagement.BAL.Interface;
using EmployeeManagement.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

namespace EmployeeManagement.API.Tests
{
    /// <summary>
    /// Summary description for EmployeeManagementControllerTest
    /// </summary>
    [TestClass]
    public class EmployeeManagementControllerTest
    {
        
        [TestMethod]
        public void GetAll()
        {
            List<PersonalDetail> personalDetails = new List<PersonalDetail>();
            // Arrange
            var mockRepository = new Mock<IEmployeeManagementService>();
            mockRepository.Setup(x => x.GetAll())
                .Returns(personalDetails);

            var controller = new EmployeeManagementController(mockRepository.Object);

            // Act
            var contentResult = controller.GetAll();

            // Assert
            Assert.IsNotNull(contentResult);
          
          
        }
        [TestMethod]
        public void Save()
        {
            PersonalDetail personalDetails = new PersonalDetail();
                // Arrange
            var mockRepository = new Mock<IEmployeeManagementService>();
            mockRepository.Setup(x => x.Save(personalDetails));
               
            var controller = new EmployeeManagementController(mockRepository.Object);

            // Act
            var contentResult = controller.Save(personalDetails);

            // Assert
            Assert.IsNotNull(contentResult);


        }
    }
}
