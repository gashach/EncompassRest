namespace EncompassRest.Services
{
    public sealed class VerificationProduct<TServiceOptions> : ServiceProduct<TServiceOptions>
        where TServiceOptions : ServiceOptions
    {
        public string BranchId { get; set; }
        public override TServiceOptions Options { get; }
    }
}
