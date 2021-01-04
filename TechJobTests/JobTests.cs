using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JobTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.AreEqual(job1.value + 1, job2);
        }

        [TestMethod]
        public void 
    }
}
