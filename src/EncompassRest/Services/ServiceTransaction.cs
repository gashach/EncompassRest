using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Services
{
    public sealed class ServiceTransaction : ExtensibleObject
    {
        public string Status { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public List<TransactionAttachment> Attachments { get; set; }
    }
}
