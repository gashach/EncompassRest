using System;
using System.Threading.Tasks;

namespace EncompassRest.Services
{
    public abstract class Services<TService,TServiceOptions,TServiceProduct> : ApiObject
        where TService : Service<TServiceProduct,TServiceOptions>
        where TServiceProduct : ServiceProduct<TServiceOptions>
        where TServiceOptions : ServiceOptions
    {
        private TService _service;

        internal Services(EncompassRestClient client, TService service) 
           : base(client, "services/v1")
        {
            _service = service;
        }

        public Task<string> OrderServiceAsync()
        {
            throw new NotImplementedException();
        }
    }
}
