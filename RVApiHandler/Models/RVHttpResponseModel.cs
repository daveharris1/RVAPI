using System.Collections.Generic;

namespace RVApiHandler.Models
{
    public class RVHttpResponseModel
    {
        public List<Item> YouTubeResponseContent { set; get; }
        public List<SpreadShirtResponseModel> SpreadShirtResponseContent { set; get; }
        public List<Datum> InstagramResponseContent { get; set; }
    }
}
