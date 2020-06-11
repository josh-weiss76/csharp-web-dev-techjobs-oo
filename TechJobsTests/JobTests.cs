using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Assert.IsFalse(testJob1.Id == testJob2.Id);
        }
        [TestMethod]
        public void TestJobConstructionSetsAllFields()
        {
            Job testJob = new Job("Product tester", "ACME", "Desert", "Quality Control", "Persistence");
        }
    }
}
