using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamManager.Core.Utilities;

namespace SteamManager.Core.Test
{
    [TestClass]
    public class HashHelperTest
    {
        [TestMethod]
        public void ValidateHashValue()
        {
            var expected = "3CA844E135A9367EF21DA1F4E49CB487DE7E8CCC41137454F339B08EDACA5063";

            var value = "testvalue";
            var salt = "v^fj8948y";
            var actual = HashHelper.SHA256Hash(value, salt);

            Assert.AreEqual(expected,actual);
        }
    }
}
