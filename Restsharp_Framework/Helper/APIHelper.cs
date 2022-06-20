using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace Restsharp_Framework.Helper
{
    public class APIHelper
    {
        public RestClient restClient;
        public RestRequest restRequest;
        public string BASE_URL = "https://reqres.in/";

        public RestClient SetURL(string endpoint)
        {
            var url = Path.Combine(BASE_URL, endpoint);
            restClient = new RestClient(url);
            return restClient;
        }

        public RestRequest GetRequest()
        {
            restRequest = new RestRequest
            {
                Method = Method.Get
            };
            //restRequest.AddHeaders(new Dictionary<string, string>
            //{
            //    { "Accept", "application/json" },
            //    { "Content-Type", "application/json" }

            //});
            restRequest.RequestFormat = DataFormat.Json;
            return restRequest;
        }

        public RestRequest CreateRequest<T>(T payload) where T : class
        {
            restRequest = new RestRequest { Method = Method.Post };
            restRequest.AddHeader("Accept", "application/json");
            //restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddBody(payload);
            restRequest.RequestFormat = DataFormat.Json;
            return restRequest;
        }

        public RestRequest EditRequest<T>(T payload) where T : class
        {
            restRequest = new RestRequest { Method = Method.Put };
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddBody(payload);
            restRequest.RequestFormat = DataFormat.Json;
            return restRequest;
        }

        public RestRequest DeleteRequest()
        {
            restRequest = new RestRequest { Method = Method.Delete };
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            return restRequest;
        }


        public async Task<RestResponse> GetResponse(RestClient restClient, RestRequest restRequest)
        {
            return await restClient.ExecuteAsync(restRequest);
        }
        
        //public DataObjects SerializeJSON<DataObjects>(IRestResponse response)
        //{
        //    var content = response.Content;
        //    var data = JsonConvert.SerializeObject(content);
        //    return data;
        //}
    }
}
