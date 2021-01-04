using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job job1;
        Job job2;
        Job job3;
        Job job4;
        Job job5;

        [TestInitialize]
        public void CreateJobObjects()
        {
            job1 = new Job();
            job2 = new Job();
            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job5 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
        }
        //         
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreNotEqual(job1.Id, job2.Id);
            Assert.AreEqual(job1.Id + 1, job2.Id);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            Assert.AreEqual(job3.Name, "Product tester");
            Assert.AreEqual(job3.EmployerName.Value, "ACME");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job3.JobType.Value, "Quality control");
            Assert.AreEqual(job3.JobCoreCompetency.Value, "Persistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {

            Assert.IsFalse(job3.Equals(job4));
        }
        [TestMethod]
        public void TestJobsToString()
        {

            Assert.AreEqual(job3.ToString(), @"ID: 13
Name: Product tester
Employer: ACME
Location: Desert
Position Type: Quality control
Core Competency: Persistence");
        }
        [TestMethod]
        public void TestJobsToStringHasEmpty()
        {


            Assert.AreEqual(job5.ToString(), @"ID: 25
Name: Data not available
Employer: Data not available
Location: Data not available
Position Type: Data not available
Core Competency: Data not available");
        }
        [TestMethod]
        public void TestJobsToStringAllEmpty()
        {

            Assert.AreEqual(job1.ToString(), @"OOPS! This job does not seem to exist.");
        }


    }

}


