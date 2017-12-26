using RVApiHandler.Models;
using System.Collections.Generic;

namespace RVApiHandler.RVHttpResponseConversionHandler
{
    public interface IRVHttpResponseConvertor
    {
        RVHttpResponseModel ConvertItemListToHttpResponseModel(List<Item> videoListItem, List<SpreadShirtResponseModel> productListItem, List<Datum> instagramData);
    }
}
