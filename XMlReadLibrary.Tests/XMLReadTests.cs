using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMLReadLibrary.XMLOperations;
using XMLReadLibrary;

namespace XMlReadLibrary.Tests
{
    [TestClass]
    public class XMLReadTests
    {
        [TestMethod]
        public void ReadXmlFileTests()
        {

            SerializeOperaionsXML ser = new SerializeOperaionsXML();

            SearchResult list = ser.ReadXml();

            Assert.IsNotNull(list);
        }
    }
}
