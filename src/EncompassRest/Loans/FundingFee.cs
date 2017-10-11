using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FundingFee : IDirty
    {
        private DirtyValue<bool?> _balanceChecked;
        public bool? BalanceChecked { get { return _balanceChecked; } set { _balanceChecked = value; } }
        private DirtyValue<string> _cdLineId;
        public string CdLineId { get { return _cdLineId; } set { _cdLineId = value; } }
        private DirtyValue<string> _feeDescription;
        public string FeeDescription { get { return _feeDescription; } set { _feeDescription = value; } }
        private DirtyValue<string> _feeDescription2015;
        public string FeeDescription2015 { get { return _feeDescription2015; } set { _feeDescription2015 = value; } }
        private DirtyValue<string> _lineId;
        public string LineId { get { return _lineId; } set { _lineId = value; } }
        private DirtyValue<int?> _lineNumber;
        public int? LineNumber { get { return _lineNumber; } set { _lineNumber = value; } }
        private DirtyValue<string> _paidBy;
        public string PaidBy { get { return _paidBy; } set { _paidBy = value; } }
        private DirtyValue<string> _paidTo;
        public string PaidTo { get { return _paidTo; } set { _paidTo = value; } }
        private DirtyValue<string> _payee;
        public string Payee { get { return _payee; } set { _payee = value; } }
        private DirtyValue<string> _pocPaidBy;
        public string PocPaidBy { get { return _pocPaidBy; } set { _pocPaidBy = value; } }
        private DirtyValue<string> _ptcPaidBy;
        public string PtcPaidBy { get { return _ptcPaidBy; } set { _ptcPaidBy = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _balanceChecked.Dirty
                    || _cdLineId.Dirty
                    || _feeDescription.Dirty
                    || _feeDescription2015.Dirty
                    || _lineId.Dirty
                    || _lineNumber.Dirty
                    || _paidBy.Dirty
                    || _paidTo.Dirty
                    || _payee.Dirty
                    || _pocPaidBy.Dirty
                    || _ptcPaidBy.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _balanceChecked.Dirty = value;
                _cdLineId.Dirty = value;
                _feeDescription.Dirty = value;
                _feeDescription2015.Dirty = value;
                _lineId.Dirty = value;
                _lineNumber.Dirty = value;
                _paidBy.Dirty = value;
                _paidTo.Dirty = value;
                _payee.Dirty = value;
                _pocPaidBy.Dirty = value;
                _ptcPaidBy.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}