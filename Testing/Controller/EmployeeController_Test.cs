using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CodeFirstWithMvc.Controllers;
using CodeFirstWithMvc.Models;

namespace Testing.Controller
{
    [TestClass]
    public class EmployeeController_Test
    {
        #region PRIVATE INSTANCES
        private Mock<EmployeesController> _mockTestEmployeesController;
        private EmployeesController _employeesController;
        #endregion
        #region INITIALISATION
        [TestInitialize]
        public void InitializeTest()
        {
            _mockTestEmployeesController = new Mock<EmployeesController>();
            _employeesController = new EmployeesController();
        }
        #endregion
        #region PUBLIC METHODS
        [TestMethod]
        public void getEmpData_With_validId()
        {
            //arrange
            _mockTestEmployeesController.Setup(p => p.getEmployeeDetailsWithId(It.IsAny<int>())).Returns(new Employee());
            //act
            var result = _employeesController.getEmployeeDetailsWithId(2);
            //assert
            Assert.AreEqual(result,new Employee());
        }
        #endregion
    }
}   //arrange

//act
//assert
