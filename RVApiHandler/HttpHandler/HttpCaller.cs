using System.IO;
using System.Net;

namespace RVApiHandler.HttpHandler
{
    public class HttpCaller : IHttpCaller
    {
        public string CallEndPoint(string url)
        {
            string apiResponse;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())

            using (Stream stream = response.GetResponseStream())

            using (StreamReader reader = new StreamReader(stream))
            {
                apiResponse = reader.ReadToEnd();
            }

            return apiResponse;
        }
    }
}
