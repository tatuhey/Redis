using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StackExchange.Redis;
using System.Net;

namespace Redis
{
    [TestClass]
    public class UnitTest1
    {
        
        //private static TestContext testContext = null;
        //[ClassInitialize]

        //public static void Class_init(TestContext ctx)
        //{
        //    testContext = ctx;
        //}

        [TestMethod]
        public void TestMethod1_connect()
        {
            //var config = "azureredis2023.redis.cache.windows.net:6380,password=ThQaUVV3072JZP1XhFccCVMVwY87FvGiTAzCaBheeiI=,ssl=True,abortConnect=False";
            //var connMultiplexter = ConnectionMultiplexer.Connect(config);
            //var redis = connMultiplexter.GetDatabase();

            // Hide the string from the code
            var ipAddresses = Dns.GetHostAddresses("azureredis2023.redis.cache.windows.net");
            var port = 6380;

            var config = new ConfigurationOptions
            {
                // Endpoints are IP
                EndPoints = { new IPEndPoint(ipAddresses[0], port) },
                Ssl = true,
                Password = "ThQaUVV3072JZP1XhFccCVMVwY87FvGiTAzCaBheeiI=",
                ClientName = nameof(UnitTest1),
                AllowAdmin = true, // to have access to all commands
                AbortOnConnectFail = false
            };

            var connMultiplexter = ConnectionMultiplexer.Connect(config);
            var redis = connMultiplexter.GetDatabase();

            //string ourNewConnectionString = testContext.Properties["azureRedisConnectionString"] as string;

            //var connMultiplexter = ConnectionMultiplexer.Connect(ourNewConnectionString);
            //var redis = connMultiplexter.GetDatabase();

        }
    }
}
