using System.Collections.Generic;
using RVApiHandler.Models;
using System.Xml;
using RVApiHandler.Urls;

namespace RVApiHandler.XmlModelConversionHandler
{
    public class XmlModelConvertor : IXmlModelConvertor
    {
        public List<SpreadShirtResponseModel> ConvertXmlToResponseModel(string xmlString)
        {
            List<SpreadShirtResponseModel> spreadShirtResponseModelList = new List<SpreadShirtResponseModel>();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);

            XmlNodeList productList = doc.GetElementsByTagName("product");

            for (int i = 0; i < productList.Count; i++)
            {
                var spreadShirtResponseModel = new SpreadShirtResponseModel();

                XmlNode product = productList[i];
                spreadShirtResponseModel.SSUrl = ApiUrls.SpreadShirtHomeUrl;

                XmlNodeList childNodes = product.ChildNodes;

                for (int j = 0; j < childNodes.Count; j++)
                {
                    if (childNodes[j].Name == "resources")
                    {
                        XmlNodeList resChildNodes = childNodes[j].ChildNodes;

                        for (int c = 0; c < resChildNodes.Count; c++)
                        {
                            var xmlAttributeCollection = resChildNodes[c].Attributes;

                            if (xmlAttributeCollection != null)
                            {
                                spreadShirtResponseModel.SSImage = xmlAttributeCollection["xlink:href"].Value;
                            }

                            spreadShirtResponseModelList.Add(spreadShirtResponseModel);
                        }
                    }
                }
            }

            return spreadShirtResponseModelList;
        }
    }
}
