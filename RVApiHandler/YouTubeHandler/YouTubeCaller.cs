using RVApiHandler.HttpHandler;
using RVApiHandler.JsonModelConversionHandler;
using RVApiHandler.Models;
using System.Collections.Generic;
using RVApiHandler.Urls;


namespace RVApiHandler.YouTubeHandler
{
    public class YouTubeCaller : HttpCaller, IYouTubeCaller
    {
        private IJsonModelConverter _jsonModelConverter;

        private List<Item> _youTubeVideoList = new List<Item>();

        private YouTubeResponseModel _youTubeResponseModel;

        public YouTubeCaller(IJsonModelConverter jsonModelConverter)
        {
            _jsonModelConverter = jsonModelConverter;
        }

        public List<Item> GetVideoList()
        {
            CallEndPoints();

            return _youTubeVideoList;
        }

        private void CallEndPoints()
        {
            _youTubeResponseModel = _jsonModelConverter.ConvertJsonToResponseModel(CallEndPoint(ApiUrls.YouTubeUrl));

            AddVideosToList(_youTubeResponseModel.items);
        }

        private void AddVideosToList(List<Item> youTubeVideos)
        {
            if (youTubeVideos != null && youTubeVideos.Count > 0)
            {

                for (int i = 0; i < 3; i++)
                {
                    _youTubeVideoList.Add(youTubeVideos[i]);
                }
            }
        }
    }
}
