using Microsoft.VisualStudio.TestTools.UnitTesting;
using assignment2._2;

namespace assignment2._2__Unit_tests
{
    [TestClass]
    public class SkydaTest
    {
        [TestMethod]
        public void Has_Property_FalledProtectionLayersNumber()
        {
            var res = typeof(Skyda).HasProperty("FalledProtectionLayersNumber");
            Assert.IsTrue(res);
		}

		[TestMethod]
		public void Has_Property_KnownFalledProtectionLayerNumber()
		{
			var res = typeof(Skyda).HasProperty("KnownFalledProtectionLayerNumber");
			Assert.IsTrue(res);
		}

		[TestMethod]
		public void Has_Property_ProtectionSystem()
		{
			var res = typeof(Skyda).HasProperty("ProtectionSystem");
			Assert.IsTrue(res);
		}

		[TestMethod]
		public void Has_Property_ProtectionFall()
		{
			var res = typeof(Skyda).HasProperty("ProtectionFall");
			Assert.IsTrue(res);
		}

		[TestMethod]
		public void Has_Method_NotifyProtectionFall()
		{
			var res = typeof(Skyda).HasMethod("NotifyProtectionFall");
			Assert.IsTrue(res);
		}

		[TestMethod]
		public void Has_Method_Attack()
		{
			var res = typeof(Skyda).HasMethod("Attack");
			Assert.IsTrue(res);
		}
	}
}