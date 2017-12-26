using Microsoft.VisualStudio.TestTools.UnitTesting;
using RVApiHandler.Models;
using System.IO;
using RVApiHandler.InstagramModelConversionHandler;
using System.Collections.Generic;

namespace RVApiHandler.Tests.UnitTests
{
    [TestClass]
    public class InstagramHandlerUnitTests
    {
        [TestMethod]
        public void Instagram_Model_Handler_Should_Only_Return_12_List_Items()
        {
            string instagramMockedJsonResponse = MockedInstagramResponseJson();

            InstagramModelHandler instagramModelHandler = new InstagramModelHandler();

            List<Datum> datumList = instagramModelHandler.ConvertJsonToDatumList(instagramMockedJsonResponse);

            Assert.IsNotNull(datumList);

            Assert.AreEqual(12, datumList.Count);
        }

        private string MockedInstagramResponseJson()
        {
            StreamReader jsonReader = new StreamReader(@".\..\..\MockedJSON\MockedInstagramJson.txt");

            return jsonReader.ReadToEnd();
        }
    }
}
