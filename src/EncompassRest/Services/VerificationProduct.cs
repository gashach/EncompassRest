namespace EncompassRest.Services
{
    public sealed class VerificationProduct : ServiceProduct<ServiceOptions>
    {
        public string BranchId { get; set; }
        public override ServiceOptions Options { get; }
    }
}
