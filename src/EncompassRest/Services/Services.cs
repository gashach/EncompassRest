using System;
using System.Threading.Tasks;

namespace EncompassRest.Services
{
    public abstract class Services<TProduct, TOptions> : ApiObject
        where TProduct : ServiceProduct<TOptions>
        where TOptions : ServiceOptions
    {
        internal Services(EncompassRestClient client) 
           : base(client, "services/v1")
        {
        }

        public Task<string> OrderServiceAsync()
        {
            throw new NotImplementedException();
        }
    }
}
