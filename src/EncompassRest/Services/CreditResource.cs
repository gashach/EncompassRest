using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Services
{
    public sealed class CreditResource : ExtensibleObject
    {
        public EntityReference EntityRef { get; set; }
        public string Name { get; set; }
        public Credentials Credentials { get; set; }
        public CreditOptions Options { get; set; }
        public Preferences Preferences { get; set; }
    }
}
