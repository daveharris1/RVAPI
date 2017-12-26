using System.Collections.Generic;
using RVApiHandler.Models;
using RVApiHandler.HttpHandler;
using RVApiHandler.Urls;
using RVApiHandler.XmlModelConversionHandler;

namespace RVApiHandler.SpreadShirtHandler
{
    public class SpreadShirtCaller : HttpCaller, ISpreadShirtCaller
    {
        private IXmlModelConvertor _xmlModelConvertor;

        public SpreadShirtCaller(IXmlModelConvertor xmlModelConvertor)
        {
            _xmlModelConvertor = xmlModelConvertor;
        }

        public List<SpreadShirtResponseModel> GetSpreadShirtsProducts()
        {
            return SortSpreadShirtProducts(_xmlModelConvertor.ConvertXmlToResponseModel(CallEndPoint(ApiUrls.SpreadShirtUrl)));
        }

        private List<SpreadShirtResponseModel> SortSpreadShirtProducts(List<SpreadShirtResponseModel> spreadShirtProducts)
        {
            List<SpreadShirtResponseModel> sortedSpreadShirtProducts = new List<SpreadShirtResponseModel>();

            for(int i = 0; i < 12; i++)
            {
                sortedSpreadShirtProducts.Add(spreadShirtProducts[i]);
            }

            return sortedSpreadShirtProducts;
        }
    }
}
