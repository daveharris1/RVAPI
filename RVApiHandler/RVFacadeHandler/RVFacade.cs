using RVApiHandler.InstagramHandler;
using RVApiHandler.Models;
using RVApiHandler.RVHttpResponseConversionHandler;
using RVApiHandler.SpreadShirtHandler;
using RVApiHandler.YouTubeHandler;

namespace RVApiHandler.RVFacadeHandler
{
    public class RVFacade:IRVFacade
    {
        private IYouTubeCaller _youTubeHandler;
        private ISpreadShirtCaller _spreadShirtHandler;
        private IInstagramCaller _instagramCaller;

        private IRVHttpResponseConvertor _rvHttpResponseConvertor;

        public RVFacade(IYouTubeCaller youTubeHandler, ISpreadShirtCaller spreadShirtHandler, IInstagramCaller instagramCaller,  IRVHttpResponseConvertor rvHttpResponseConvertor)
        {
            _youTubeHandler = youTubeHandler;
            _spreadShirtHandler = spreadShirtHandler;
            _instagramCaller = instagramCaller;

            _rvHttpResponseConvertor = rvHttpResponseConvertor;
        }

        public RVHttpResponseModel GetRVContent()
        {
            return _rvHttpResponseConvertor.ConvertItemListToHttpResponseModel(_youTubeHandler.GetVideoList(), _spreadShirtHandler.GetSpreadShirtsProducts(), _instagramCaller.GetInstagramData());
        }
    }
}
