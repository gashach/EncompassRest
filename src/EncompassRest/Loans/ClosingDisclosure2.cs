using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure2 : IDirty
    {
        private DirtyValue<decimal?> _borrowerClosingCostAtClosing;
        public decimal? BorrowerClosingCostAtClosing { get { return _borrowerClosingCostAtClosing; } set { _borrowerClosingCostAtClosing = value; } }
        private DirtyValue<decimal?> _borrowerClosingCostBeforeClosing;
        public decimal? BorrowerClosingCostBeforeClosing { get { return _borrowerClosingCostBeforeClosing; } set { _borrowerClosingCostBeforeClosing = value; } }
        private DirtyValue<decimal?> _closingCostLenderCredits;
        public decimal? ClosingCostLenderCredits { get { return _closingCostLenderCredits; } set { _closingCostLenderCredits = value; } }
        private DirtyValue<decimal?> _closingCostPaidByOthers;
        public decimal? ClosingCostPaidByOthers { get { return _closingCostPaidByOthers; } set { _closingCostPaidByOthers = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _initialEscrowSubTotal;
        public decimal? InitialEscrowSubTotal { get { return _initialEscrowSubTotal; } set { _initialEscrowSubTotal = value; } }
        private DirtyValue<decimal?> _lastDisclosedLenderCredits;
        public decimal? LastDisclosedLenderCredits { get { return _lastDisclosedLenderCredits; } set { _lastDisclosedLenderCredits = value; } }
        private DirtyValue<decimal?> _lastDisclosedLoanCosts;
        public decimal? LastDisclosedLoanCosts { get { return _lastDisclosedLoanCosts; } set { _lastDisclosedLoanCosts = value; } }
        private DirtyValue<decimal?> _lastDisclosedOtherCosts;
        public decimal? LastDisclosedOtherCosts { get { return _lastDisclosedOtherCosts; } set { _lastDisclosedOtherCosts = value; } }
        private DirtyValue<decimal?> _lCAtClosing;
        public decimal? LCAtClosing { get { return _lCAtClosing; } set { _lCAtClosing = value; } }
        private DirtyValue<decimal?> _originationChargesSubTotal;
        public decimal? OriginationChargesSubTotal { get { return _originationChargesSubTotal; } set { _originationChargesSubTotal = value; } }
        private DirtyValue<decimal?> _otherSubTotal;
        public decimal? OtherSubTotal { get { return _otherSubTotal; } set { _otherSubTotal = value; } }
        private DirtyValue<decimal?> _prepaidsSubTotal;
        public decimal? PrepaidsSubTotal { get { return _prepaidsSubTotal; } set { _prepaidsSubTotal = value; } }
        private DirtyValue<decimal?> _sellerClosingCostAtClosing;
        public decimal? SellerClosingCostAtClosing { get { return _sellerClosingCostAtClosing; } set { _sellerClosingCostAtClosing = value; } }
        private DirtyValue<decimal?> _sellerClosingCostBeforeClosing;
        public decimal? SellerClosingCostBeforeClosing { get { return _sellerClosingCostBeforeClosing; } set { _sellerClosingCostBeforeClosing = value; } }
        private DirtyValue<decimal?> _servicesDidNotShopSubTotal;
        public decimal? ServicesDidNotShopSubTotal { get { return _servicesDidNotShopSubTotal; } set { _servicesDidNotShopSubTotal = value; } }
        private DirtyValue<decimal?> _servicesDidShopSubTotal;
        public decimal? ServicesDidShopSubTotal { get { return _servicesDidShopSubTotal; } set { _servicesDidShopSubTotal = value; } }
        private DirtyValue<decimal?> _taxesGovermentFeesSubTotal;
        public decimal? TaxesGovermentFeesSubTotal { get { return _taxesGovermentFeesSubTotal; } set { _taxesGovermentFeesSubTotal = value; } }
        private DirtyValue<decimal?> _totalBorrowerPaidAtClosing;
        public decimal? TotalBorrowerPaidAtClosing { get { return _totalBorrowerPaidAtClosing; } set { _totalBorrowerPaidAtClosing = value; } }
        private DirtyValue<decimal?> _totalBorrowerPaidBeforeClosing;
        public decimal? TotalBorrowerPaidBeforeClosing { get { return _totalBorrowerPaidBeforeClosing; } set { _totalBorrowerPaidBeforeClosing = value; } }
        private DirtyValue<decimal?> _totalClosingCost;
        public decimal? TotalClosingCost { get { return _totalClosingCost; } set { _totalClosingCost = value; } }
        private DirtyValue<decimal?> _totalLoanCost;
        public decimal? TotalLoanCost { get { return _totalLoanCost; } set { _totalLoanCost = value; } }
        private DirtyValue<decimal?> _totalOtherCost;
        public decimal? TotalOtherCost { get { return _totalOtherCost; } set { _totalOtherCost = value; } }
        private DirtyValue<decimal?> _totalOtherCostAtClosing;
        public decimal? TotalOtherCostAtClosing { get { return _totalOtherCostAtClosing; } set { _totalOtherCostAtClosing = value; } }
        private DirtyValue<decimal?> _totalOtherCostBeforeClosing;
        public decimal? TotalOtherCostBeforeClosing { get { return _totalOtherCostBeforeClosing; } set { _totalOtherCostBeforeClosing = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _borrowerClosingCostAtClosing.Dirty
                    || _borrowerClosingCostBeforeClosing.Dirty
                    || _closingCostLenderCredits.Dirty
                    || _closingCostPaidByOthers.Dirty
                    || _id.Dirty
                    || _initialEscrowSubTotal.Dirty
                    || _lastDisclosedLenderCredits.Dirty
                    || _lastDisclosedLoanCosts.Dirty
                    || _lastDisclosedOtherCosts.Dirty
                    || _lCAtClosing.Dirty
                    || _originationChargesSubTotal.Dirty
                    || _otherSubTotal.Dirty
                    || _prepaidsSubTotal.Dirty
                    || _sellerClosingCostAtClosing.Dirty
                    || _sellerClosingCostBeforeClosing.Dirty
                    || _servicesDidNotShopSubTotal.Dirty
                    || _servicesDidShopSubTotal.Dirty
                    || _taxesGovermentFeesSubTotal.Dirty
                    || _totalBorrowerPaidAtClosing.Dirty
                    || _totalBorrowerPaidBeforeClosing.Dirty
                    || _totalClosingCost.Dirty
                    || _totalLoanCost.Dirty
                    || _totalOtherCost.Dirty
                    || _totalOtherCostAtClosing.Dirty
                    || _totalOtherCostBeforeClosing.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _borrowerClosingCostAtClosing.Dirty = value;
                _borrowerClosingCostBeforeClosing.Dirty = value;
                _closingCostLenderCredits.Dirty = value;
                _closingCostPaidByOthers.Dirty = value;
                _id.Dirty = value;
                _initialEscrowSubTotal.Dirty = value;
                _lastDisclosedLenderCredits.Dirty = value;
                _lastDisclosedLoanCosts.Dirty = value;
                _lastDisclosedOtherCosts.Dirty = value;
                _lCAtClosing.Dirty = value;
                _originationChargesSubTotal.Dirty = value;
                _otherSubTotal.Dirty = value;
                _prepaidsSubTotal.Dirty = value;
                _sellerClosingCostAtClosing.Dirty = value;
                _sellerClosingCostBeforeClosing.Dirty = value;
                _servicesDidNotShopSubTotal.Dirty = value;
                _servicesDidShopSubTotal.Dirty = value;
                _taxesGovermentFeesSubTotal.Dirty = value;
                _totalBorrowerPaidAtClosing.Dirty = value;
                _totalBorrowerPaidBeforeClosing.Dirty = value;
                _totalClosingCost.Dirty = value;
                _totalLoanCost.Dirty = value;
                _totalOtherCost.Dirty = value;
                _totalOtherCostAtClosing.Dirty = value;
                _totalOtherCostBeforeClosing.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}