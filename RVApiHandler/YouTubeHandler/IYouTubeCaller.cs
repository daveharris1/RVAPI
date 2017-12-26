using RVApiHandler.Models;
using System.Collections.Generic;

namespace RVApiHandler.YouTubeHandler
{
    public interface IYouTubeCaller
    {
        List<Item> GetVideoList();
    }
}
