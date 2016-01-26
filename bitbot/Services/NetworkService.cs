using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace bitbot.Services
{
    class NetworkService : INetworkService
    {
        //Uri baseUri;
        string baseUri;

        public NetworkService()
        {
            //baseUri = new Uri("http://api.coindesk.com/v1/bpi/currentprice.json");
            baseUri = "http://api.coindesk.com/v1/bpi/currentprice.json";
        }

        public string Get()
        {
            WebRequest get = WebRequest.Create(baseUri);
            get.Method = "GET";
            get.ContentType = "application/json; charset=utf-8";

            var resp = get.GetResponse();
            var stream = resp.GetResponseStream();
            var reader = new StreamReader(stream);

            string result = reader.ReadToEnd();

            reader.Close();
            resp.Close();

            return result;
        }

        public void Post(string paramaters)
        {
            throw new NotImplementedException();
        }
    }
}
