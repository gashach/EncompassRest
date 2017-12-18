namespace EncompassRest.Services
{
    public abstract class Services<TService> : ApiObject
        where TService : Service
    {
        internal Services(EncompassRestClient client) 
           : base(client, "services/v1")
        {
        }

        public Task<ServiceProduct>
    }
}
