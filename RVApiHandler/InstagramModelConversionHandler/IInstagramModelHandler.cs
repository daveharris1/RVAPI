using RVApiHandler.Models;
using System.Collections.Generic;

namespace RVApiHandler.InstagramModelConversionHandler
{
    public interface IInstagramModelHandler
    {
        List<Datum> ConvertJsonToDatumList(string instagramJson);
    }
}
