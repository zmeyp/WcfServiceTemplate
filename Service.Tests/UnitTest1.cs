using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.Tests.ServiceRef;

namespace Service.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Service1Client _client;

        [TestInitialize]
        public void Init()
        {
            _client = new Service1Client();

            //ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) => true;
        }

        [TestMethod]
        public void TestMethod1()
        {
            //_client.ClientCredentials.Windows.ClientCredential = CredentialCache.DefaultNetworkCredentials;

            var actual = new List<Task<string>>(); 

            for (var i = 0; i < 10; i++)
            {
                actual.Add(Run(i));
            }

            for (var i = 0; i < 10; i++)
            {
                Assert.IsNotNull(actual[i].Result);
                Console.WriteLine(actual[i].Result);
            }
        }

        public async Task<string> Run(int count)
        {
            return await _client.GetDataAsync(count);
        }

    }
}
