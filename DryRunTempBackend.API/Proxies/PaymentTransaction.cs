namespace DryRunTempBackend.API.Controllers
{
    public class PaymentTransaction
    {
        public decimal Amount { get; set; }
        public SupplierInfo Supplier { get; set; }
        public string Notes { get; set; }
    }
}