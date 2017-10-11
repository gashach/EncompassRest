using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Fee : IDirty
    {
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get { return _amount; } set { _amount = value; } }
        private DirtyValue<decimal?> _amountPerDay;
        public decimal? AmountPerDay { get { return _amountPerDay; } set { _amountPerDay = value; } }
        private DirtyValue<decimal?> _borPaidAmount;
        public decimal? BorPaidAmount { get { return _borPaidAmount; } set { _borPaidAmount = value; } }
        private DirtyValue<DateTime?> _dateFrom;
        public DateTime? DateFrom { get { return _dateFrom; } set { _dateFrom = value; } }
        private DirtyValue<DateTime?> _dateTo;
        public DateTime? DateTo { get { return _dateTo; } set { _dateTo = value; } }
        private DirtyValue<int?> _days;
        public int? Days { get { return _days; } set { _days = value; } }
        private DirtyValue<decimal?> _deedAmount;
        public decimal? DeedAmount { get { return _deedAmount; } set { _deedAmount = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<string> _feeType;
        public string FeeType { get { return _feeType; } set { _feeType = value; } }
        private DirtyValue<bool?> _fHA;
        public bool? FHA { get { return _fHA; } set { _fHA = value; } }
        private DirtyValue<string> _fWBC;
        public string FWBC { get { return _fWBC; } set { _fWBC = value; } }
        private DirtyValue<string> _fWSC;
        public string FWSC { get { return _fWSC; } set { _fWSC = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _includeAboveNumber;
        public string IncludeAboveNumber { get { return _includeAboveNumber; } set { _includeAboveNumber = value; } }
        private DirtyValue<decimal?> _lenderCoverage;
        public decimal? LenderCoverage { get { return _lenderCoverage; } set { _lenderCoverage = value; } }
        private DirtyValue<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get { return _monthlyPayment; } set { _monthlyPayment = value; } }
        private DirtyValue<decimal?> _mortgageAmount;
        public decimal? MortgageAmount { get { return _mortgageAmount; } set { _mortgageAmount = value; } }
        private DirtyValue<NA<decimal>?> _newHUDBorPaidAmount;
        public NA<decimal>? NewHUDBorPaidAmount { get { return _newHUDBorPaidAmount; } set { _newHUDBorPaidAmount = value; } }
        private DirtyValue<int?> _numberOfMonths;
        public int? NumberOfMonths { get { return _numberOfMonths; } set { _numberOfMonths = value; } }
        private DirtyValue<decimal?> _ownerCoverage;
        public decimal? OwnerCoverage { get { return _ownerCoverage; } set { _ownerCoverage = value; } }
        private DirtyValue<string> _paidBy;
        public string PaidBy { get { return _paidBy; } set { _paidBy = value; } }
        private DirtyValue<decimal?> _paidInAdvance;
        public decimal? PaidInAdvance { get { return _paidInAdvance; } set { _paidInAdvance = value; } }
        private DirtyValue<decimal?> _paidToBroker;
        public decimal? PaidToBroker { get { return _paidToBroker; } set { _paidToBroker = value; } }
        private DirtyValue<string> _paidToName;
        public string PaidToName { get { return _paidToName; } set { _paidToName = value; } }
        private DirtyValue<decimal?> _paidToOthers;
        public decimal? PaidToOthers { get { return _paidToOthers; } set { _paidToOthers = value; } }
        private DirtyValue<decimal?> _percentage;
        public decimal? Percentage { get { return _percentage; } set { _percentage = value; } }
        private DirtyValue<bool?> _pFC;
        public bool? PFC { get { return _pFC; } set { _pFC = value; } }
        private DirtyValue<bool?> _pOC;
        public bool? POC { get { return _pOC; } set { _pOC = value; } }
        private DirtyValue<string> _pTB;
        public string PTB { get { return _pTB; } set { _pTB = value; } }
        private DirtyValue<decimal?> _releasesAmount;
        public decimal? ReleasesAmount { get { return _releasesAmount; } set { _releasesAmount = value; } }
        private DirtyValue<decimal?> _sellerPaidAmount;
        public decimal? SellerPaidAmount { get { return _sellerPaidAmount; } set { _sellerPaidAmount = value; } }
        private DirtyValue<decimal?> _truncatedAmountPerDay;
        public decimal? TruncatedAmountPerDay { get { return _truncatedAmountPerDay; } set { _truncatedAmountPerDay = value; } }
        private DirtyValue<bool?> _use4Decimals;
        public bool? Use4Decimals { get { return _use4Decimals; } set { _use4Decimals = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _amount.Dirty
                    || _amountPerDay.Dirty
                    || _borPaidAmount.Dirty
                    || _dateFrom.Dirty
                    || _dateTo.Dirty
                    || _days.Dirty
                    || _deedAmount.Dirty
                    || _description.Dirty
                    || _feeType.Dirty
                    || _fHA.Dirty
                    || _fWBC.Dirty
                    || _fWSC.Dirty
                    || _id.Dirty
                    || _includeAboveNumber.Dirty
                    || _lenderCoverage.Dirty
                    || _monthlyPayment.Dirty
                    || _mortgageAmount.Dirty
                    || _newHUDBorPaidAmount.Dirty
                    || _numberOfMonths.Dirty
                    || _ownerCoverage.Dirty
                    || _paidBy.Dirty
                    || _paidInAdvance.Dirty
                    || _paidToBroker.Dirty
                    || _paidToName.Dirty
                    || _paidToOthers.Dirty
                    || _percentage.Dirty
                    || _pFC.Dirty
                    || _pOC.Dirty
                    || _pTB.Dirty
                    || _releasesAmount.Dirty
                    || _sellerPaidAmount.Dirty
                    || _truncatedAmountPerDay.Dirty
                    || _use4Decimals.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _amount.Dirty = value;
                _amountPerDay.Dirty = value;
                _borPaidAmount.Dirty = value;
                _dateFrom.Dirty = value;
                _dateTo.Dirty = value;
                _days.Dirty = value;
                _deedAmount.Dirty = value;
                _description.Dirty = value;
                _feeType.Dirty = value;
                _fHA.Dirty = value;
                _fWBC.Dirty = value;
                _fWSC.Dirty = value;
                _id.Dirty = value;
                _includeAboveNumber.Dirty = value;
                _lenderCoverage.Dirty = value;
                _monthlyPayment.Dirty = value;
                _mortgageAmount.Dirty = value;
                _newHUDBorPaidAmount.Dirty = value;
                _numberOfMonths.Dirty = value;
                _ownerCoverage.Dirty = value;
                _paidBy.Dirty = value;
                _paidInAdvance.Dirty = value;
                _paidToBroker.Dirty = value;
                _paidToName.Dirty = value;
                _paidToOthers.Dirty = value;
                _percentage.Dirty = value;
                _pFC.Dirty = value;
                _pOC.Dirty = value;
                _pTB.Dirty = value;
                _releasesAmount.Dirty = value;
                _sellerPaidAmount.Dirty = value;
                _truncatedAmountPerDay.Dirty = value;
                _use4Decimals.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}