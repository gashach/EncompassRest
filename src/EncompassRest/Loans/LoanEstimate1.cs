#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class LoanEstimate1 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<TermType>> _adjustsTermType;
        public StringEnumValue<TermType> AdjustsTermType { get => _adjustsTermType; set => _adjustsTermType = value; }
        private DirtyValue<string> _changedCircumstanceComments;
        public string ChangedCircumstanceComments { get => _changedCircumstanceComments; set => _changedCircumstanceComments = value; }
        private DirtyValue<DateTime?> _closingCostEstimateExpirationDate;
        public DateTime? ClosingCostEstimateExpirationDate { get => _closingCostEstimateExpirationDate; set => _closingCostEstimateExpirationDate = value; }
        private DirtyValue<string> _closingCostEstimateExpirationTime;
        public string ClosingCostEstimateExpirationTime { get => _closingCostEstimateExpirationTime; set => _closingCostEstimateExpirationTime = value; }
        private DirtyValue<string> _closingCostEstimateExpirationTimeZone;
        public string ClosingCostEstimateExpirationTimeZone { get => _closingCostEstimateExpirationTimeZone; set => _closingCostEstimateExpirationTimeZone = value; }
        private DirtyValue<string> _disclosureBy;
        public string DisclosureBy { get => _disclosureBy; set => _disclosureBy = value; }
        private DirtyValue<DateTime?> _disclosureClosingCostExpDate;
        public DateTime? DisclosureClosingCostExpDate { get => _disclosureClosingCostExpDate; set => _disclosureClosingCostExpDate = value; }
        private DirtyValue<string> _disclosureClosingCostExpTime;
        public string DisclosureClosingCostExpTime { get => _disclosureClosingCostExpTime; set => _disclosureClosingCostExpTime = value; }
        private DirtyValue<string> _disclosureClosingCostExpTimeZone;
        public string DisclosureClosingCostExpTimeZone { get => _disclosureClosingCostExpTimeZone; set => _disclosureClosingCostExpTimeZone = value; }
        private DirtyValue<string> _disclosureComments;
        public string DisclosureComments { get => _disclosureComments; set => _disclosureComments = value; }
        private DirtyValue<DateTime?> _disclosureLastSentDate;
        public DateTime? DisclosureLastSentDate { get => _disclosureLastSentDate; set => _disclosureLastSentDate = value; }
        private DirtyValue<DateTime?> _disclosureReceivedDate;
        public DateTime? DisclosureReceivedDate { get => _disclosureReceivedDate; set => _disclosureReceivedDate = value; }
        private DirtyValue<string> _disclosureSentMethod;
        public string DisclosureSentMethod { get => _disclosureSentMethod; set => _disclosureSentMethod = value; }
        private DirtyValue<decimal?> _estimatedTaxesInsuranceAssessments;
        public decimal? EstimatedTaxesInsuranceAssessments { get => _estimatedTaxesInsuranceAssessments; set => _estimatedTaxesInsuranceAssessments = value; }
        private DirtyValue<string> _estimatedTaxesInsuranceAssessmentsUI;
        public string EstimatedTaxesInsuranceAssessmentsUI { get => _estimatedTaxesInsuranceAssessmentsUI; set => _estimatedTaxesInsuranceAssessmentsUI = value; }
        private DirtyValue<decimal?> _highestMonthlyPI;
        public decimal? HighestMonthlyPI { get => _highestMonthlyPI; set => _highestMonthlyPI = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _inEscrowHomeownerInsurance;
        public string InEscrowHomeownerInsurance { get => _inEscrowHomeownerInsurance; set => _inEscrowHomeownerInsurance = value; }
        private DirtyValue<string> _inEscrowOther;
        public string InEscrowOther { get => _inEscrowOther; set => _inEscrowOther = value; }
        private DirtyValue<string> _inEscrowPropertyTaxes;
        public string InEscrowPropertyTaxes { get => _inEscrowPropertyTaxes; set => _inEscrowPropertyTaxes = value; }
        private DirtyValue<string> _interestRateAdjustsEveryYears;
        public string InterestRateAdjustsEveryYears { get => _interestRateAdjustsEveryYears; set => _interestRateAdjustsEveryYears = value; }
        private DirtyValue<int?> _interestRateAdjustsInYear;
        public int? InterestRateAdjustsInYear { get => _interestRateAdjustsInYear; set => _interestRateAdjustsInYear = value; }
        private DirtyValue<StringEnumValue<MonthOrYear>> _interestRateAdjustsStartingInType;
        public StringEnumValue<MonthOrYear> InterestRateAdjustsStartingInType { get => _interestRateAdjustsStartingInType; set => _interestRateAdjustsStartingInType = value; }
        private DirtyValue<int?> _interestRateAfterAdjustment;
        public int? InterestRateAfterAdjustment { get => _interestRateAfterAdjustment; set => _interestRateAfterAdjustment = value; }
        private DirtyValue<StringEnumValue<CanGoOrGoes>> _interestRateCanGoGoes;
        public StringEnumValue<CanGoOrGoes> InterestRateCanGoGoes { get => _interestRateCanGoGoes; set => _interestRateCanGoGoes = value; }
        private DirtyValue<DateTime?> _lEDateIssued;
        public DateTime? LEDateIssued { get => _lEDateIssued; set => _lEDateIssued = value; }
        private DirtyValue<StringEnumValue<CanGoOrGoes>> _loanAmountCanGoGoes;
        public StringEnumValue<CanGoOrGoes> LoanAmountCanGoGoes { get => _loanAmountCanGoGoes; set => _loanAmountCanGoGoes = value; }
        private DirtyValue<StringEnumValue<CanIncreaseOrIncreases>> _loanAmountCanIncreaseOrIncreases;
        public StringEnumValue<CanIncreaseOrIncreases> LoanAmountCanIncreaseOrIncreases { get => _loanAmountCanIncreaseOrIncreases; set => _loanAmountCanIncreaseOrIncreases = value; }
        private DirtyValue<string> _loanProduct;
        public string LoanProduct { get => _loanProduct; set => _loanProduct = value; }
        private DirtyValue<StringEnumValue<LoanEstimate1LoanPurpose>> _loanPurpose;
        public StringEnumValue<LoanEstimate1LoanPurpose> LoanPurpose { get => _loanPurpose; set => _loanPurpose = value; }
        private DirtyValue<int?> _loanTermMonths;
        public int? LoanTermMonths { get => _loanTermMonths; set => _loanTermMonths = value; }
        private DirtyValue<int?> _loanTermYears;
        public int? LoanTermYears { get => _loanTermYears; set => _loanTermYears = value; }
        private DirtyValue<StringEnumValue<MonthOrYear>> _monthlyPIAdjustedInDateType;
        public StringEnumValue<MonthOrYear> MonthlyPIAdjustedInDateType { get => _monthlyPIAdjustedInDateType; set => _monthlyPIAdjustedInDateType = value; }
        private DirtyValue<string> _monthlyPIAdjustsEveryYears;
        public string MonthlyPIAdjustsEveryYears { get => _monthlyPIAdjustsEveryYears; set => _monthlyPIAdjustsEveryYears = value; }
        private DirtyValue<int?> _monthlyPIAdjustsInYear;
        public int? MonthlyPIAdjustsInYear { get => _monthlyPIAdjustsInYear; set => _monthlyPIAdjustsInYear = value; }
        private DirtyValue<StringEnumValue<MonthOrYear>> _monthlyPIAdjustsStartingInType;
        public StringEnumValue<MonthOrYear> MonthlyPIAdjustsStartingInType { get => _monthlyPIAdjustsStartingInType; set => _monthlyPIAdjustsStartingInType = value; }
        private DirtyValue<StringEnumValue<TermType>> _monthlyPIAdjustsTermType;
        public StringEnumValue<TermType> MonthlyPIAdjustsTermType { get => _monthlyPIAdjustsTermType; set => _monthlyPIAdjustsTermType = value; }
        private DirtyValue<int?> _monthlyPIAfterAdjustment;
        public int? MonthlyPIAfterAdjustment { get => _monthlyPIAfterAdjustment; set => _monthlyPIAfterAdjustment = value; }
        private DirtyValue<StringEnumValue<CanGoOrGoes>> _monthlyPICanGoGoes;
        public StringEnumValue<CanGoOrGoes> MonthlyPICanGoGoes { get => _monthlyPICanGoGoes; set => _monthlyPICanGoGoes = value; }
        private DirtyValue<StringEnumValue<MonthOrYear>> _monthlyPIInterestOnlyDateType;
        public StringEnumValue<MonthOrYear> MonthlyPIInterestOnlyDateType { get => _monthlyPIInterestOnlyDateType; set => _monthlyPIInterestOnlyDateType = value; }
        private DirtyValue<int?> _monthlyPIInterestOnlyUntilYear;
        public int? MonthlyPIInterestOnlyUntilYear { get => _monthlyPIInterestOnlyUntilYear; set => _monthlyPIInterestOnlyUntilYear = value; }
        private DirtyValue<int?> _pPC1EstimatedEscrowAmount;
        public int? PPC1EstimatedEscrowAmount { get => _pPC1EstimatedEscrowAmount; set => _pPC1EstimatedEscrowAmount = value; }
        private DirtyValue<string> _pPC1EstimatedEscrowAmountUI;
        public string PPC1EstimatedEscrowAmountUI { get => _pPC1EstimatedEscrowAmountUI; set => _pPC1EstimatedEscrowAmountUI = value; }
        private DirtyValue<bool?> _pPC1InterestOnly;
        public bool? PPC1InterestOnly { get => _pPC1InterestOnly; set => _pPC1InterestOnly = value; }
        private DirtyValue<decimal?> _pPC1MaximumMonthlyPayment;
        public decimal? PPC1MaximumMonthlyPayment { get => _pPC1MaximumMonthlyPayment; set => _pPC1MaximumMonthlyPayment = value; }
        private DirtyValue<string> _pPC1MaximumMonthlyPaymentUI;
        public string PPC1MaximumMonthlyPaymentUI { get => _pPC1MaximumMonthlyPaymentUI; set => _pPC1MaximumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC1MaximumPIPayment;
        public decimal? PPC1MaximumPIPayment { get => _pPC1MaximumPIPayment; set => _pPC1MaximumPIPayment = value; }
        private DirtyValue<string> _pPC1MaximumPIPaymentUI;
        public string PPC1MaximumPIPaymentUI { get => _pPC1MaximumPIPaymentUI; set => _pPC1MaximumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC1MIAmount;
        public int? PPC1MIAmount { get => _pPC1MIAmount; set => _pPC1MIAmount = value; }
        private DirtyValue<string> _pPC1MIAmountUI;
        public string PPC1MIAmountUI { get => _pPC1MIAmountUI; set => _pPC1MIAmountUI = value; }
        private DirtyValue<int?> _pPC1MinimumMonthlyPayment;
        public int? PPC1MinimumMonthlyPayment { get => _pPC1MinimumMonthlyPayment; set => _pPC1MinimumMonthlyPayment = value; }
        private DirtyValue<string> _pPC1MinimumMonthlyPaymentUI;
        public string PPC1MinimumMonthlyPaymentUI { get => _pPC1MinimumMonthlyPaymentUI; set => _pPC1MinimumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC1MinimumPIPayment;
        public decimal? PPC1MinimumPIPayment { get => _pPC1MinimumPIPayment; set => _pPC1MinimumPIPayment = value; }
        private DirtyValue<string> _pPC1MinimumPIPaymentUI;
        public string PPC1MinimumPIPaymentUI { get => _pPC1MinimumPIPaymentUI; set => _pPC1MinimumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC1Year;
        public int? PPC1Year { get => _pPC1Year; set => _pPC1Year = value; }
        private DirtyValue<int?> _pPC2EstimatedEscrowAmount;
        public int? PPC2EstimatedEscrowAmount { get => _pPC2EstimatedEscrowAmount; set => _pPC2EstimatedEscrowAmount = value; }
        private DirtyValue<string> _pPC2EstimatedEscrowAmountUI;
        public string PPC2EstimatedEscrowAmountUI { get => _pPC2EstimatedEscrowAmountUI; set => _pPC2EstimatedEscrowAmountUI = value; }
        private DirtyValue<bool?> _pPC2InterestOnly;
        public bool? PPC2InterestOnly { get => _pPC2InterestOnly; set => _pPC2InterestOnly = value; }
        private DirtyValue<decimal?> _pPC2MaximumMonthlyPayment;
        public decimal? PPC2MaximumMonthlyPayment { get => _pPC2MaximumMonthlyPayment; set => _pPC2MaximumMonthlyPayment = value; }
        private DirtyValue<string> _pPC2MaximumMonthlyPaymentUI;
        public string PPC2MaximumMonthlyPaymentUI { get => _pPC2MaximumMonthlyPaymentUI; set => _pPC2MaximumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC2MaximumPIPayment;
        public decimal? PPC2MaximumPIPayment { get => _pPC2MaximumPIPayment; set => _pPC2MaximumPIPayment = value; }
        private DirtyValue<string> _pPC2MaximumPIPaymentUI;
        public string PPC2MaximumPIPaymentUI { get => _pPC2MaximumPIPaymentUI; set => _pPC2MaximumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC2MIAmount;
        public int? PPC2MIAmount { get => _pPC2MIAmount; set => _pPC2MIAmount = value; }
        private DirtyValue<string> _pPC2MIAmountUI;
        public string PPC2MIAmountUI { get => _pPC2MIAmountUI; set => _pPC2MIAmountUI = value; }
        private DirtyValue<int?> _pPC2MinimumMonthlyPayment;
        public int? PPC2MinimumMonthlyPayment { get => _pPC2MinimumMonthlyPayment; set => _pPC2MinimumMonthlyPayment = value; }
        private DirtyValue<string> _pPC2MinimumMonthlyPaymentUI;
        public string PPC2MinimumMonthlyPaymentUI { get => _pPC2MinimumMonthlyPaymentUI; set => _pPC2MinimumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC2MinimumPIPayment;
        public decimal? PPC2MinimumPIPayment { get => _pPC2MinimumPIPayment; set => _pPC2MinimumPIPayment = value; }
        private DirtyValue<string> _pPC2MinimumPIPaymentUI;
        public string PPC2MinimumPIPaymentUI { get => _pPC2MinimumPIPaymentUI; set => _pPC2MinimumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC2YearFrom;
        public int? PPC2YearFrom { get => _pPC2YearFrom; set => _pPC2YearFrom = value; }
        private DirtyValue<int?> _pPC2YearTo;
        public int? PPC2YearTo { get => _pPC2YearTo; set => _pPC2YearTo = value; }
        private DirtyValue<int?> _pPC3EstimatedEscrowAmount;
        public int? PPC3EstimatedEscrowAmount { get => _pPC3EstimatedEscrowAmount; set => _pPC3EstimatedEscrowAmount = value; }
        private DirtyValue<string> _pPC3EstimatedEscrowAmountUI;
        public string PPC3EstimatedEscrowAmountUI { get => _pPC3EstimatedEscrowAmountUI; set => _pPC3EstimatedEscrowAmountUI = value; }
        private DirtyValue<bool?> _pPC3InterestOnly;
        public bool? PPC3InterestOnly { get => _pPC3InterestOnly; set => _pPC3InterestOnly = value; }
        private DirtyValue<decimal?> _pPC3MaximumMonthlyPayment;
        public decimal? PPC3MaximumMonthlyPayment { get => _pPC3MaximumMonthlyPayment; set => _pPC3MaximumMonthlyPayment = value; }
        private DirtyValue<string> _pPC3MaximumMonthlyPaymentUI;
        public string PPC3MaximumMonthlyPaymentUI { get => _pPC3MaximumMonthlyPaymentUI; set => _pPC3MaximumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC3MaximumPIPayment;
        public decimal? PPC3MaximumPIPayment { get => _pPC3MaximumPIPayment; set => _pPC3MaximumPIPayment = value; }
        private DirtyValue<string> _pPC3MaximumPIPaymentUI;
        public string PPC3MaximumPIPaymentUI { get => _pPC3MaximumPIPaymentUI; set => _pPC3MaximumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC3MIAmount;
        public int? PPC3MIAmount { get => _pPC3MIAmount; set => _pPC3MIAmount = value; }
        private DirtyValue<string> _pPC3MIAmountUI;
        public string PPC3MIAmountUI { get => _pPC3MIAmountUI; set => _pPC3MIAmountUI = value; }
        private DirtyValue<int?> _pPC3MinimumMonthlyPayment;
        public int? PPC3MinimumMonthlyPayment { get => _pPC3MinimumMonthlyPayment; set => _pPC3MinimumMonthlyPayment = value; }
        private DirtyValue<string> _pPC3MinimumMonthlyPaymentUI;
        public string PPC3MinimumMonthlyPaymentUI { get => _pPC3MinimumMonthlyPaymentUI; set => _pPC3MinimumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC3MinimumPIPayment;
        public decimal? PPC3MinimumPIPayment { get => _pPC3MinimumPIPayment; set => _pPC3MinimumPIPayment = value; }
        private DirtyValue<string> _pPC3MinimumPIPaymentUI;
        public string PPC3MinimumPIPaymentUI { get => _pPC3MinimumPIPaymentUI; set => _pPC3MinimumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC3YearFrom;
        public int? PPC3YearFrom { get => _pPC3YearFrom; set => _pPC3YearFrom = value; }
        private DirtyValue<int?> _pPC3YearTo;
        public int? PPC3YearTo { get => _pPC3YearTo; set => _pPC3YearTo = value; }
        private DirtyValue<int?> _pPC4EstimatedEscrowAmount;
        public int? PPC4EstimatedEscrowAmount { get => _pPC4EstimatedEscrowAmount; set => _pPC4EstimatedEscrowAmount = value; }
        private DirtyValue<string> _pPC4EstimatedEscrowAmountUI;
        public string PPC4EstimatedEscrowAmountUI { get => _pPC4EstimatedEscrowAmountUI; set => _pPC4EstimatedEscrowAmountUI = value; }
        private DirtyValue<bool?> _pPC4InterestOnly;
        public bool? PPC4InterestOnly { get => _pPC4InterestOnly; set => _pPC4InterestOnly = value; }
        private DirtyValue<decimal?> _pPC4MaximumMonthlyPayment;
        public decimal? PPC4MaximumMonthlyPayment { get => _pPC4MaximumMonthlyPayment; set => _pPC4MaximumMonthlyPayment = value; }
        private DirtyValue<string> _pPC4MaximumMonthlyPaymentUI;
        public string PPC4MaximumMonthlyPaymentUI { get => _pPC4MaximumMonthlyPaymentUI; set => _pPC4MaximumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC4MaximumPIPayment;
        public decimal? PPC4MaximumPIPayment { get => _pPC4MaximumPIPayment; set => _pPC4MaximumPIPayment = value; }
        private DirtyValue<string> _pPC4MaximumPIPaymentUI;
        public string PPC4MaximumPIPaymentUI { get => _pPC4MaximumPIPaymentUI; set => _pPC4MaximumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC4MIAmount;
        public int? PPC4MIAmount { get => _pPC4MIAmount; set => _pPC4MIAmount = value; }
        private DirtyValue<string> _pPC4MIAmountUI;
        public string PPC4MIAmountUI { get => _pPC4MIAmountUI; set => _pPC4MIAmountUI = value; }
        private DirtyValue<int?> _pPC4MinimumMonthlyPayment;
        public int? PPC4MinimumMonthlyPayment { get => _pPC4MinimumMonthlyPayment; set => _pPC4MinimumMonthlyPayment = value; }
        private DirtyValue<string> _pPC4MinimumMonthlyPaymentUI;
        public string PPC4MinimumMonthlyPaymentUI { get => _pPC4MinimumMonthlyPaymentUI; set => _pPC4MinimumMonthlyPaymentUI = value; }
        private DirtyValue<decimal?> _pPC4MinimumPIPayment;
        public decimal? PPC4MinimumPIPayment { get => _pPC4MinimumPIPayment; set => _pPC4MinimumPIPayment = value; }
        private DirtyValue<string> _pPC4MinimumPIPaymentUI;
        public string PPC4MinimumPIPaymentUI { get => _pPC4MinimumPIPaymentUI; set => _pPC4MinimumPIPaymentUI = value; }
        private DirtyValue<int?> _pPC4YearFrom;
        public int? PPC4YearFrom { get => _pPC4YearFrom; set => _pPC4YearFrom = value; }
        private DirtyValue<int?> _pPC4YearTo;
        public int? PPC4YearTo { get => _pPC4YearTo; set => _pPC4YearTo = value; }
        private DirtyValue<bool?> _pPEstimatedEscrowIndicator;
        public bool? PPEstimatedEscrowIndicator { get => _pPEstimatedEscrowIndicator; set => _pPEstimatedEscrowIndicator = value; }
        private DirtyValue<int?> _prepaymentPenaltyPayOffDuringYear;
        public int? PrepaymentPenaltyPayOffDuringYear { get => _prepaymentPenaltyPayOffDuringYear; set => _prepaymentPenaltyPayOffDuringYear = value; }
        private DirtyValue<StringEnumValue<TermType>> _prepaymentPenaltyPayOffInDateType;
        public StringEnumValue<TermType> PrepaymentPenaltyPayOffInDateType { get => _prepaymentPenaltyPayOffInDateType; set => _prepaymentPenaltyPayOffInDateType = value; }
        private DirtyValue<string> _prepaymentPenaltyPayOffInFirstYear;
        public string PrepaymentPenaltyPayOffInFirstYear { get => _prepaymentPenaltyPayOffInFirstYear; set => _prepaymentPenaltyPayOffInFirstYear = value; }
        private DirtyValue<bool?> _rangePaymentIndicatorC1;
        public bool? RangePaymentIndicatorC1 { get => _rangePaymentIndicatorC1; set => _rangePaymentIndicatorC1 = value; }
        private DirtyValue<bool?> _rangePaymentIndicatorC2;
        public bool? RangePaymentIndicatorC2 { get => _rangePaymentIndicatorC2; set => _rangePaymentIndicatorC2 = value; }
        private DirtyValue<bool?> _rangePaymentIndicatorC3;
        public bool? RangePaymentIndicatorC3 { get => _rangePaymentIndicatorC3; set => _rangePaymentIndicatorC3 = value; }
        private DirtyValue<bool?> _rangePaymentIndicatorC4;
        public bool? RangePaymentIndicatorC4 { get => _rangePaymentIndicatorC4; set => _rangePaymentIndicatorC4 = value; }
        private DirtyValue<string> _rateLockExpirationTime;
        public string RateLockExpirationTime { get => _rateLockExpirationTime; set => _rateLockExpirationTime = value; }
        private DirtyValue<string> _rateLockExpirationTimeZone;
        public string RateLockExpirationTimeZone { get => _rateLockExpirationTimeZone; set => _rateLockExpirationTimeZone = value; }
        private DirtyValue<string> _reasonChangedCircumstanceFlags;
        public string ReasonChangedCircumstanceFlags { get => _reasonChangedCircumstanceFlags; set => _reasonChangedCircumstanceFlags = value; }
        private DirtyValue<bool?> _reasonDelayedSettlement;
        public bool? ReasonDelayedSettlement { get => _reasonDelayedSettlement; set => _reasonDelayedSettlement = value; }
        private DirtyValue<bool?> _reasonEligibility;
        public bool? ReasonEligibility { get => _reasonEligibility; set => _reasonEligibility = value; }
        private DirtyValue<bool?> _reasonExpiration;
        public bool? ReasonExpiration { get => _reasonExpiration; set => _reasonExpiration = value; }
        private DirtyValue<bool?> _reasonInterestRate;
        public bool? ReasonInterestRate { get => _reasonInterestRate; set => _reasonInterestRate = value; }
        private DirtyValue<bool?> _reasonOther;
        public bool? ReasonOther { get => _reasonOther; set => _reasonOther = value; }
        private DirtyValue<string> _reasonOtherDescription;
        public string ReasonOtherDescription { get => _reasonOtherDescription; set => _reasonOtherDescription = value; }
        private DirtyValue<bool?> _reasonRevisions;
        public bool? ReasonRevisions { get => _reasonRevisions; set => _reasonRevisions = value; }
        private DirtyValue<bool?> _reasonSettlementCharges;
        public bool? ReasonSettlementCharges { get => _reasonSettlementCharges; set => _reasonSettlementCharges = value; }
        private DirtyValue<decimal?> _totalEstimatedCashClose;
        public decimal? TotalEstimatedCashClose { get => _totalEstimatedCashClose; set => _totalEstimatedCashClose = value; }
        private DirtyValue<int?> _yearsToRecast;
        public int? YearsToRecast { get => _yearsToRecast; set => _yearsToRecast = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _adjustsTermType.Dirty
                    || _changedCircumstanceComments.Dirty
                    || _closingCostEstimateExpirationDate.Dirty
                    || _closingCostEstimateExpirationTime.Dirty
                    || _closingCostEstimateExpirationTimeZone.Dirty
                    || _disclosureBy.Dirty
                    || _disclosureClosingCostExpDate.Dirty
                    || _disclosureClosingCostExpTime.Dirty
                    || _disclosureClosingCostExpTimeZone.Dirty
                    || _disclosureComments.Dirty
                    || _disclosureLastSentDate.Dirty
                    || _disclosureReceivedDate.Dirty
                    || _disclosureSentMethod.Dirty
                    || _estimatedTaxesInsuranceAssessments.Dirty
                    || _estimatedTaxesInsuranceAssessmentsUI.Dirty
                    || _highestMonthlyPI.Dirty
                    || _id.Dirty
                    || _inEscrowHomeownerInsurance.Dirty
                    || _inEscrowOther.Dirty
                    || _inEscrowPropertyTaxes.Dirty
                    || _interestRateAdjustsEveryYears.Dirty
                    || _interestRateAdjustsInYear.Dirty
                    || _interestRateAdjustsStartingInType.Dirty
                    || _interestRateAfterAdjustment.Dirty
                    || _interestRateCanGoGoes.Dirty
                    || _lEDateIssued.Dirty
                    || _loanAmountCanGoGoes.Dirty
                    || _loanAmountCanIncreaseOrIncreases.Dirty
                    || _loanProduct.Dirty
                    || _loanPurpose.Dirty
                    || _loanTermMonths.Dirty
                    || _loanTermYears.Dirty
                    || _monthlyPIAdjustedInDateType.Dirty
                    || _monthlyPIAdjustsEveryYears.Dirty
                    || _monthlyPIAdjustsInYear.Dirty
                    || _monthlyPIAdjustsStartingInType.Dirty
                    || _monthlyPIAdjustsTermType.Dirty
                    || _monthlyPIAfterAdjustment.Dirty
                    || _monthlyPICanGoGoes.Dirty
                    || _monthlyPIInterestOnlyDateType.Dirty
                    || _monthlyPIInterestOnlyUntilYear.Dirty
                    || _pPC1EstimatedEscrowAmount.Dirty
                    || _pPC1EstimatedEscrowAmountUI.Dirty
                    || _pPC1InterestOnly.Dirty
                    || _pPC1MaximumMonthlyPayment.Dirty
                    || _pPC1MaximumMonthlyPaymentUI.Dirty
                    || _pPC1MaximumPIPayment.Dirty
                    || _pPC1MaximumPIPaymentUI.Dirty
                    || _pPC1MIAmount.Dirty
                    || _pPC1MIAmountUI.Dirty
                    || _pPC1MinimumMonthlyPayment.Dirty
                    || _pPC1MinimumMonthlyPaymentUI.Dirty
                    || _pPC1MinimumPIPayment.Dirty
                    || _pPC1MinimumPIPaymentUI.Dirty
                    || _pPC1Year.Dirty
                    || _pPC2EstimatedEscrowAmount.Dirty
                    || _pPC2EstimatedEscrowAmountUI.Dirty
                    || _pPC2InterestOnly.Dirty
                    || _pPC2MaximumMonthlyPayment.Dirty
                    || _pPC2MaximumMonthlyPaymentUI.Dirty
                    || _pPC2MaximumPIPayment.Dirty
                    || _pPC2MaximumPIPaymentUI.Dirty
                    || _pPC2MIAmount.Dirty
                    || _pPC2MIAmountUI.Dirty
                    || _pPC2MinimumMonthlyPayment.Dirty
                    || _pPC2MinimumMonthlyPaymentUI.Dirty
                    || _pPC2MinimumPIPayment.Dirty
                    || _pPC2MinimumPIPaymentUI.Dirty
                    || _pPC2YearFrom.Dirty
                    || _pPC2YearTo.Dirty
                    || _pPC3EstimatedEscrowAmount.Dirty
                    || _pPC3EstimatedEscrowAmountUI.Dirty
                    || _pPC3InterestOnly.Dirty
                    || _pPC3MaximumMonthlyPayment.Dirty
                    || _pPC3MaximumMonthlyPaymentUI.Dirty
                    || _pPC3MaximumPIPayment.Dirty
                    || _pPC3MaximumPIPaymentUI.Dirty
                    || _pPC3MIAmount.Dirty
                    || _pPC3MIAmountUI.Dirty
                    || _pPC3MinimumMonthlyPayment.Dirty
                    || _pPC3MinimumMonthlyPaymentUI.Dirty
                    || _pPC3MinimumPIPayment.Dirty
                    || _pPC3MinimumPIPaymentUI.Dirty
                    || _pPC3YearFrom.Dirty
                    || _pPC3YearTo.Dirty
                    || _pPC4EstimatedEscrowAmount.Dirty
                    || _pPC4EstimatedEscrowAmountUI.Dirty
                    || _pPC4InterestOnly.Dirty
                    || _pPC4MaximumMonthlyPayment.Dirty
                    || _pPC4MaximumMonthlyPaymentUI.Dirty
                    || _pPC4MaximumPIPayment.Dirty
                    || _pPC4MaximumPIPaymentUI.Dirty
                    || _pPC4MIAmount.Dirty
                    || _pPC4MIAmountUI.Dirty
                    || _pPC4MinimumMonthlyPayment.Dirty
                    || _pPC4MinimumMonthlyPaymentUI.Dirty
                    || _pPC4MinimumPIPayment.Dirty
                    || _pPC4MinimumPIPaymentUI.Dirty
                    || _pPC4YearFrom.Dirty
                    || _pPC4YearTo.Dirty
                    || _pPEstimatedEscrowIndicator.Dirty
                    || _prepaymentPenaltyPayOffDuringYear.Dirty
                    || _prepaymentPenaltyPayOffInDateType.Dirty
                    || _prepaymentPenaltyPayOffInFirstYear.Dirty
                    || _rangePaymentIndicatorC1.Dirty
                    || _rangePaymentIndicatorC2.Dirty
                    || _rangePaymentIndicatorC3.Dirty
                    || _rangePaymentIndicatorC4.Dirty
                    || _rateLockExpirationTime.Dirty
                    || _rateLockExpirationTimeZone.Dirty
                    || _reasonChangedCircumstanceFlags.Dirty
                    || _reasonDelayedSettlement.Dirty
                    || _reasonEligibility.Dirty
                    || _reasonExpiration.Dirty
                    || _reasonInterestRate.Dirty
                    || _reasonOther.Dirty
                    || _reasonOtherDescription.Dirty
                    || _reasonRevisions.Dirty
                    || _reasonSettlementCharges.Dirty
                    || _totalEstimatedCashClose.Dirty
                    || _yearsToRecast.Dirty;
            }
            set
            {
                _adjustsTermType.Dirty = value;
                _changedCircumstanceComments.Dirty = value;
                _closingCostEstimateExpirationDate.Dirty = value;
                _closingCostEstimateExpirationTime.Dirty = value;
                _closingCostEstimateExpirationTimeZone.Dirty = value;
                _disclosureBy.Dirty = value;
                _disclosureClosingCostExpDate.Dirty = value;
                _disclosureClosingCostExpTime.Dirty = value;
                _disclosureClosingCostExpTimeZone.Dirty = value;
                _disclosureComments.Dirty = value;
                _disclosureLastSentDate.Dirty = value;
                _disclosureReceivedDate.Dirty = value;
                _disclosureSentMethod.Dirty = value;
                _estimatedTaxesInsuranceAssessments.Dirty = value;
                _estimatedTaxesInsuranceAssessmentsUI.Dirty = value;
                _highestMonthlyPI.Dirty = value;
                _id.Dirty = value;
                _inEscrowHomeownerInsurance.Dirty = value;
                _inEscrowOther.Dirty = value;
                _inEscrowPropertyTaxes.Dirty = value;
                _interestRateAdjustsEveryYears.Dirty = value;
                _interestRateAdjustsInYear.Dirty = value;
                _interestRateAdjustsStartingInType.Dirty = value;
                _interestRateAfterAdjustment.Dirty = value;
                _interestRateCanGoGoes.Dirty = value;
                _lEDateIssued.Dirty = value;
                _loanAmountCanGoGoes.Dirty = value;
                _loanAmountCanIncreaseOrIncreases.Dirty = value;
                _loanProduct.Dirty = value;
                _loanPurpose.Dirty = value;
                _loanTermMonths.Dirty = value;
                _loanTermYears.Dirty = value;
                _monthlyPIAdjustedInDateType.Dirty = value;
                _monthlyPIAdjustsEveryYears.Dirty = value;
                _monthlyPIAdjustsInYear.Dirty = value;
                _monthlyPIAdjustsStartingInType.Dirty = value;
                _monthlyPIAdjustsTermType.Dirty = value;
                _monthlyPIAfterAdjustment.Dirty = value;
                _monthlyPICanGoGoes.Dirty = value;
                _monthlyPIInterestOnlyDateType.Dirty = value;
                _monthlyPIInterestOnlyUntilYear.Dirty = value;
                _pPC1EstimatedEscrowAmount.Dirty = value;
                _pPC1EstimatedEscrowAmountUI.Dirty = value;
                _pPC1InterestOnly.Dirty = value;
                _pPC1MaximumMonthlyPayment.Dirty = value;
                _pPC1MaximumMonthlyPaymentUI.Dirty = value;
                _pPC1MaximumPIPayment.Dirty = value;
                _pPC1MaximumPIPaymentUI.Dirty = value;
                _pPC1MIAmount.Dirty = value;
                _pPC1MIAmountUI.Dirty = value;
                _pPC1MinimumMonthlyPayment.Dirty = value;
                _pPC1MinimumMonthlyPaymentUI.Dirty = value;
                _pPC1MinimumPIPayment.Dirty = value;
                _pPC1MinimumPIPaymentUI.Dirty = value;
                _pPC1Year.Dirty = value;
                _pPC2EstimatedEscrowAmount.Dirty = value;
                _pPC2EstimatedEscrowAmountUI.Dirty = value;
                _pPC2InterestOnly.Dirty = value;
                _pPC2MaximumMonthlyPayment.Dirty = value;
                _pPC2MaximumMonthlyPaymentUI.Dirty = value;
                _pPC2MaximumPIPayment.Dirty = value;
                _pPC2MaximumPIPaymentUI.Dirty = value;
                _pPC2MIAmount.Dirty = value;
                _pPC2MIAmountUI.Dirty = value;
                _pPC2MinimumMonthlyPayment.Dirty = value;
                _pPC2MinimumMonthlyPaymentUI.Dirty = value;
                _pPC2MinimumPIPayment.Dirty = value;
                _pPC2MinimumPIPaymentUI.Dirty = value;
                _pPC2YearFrom.Dirty = value;
                _pPC2YearTo.Dirty = value;
                _pPC3EstimatedEscrowAmount.Dirty = value;
                _pPC3EstimatedEscrowAmountUI.Dirty = value;
                _pPC3InterestOnly.Dirty = value;
                _pPC3MaximumMonthlyPayment.Dirty = value;
                _pPC3MaximumMonthlyPaymentUI.Dirty = value;
                _pPC3MaximumPIPayment.Dirty = value;
                _pPC3MaximumPIPaymentUI.Dirty = value;
                _pPC3MIAmount.Dirty = value;
                _pPC3MIAmountUI.Dirty = value;
                _pPC3MinimumMonthlyPayment.Dirty = value;
                _pPC3MinimumMonthlyPaymentUI.Dirty = value;
                _pPC3MinimumPIPayment.Dirty = value;
                _pPC3MinimumPIPaymentUI.Dirty = value;
                _pPC3YearFrom.Dirty = value;
                _pPC3YearTo.Dirty = value;
                _pPC4EstimatedEscrowAmount.Dirty = value;
                _pPC4EstimatedEscrowAmountUI.Dirty = value;
                _pPC4InterestOnly.Dirty = value;
                _pPC4MaximumMonthlyPayment.Dirty = value;
                _pPC4MaximumMonthlyPaymentUI.Dirty = value;
                _pPC4MaximumPIPayment.Dirty = value;
                _pPC4MaximumPIPaymentUI.Dirty = value;
                _pPC4MIAmount.Dirty = value;
                _pPC4MIAmountUI.Dirty = value;
                _pPC4MinimumMonthlyPayment.Dirty = value;
                _pPC4MinimumMonthlyPaymentUI.Dirty = value;
                _pPC4MinimumPIPayment.Dirty = value;
                _pPC4MinimumPIPaymentUI.Dirty = value;
                _pPC4YearFrom.Dirty = value;
                _pPC4YearTo.Dirty = value;
                _pPEstimatedEscrowIndicator.Dirty = value;
                _prepaymentPenaltyPayOffDuringYear.Dirty = value;
                _prepaymentPenaltyPayOffInDateType.Dirty = value;
                _prepaymentPenaltyPayOffInFirstYear.Dirty = value;
                _rangePaymentIndicatorC1.Dirty = value;
                _rangePaymentIndicatorC2.Dirty = value;
                _rangePaymentIndicatorC3.Dirty = value;
                _rangePaymentIndicatorC4.Dirty = value;
                _rateLockExpirationTime.Dirty = value;
                _rateLockExpirationTimeZone.Dirty = value;
                _reasonChangedCircumstanceFlags.Dirty = value;
                _reasonDelayedSettlement.Dirty = value;
                _reasonEligibility.Dirty = value;
                _reasonExpiration.Dirty = value;
                _reasonInterestRate.Dirty = value;
                _reasonOther.Dirty = value;
                _reasonOtherDescription.Dirty = value;
                _reasonRevisions.Dirty = value;
                _reasonSettlementCharges.Dirty = value;
                _totalEstimatedCashClose.Dirty = value;
                _yearsToRecast.Dirty = value;
            }
        }
    }
}