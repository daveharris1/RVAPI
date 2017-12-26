using RVApiHandler.Models;
using System.Collections.Generic;

namespace RVApiHandler.XmlModelConversionHandler
{
    public interface IXmlModelConvertor
    {
        List<SpreadShirtResponseModel> ConvertXmlToResponseModel(string xmlString);
    }
}
