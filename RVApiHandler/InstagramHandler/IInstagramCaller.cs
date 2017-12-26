using RVApiHandler.Models;
using System.Collections.Generic;

namespace RVApiHandler.InstagramHandler
{
    public interface IInstagramCaller
    {
        List<Datum> GetInstagramData();
    }
}
