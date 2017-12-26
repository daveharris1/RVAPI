using RVApiHandler.Models;

namespace RVApiHandler.JsonModelConversionHandler
{
    public interface IJsonModelConverter
    {
        YouTubeResponseModel ConvertJsonToResponseModel(string jsonString);
    }
}
