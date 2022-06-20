using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Restsharp_Framework.Helper
{
    public class Common
    {

        APIHelper apiHelper;
        public Common(){
            apiHelper = new APIHelper();
        }
        public async Task<RestResponse> GetData(string endpoint)
        {
            RestClient restClient = apiHelper.SetURL(endpoint);
            RestRequest restRequest = apiHelper.GetRequest();
            RestResponse response = await apiHelper.GetResponse(restClient, restRequest);
            return response;
        }

        public async Task<RestResponse> CreateData(string endpoint, dynamic payload)
        {
            var restClient = apiHelper.SetURL(endpoint);
            var restRequest = apiHelper.CreateRequest(payload);
            var response = await apiHelper.GetResponse(restClient, restRequest);
            return response;
        }

        public async Task<RestResponse> UpdateData(string endpoint, dynamic payload)
        {
            RestClient restClient = apiHelper.SetURL(endpoint);
            RestRequest restRequest = apiHelper.EditRequest(payload);
            RestResponse response = await apiHelper.GetResponse(restClient, restRequest);
            return response;
        }

        public async Task<RestResponse> DeleteData(string endpoint)
        {
            RestClient restClient = apiHelper.SetURL(endpoint);
            RestRequest restRequest = apiHelper.DeleteRequest();
            RestResponse response = await apiHelper.GetResponse(restClient, restRequest);
            return response;
        }
    }
}
