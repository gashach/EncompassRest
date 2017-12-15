using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Services
{
    public sealed class ServicePreferences
    {
        public bool ImportLiabilities { get; set; }
        public bool ExcludeZeroBalances { get; set; }

    }
}
