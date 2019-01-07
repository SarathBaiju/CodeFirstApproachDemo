using System;
using CodeFirstWithMvc.Context;
using CodeFirstWithMvc.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        #region PRIVATE INSTANCES
        #endregion
        private Mock<DepartmentContext> _testDepartmentContext;
        private Mock<EmployeesController> _testEmployeeController;

        #region INITIALISATION
        [TestInitialize]
        public void InitialiseTest()
        {
            _testDepartmentContext = new Mock<DepartmentContext>();
            _testEmployeeController = new Mock<EmployeesController>();
        }
        #endregion
        #region PUBLIC METHODS
        [TestMethod]
        public void getDatails_With_InvalidId()
        {
            
        }
        #endregion
    }
}
/*--arrange-*/
/*--act-*/
/*--assert-*/
