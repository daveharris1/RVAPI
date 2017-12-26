using Newtonsoft.Json;
using RVApiHandler.Models;
using RVApiHandler.YouTubeResponseModelHandler;

namespace RVApiHandler.JsonModelConversionHandler
{
    public class JsonModelConverter : IJsonModelConverter
    {
        private IYTResponseModelHandler _ytResponseModelHandler;

        public JsonModelConverter(IYTResponseModelHandler ytResponseModelHandler)
        {
            _ytResponseModelHandler = ytResponseModelHandler;
        }

        public YouTubeResponseModel ConvertJsonToResponseModel(string jsonString)
        {
            YouTubeResponseModel modelList = null;

            if (!string.IsNullOrEmpty(jsonString))
            {
                modelList = Convert(jsonString);
            }
            return modelList;
        }

        private YouTubeResponseModel Convert(string jsonString)
        {
            YouTubeResponseModel ytResponseModel = JsonConvert.DeserializeObject<YouTubeResponseModel>(jsonString);

            return _ytResponseModelHandler.UpdateYouTubeVidLinks(ytResponseModel);
        }
    }
}
