using System;
using System.Net;
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
            var actual = _client.GetData(123);
            Assert.IsNotNull(actual);
            Console.WriteLine(actual);
        }
    }
}
