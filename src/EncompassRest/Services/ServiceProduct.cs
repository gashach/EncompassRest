using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Services
{
    public abstract class ServiceProduct<TOptions> : ExtensibleObject
        where TOptions : ServiceOptions
    {
        public EntityReference EntityRef { get; set; }
        public  string Name { get; set; }
        public abstract TOptions Options { get; }
        public ServicePreferences Preferences { get; set; }
        public ServiceCredentials Credentials { get; set; }
        //public string BranchId { get; set; }
    }
}
