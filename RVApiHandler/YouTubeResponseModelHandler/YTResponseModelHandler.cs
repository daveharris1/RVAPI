using RVApiHandler.Models;
using RVApiHandler.Urls;

namespace RVApiHandler.YouTubeResponseModelHandler
{
    public class YTResponseModelHandler : IYTResponseModelHandler
    {
        public YouTubeResponseModel UpdateYouTubeVidLinks(YouTubeResponseModel ytResponseModel)
        {
            foreach (Item item in ytResponseModel.items)
            {
                string youtubeEmbedded = ApiUrls.YouTubeEmbeddedUrl + item.snippet.resourceId.videoId;

                item.snippet.resourceId.videoId = youtubeEmbedded;
            }

            return ytResponseModel;
        }
    }
}
