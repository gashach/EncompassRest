#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class AdditionalStateDisclosure : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _disclosureName;
        public string DisclosureName { get => _disclosureName; set => _disclosureName = value; }
        private DirtyValue<string> _disclosureValue;
        public string DisclosureValue { get => _disclosureValue; set => _disclosureValue = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _stateCode;
        public string StateCode { get => _stateCode; set => _stateCode = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _disclosureName.Dirty
                    || _disclosureValue.Dirty
                    || _id.Dirty
                    || _stateCode.Dirty;
            }
            set
            {
                _disclosureName.Dirty = value;
                _disclosureValue.Dirty = value;
                _id.Dirty = value;
                _stateCode.Dirty = value;
            }
        }
    }
}