using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using Restsharp_Framework.DataObjects;
using Restsharp_Framework.DataObjects.Request;
using Restsharp_Framework.Helper;
using Restsharp_Framework.TestCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Restsharp_Framework
{
    [TestFixture]
    public class Test : BaseTest
    {
        readonly Common user;

        public Test()
        {
            this.user = new Common(); ;
        }

        [Test]
        public async Task GetData()
        {
            
            var response = await user.GetData("api/users?page=2");
            var responseContent = HandleContent.GetContent<UserDetails>(response);
            Assert.AreEqual(responseContent.Page, 2);
        }

        [Test]
        public async Task CreateData()
        {
            var payload = HandleContent.ParseJson<UserInformation>($"{TestContext.TestDirectory}\\Test Data\\UserInformation.json");
            var response = await user.CreateData("api/users?page=2", payload);
            var responseContent = HandleContent.GetContent<UserInfo>(response);
            Assert.AreEqual(responseContent.Job, payload.job);
        }

        [Test]
        public async Task UpdateData()
        {
            var payload = HandleContent.ParseJson<UserInformation>($"{TestContext.TestDirectory}\\Test Data\\UserInformation.json");
            var response = await user.UpdateData("api/users/2", payload);
            var responseContent = HandleContent.GetContent<UserModification>(response);
            Assert.AreEqual(responseContent.Job, payload.job);
        }

        [Test]
        public async Task DeleteData()
        {
            var response = await user.DeleteData("api/users/2");
            var responseContent = HandleContent.GetContent<UserModification>(response);
            Assert.AreEqual(response.StatusCode.ToString(), "NoContent");
        }
    }
}
