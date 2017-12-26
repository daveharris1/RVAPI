using Newtonsoft.Json;
using RVApiHandler.Models;
using System.Collections.Generic;

namespace RVApiHandler.InstagramModelConversionHandler
{
    public class InstagramModelHandler : IInstagramModelHandler
    {
        public List<Datum> ConvertJsonToDatumList(string instagramJson)
        {
            InstagramResponseModel instagramResponseModel =  JsonConvert.DeserializeObject<InstagramResponseModel>(instagramJson);

            List<Datum> datumItems = new List<Datum>();

            for(int i = 0; i < 12; i ++)
            {
                datumItems.Add(instagramResponseModel.data[i]);
            }

            return datumItems;
        }
    }
}
