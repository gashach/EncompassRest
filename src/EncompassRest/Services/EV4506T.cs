using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Services
{
    public sealed class EV4506T : ServiceProduct<EV4506TOptions>
    {
        public string BranchId { get; set; }
        public override EV4506TOptions Options { get; }
    }
}
