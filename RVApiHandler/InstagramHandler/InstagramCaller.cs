using RVApiHandler.HttpHandler;
using System.Collections.Generic;
using RVApiHandler.Models;
using RVApiHandler.InstagramModelConversionHandler;
using RVApiHandler.Urls;

namespace RVApiHandler.InstagramHandler
{
    public class InstagramCaller:HttpCaller, IInstagramCaller
    {
        private IInstagramModelHandler _instagramModelHandler;

        public InstagramCaller(IInstagramModelHandler instagramModelHandler)
        {
            _instagramModelHandler = instagramModelHandler;
        }

        public List<Datum> GetInstagramData()
        {
            return _instagramModelHandler.ConvertJsonToDatumList(CallEndPoint(ApiUrls.InstagramUrl));
        }
    }
}
