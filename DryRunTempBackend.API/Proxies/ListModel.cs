using System.Collections.Generic;

namespace DryRunTempBackend.API.Proxies
{
    public class ListModel<T>
    {
        public int Total { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}