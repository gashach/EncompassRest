#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010Fee : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _additionalAmount;
        public decimal? AdditionalAmount { get => _additionalAmount; set => _additionalAmount = value; }
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<bool?> _aprIndicator;
        public bool? AprIndicator { get => _aprIndicator; set => _aprIndicator = value; }
        private DirtyValue<decimal?> _borPaidAmount;
        public decimal? BorPaidAmount { get => _borPaidAmount; set => _borPaidAmount = value; }
        private DirtyValue<decimal?> _borrowerAmountPaid2015;
        public decimal? BorrowerAmountPaid2015 { get => _borrowerAmountPaid2015; set => _borrowerAmountPaid2015 = value; }
        private DirtyValue<bool?> _borrowerCanShopForIndicator2015;
        public bool? BorrowerCanShopForIndicator2015 { get => _borrowerCanShopForIndicator2015; set => _borrowerCanShopForIndicator2015 = value; }
        private DirtyValue<bool?> _borrowerDidShopForIndicator2015;
        public bool? BorrowerDidShopForIndicator2015 { get => _borrowerDidShopForIndicator2015; set => _borrowerDidShopForIndicator2015 = value; }
        private DirtyValue<decimal?> _borrowerFinanced2015;
        public decimal? BorrowerFinanced2015 { get => _borrowerFinanced2015; set => _borrowerFinanced2015 = value; }
        private DirtyValue<decimal?> _borrowerPAC2015;
        public decimal? BorrowerPAC2015 { get => _borrowerPAC2015; set => _borrowerPAC2015 = value; }
        private DirtyValue<decimal?> _borrowerPOC2015;
        public decimal? BorrowerPOC2015 { get => _borrowerPOC2015; set => _borrowerPOC2015 = value; }
        private DirtyValue<decimal?> _borrowerPTC2015;
        public decimal? BorrowerPTC2015 { get => _borrowerPTC2015; set => _borrowerPTC2015 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator;
        public bool? BorrowerSelectIndicator { get => _borrowerSelectIndicator; set => _borrowerSelectIndicator = value; }
        private DirtyValue<decimal?> _brokerAmountPaid2015;
        public decimal? BrokerAmountPaid2015 { get => _brokerAmountPaid2015; set => _brokerAmountPaid2015 = value; }
        private DirtyValue<decimal?> _brokerPAC2015;
        public decimal? BrokerPAC2015 { get => _brokerPAC2015; set => _brokerPAC2015 = value; }
        private DirtyValue<decimal?> _brokerPOC2015;
        public decimal? BrokerPOC2015 { get => _brokerPOC2015; set => _brokerPOC2015 = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<bool?> _escrowedIndicator2015;
        public bool? EscrowedIndicator2015 { get => _escrowedIndicator2015; set => _escrowedIndicator2015 = value; }
        private DirtyValue<bool?> _financedIndicator;
        public bool? FinancedIndicator { get => _financedIndicator; set => _financedIndicator = value; }
        private DirtyValue<int?> _gfe2010FeeIndex;
        public int? Gfe2010FeeIndex { get => _gfe2010FeeIndex; set => _gfe2010FeeIndex = value; }
        private DirtyValue<StringEnumValue<Gfe2010FeeParentType>> _gfe2010FeeParentType;
        public StringEnumValue<Gfe2010FeeParentType> Gfe2010FeeParentType { get => _gfe2010FeeParentType; set => _gfe2010FeeParentType = value; }
        private DirtyValue<StringEnumValue<Gfe2010FeeType>> _gfe2010FeeType;
        public StringEnumValue<Gfe2010FeeType> Gfe2010FeeType { get => _gfe2010FeeType; set => _gfe2010FeeType = value; }
        private DirtyValue<decimal?> _gfeAmount;
        public decimal? GfeAmount { get => _gfeAmount; set => _gfeAmount = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _insuranceIndicator2015;
        public bool? InsuranceIndicator2015 { get => _insuranceIndicator2015; set => _insuranceIndicator2015 = value; }
        private DirtyValue<decimal?> _lastDisclosedClosingDisclosure2015;
        public decimal? LastDisclosedClosingDisclosure2015 { get => _lastDisclosedClosingDisclosure2015; set => _lastDisclosedClosingDisclosure2015 = value; }
        private DirtyValue<int?> _lastDisclosedLoanEstimate2015;
        public int? LastDisclosedLoanEstimate2015 { get => _lastDisclosedLoanEstimate2015; set => _lastDisclosedLoanEstimate2015 = value; }
        private DirtyValue<decimal?> _lenderAmountPaid2015;
        public decimal? LenderAmountPaid2015 { get => _lenderAmountPaid2015; set => _lenderAmountPaid2015 = value; }
        private DirtyValue<decimal?> _lenderPAC2015;
        public decimal? LenderPAC2015 { get => _lenderPAC2015; set => _lenderPAC2015 = value; }
        private DirtyValue<decimal?> _lenderPOC2015;
        public decimal? LenderPOC2015 { get => _lenderPOC2015; set => _lenderPOC2015 = value; }
        private DirtyValue<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get => _monthlyPayment; set => _monthlyPayment = value; }
        private DirtyValue<int?> _numberOfMonths;
        public int? NumberOfMonths { get => _numberOfMonths; set => _numberOfMonths = value; }
        private DirtyValue<bool?> _optionalIndicator2015;
        public bool? OptionalIndicator2015 { get => _optionalIndicator2015; set => _optionalIndicator2015 = value; }
        private DirtyValue<decimal?> _otherAmountPaid2015;
        public decimal? OtherAmountPaid2015 { get => _otherAmountPaid2015; set => _otherAmountPaid2015 = value; }
        private DirtyValue<decimal?> _otherPAC2015;
        public decimal? OtherPAC2015 { get => _otherPAC2015; set => _otherPAC2015 = value; }
        private DirtyValue<decimal?> _otherPOC2015;
        public decimal? OtherPOC2015 { get => _otherPOC2015; set => _otherPOC2015 = value; }
        private DirtyValue<StringEnumValue<PaidBy>> _paidByType;
        public StringEnumValue<PaidBy> PaidByType { get => _paidByType; set => _paidByType = value; }
        private DirtyValue<string> _paidToName;
        public string PaidToName { get => _paidToName; set => _paidToName = value; }
        private DirtyValue<bool?> _pocPtcIndicator;
        public bool? PocPtcIndicator { get => _pocPtcIndicator; set => _pocPtcIndicator = value; }
        private DirtyValue<bool?> _propertyIndicator2015;
        public bool? PropertyIndicator2015 { get => _propertyIndicator2015; set => _propertyIndicator2015 = value; }
        private DirtyValue<StringEnumValue<PTB>> _ptbType;
        public StringEnumValue<PTB> PtbType { get => _ptbType; set => _ptbType = value; }
        private DirtyValue<decimal?> _rate;
        public decimal? Rate { get => _rate; set => _rate = value; }
        private DirtyValue<decimal?> _retainedAmount2015;
        public decimal? RetainedAmount2015 { get => _retainedAmount2015; set => _retainedAmount2015 = value; }
        private DirtyValue<decimal?> _sec32PointsAndFees2015;
        public decimal? Sec32PointsAndFees2015 { get => _sec32PointsAndFees2015; set => _sec32PointsAndFees2015 = value; }
        private DirtyValue<decimal?> _sellerAmountPaid2015;
        public decimal? SellerAmountPaid2015 { get => _sellerAmountPaid2015; set => _sellerAmountPaid2015 = value; }
        private DirtyValue<bool?> _sellerCreditIndicator2015;
        public bool? SellerCreditIndicator2015 { get => _sellerCreditIndicator2015; set => _sellerCreditIndicator2015 = value; }
        private DirtyValue<decimal?> _sellerObligatedAmount2015;
        public decimal? SellerObligatedAmount2015 { get => _sellerObligatedAmount2015; set => _sellerObligatedAmount2015 = value; }
        private DirtyValue<bool?> _sellerObligatedIndicator2015;
        public bool? SellerObligatedIndicator2015 { get => _sellerObligatedIndicator2015; set => _sellerObligatedIndicator2015 = value; }
        private DirtyValue<decimal?> _sellerPAC2015;
        public decimal? SellerPAC2015 { get => _sellerPAC2015; set => _sellerPAC2015 = value; }
        private DirtyValue<decimal?> _sellerPOC2015;
        public decimal? SellerPOC2015 { get => _sellerPOC2015; set => _sellerPOC2015 = value; }
        private DirtyValue<decimal?> _selPaidAmount;
        public decimal? SelPaidAmount { get => _selPaidAmount; set => _selPaidAmount = value; }
        private DirtyValue<bool?> _simultaneousIssuanceIndicator2015;
        public bool? SimultaneousIssuanceIndicator2015 { get => _simultaneousIssuanceIndicator2015; set => _simultaneousIssuanceIndicator2015 = value; }
        private DirtyValue<bool?> _taxesIndicator2015;
        public bool? TaxesIndicator2015 { get => _taxesIndicator2015; set => _taxesIndicator2015 = value; }
        private DirtyValue<bool?> _titleServiceSelectIndicator;
        public bool? TitleServiceSelectIndicator { get => _titleServiceSelectIndicator; set => _titleServiceSelectIndicator = value; }
        private DirtyValue<decimal?> _totalFeeAmount2015;
        public decimal? TotalFeeAmount2015 { get => _totalFeeAmount2015; set => _totalFeeAmount2015 = value; }
        private DirtyValue<decimal?> _totalFeePercentage2015;
        public decimal? TotalFeePercentage2015 { get => _totalFeePercentage2015; set => _totalFeePercentage2015 = value; }
        private DirtyValue<decimal?> _totalPaidByBLO2015;
        public decimal? TotalPaidByBLO2015 { get => _totalPaidByBLO2015; set => _totalPaidByBLO2015 = value; }
        private DirtyValue<decimal?> _undiscountedInsurance2015;
        public decimal? UndiscountedInsurance2015 { get => _undiscountedInsurance2015; set => _undiscountedInsurance2015 = value; }
        private DirtyValue<decimal?> _wholePoc;
        public decimal? WholePoc { get => _wholePoc; set => _wholePoc = value; }
        private DirtyValue<StringEnumValue<WholePocPaidByType>> _wholePocPaidByType;
        public StringEnumValue<WholePocPaidByType> WholePocPaidByType { get => _wholePocPaidByType; set => _wholePocPaidByType = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _additionalAmount.Dirty
                    || _amount.Dirty
                    || _aprIndicator.Dirty
                    || _borPaidAmount.Dirty
                    || _borrowerAmountPaid2015.Dirty
                    || _borrowerCanShopForIndicator2015.Dirty
                    || _borrowerDidShopForIndicator2015.Dirty
                    || _borrowerFinanced2015.Dirty
                    || _borrowerPAC2015.Dirty
                    || _borrowerPOC2015.Dirty
                    || _borrowerPTC2015.Dirty
                    || _borrowerSelectIndicator.Dirty
                    || _brokerAmountPaid2015.Dirty
                    || _brokerPAC2015.Dirty
                    || _brokerPOC2015.Dirty
                    || _description.Dirty
                    || _escrowedIndicator2015.Dirty
                    || _financedIndicator.Dirty
                    || _gfe2010FeeIndex.Dirty
                    || _gfe2010FeeParentType.Dirty
                    || _gfe2010FeeType.Dirty
                    || _gfeAmount.Dirty
                    || _id.Dirty
                    || _insuranceIndicator2015.Dirty
                    || _lastDisclosedClosingDisclosure2015.Dirty
                    || _lastDisclosedLoanEstimate2015.Dirty
                    || _lenderAmountPaid2015.Dirty
                    || _lenderPAC2015.Dirty
                    || _lenderPOC2015.Dirty
                    || _monthlyPayment.Dirty
                    || _numberOfMonths.Dirty
                    || _optionalIndicator2015.Dirty
                    || _otherAmountPaid2015.Dirty
                    || _otherPAC2015.Dirty
                    || _otherPOC2015.Dirty
                    || _paidByType.Dirty
                    || _paidToName.Dirty
                    || _pocPtcIndicator.Dirty
                    || _propertyIndicator2015.Dirty
                    || _ptbType.Dirty
                    || _rate.Dirty
                    || _retainedAmount2015.Dirty
                    || _sec32PointsAndFees2015.Dirty
                    || _sellerAmountPaid2015.Dirty
                    || _sellerCreditIndicator2015.Dirty
                    || _sellerObligatedAmount2015.Dirty
                    || _sellerObligatedIndicator2015.Dirty
                    || _sellerPAC2015.Dirty
                    || _sellerPOC2015.Dirty
                    || _selPaidAmount.Dirty
                    || _simultaneousIssuanceIndicator2015.Dirty
                    || _taxesIndicator2015.Dirty
                    || _titleServiceSelectIndicator.Dirty
                    || _totalFeeAmount2015.Dirty
                    || _totalFeePercentage2015.Dirty
                    || _totalPaidByBLO2015.Dirty
                    || _undiscountedInsurance2015.Dirty
                    || _wholePoc.Dirty
                    || _wholePocPaidByType.Dirty;
            }
            set
            {
                _additionalAmount.Dirty = value;
                _amount.Dirty = value;
                _aprIndicator.Dirty = value;
                _borPaidAmount.Dirty = value;
                _borrowerAmountPaid2015.Dirty = value;
                _borrowerCanShopForIndicator2015.Dirty = value;
                _borrowerDidShopForIndicator2015.Dirty = value;
                _borrowerFinanced2015.Dirty = value;
                _borrowerPAC2015.Dirty = value;
                _borrowerPOC2015.Dirty = value;
                _borrowerPTC2015.Dirty = value;
                _borrowerSelectIndicator.Dirty = value;
                _brokerAmountPaid2015.Dirty = value;
                _brokerPAC2015.Dirty = value;
                _brokerPOC2015.Dirty = value;
                _description.Dirty = value;
                _escrowedIndicator2015.Dirty = value;
                _financedIndicator.Dirty = value;
                _gfe2010FeeIndex.Dirty = value;
                _gfe2010FeeParentType.Dirty = value;
                _gfe2010FeeType.Dirty = value;
                _gfeAmount.Dirty = value;
                _id.Dirty = value;
                _insuranceIndicator2015.Dirty = value;
                _lastDisclosedClosingDisclosure2015.Dirty = value;
                _lastDisclosedLoanEstimate2015.Dirty = value;
                _lenderAmountPaid2015.Dirty = value;
                _lenderPAC2015.Dirty = value;
                _lenderPOC2015.Dirty = value;
                _monthlyPayment.Dirty = value;
                _numberOfMonths.Dirty = value;
                _optionalIndicator2015.Dirty = value;
                _otherAmountPaid2015.Dirty = value;
                _otherPAC2015.Dirty = value;
                _otherPOC2015.Dirty = value;
                _paidByType.Dirty = value;
                _paidToName.Dirty = value;
                _pocPtcIndicator.Dirty = value;
                _propertyIndicator2015.Dirty = value;
                _ptbType.Dirty = value;
                _rate.Dirty = value;
                _retainedAmount2015.Dirty = value;
                _sec32PointsAndFees2015.Dirty = value;
                _sellerAmountPaid2015.Dirty = value;
                _sellerCreditIndicator2015.Dirty = value;
                _sellerObligatedAmount2015.Dirty = value;
                _sellerObligatedIndicator2015.Dirty = value;
                _sellerPAC2015.Dirty = value;
                _sellerPOC2015.Dirty = value;
                _selPaidAmount.Dirty = value;
                _simultaneousIssuanceIndicator2015.Dirty = value;
                _taxesIndicator2015.Dirty = value;
                _titleServiceSelectIndicator.Dirty = value;
                _totalFeeAmount2015.Dirty = value;
                _totalFeePercentage2015.Dirty = value;
                _totalPaidByBLO2015.Dirty = value;
                _undiscountedInsurance2015.Dirty = value;
                _wholePoc.Dirty = value;
                _wholePocPaidByType.Dirty = value;
            }
        }
    }
}