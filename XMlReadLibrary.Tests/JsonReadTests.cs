using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMLReadLibrary.XMLOperations;
using XMLReadLibrary.XMLClasses;
using XMLReadLibrary.XMLClasses.ProviderOne;

namespace XMlReadLibrary.Tests
{
    [TestClass]
    public class JsonReadTests
    {
        [TestMethod]
        public void JsonOneTests()
        {
            SerializeJsonProvider1 serjson = new SerializeJsonProvider1();

            Hotel_Data rootObject = serjson.ReadJson();

            Assert.IsNotNull(rootObject);
        }

        [TestMethod]
        public void JsonTwoTests()
        {
            SerializeJsonProvider2 serjson = new SerializeJsonProvider2();

            var rootObject = serjson.ReadJson();

            Assert.IsNotNull(rootObject);
        }
    }
}
