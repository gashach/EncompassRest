using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Services
{
    public class VerificationServices<TProduct, TOptions> : Services<Service<TProduct, TOptions>, TOptions, TProduct>
        where TOptions : ServiceOptions
        where TProduct : ServiceProduct<TOptions>
    {
        internal VerificationServices(EncompassRestClient client, Service<TProduct, TOptions> service) : base(client, service)
        {
        }
    }
}
