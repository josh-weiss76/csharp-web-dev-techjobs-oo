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
            Assert.AreEqual("Product tester", testJob.Name);
            Assert.AreEqual("ACME", testJob.EmployerName.Value);
            Assert.AreEqual("Desert", testJob.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", testJob.JobType.Value);
            Assert.AreEqual("Persistence", testJob.JobCoreCompetency.Value);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob = new Job("Product tester", "ACME", "Desert", "Quality Control", "Persistence");
            Job testJob1 = new Job("Product tester", "ACME", "Desert", "Quality Control", "Persistence");
            Assert.IsFalse(testJob.Equals(testJob1));
        }
        [TestMethod]
        public void TestJobsToStringMethod()
        {
            Job testJob = new Job("Product tester", "ACME", "Desert", "Quality Control", "Persistence");
            Assert.AreEqual(" \nID: " + testJob.Id + "\nName: " + testJob.Name + "\nEmployer: " + testJob.EmployerName + "\nLocation: " + testJob.EmployerLocation + "\nPosition Type: " + testJob.JobType + "\nCore Competency: " + testJob.JobCoreCompetency + "\n", testJob.ToString());
        }
    }
}
