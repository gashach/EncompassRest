using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassRest.Services
{
    public sealed class EV4506TResources : ExtensibleObject
    {
        public string AttachmentId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
