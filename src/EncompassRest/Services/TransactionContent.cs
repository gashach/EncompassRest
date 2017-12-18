using System;

namespace EncompassRest.Services
{
    public sealed class TransactionContent : ExtensibleObject
    {
        public DateTime? CreatedDateTime { get; set; }
        public string AttachmentFile { get; set; }
    }
}
