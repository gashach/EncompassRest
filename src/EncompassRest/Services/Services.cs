using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using System;


namespace EncompassRest.Services
{
    public abstract class Services :ApiObject
    {
        internal Services(EncompassRestClient client) 
           : base(client, "services/v1")
        {
        }


    }
}
