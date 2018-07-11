using DryRunTempBackend.BigChainDbProvider;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DryRunTempBackend.Test
{
    [TestClass]
    public class HttpHandlerTest
    {
        private readonly HttpHandler _httpHandler = new HttpHandler("https://jsonplaceholder.typicode.com/"); 

        [TestMethod]
        public void ExecuteRequest_SendRequest_ReturnsResponse()
        {
            //Arrange
            string resourceUrl = "posts";

            //Act
            string result = _httpHandler.ExecuteGetRequestAsync(resourceUrl).Result;

            //Result
            Assert.IsNotNull(result);
            Assert.AreNotEqual(string.Empty,result);
        }
    }
}
