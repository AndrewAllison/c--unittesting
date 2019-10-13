using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class EmployeeControllerTests
    {
        [Test]
        public void DeleteEmployee_WithArgs_DeletesEmployee()
        {
            var respository = new Mock<IEmployeeStorage>();
            var controller = new EmployeeController(respository.Object);

            var result = controller.DeleteEmployee(1);

            respository.Setup(s => s.DeleteEmployeeById(1));
        }  
        
        [Test]
        public void DeleteEmployee_WithArgs_ReturnsRedirectResult()
        {
            var respository = new Mock<IEmployeeStorage>();
            var controller = new EmployeeController(respository.Object);

            var result = controller.DeleteEmployee(1);

            Assert.That(result, Is.TypeOf<RedirectResult>());
        }
    }
}
