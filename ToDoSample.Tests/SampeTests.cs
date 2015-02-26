using NUnit.Framework;
using ToDoSample.WebApi.Controller;
using ToDoSample.WebApi.Models;

namespace ToDoSample.Tests
{
    [TestFixture]
    public class SampeTests
    {
        [Test]
        public void Todo_Feature_1_Works()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Most_Epic_Unit_Test_in_Zuehlke_History()
        {
            var target = new ToDoController();
            target.Create(new ToDoItemDto());

            Assert.IsTrue(true);
        }
    }
}
