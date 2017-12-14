#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class StatusOnlineEvent : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _dateText;
        public string DateText { get => _dateText; set => _dateText = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _dateText.Dirty
                    || _description.Dirty
                    || _id.Dirty;
            }
            set
            {
                _dateText.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
            }
        }
    }
}