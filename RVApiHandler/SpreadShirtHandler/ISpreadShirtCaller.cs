using RVApiHandler.Models;
using System.Collections.Generic;

namespace RVApiHandler.SpreadShirtHandler
{
    public interface ISpreadShirtCaller
    {
        List<SpreadShirtResponseModel> GetSpreadShirtsProducts();
    }
}
