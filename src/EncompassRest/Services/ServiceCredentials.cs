using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Services
{
    public sealed class ServiceCredentials : ExtensibleObject
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
