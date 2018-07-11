using System;
using System.Net.Http;

namespace DryRunTempBackend.BigChainDbProvider
{
    public class DbContextBase : HttpHandler
    {
        public DbContextBase(string apiRoot) : base(apiRoot) { }

        public string GetTransaction(string transactionId)
        {
            //TODO: remove hard coded value
            transactionId = "4957744b3ac54434b8270f2c854cc1040228c82ea4e72d66d2887a4d3e30b317";
            return ExecuteGetRequestAsync("transactions/"+transactionId).Result;
        }

        public string GetTransactions(string assetId, string operation)
        {
            return ExecuteGetRequestAsync($"transactions?asset_id={assetId}&operation={operation}").Result;
        }

    }

    public class DbContext : DbContextBase
    {
        public DbContext() : base("https://test.bigchaindb.com/api/v1/") {}


    }
}
