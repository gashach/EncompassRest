using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PrequalificationScenario : IDirty
    {
        private DirtyValue<int?> _appraisedValue;
        public int? AppraisedValue { get { return _appraisedValue; } set { _appraisedValue = value; } }
        private DirtyValue<decimal?> _apr;
        public decimal? Apr { get { return _apr; } set { _apr = value; } }
        private DirtyValue<decimal?> _cashToClose;
        public decimal? CashToClose { get { return _cashToClose; } set { _cashToClose = value; } }
        private DirtyValue<decimal?> _closingCost;
        public decimal? ClosingCost { get { return _closingCost; } set { _closingCost = value; } }
        private DirtyValue<decimal?> _cltv;
        public decimal? Cltv { get { return _cltv; } set { _cltv = value; } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<string> _creditScore;
        public string CreditScore { get { return _creditScore; } set { _creditScore = value; } }
        private DirtyValue<string> _currentStatus;
        public string CurrentStatus { get { return _currentStatus; } set { _currentStatus = value; } }
        private DirtyValue<decimal?> _downPaymentAmount;
        public decimal? DownPaymentAmount { get { return _downPaymentAmount; } set { _downPaymentAmount = value; } }
        private DirtyValue<decimal?> _downPaymentPercent;
        public decimal? DownPaymentPercent { get { return _downPaymentPercent; } set { _downPaymentPercent = value; } }
        private DirtyValue<decimal?> _fhaUpfrontMIPremiumPercent;
        public decimal? FhaUpfrontMIPremiumPercent { get { return _fhaUpfrontMIPremiumPercent; } set { _fhaUpfrontMIPremiumPercent = value; } }
        private DirtyValue<decimal?> _grossNegativeCashFlow;
        public decimal? GrossNegativeCashFlow { get { return _grossNegativeCashFlow; } set { _grossNegativeCashFlow = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _loanAmount;
        public decimal? LoanAmount { get { return _loanAmount; } set { _loanAmount = value; } }
        private DirtyValue<decimal?> _ltv;
        public decimal? Ltv { get { return _ltv; } set { _ltv = value; } }
        private DirtyValue<decimal?> _maximumDebt;
        public decimal? MaximumDebt { get { return _maximumDebt; } set { _maximumDebt = value; } }
        private DirtyValue<decimal?> _maximumLoanAmount;
        public decimal? MaximumLoanAmount { get { return _maximumLoanAmount; } set { _maximumLoanAmount = value; } }
        private DirtyValue<decimal?> _miAndFundingFeeFinancedAmount;
        public decimal? MiAndFundingFeeFinancedAmount { get { return _miAndFundingFeeFinancedAmount; } set { _miAndFundingFeeFinancedAmount = value; } }
        private DirtyValue<decimal?> _minimumIncome;
        public decimal? MinimumIncome { get { return _minimumIncome; } set { _minimumIncome = value; } }
        private DirtyValue<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get { return _monthlyPayment; } set { _monthlyPayment = value; } }
        private DirtyValue<decimal?> _prepaidItemsEstimatedAmount;
        public decimal? PrepaidItemsEstimatedAmount { get { return _prepaidItemsEstimatedAmount; } set { _prepaidItemsEstimatedAmount = value; } }
        private DirtyValue<int?> _prequalificationScenarioIndex;
        public int? PrequalificationScenarioIndex { get { return _prequalificationScenarioIndex; } set { _prequalificationScenarioIndex = value; } }
        private DirtyValue<decimal?> _qualBottomRatioPercent;
        public decimal? QualBottomRatioPercent { get { return _qualBottomRatioPercent; } set { _qualBottomRatioPercent = value; } }
        private DirtyValue<decimal?> _qualTopRatioPercent;
        public decimal? QualTopRatioPercent { get { return _qualTopRatioPercent; } set { _qualTopRatioPercent = value; } }
        private DirtyValue<decimal?> _salesPrice;
        public decimal? SalesPrice { get { return _salesPrice; } set { _salesPrice = value; } }
        private DirtyValue<decimal?> _subordinateFin;
        public decimal? SubordinateFin { get { return _subordinateFin; } set { _subordinateFin = value; } }
        private DirtyValue<decimal?> _totalBaseCost;
        public decimal? TotalBaseCost { get { return _totalBaseCost; } set { _totalBaseCost = value; } }
        private DirtyValue<decimal?> _totalCashAvailable;
        public decimal? TotalCashAvailable { get { return _totalCashAvailable; } set { _totalCashAvailable = value; } }
        private DirtyValue<decimal?> _totalCashLeft;
        public decimal? TotalCashLeft { get { return _totalCashLeft; } set { _totalCashLeft = value; } }
        private DirtyValue<decimal?> _totalCosts;
        public decimal? TotalCosts { get { return _totalCosts; } set { _totalCosts = value; } }
        private DirtyValue<decimal?> _totalFinancing;
        public decimal? TotalFinancing { get { return _totalFinancing; } set { _totalFinancing = value; } }
        private DirtyValue<decimal?> _totalHe;
        public decimal? TotalHe { get { return _totalHe; } set { _totalHe = value; } }
        private DirtyValue<decimal?> _totalIncome;
        public decimal? TotalIncome { get { return _totalIncome; } set { _totalIncome = value; } }
        private DirtyValue<decimal?> _totalLoanAmount;
        public decimal? TotalLoanAmount { get { return _totalLoanAmount; } set { _totalLoanAmount = value; } }
        private DirtyValue<decimal?> _totalOtherExpense;
        public decimal? TotalOtherExpense { get { return _totalOtherExpense; } set { _totalOtherExpense = value; } }
        private DirtyValue<decimal?> _totalPaidOffMortgage;
        public decimal? TotalPaidOffMortgage { get { return _totalPaidOffMortgage; } set { _totalPaidOffMortgage = value; } }
        private DirtyValue<decimal?> _totalPaidOffOthers;
        public decimal? TotalPaidOffOthers { get { return _totalPaidOffOthers; } set { _totalPaidOffOthers = value; } }
        private DirtyValue<decimal?> _totalPayments;
        public decimal? TotalPayments { get { return _totalPayments; } set { _totalPayments = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _appraisedValue.Dirty
                    || _apr.Dirty
                    || _cashToClose.Dirty
                    || _closingCost.Dirty
                    || _cltv.Dirty
                    || _comments.Dirty
                    || _creditScore.Dirty
                    || _currentStatus.Dirty
                    || _downPaymentAmount.Dirty
                    || _downPaymentPercent.Dirty
                    || _fhaUpfrontMIPremiumPercent.Dirty
                    || _grossNegativeCashFlow.Dirty
                    || _id.Dirty
                    || _loanAmount.Dirty
                    || _ltv.Dirty
                    || _maximumDebt.Dirty
                    || _maximumLoanAmount.Dirty
                    || _miAndFundingFeeFinancedAmount.Dirty
                    || _minimumIncome.Dirty
                    || _monthlyPayment.Dirty
                    || _prepaidItemsEstimatedAmount.Dirty
                    || _prequalificationScenarioIndex.Dirty
                    || _qualBottomRatioPercent.Dirty
                    || _qualTopRatioPercent.Dirty
                    || _salesPrice.Dirty
                    || _subordinateFin.Dirty
                    || _totalBaseCost.Dirty
                    || _totalCashAvailable.Dirty
                    || _totalCashLeft.Dirty
                    || _totalCosts.Dirty
                    || _totalFinancing.Dirty
                    || _totalHe.Dirty
                    || _totalIncome.Dirty
                    || _totalLoanAmount.Dirty
                    || _totalOtherExpense.Dirty
                    || _totalPaidOffMortgage.Dirty
                    || _totalPaidOffOthers.Dirty
                    || _totalPayments.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _appraisedValue.Dirty = value;
                _apr.Dirty = value;
                _cashToClose.Dirty = value;
                _closingCost.Dirty = value;
                _cltv.Dirty = value;
                _comments.Dirty = value;
                _creditScore.Dirty = value;
                _currentStatus.Dirty = value;
                _downPaymentAmount.Dirty = value;
                _downPaymentPercent.Dirty = value;
                _fhaUpfrontMIPremiumPercent.Dirty = value;
                _grossNegativeCashFlow.Dirty = value;
                _id.Dirty = value;
                _loanAmount.Dirty = value;
                _ltv.Dirty = value;
                _maximumDebt.Dirty = value;
                _maximumLoanAmount.Dirty = value;
                _miAndFundingFeeFinancedAmount.Dirty = value;
                _minimumIncome.Dirty = value;
                _monthlyPayment.Dirty = value;
                _prepaidItemsEstimatedAmount.Dirty = value;
                _prequalificationScenarioIndex.Dirty = value;
                _qualBottomRatioPercent.Dirty = value;
                _qualTopRatioPercent.Dirty = value;
                _salesPrice.Dirty = value;
                _subordinateFin.Dirty = value;
                _totalBaseCost.Dirty = value;
                _totalCashAvailable.Dirty = value;
                _totalCashLeft.Dirty = value;
                _totalCosts.Dirty = value;
                _totalFinancing.Dirty = value;
                _totalHe.Dirty = value;
                _totalIncome.Dirty = value;
                _totalLoanAmount.Dirty = value;
                _totalOtherExpense.Dirty = value;
                _totalPaidOffMortgage.Dirty = value;
                _totalPaidOffOthers.Dirty = value;
                _totalPayments.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}