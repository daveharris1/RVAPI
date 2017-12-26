using Microsoft.VisualStudio.TestTools.UnitTesting;
using RVApiHandler.Models;
using Newtonsoft.Json;
using System.IO;
using RVApiHandler.YouTubeResponseModelHandler;
using RVApiHandler.Urls;

namespace RVApiHandler.Tests.UnitTests
{
    [TestClass]
    public class YTResponseModelHandlerUnitTests
    {
        [TestMethod]
        public void UpdateYouTubeVidLinks_Should_Return_A_Video_List_With_The_VideoId_Append_To_A_YouTube_Link_At_Posistion_0()
        {
            YouTubeResponseModel mockedYouTubeResponse = MockedYouTubeResponseModel();

            YTResponseModelHandler ytResponseModelHandler = new YTResponseModelHandler();

            YouTubeResponseModel updatedYouTubeResponseModel = ytResponseModelHandler.UpdateYouTubeVidLinks(mockedYouTubeResponse);

            Assert.IsNotNull(updatedYouTubeResponseModel);

            Assert.AreEqual(ApiUrls.YouTubeEmbeddedUrl + "URyhyhFam4Q", updatedYouTubeResponseModel.items[0].snippet.resourceId.videoId);
        }

        [TestMethod]
        public void UpdateYouTubeVidLinks_Should_Return_A_Video_List_With_The_VideoId_Append_To_A_YouTube_Link_At_Posistion_1()
        {
            YouTubeResponseModel mockedYouTubeResponse = MockedYouTubeResponseModel();

            YTResponseModelHandler ytResponseModelHandler = new YTResponseModelHandler();

            YouTubeResponseModel updatedYouTubeResponseModel = ytResponseModelHandler.UpdateYouTubeVidLinks(mockedYouTubeResponse);

            Assert.IsNotNull(updatedYouTubeResponseModel);

            Assert.AreEqual(ApiUrls.YouTubeEmbeddedUrl + "8z6I8ln0Wkc", updatedYouTubeResponseModel.items[1].snippet.resourceId.videoId);
        }
        [TestMethod]
        public void UpdateYouTubeVidLinks_Should_Return_A_Video_List_With_The_VideoId_Append_To_A_YouTube_Link_At_Posistion_2()
        {
            YouTubeResponseModel mockedYouTubeResponse = MockedYouTubeResponseModel();

            YTResponseModelHandler ytResponseModelHandler = new YTResponseModelHandler();

            YouTubeResponseModel updatedYouTubeResponseModel = ytResponseModelHandler.UpdateYouTubeVidLinks(mockedYouTubeResponse);

            Assert.IsNotNull(updatedYouTubeResponseModel);

            Assert.AreEqual(ApiUrls.YouTubeEmbeddedUrl + "jirIfZa4cv4", updatedYouTubeResponseModel.items[2].snippet.resourceId.videoId);
        }
        [TestMethod]
        public void UpdateYouTubeVidLinks_Should_Return_A_Video_List_With_The_VideoId_Append_To_A_YouTube_Link_At_Posistion_3()
        {
            YouTubeResponseModel mockedYouTubeResponse = MockedYouTubeResponseModel();

            YTResponseModelHandler ytResponseModelHandler = new YTResponseModelHandler();

            YouTubeResponseModel updatedYouTubeResponseModel = ytResponseModelHandler.UpdateYouTubeVidLinks(mockedYouTubeResponse);

            Assert.IsNotNull(updatedYouTubeResponseModel);

            Assert.AreEqual(ApiUrls.YouTubeEmbeddedUrl + "TllvbDLt3ZE", updatedYouTubeResponseModel.items[3].snippet.resourceId.videoId);
        }
        private YouTubeResponseModel MockedYouTubeResponseModel()
        {
            StreamReader jsonReader = new StreamReader(@".\..\..\MockedJSON\MockedYouTubeJson.txt");

            string mockedJsonString = jsonReader.ReadToEnd();

            return JsonConvert.DeserializeObject<YouTubeResponseModel>(mockedJsonString);
        }
    }
}
