using System;

namespace DryRunTempBackend.API.Controllers
{
    public class Transaction
    {
        public DateTime TimeStamp { get; set; }
        public string To { get; set; }
    }
}