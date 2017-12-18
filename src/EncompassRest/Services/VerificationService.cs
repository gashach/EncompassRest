using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Services
{
    public class VerificationService<TVerificationOptions> : Service<VerificationProduct<TVerificationOptions>,TVerificationOptions>
        where TVerificationOptions : ServiceOptions
    {

    }
}
