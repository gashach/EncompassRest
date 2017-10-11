using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Income : IDirty
    {
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private DirtyValue<bool?> _currentIndicator;
        public bool? CurrentIndicator { get { return _currentIndicator; } set { _currentIndicator = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _incomeType;
        public string IncomeType { get { return _incomeType; } set { _incomeType = value; } }
        private DirtyValue<int?> _otherIncomeIndex;
        public int? OtherIncomeIndex { get { return _otherIncomeIndex; } set { _otherIncomeIndex = value; } }
        private DirtyValue<string> _owner;
        public string Owner { get { return _owner; } set { _owner = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _amount.Dirty
                    || _currentIndicator.Dirty
                    || _description.Dirty
                    || _id.Dirty
                    || _incomeType.Dirty
                    || _otherIncomeIndex.Dirty
                    || _owner.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _amount.Dirty = value;
                _currentIndicator.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _incomeType.Dirty = value;
                _otherIncomeIndex.Dirty = value;
                _owner.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}