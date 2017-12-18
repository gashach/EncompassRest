namespace EncompassRest.Services
{
    public abstract class Service<TProduct, TOptions>
        where TProduct : ServiceProduct<TOptions>
        where TOptions : ServiceOptions
    {
        public string partnerId { get; set; }
        public TProduct product { get; set; }
    }
}
