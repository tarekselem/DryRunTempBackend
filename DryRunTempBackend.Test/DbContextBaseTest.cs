using DryRunTempBackend.BigChainDbProvider;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DryRunTempBackend.Test
{
    [TestClass]
    public class DbContextBaseTest
    {
        private readonly DbContextBase _dbContextBase = new DbContextBase("https://test.bigchaindb.com/api/v1/");

        [TestMethod]
        public void ExecuteRequest_GetTransactions_ReturnsTransactionsDependsOnAssetIdAndOperation()
        {
            //Arrange
            var assetId = "4957744b3ac54434b8270f2c854cc1040228c82ea4e72d66d2887a4d3e30b317";
            var operation = "CREATE"; //CREATE | TRANSFER

            //Act
            string result = _dbContextBase.GetTransactions(assetId,operation);

            //Result
            Assert.IsNotNull(result);
            Assert.AreNotEqual(string.Empty, result);
        }

        [TestMethod]
        public void ExecuteRequest_GetTransaction_ReturnsTransactionsDependsOnAssetIdAndOperation()
        {
            //Arrange
            var transactionId = "4957744b3ac54434b8270f2c854cc1040228c82ea4e72d66d2887a4d3e30b317";

            //Act
            string result = _dbContextBase.GetTransaction(transactionId);

            //Result
            Assert.IsNotNull(result);
            Assert.AreNotEqual(string.Empty, result);
        }
    }
}
