using RVApiHandler.Models;
using System.Collections.Generic;

namespace RVApiHandler.RVHttpResponseConversionHandler
{
    public class RVHttpResponseConvertor : IRVHttpResponseConvertor
    {
        public RVHttpResponseModel ConvertItemListToHttpResponseModel(List<Item> videoListItem, List<SpreadShirtResponseModel> productListItem, List<Datum> instagramData)
        {
            RVHttpResponseModel rvHttpResponseModel = new RVHttpResponseModel();

            rvHttpResponseModel.YouTubeResponseContent = new List<Item>();
            rvHttpResponseModel.SpreadShirtResponseContent = new List<SpreadShirtResponseModel>();
            rvHttpResponseModel.InstagramResponseContent = new List<Datum>();

            rvHttpResponseModel.YouTubeResponseContent = videoListItem;
            rvHttpResponseModel.SpreadShirtResponseContent = productListItem;
            rvHttpResponseModel.InstagramResponseContent = instagramData;

            return rvHttpResponseModel;
        }

    }
}
