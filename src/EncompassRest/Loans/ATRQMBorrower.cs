using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ATRQMBorrower : IDirty
    {
        private DirtyValue<int?> _aTRQMBorrowerIndex;
        public int? ATRQMBorrowerIndex { get { return _aTRQMBorrowerIndex; } set { _aTRQMBorrowerIndex = value; } }
        private DirtyValue<string> _aUSRecommendation;
        public string AUSRecommendation { get { return _aUSRecommendation; } set { _aUSRecommendation = value; } }
        private DirtyValue<string> _aUSVersion;
        public string AUSVersion { get { return _aUSVersion; } set { _aUSVersion = value; } }
        private DirtyValue<decimal?> _borBonusAverageOvertime;
        public decimal? BorBonusAverageOvertime { get { return _borBonusAverageOvertime; } set { _borBonusAverageOvertime = value; } }
        private DirtyValue<decimal?> _borBonusMostRecentAmount;
        public decimal? BorBonusMostRecentAmount { get { return _borBonusMostRecentAmount; } set { _borBonusMostRecentAmount = value; } }
        private DirtyValue<int?> _borBonusMostRecentMonths;
        public int? BorBonusMostRecentMonths { get { return _borBonusMostRecentMonths; } set { _borBonusMostRecentMonths = value; } }
        private DirtyValue<int?> _borBonusMostRecentYear;
        public int? BorBonusMostRecentYear { get { return _borBonusMostRecentYear; } set { _borBonusMostRecentYear = value; } }
        private DirtyValue<decimal?> _borBonusPreviousAmount1;
        public decimal? BorBonusPreviousAmount1 { get { return _borBonusPreviousAmount1; } set { _borBonusPreviousAmount1 = value; } }
        private DirtyValue<decimal?> _borBonusPreviousAmount2;
        public decimal? BorBonusPreviousAmount2 { get { return _borBonusPreviousAmount2; } set { _borBonusPreviousAmount2 = value; } }
        private DirtyValue<int?> _borBonusPreviousMonths1;
        public int? BorBonusPreviousMonths1 { get { return _borBonusPreviousMonths1; } set { _borBonusPreviousMonths1 = value; } }
        private DirtyValue<int?> _borBonusPreviousMonths2;
        public int? BorBonusPreviousMonths2 { get { return _borBonusPreviousMonths2; } set { _borBonusPreviousMonths2 = value; } }
        private DirtyValue<int?> _borBonusPreviousYear1;
        public int? BorBonusPreviousYear1 { get { return _borBonusPreviousYear1; } set { _borBonusPreviousYear1 = value; } }
        private DirtyValue<int?> _borBonusPreviousYear2;
        public int? BorBonusPreviousYear2 { get { return _borBonusPreviousYear2; } set { _borBonusPreviousYear2 = value; } }
        private DirtyValue<decimal?> _borCommissionAverageOvertime;
        public decimal? BorCommissionAverageOvertime { get { return _borCommissionAverageOvertime; } set { _borCommissionAverageOvertime = value; } }
        private DirtyValue<decimal?> _borCommissionMostRecentAmount;
        public decimal? BorCommissionMostRecentAmount { get { return _borCommissionMostRecentAmount; } set { _borCommissionMostRecentAmount = value; } }
        private DirtyValue<int?> _borCommissionMostRecentMonths;
        public int? BorCommissionMostRecentMonths { get { return _borCommissionMostRecentMonths; } set { _borCommissionMostRecentMonths = value; } }
        private DirtyValue<int?> _borCommissionMostRecentYear;
        public int? BorCommissionMostRecentYear { get { return _borCommissionMostRecentYear; } set { _borCommissionMostRecentYear = value; } }
        private DirtyValue<decimal?> _borCommissionPreviousAmount1;
        public decimal? BorCommissionPreviousAmount1 { get { return _borCommissionPreviousAmount1; } set { _borCommissionPreviousAmount1 = value; } }
        private DirtyValue<decimal?> _borCommissionPreviousAmount2;
        public decimal? BorCommissionPreviousAmount2 { get { return _borCommissionPreviousAmount2; } set { _borCommissionPreviousAmount2 = value; } }
        private DirtyValue<int?> _borCommissionPreviousMonths1;
        public int? BorCommissionPreviousMonths1 { get { return _borCommissionPreviousMonths1; } set { _borCommissionPreviousMonths1 = value; } }
        private DirtyValue<int?> _borCommissionPreviousMonths2;
        public int? BorCommissionPreviousMonths2 { get { return _borCommissionPreviousMonths2; } set { _borCommissionPreviousMonths2 = value; } }
        private DirtyValue<int?> _borCommissionPreviousYear1;
        public int? BorCommissionPreviousYear1 { get { return _borCommissionPreviousYear1; } set { _borCommissionPreviousYear1 = value; } }
        private DirtyValue<int?> _borCommissionPreviousYear2;
        public int? BorCommissionPreviousYear2 { get { return _borCommissionPreviousYear2; } set { _borCommissionPreviousYear2 = value; } }
        private DirtyValue<decimal?> _borContingentLiabilitiesLiabilityAmount1;
        public decimal? BorContingentLiabilitiesLiabilityAmount1 { get { return _borContingentLiabilitiesLiabilityAmount1; } set { _borContingentLiabilitiesLiabilityAmount1 = value; } }
        private DirtyValue<decimal?> _borContingentLiabilitiesLiabilityAmount2;
        public decimal? BorContingentLiabilitiesLiabilityAmount2 { get { return _borContingentLiabilitiesLiabilityAmount2; } set { _borContingentLiabilitiesLiabilityAmount2 = value; } }
        private DirtyValue<decimal?> _borContingentLiabilitiesLiabilityAmount3;
        public decimal? BorContingentLiabilitiesLiabilityAmount3 { get { return _borContingentLiabilitiesLiabilityAmount3; } set { _borContingentLiabilitiesLiabilityAmount3 = value; } }
        private DirtyValue<string> _borContingentLiabilitiesLiabilityDescription1;
        public string BorContingentLiabilitiesLiabilityDescription1 { get { return _borContingentLiabilitiesLiabilityDescription1; } set { _borContingentLiabilitiesLiabilityDescription1 = value; } }
        private DirtyValue<string> _borContingentLiabilitiesLiabilityDescription2;
        public string BorContingentLiabilitiesLiabilityDescription2 { get { return _borContingentLiabilitiesLiabilityDescription2; } set { _borContingentLiabilitiesLiabilityDescription2 = value; } }
        private DirtyValue<string> _borContingentLiabilitiesLiabilityDescription3;
        public string BorContingentLiabilitiesLiabilityDescription3 { get { return _borContingentLiabilitiesLiabilityDescription3; } set { _borContingentLiabilitiesLiabilityDescription3 = value; } }
        private DirtyValue<decimal?> _borContingentLiabilitiesTotalLiabilityAmount;
        public decimal? BorContingentLiabilitiesTotalLiabilityAmount { get { return _borContingentLiabilitiesTotalLiabilityAmount; } set { _borContingentLiabilitiesTotalLiabilityAmount = value; } }
        private DirtyValue<decimal?> _borCosignedObligationsCarLoanPayment;
        public decimal? BorCosignedObligationsCarLoanPayment { get { return _borCosignedObligationsCarLoanPayment; } set { _borCosignedObligationsCarLoanPayment = value; } }
        private DirtyValue<decimal?> _borCosignedObligationsMortgagePayment;
        public decimal? BorCosignedObligationsMortgagePayment { get { return _borCosignedObligationsMortgagePayment; } set { _borCosignedObligationsMortgagePayment = value; } }
        private DirtyValue<decimal?> _borCosignedObligationsOtherPayment;
        public decimal? BorCosignedObligationsOtherPayment { get { return _borCosignedObligationsOtherPayment; } set { _borCosignedObligationsOtherPayment = value; } }
        private DirtyValue<string> _borCosignedObligationsOtherPaymentDescription;
        public string BorCosignedObligationsOtherPaymentDescription { get { return _borCosignedObligationsOtherPaymentDescription; } set { _borCosignedObligationsOtherPaymentDescription = value; } }
        private DirtyValue<decimal?> _borCosignedObligationsStudentLoanPayment;
        public decimal? BorCosignedObligationsStudentLoanPayment { get { return _borCosignedObligationsStudentLoanPayment; } set { _borCosignedObligationsStudentLoanPayment = value; } }
        private DirtyValue<decimal?> _borCosignedObligationsTotalCoMortgagorLiabilities;
        public decimal? BorCosignedObligationsTotalCoMortgagorLiabilities { get { return _borCosignedObligationsTotalCoMortgagorLiabilities; } set { _borCosignedObligationsTotalCoMortgagorLiabilities = value; } }
        private DirtyValue<decimal?> _borDividendAverageDividend;
        public decimal? BorDividendAverageDividend { get { return _borDividendAverageDividend; } set { _borDividendAverageDividend = value; } }
        private DirtyValue<decimal?> _borDividendPreviousAmount1;
        public decimal? BorDividendPreviousAmount1 { get { return _borDividendPreviousAmount1; } set { _borDividendPreviousAmount1 = value; } }
        private DirtyValue<decimal?> _borDividendPreviousAmount2;
        public decimal? BorDividendPreviousAmount2 { get { return _borDividendPreviousAmount2; } set { _borDividendPreviousAmount2 = value; } }
        private DirtyValue<int?> _borDividendPreviousMonths1;
        public int? BorDividendPreviousMonths1 { get { return _borDividendPreviousMonths1; } set { _borDividendPreviousMonths1 = value; } }
        private DirtyValue<int?> _borDividendPreviousMonths2;
        public int? BorDividendPreviousMonths2 { get { return _borDividendPreviousMonths2; } set { _borDividendPreviousMonths2 = value; } }
        private DirtyValue<int?> _borDividendPreviousYear1;
        public int? BorDividendPreviousYear1 { get { return _borDividendPreviousYear1; } set { _borDividendPreviousYear1 = value; } }
        private DirtyValue<int?> _borDividendPreviousYear2;
        public int? BorDividendPreviousYear2 { get { return _borDividendPreviousYear2; } set { _borDividendPreviousYear2 = value; } }
        private DirtyValue<decimal?> _borDividendRequiredForCashAmount;
        public decimal? BorDividendRequiredForCashAmount { get { return _borDividendRequiredForCashAmount; } set { _borDividendRequiredForCashAmount = value; } }
        private DirtyValue<decimal?> _borInterestAverageDividend;
        public decimal? BorInterestAverageDividend { get { return _borInterestAverageDividend; } set { _borInterestAverageDividend = value; } }
        private DirtyValue<decimal?> _borInterestPreviousAmount1;
        public decimal? BorInterestPreviousAmount1 { get { return _borInterestPreviousAmount1; } set { _borInterestPreviousAmount1 = value; } }
        private DirtyValue<decimal?> _borInterestPreviousAmount2;
        public decimal? BorInterestPreviousAmount2 { get { return _borInterestPreviousAmount2; } set { _borInterestPreviousAmount2 = value; } }
        private DirtyValue<int?> _borInterestPreviousMonths1;
        public int? BorInterestPreviousMonths1 { get { return _borInterestPreviousMonths1; } set { _borInterestPreviousMonths1 = value; } }
        private DirtyValue<int?> _borInterestPreviousMonths2;
        public int? BorInterestPreviousMonths2 { get { return _borInterestPreviousMonths2; } set { _borInterestPreviousMonths2 = value; } }
        private DirtyValue<int?> _borInterestPreviousYear1;
        public int? BorInterestPreviousYear1 { get { return _borInterestPreviousYear1; } set { _borInterestPreviousYear1 = value; } }
        private DirtyValue<int?> _borInterestPreviousYear2;
        public int? BorInterestPreviousYear2 { get { return _borInterestPreviousYear2; } set { _borInterestPreviousYear2 = value; } }
        private DirtyValue<decimal?> _borInterestRequiredForCashAmount;
        public decimal? BorInterestRequiredForCashAmount { get { return _borInterestRequiredForCashAmount; } set { _borInterestRequiredForCashAmount = value; } }
        private DirtyValue<decimal?> _borMilitaryAllowanceClothingAllowance;
        public decimal? BorMilitaryAllowanceClothingAllowance { get { return _borMilitaryAllowanceClothingAllowance; } set { _borMilitaryAllowanceClothingAllowance = value; } }
        private DirtyValue<decimal?> _borMilitaryAllowanceOtherAllowance;
        public decimal? BorMilitaryAllowanceOtherAllowance { get { return _borMilitaryAllowanceOtherAllowance; } set { _borMilitaryAllowanceOtherAllowance = value; } }
        private DirtyValue<string> _borMilitaryAllowanceOtherAllowanceDescription;
        public string BorMilitaryAllowanceOtherAllowanceDescription { get { return _borMilitaryAllowanceOtherAllowanceDescription; } set { _borMilitaryAllowanceOtherAllowanceDescription = value; } }
        private DirtyValue<decimal?> _borMilitaryAllowanceQuartersAllowance;
        public decimal? BorMilitaryAllowanceQuartersAllowance { get { return _borMilitaryAllowanceQuartersAllowance; } set { _borMilitaryAllowanceQuartersAllowance = value; } }
        private DirtyValue<decimal?> _borMilitaryAllowanceRationsAllowance;
        public decimal? BorMilitaryAllowanceRationsAllowance { get { return _borMilitaryAllowanceRationsAllowance; } set { _borMilitaryAllowanceRationsAllowance = value; } }
        private DirtyValue<decimal?> _borMilitaryAllowanceTotalAllowance;
        public decimal? BorMilitaryAllowanceTotalAllowance { get { return _borMilitaryAllowanceTotalAllowance; } set { _borMilitaryAllowanceTotalAllowance = value; } }
        private DirtyValue<decimal?> _borMilitaryAllowanceVariableHousingAllowance;
        public decimal? BorMilitaryAllowanceVariableHousingAllowance { get { return _borMilitaryAllowanceVariableHousingAllowance; } set { _borMilitaryAllowanceVariableHousingAllowance = value; } }
        private DirtyValue<decimal?> _borMilitaryBasePay;
        public decimal? BorMilitaryBasePay { get { return _borMilitaryBasePay; } set { _borMilitaryBasePay = value; } }
        private DirtyValue<decimal?> _borMilitaryCombatPay;
        public decimal? BorMilitaryCombatPay { get { return _borMilitaryCombatPay; } set { _borMilitaryCombatPay = value; } }
        private DirtyValue<decimal?> _borMilitaryFlightPay;
        public decimal? BorMilitaryFlightPay { get { return _borMilitaryFlightPay; } set { _borMilitaryFlightPay = value; } }
        private DirtyValue<decimal?> _borMilitaryHazardPay;
        public decimal? BorMilitaryHazardPay { get { return _borMilitaryHazardPay; } set { _borMilitaryHazardPay = value; } }
        private DirtyValue<decimal?> _borMilitaryOverseasPay;
        public decimal? BorMilitaryOverseasPay { get { return _borMilitaryOverseasPay; } set { _borMilitaryOverseasPay = value; } }
        private DirtyValue<decimal?> _borMilitaryPropPay;
        public decimal? BorMilitaryPropPay { get { return _borMilitaryPropPay; } set { _borMilitaryPropPay = value; } }
        private DirtyValue<decimal?> _borMilitaryTotalPay;
        public decimal? BorMilitaryTotalPay { get { return _borMilitaryTotalPay; } set { _borMilitaryTotalPay = value; } }
        private DirtyValue<decimal?> _borMonthlyEmplymentIncomeBaseIncome;
        public decimal? BorMonthlyEmplymentIncomeBaseIncome { get { return _borMonthlyEmplymentIncomeBaseIncome; } set { _borMonthlyEmplymentIncomeBaseIncome = value; } }
        private DirtyValue<decimal?> _borMonthlyEmplymentIncomeBonuseIncome;
        public decimal? BorMonthlyEmplymentIncomeBonuseIncome { get { return _borMonthlyEmplymentIncomeBonuseIncome; } set { _borMonthlyEmplymentIncomeBonuseIncome = value; } }
        private DirtyValue<decimal?> _borMonthlyEmplymentIncomeCommissionIncome;
        public decimal? BorMonthlyEmplymentIncomeCommissionIncome { get { return _borMonthlyEmplymentIncomeCommissionIncome; } set { _borMonthlyEmplymentIncomeCommissionIncome = value; } }
        private DirtyValue<decimal?> _borMonthlyEmplymentIncomeDividendInterestIncome;
        public decimal? BorMonthlyEmplymentIncomeDividendInterestIncome { get { return _borMonthlyEmplymentIncomeDividendInterestIncome; } set { _borMonthlyEmplymentIncomeDividendInterestIncome = value; } }
        private DirtyValue<decimal?> _borMonthlyEmplymentIncomeOtherIncome1;
        public decimal? BorMonthlyEmplymentIncomeOtherIncome1 { get { return _borMonthlyEmplymentIncomeOtherIncome1; } set { _borMonthlyEmplymentIncomeOtherIncome1 = value; } }
        private DirtyValue<decimal?> _borMonthlyEmplymentIncomeOtherIncome2;
        public decimal? BorMonthlyEmplymentIncomeOtherIncome2 { get { return _borMonthlyEmplymentIncomeOtherIncome2; } set { _borMonthlyEmplymentIncomeOtherIncome2 = value; } }
        private DirtyValue<decimal?> _borMonthlyEmplymentIncomeOvertimeIncome;
        public decimal? BorMonthlyEmplymentIncomeOvertimeIncome { get { return _borMonthlyEmplymentIncomeOvertimeIncome; } set { _borMonthlyEmplymentIncomeOvertimeIncome = value; } }
        private DirtyValue<decimal?> _borMonthlyEmplymentIncomeTotalEmploymentIncome;
        public decimal? BorMonthlyEmplymentIncomeTotalEmploymentIncome { get { return _borMonthlyEmplymentIncomeTotalEmploymentIncome; } set { _borMonthlyEmplymentIncomeTotalEmploymentIncome = value; } }
        private DirtyValue<decimal?> _borNonEmploymentIncomeGovtAssitProgramIncome;
        public decimal? BorNonEmploymentIncomeGovtAssitProgramIncome { get { return _borNonEmploymentIncomeGovtAssitProgramIncome; } set { _borNonEmploymentIncomeGovtAssitProgramIncome = value; } }
        private DirtyValue<decimal?> _borNonEmploymentIncomeHomeownSubsidyIncome;
        public decimal? BorNonEmploymentIncomeHomeownSubsidyIncome { get { return _borNonEmploymentIncomeHomeownSubsidyIncome; } set { _borNonEmploymentIncomeHomeownSubsidyIncome = value; } }
        private DirtyValue<bool?> _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome;
        public bool? BorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome { get { return _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome; } set { _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome = value; } }
        private DirtyValue<bool?> _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome;
        public bool? BorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome { get { return _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome; } set { _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome = value; } }
        private DirtyValue<decimal?> _borNonEmploymentIncomeMilitaryIncome;
        public decimal? BorNonEmploymentIncomeMilitaryIncome { get { return _borNonEmploymentIncomeMilitaryIncome; } set { _borNonEmploymentIncomeMilitaryIncome = value; } }
        private DirtyValue<decimal?> _borNonEmploymentIncomeMtgCreditCertificateIncome;
        public decimal? BorNonEmploymentIncomeMtgCreditCertificateIncome { get { return _borNonEmploymentIncomeMtgCreditCertificateIncome; } set { _borNonEmploymentIncomeMtgCreditCertificateIncome = value; } }
        private DirtyValue<decimal?> _borNonEmploymentIncomeTotalNonEmploymentIncome;
        public decimal? BorNonEmploymentIncomeTotalNonEmploymentIncome { get { return _borNonEmploymentIncomeTotalNonEmploymentIncome; } set { _borNonEmploymentIncomeTotalNonEmploymentIncome = value; } }
        private DirtyValue<decimal?> _borNonEmploymentIncomeVABenefitIncome;
        public decimal? BorNonEmploymentIncomeVABenefitIncome { get { return _borNonEmploymentIncomeVABenefitIncome; } set { _borNonEmploymentIncomeVABenefitIncome = value; } }
        private DirtyValue<decimal?> _borNonTaxableIncomeChildSupportIncome;
        public decimal? BorNonTaxableIncomeChildSupportIncome { get { return _borNonTaxableIncomeChildSupportIncome; } set { _borNonTaxableIncomeChildSupportIncome = value; } }
        private DirtyValue<decimal?> _borNonTaxableIncomeDisabilityIncome;
        public decimal? BorNonTaxableIncomeDisabilityIncome { get { return _borNonTaxableIncomeDisabilityIncome; } set { _borNonTaxableIncomeDisabilityIncome = value; } }
        private DirtyValue<decimal?> _borNonTaxableIncomeFedGovtEmplRetirementIncome;
        public decimal? BorNonTaxableIncomeFedGovtEmplRetirementIncome { get { return _borNonTaxableIncomeFedGovtEmplRetirementIncome; } set { _borNonTaxableIncomeFedGovtEmplRetirementIncome = value; } }
        private DirtyValue<decimal?> _borNonTaxableIncomeMilitaryAllowances;
        public decimal? BorNonTaxableIncomeMilitaryAllowances { get { return _borNonTaxableIncomeMilitaryAllowances; } set { _borNonTaxableIncomeMilitaryAllowances = value; } }
        private DirtyValue<decimal?> _borNonTaxableIncomeOtherIncome;
        public decimal? BorNonTaxableIncomeOtherIncome { get { return _borNonTaxableIncomeOtherIncome; } set { _borNonTaxableIncomeOtherIncome = value; } }
        private DirtyValue<decimal?> _borNonTaxableIncomePublicAssistPayments;
        public decimal? BorNonTaxableIncomePublicAssistPayments { get { return _borNonTaxableIncomePublicAssistPayments; } set { _borNonTaxableIncomePublicAssistPayments = value; } }
        private DirtyValue<decimal?> _borNonTaxableIncomeRailroadRetirementBenefits;
        public decimal? BorNonTaxableIncomeRailroadRetirementBenefits { get { return _borNonTaxableIncomeRailroadRetirementBenefits; } set { _borNonTaxableIncomeRailroadRetirementBenefits = value; } }
        private DirtyValue<decimal?> _borNonTaxableIncomeSocialSecurityIncome;
        public decimal? BorNonTaxableIncomeSocialSecurityIncome { get { return _borNonTaxableIncomeSocialSecurityIncome; } set { _borNonTaxableIncomeSocialSecurityIncome = value; } }
        private DirtyValue<decimal?> _borNonTaxableIncomeStateGovtEmplRetirementIncome;
        public decimal? BorNonTaxableIncomeStateGovtEmplRetirementIncome { get { return _borNonTaxableIncomeStateGovtEmplRetirementIncome; } set { _borNonTaxableIncomeStateGovtEmplRetirementIncome = value; } }
        private DirtyValue<decimal?> _borNonTaxableIncomeTotalNonTaxableIncome;
        public decimal? BorNonTaxableIncomeTotalNonTaxableIncome { get { return _borNonTaxableIncomeTotalNonTaxableIncome; } set { _borNonTaxableIncomeTotalNonTaxableIncome = value; } }
        private DirtyValue<decimal?> _borOtherNotesReceivableIncome;
        public decimal? BorOtherNotesReceivableIncome { get { return _borOtherNotesReceivableIncome; } set { _borOtherNotesReceivableIncome = value; } }
        private DirtyValue<decimal?> _borOtherOtherIncome;
        public decimal? BorOtherOtherIncome { get { return _borOtherOtherIncome; } set { _borOtherOtherIncome = value; } }
        private DirtyValue<decimal?> _borOtherParttimeIncome;
        public decimal? BorOtherParttimeIncome { get { return _borOtherParttimeIncome; } set { _borOtherParttimeIncome = value; } }
        private DirtyValue<decimal?> _borOtherRetirementIncome;
        public decimal? BorOtherRetirementIncome { get { return _borOtherRetirementIncome; } set { _borOtherRetirementIncome = value; } }
        private DirtyValue<decimal?> _borOtherSeasonalIncome;
        public decimal? BorOtherSeasonalIncome { get { return _borOtherSeasonalIncome; } set { _borOtherSeasonalIncome = value; } }
        private DirtyValue<decimal?> _borOtherSocialSecurityIncome;
        public decimal? BorOtherSocialSecurityIncome { get { return _borOtherSocialSecurityIncome; } set { _borOtherSocialSecurityIncome = value; } }
        private DirtyValue<decimal?> _borOtherTipIncome;
        public decimal? BorOtherTipIncome { get { return _borOtherTipIncome; } set { _borOtherTipIncome = value; } }
        private DirtyValue<decimal?> _borOtherTrustIncome;
        public decimal? BorOtherTrustIncome { get { return _borOtherTrustIncome; } set { _borOtherTrustIncome = value; } }
        private DirtyValue<decimal?> _borOtherUnemploymentIncome;
        public decimal? BorOtherUnemploymentIncome { get { return _borOtherUnemploymentIncome; } set { _borOtherUnemploymentIncome = value; } }
        private DirtyValue<decimal?> _borOvertimeAverageOvertime;
        public decimal? BorOvertimeAverageOvertime { get { return _borOvertimeAverageOvertime; } set { _borOvertimeAverageOvertime = value; } }
        private DirtyValue<decimal?> _borOvertimeMostRecentAmount;
        public decimal? BorOvertimeMostRecentAmount { get { return _borOvertimeMostRecentAmount; } set { _borOvertimeMostRecentAmount = value; } }
        private DirtyValue<int?> _borOvertimeMostRecentMonths;
        public int? BorOvertimeMostRecentMonths { get { return _borOvertimeMostRecentMonths; } set { _borOvertimeMostRecentMonths = value; } }
        private DirtyValue<int?> _borOvertimeMostRecentYear;
        public int? BorOvertimeMostRecentYear { get { return _borOvertimeMostRecentYear; } set { _borOvertimeMostRecentYear = value; } }
        private DirtyValue<decimal?> _borOvertimePreviousAmount1;
        public decimal? BorOvertimePreviousAmount1 { get { return _borOvertimePreviousAmount1; } set { _borOvertimePreviousAmount1 = value; } }
        private DirtyValue<decimal?> _borOvertimePreviousAmount2;
        public decimal? BorOvertimePreviousAmount2 { get { return _borOvertimePreviousAmount2; } set { _borOvertimePreviousAmount2 = value; } }
        private DirtyValue<int?> _borOvertimePreviousMonths1;
        public int? BorOvertimePreviousMonths1 { get { return _borOvertimePreviousMonths1; } set { _borOvertimePreviousMonths1 = value; } }
        private DirtyValue<int?> _borOvertimePreviousMonths2;
        public int? BorOvertimePreviousMonths2 { get { return _borOvertimePreviousMonths2; } set { _borOvertimePreviousMonths2 = value; } }
        private DirtyValue<int?> _borOvertimePreviousYear1;
        public int? BorOvertimePreviousYear1 { get { return _borOvertimePreviousYear1; } set { _borOvertimePreviousYear1 = value; } }
        private DirtyValue<int?> _borOvertimePreviousYear2;
        public int? BorOvertimePreviousYear2 { get { return _borOvertimePreviousYear2; } set { _borOvertimePreviousYear2 = value; } }
        private DirtyValue<decimal?> _borProjectedIncomeProjectedBonuses;
        public decimal? BorProjectedIncomeProjectedBonuses { get { return _borProjectedIncomeProjectedBonuses; } set { _borProjectedIncomeProjectedBonuses = value; } }
        private DirtyValue<decimal?> _borProjectedIncomeProjectedCostLivingAdjustment;
        public decimal? BorProjectedIncomeProjectedCostLivingAdjustment { get { return _borProjectedIncomeProjectedCostLivingAdjustment; } set { _borProjectedIncomeProjectedCostLivingAdjustment = value; } }
        private DirtyValue<decimal?> _borProjectedIncomeProjectedNewJobIncome;
        public decimal? BorProjectedIncomeProjectedNewJobIncome { get { return _borProjectedIncomeProjectedNewJobIncome; } set { _borProjectedIncomeProjectedNewJobIncome = value; } }
        private DirtyValue<decimal?> _borProjectedIncomeProjectedPerformanceRaises;
        public decimal? BorProjectedIncomeProjectedPerformanceRaises { get { return _borProjectedIncomeProjectedPerformanceRaises; } set { _borProjectedIncomeProjectedPerformanceRaises = value; } }
        private DirtyValue<decimal?> _borProjectedIncomeTotalProjectedIncome;
        public decimal? BorProjectedIncomeTotalProjectedIncome { get { return _borProjectedIncomeTotalProjectedIncome; } set { _borProjectedIncomeTotalProjectedIncome = value; } }
        private DirtyValue<decimal?> _cobBonusAverageOvertime;
        public decimal? CobBonusAverageOvertime { get { return _cobBonusAverageOvertime; } set { _cobBonusAverageOvertime = value; } }
        private DirtyValue<decimal?> _cobBonusMostRecentAmount;
        public decimal? CobBonusMostRecentAmount { get { return _cobBonusMostRecentAmount; } set { _cobBonusMostRecentAmount = value; } }
        private DirtyValue<int?> _cobBonusMostRecentMonths;
        public int? CobBonusMostRecentMonths { get { return _cobBonusMostRecentMonths; } set { _cobBonusMostRecentMonths = value; } }
        private DirtyValue<int?> _cobBonusMostRecentYear;
        public int? CobBonusMostRecentYear { get { return _cobBonusMostRecentYear; } set { _cobBonusMostRecentYear = value; } }
        private DirtyValue<decimal?> _cobBonusPreviousAmount1;
        public decimal? CobBonusPreviousAmount1 { get { return _cobBonusPreviousAmount1; } set { _cobBonusPreviousAmount1 = value; } }
        private DirtyValue<decimal?> _cobBonusPreviousAmount2;
        public decimal? CobBonusPreviousAmount2 { get { return _cobBonusPreviousAmount2; } set { _cobBonusPreviousAmount2 = value; } }
        private DirtyValue<int?> _cobBonusPreviousMonths1;
        public int? CobBonusPreviousMonths1 { get { return _cobBonusPreviousMonths1; } set { _cobBonusPreviousMonths1 = value; } }
        private DirtyValue<int?> _cobBonusPreviousMonths2;
        public int? CobBonusPreviousMonths2 { get { return _cobBonusPreviousMonths2; } set { _cobBonusPreviousMonths2 = value; } }
        private DirtyValue<int?> _cobBonusPreviousYear1;
        public int? CobBonusPreviousYear1 { get { return _cobBonusPreviousYear1; } set { _cobBonusPreviousYear1 = value; } }
        private DirtyValue<int?> _cobBonusPreviousYear2;
        public int? CobBonusPreviousYear2 { get { return _cobBonusPreviousYear2; } set { _cobBonusPreviousYear2 = value; } }
        private DirtyValue<decimal?> _cobCommissionAverageOvertime;
        public decimal? CobCommissionAverageOvertime { get { return _cobCommissionAverageOvertime; } set { _cobCommissionAverageOvertime = value; } }
        private DirtyValue<decimal?> _cobCommissionMostRecentAmount;
        public decimal? CobCommissionMostRecentAmount { get { return _cobCommissionMostRecentAmount; } set { _cobCommissionMostRecentAmount = value; } }
        private DirtyValue<int?> _cobCommissionMostRecentMonths;
        public int? CobCommissionMostRecentMonths { get { return _cobCommissionMostRecentMonths; } set { _cobCommissionMostRecentMonths = value; } }
        private DirtyValue<int?> _cobCommissionMostRecentYear;
        public int? CobCommissionMostRecentYear { get { return _cobCommissionMostRecentYear; } set { _cobCommissionMostRecentYear = value; } }
        private DirtyValue<decimal?> _cobCommissionPreviousAmount1;
        public decimal? CobCommissionPreviousAmount1 { get { return _cobCommissionPreviousAmount1; } set { _cobCommissionPreviousAmount1 = value; } }
        private DirtyValue<decimal?> _cobCommissionPreviousAmount2;
        public decimal? CobCommissionPreviousAmount2 { get { return _cobCommissionPreviousAmount2; } set { _cobCommissionPreviousAmount2 = value; } }
        private DirtyValue<int?> _cobCommissionPreviousMonths1;
        public int? CobCommissionPreviousMonths1 { get { return _cobCommissionPreviousMonths1; } set { _cobCommissionPreviousMonths1 = value; } }
        private DirtyValue<int?> _cobCommissionPreviousMonths2;
        public int? CobCommissionPreviousMonths2 { get { return _cobCommissionPreviousMonths2; } set { _cobCommissionPreviousMonths2 = value; } }
        private DirtyValue<int?> _cobCommissionPreviousYear1;
        public int? CobCommissionPreviousYear1 { get { return _cobCommissionPreviousYear1; } set { _cobCommissionPreviousYear1 = value; } }
        private DirtyValue<int?> _cobCommissionPreviousYear2;
        public int? CobCommissionPreviousYear2 { get { return _cobCommissionPreviousYear2; } set { _cobCommissionPreviousYear2 = value; } }
        private DirtyValue<decimal?> _cobDividendAverageDividend;
        public decimal? CobDividendAverageDividend { get { return _cobDividendAverageDividend; } set { _cobDividendAverageDividend = value; } }
        private DirtyValue<decimal?> _cobDividendPreviousAmount1;
        public decimal? CobDividendPreviousAmount1 { get { return _cobDividendPreviousAmount1; } set { _cobDividendPreviousAmount1 = value; } }
        private DirtyValue<decimal?> _cobDividendPreviousAmount2;
        public decimal? CobDividendPreviousAmount2 { get { return _cobDividendPreviousAmount2; } set { _cobDividendPreviousAmount2 = value; } }
        private DirtyValue<int?> _cobDividendPreviousMonths1;
        public int? CobDividendPreviousMonths1 { get { return _cobDividendPreviousMonths1; } set { _cobDividendPreviousMonths1 = value; } }
        private DirtyValue<int?> _cobDividendPreviousMonths2;
        public int? CobDividendPreviousMonths2 { get { return _cobDividendPreviousMonths2; } set { _cobDividendPreviousMonths2 = value; } }
        private DirtyValue<int?> _cobDividendPreviousYear1;
        public int? CobDividendPreviousYear1 { get { return _cobDividendPreviousYear1; } set { _cobDividendPreviousYear1 = value; } }
        private DirtyValue<int?> _cobDividendPreviousYear2;
        public int? CobDividendPreviousYear2 { get { return _cobDividendPreviousYear2; } set { _cobDividendPreviousYear2 = value; } }
        private DirtyValue<decimal?> _cobDividendRequiredForCashAmount;
        public decimal? CobDividendRequiredForCashAmount { get { return _cobDividendRequiredForCashAmount; } set { _cobDividendRequiredForCashAmount = value; } }
        private DirtyValue<decimal?> _cobInterestAverageDividend;
        public decimal? CobInterestAverageDividend { get { return _cobInterestAverageDividend; } set { _cobInterestAverageDividend = value; } }
        private DirtyValue<decimal?> _cobInterestPreviousAmount1;
        public decimal? CobInterestPreviousAmount1 { get { return _cobInterestPreviousAmount1; } set { _cobInterestPreviousAmount1 = value; } }
        private DirtyValue<decimal?> _cobInterestPreviousAmount2;
        public decimal? CobInterestPreviousAmount2 { get { return _cobInterestPreviousAmount2; } set { _cobInterestPreviousAmount2 = value; } }
        private DirtyValue<int?> _cobInterestPreviousMonths1;
        public int? CobInterestPreviousMonths1 { get { return _cobInterestPreviousMonths1; } set { _cobInterestPreviousMonths1 = value; } }
        private DirtyValue<int?> _cobInterestPreviousMonths2;
        public int? CobInterestPreviousMonths2 { get { return _cobInterestPreviousMonths2; } set { _cobInterestPreviousMonths2 = value; } }
        private DirtyValue<int?> _cobInterestPreviousYear1;
        public int? CobInterestPreviousYear1 { get { return _cobInterestPreviousYear1; } set { _cobInterestPreviousYear1 = value; } }
        private DirtyValue<int?> _cobInterestPreviousYear2;
        public int? CobInterestPreviousYear2 { get { return _cobInterestPreviousYear2; } set { _cobInterestPreviousYear2 = value; } }
        private DirtyValue<decimal?> _cobInterestRequiredForCashAmount;
        public decimal? CobInterestRequiredForCashAmount { get { return _cobInterestRequiredForCashAmount; } set { _cobInterestRequiredForCashAmount = value; } }
        private DirtyValue<decimal?> _cobMilitaryAllowanceClothingAllowance;
        public decimal? CobMilitaryAllowanceClothingAllowance { get { return _cobMilitaryAllowanceClothingAllowance; } set { _cobMilitaryAllowanceClothingAllowance = value; } }
        private DirtyValue<decimal?> _cobMilitaryAllowanceOtherAllowance;
        public decimal? CobMilitaryAllowanceOtherAllowance { get { return _cobMilitaryAllowanceOtherAllowance; } set { _cobMilitaryAllowanceOtherAllowance = value; } }
        private DirtyValue<decimal?> _cobMilitaryAllowanceQuartersAllowance;
        public decimal? CobMilitaryAllowanceQuartersAllowance { get { return _cobMilitaryAllowanceQuartersAllowance; } set { _cobMilitaryAllowanceQuartersAllowance = value; } }
        private DirtyValue<decimal?> _cobMilitaryAllowanceRationsAllowance;
        public decimal? CobMilitaryAllowanceRationsAllowance { get { return _cobMilitaryAllowanceRationsAllowance; } set { _cobMilitaryAllowanceRationsAllowance = value; } }
        private DirtyValue<decimal?> _cobMilitaryAllowanceTotalAllowance;
        public decimal? CobMilitaryAllowanceTotalAllowance { get { return _cobMilitaryAllowanceTotalAllowance; } set { _cobMilitaryAllowanceTotalAllowance = value; } }
        private DirtyValue<decimal?> _cobMilitaryAllowanceVariableHousingAllowance;
        public decimal? CobMilitaryAllowanceVariableHousingAllowance { get { return _cobMilitaryAllowanceVariableHousingAllowance; } set { _cobMilitaryAllowanceVariableHousingAllowance = value; } }
        private DirtyValue<decimal?> _cobMilitaryBasePay;
        public decimal? CobMilitaryBasePay { get { return _cobMilitaryBasePay; } set { _cobMilitaryBasePay = value; } }
        private DirtyValue<decimal?> _cobMilitaryCombatPay;
        public decimal? CobMilitaryCombatPay { get { return _cobMilitaryCombatPay; } set { _cobMilitaryCombatPay = value; } }
        private DirtyValue<decimal?> _cobMilitaryFlightPay;
        public decimal? CobMilitaryFlightPay { get { return _cobMilitaryFlightPay; } set { _cobMilitaryFlightPay = value; } }
        private DirtyValue<decimal?> _cobMilitaryHazardPay;
        public decimal? CobMilitaryHazardPay { get { return _cobMilitaryHazardPay; } set { _cobMilitaryHazardPay = value; } }
        private DirtyValue<decimal?> _cobMilitaryOverseasPay;
        public decimal? CobMilitaryOverseasPay { get { return _cobMilitaryOverseasPay; } set { _cobMilitaryOverseasPay = value; } }
        private DirtyValue<decimal?> _cobMilitaryPropPay;
        public decimal? CobMilitaryPropPay { get { return _cobMilitaryPropPay; } set { _cobMilitaryPropPay = value; } }
        private DirtyValue<decimal?> _cobMilitaryTotalPay;
        public decimal? CobMilitaryTotalPay { get { return _cobMilitaryTotalPay; } set { _cobMilitaryTotalPay = value; } }
        private DirtyValue<decimal?> _cobMonthlyEmplymentIncomeBaseIncome;
        public decimal? CobMonthlyEmplymentIncomeBaseIncome { get { return _cobMonthlyEmplymentIncomeBaseIncome; } set { _cobMonthlyEmplymentIncomeBaseIncome = value; } }
        private DirtyValue<decimal?> _cobMonthlyEmplymentIncomeBonuseIncome;
        public decimal? CobMonthlyEmplymentIncomeBonuseIncome { get { return _cobMonthlyEmplymentIncomeBonuseIncome; } set { _cobMonthlyEmplymentIncomeBonuseIncome = value; } }
        private DirtyValue<decimal?> _cobMonthlyEmplymentIncomeCommissionIncome;
        public decimal? CobMonthlyEmplymentIncomeCommissionIncome { get { return _cobMonthlyEmplymentIncomeCommissionIncome; } set { _cobMonthlyEmplymentIncomeCommissionIncome = value; } }
        private DirtyValue<decimal?> _cobMonthlyEmplymentIncomeDividendInterestIncome;
        public decimal? CobMonthlyEmplymentIncomeDividendInterestIncome { get { return _cobMonthlyEmplymentIncomeDividendInterestIncome; } set { _cobMonthlyEmplymentIncomeDividendInterestIncome = value; } }
        private DirtyValue<decimal?> _cobMonthlyEmplymentIncomeOtherIncome1;
        public decimal? CobMonthlyEmplymentIncomeOtherIncome1 { get { return _cobMonthlyEmplymentIncomeOtherIncome1; } set { _cobMonthlyEmplymentIncomeOtherIncome1 = value; } }
        private DirtyValue<decimal?> _cobMonthlyEmplymentIncomeOtherIncome2;
        public decimal? CobMonthlyEmplymentIncomeOtherIncome2 { get { return _cobMonthlyEmplymentIncomeOtherIncome2; } set { _cobMonthlyEmplymentIncomeOtherIncome2 = value; } }
        private DirtyValue<decimal?> _cobMonthlyEmplymentIncomeOvertimeIncome;
        public decimal? CobMonthlyEmplymentIncomeOvertimeIncome { get { return _cobMonthlyEmplymentIncomeOvertimeIncome; } set { _cobMonthlyEmplymentIncomeOvertimeIncome = value; } }
        private DirtyValue<decimal?> _cobMonthlyEmplymentIncomeTotalEmploymentIncome;
        public decimal? CobMonthlyEmplymentIncomeTotalEmploymentIncome { get { return _cobMonthlyEmplymentIncomeTotalEmploymentIncome; } set { _cobMonthlyEmplymentIncomeTotalEmploymentIncome = value; } }
        private DirtyValue<decimal?> _cobNonEmploymentIncomeGovtAssitProgramIncome;
        public decimal? CobNonEmploymentIncomeGovtAssitProgramIncome { get { return _cobNonEmploymentIncomeGovtAssitProgramIncome; } set { _cobNonEmploymentIncomeGovtAssitProgramIncome = value; } }
        private DirtyValue<decimal?> _cobNonEmploymentIncomeHomeownSubsidyIncome;
        public decimal? CobNonEmploymentIncomeHomeownSubsidyIncome { get { return _cobNonEmploymentIncomeHomeownSubsidyIncome; } set { _cobNonEmploymentIncomeHomeownSubsidyIncome = value; } }
        private DirtyValue<decimal?> _cobNonEmploymentIncomeMilitaryIncome;
        public decimal? CobNonEmploymentIncomeMilitaryIncome { get { return _cobNonEmploymentIncomeMilitaryIncome; } set { _cobNonEmploymentIncomeMilitaryIncome = value; } }
        private DirtyValue<decimal?> _cobNonEmploymentIncomeMtgCreditCertificateIncome;
        public decimal? CobNonEmploymentIncomeMtgCreditCertificateIncome { get { return _cobNonEmploymentIncomeMtgCreditCertificateIncome; } set { _cobNonEmploymentIncomeMtgCreditCertificateIncome = value; } }
        private DirtyValue<decimal?> _cobNonEmploymentIncomeTotalNonEmploymentIncome;
        public decimal? CobNonEmploymentIncomeTotalNonEmploymentIncome { get { return _cobNonEmploymentIncomeTotalNonEmploymentIncome; } set { _cobNonEmploymentIncomeTotalNonEmploymentIncome = value; } }
        private DirtyValue<decimal?> _cobNonEmploymentIncomeVABenefitIncome;
        public decimal? CobNonEmploymentIncomeVABenefitIncome { get { return _cobNonEmploymentIncomeVABenefitIncome; } set { _cobNonEmploymentIncomeVABenefitIncome = value; } }
        private DirtyValue<decimal?> _cobNonTaxableIncomeChildSupportIncome;
        public decimal? CobNonTaxableIncomeChildSupportIncome { get { return _cobNonTaxableIncomeChildSupportIncome; } set { _cobNonTaxableIncomeChildSupportIncome = value; } }
        private DirtyValue<decimal?> _cobNonTaxableIncomeDisabilityIncome;
        public decimal? CobNonTaxableIncomeDisabilityIncome { get { return _cobNonTaxableIncomeDisabilityIncome; } set { _cobNonTaxableIncomeDisabilityIncome = value; } }
        private DirtyValue<decimal?> _cobNonTaxableIncomeFedGovtEmplRetirementIncome;
        public decimal? CobNonTaxableIncomeFedGovtEmplRetirementIncome { get { return _cobNonTaxableIncomeFedGovtEmplRetirementIncome; } set { _cobNonTaxableIncomeFedGovtEmplRetirementIncome = value; } }
        private DirtyValue<decimal?> _cobNonTaxableIncomeMilitaryAllowances;
        public decimal? CobNonTaxableIncomeMilitaryAllowances { get { return _cobNonTaxableIncomeMilitaryAllowances; } set { _cobNonTaxableIncomeMilitaryAllowances = value; } }
        private DirtyValue<decimal?> _cobNonTaxableIncomeOtherIncome;
        public decimal? CobNonTaxableIncomeOtherIncome { get { return _cobNonTaxableIncomeOtherIncome; } set { _cobNonTaxableIncomeOtherIncome = value; } }
        private DirtyValue<decimal?> _cobNonTaxableIncomePublicAssistPayments;
        public decimal? CobNonTaxableIncomePublicAssistPayments { get { return _cobNonTaxableIncomePublicAssistPayments; } set { _cobNonTaxableIncomePublicAssistPayments = value; } }
        private DirtyValue<decimal?> _cobNonTaxableIncomeRailroadRetirementBenefits;
        public decimal? CobNonTaxableIncomeRailroadRetirementBenefits { get { return _cobNonTaxableIncomeRailroadRetirementBenefits; } set { _cobNonTaxableIncomeRailroadRetirementBenefits = value; } }
        private DirtyValue<decimal?> _cobNonTaxableIncomeSocialSecurityIncome;
        public decimal? CobNonTaxableIncomeSocialSecurityIncome { get { return _cobNonTaxableIncomeSocialSecurityIncome; } set { _cobNonTaxableIncomeSocialSecurityIncome = value; } }
        private DirtyValue<decimal?> _cobNonTaxableIncomeStateGovtEmplRetirementIncome;
        public decimal? CobNonTaxableIncomeStateGovtEmplRetirementIncome { get { return _cobNonTaxableIncomeStateGovtEmplRetirementIncome; } set { _cobNonTaxableIncomeStateGovtEmplRetirementIncome = value; } }
        private DirtyValue<decimal?> _cobNonTaxableIncomeTotalNonTaxableIncome;
        public decimal? CobNonTaxableIncomeTotalNonTaxableIncome { get { return _cobNonTaxableIncomeTotalNonTaxableIncome; } set { _cobNonTaxableIncomeTotalNonTaxableIncome = value; } }
        private DirtyValue<decimal?> _cobOtherNotesReceivableIncome;
        public decimal? CobOtherNotesReceivableIncome { get { return _cobOtherNotesReceivableIncome; } set { _cobOtherNotesReceivableIncome = value; } }
        private DirtyValue<decimal?> _cobOtherOtherIncome;
        public decimal? CobOtherOtherIncome { get { return _cobOtherOtherIncome; } set { _cobOtherOtherIncome = value; } }
        private DirtyValue<decimal?> _cobOtherParttimeIncome;
        public decimal? CobOtherParttimeIncome { get { return _cobOtherParttimeIncome; } set { _cobOtherParttimeIncome = value; } }
        private DirtyValue<decimal?> _cobOtherRetirementIncome;
        public decimal? CobOtherRetirementIncome { get { return _cobOtherRetirementIncome; } set { _cobOtherRetirementIncome = value; } }
        private DirtyValue<decimal?> _cobOtherSeasonalIncome;
        public decimal? CobOtherSeasonalIncome { get { return _cobOtherSeasonalIncome; } set { _cobOtherSeasonalIncome = value; } }
        private DirtyValue<decimal?> _cobOtherSocialSecurityIncome;
        public decimal? CobOtherSocialSecurityIncome { get { return _cobOtherSocialSecurityIncome; } set { _cobOtherSocialSecurityIncome = value; } }
        private DirtyValue<decimal?> _cobOtherTipIncome;
        public decimal? CobOtherTipIncome { get { return _cobOtherTipIncome; } set { _cobOtherTipIncome = value; } }
        private DirtyValue<decimal?> _cobOtherTrustIncome;
        public decimal? CobOtherTrustIncome { get { return _cobOtherTrustIncome; } set { _cobOtherTrustIncome = value; } }
        private DirtyValue<decimal?> _cobOtherUnemploymentIncome;
        public decimal? CobOtherUnemploymentIncome { get { return _cobOtherUnemploymentIncome; } set { _cobOtherUnemploymentIncome = value; } }
        private DirtyValue<decimal?> _cobOvertimeAverageOvertime;
        public decimal? CobOvertimeAverageOvertime { get { return _cobOvertimeAverageOvertime; } set { _cobOvertimeAverageOvertime = value; } }
        private DirtyValue<decimal?> _cobOvertimeMostRecentAmount;
        public decimal? CobOvertimeMostRecentAmount { get { return _cobOvertimeMostRecentAmount; } set { _cobOvertimeMostRecentAmount = value; } }
        private DirtyValue<int?> _cobOvertimeMostRecentMonths;
        public int? CobOvertimeMostRecentMonths { get { return _cobOvertimeMostRecentMonths; } set { _cobOvertimeMostRecentMonths = value; } }
        private DirtyValue<int?> _cobOvertimeMostRecentYear;
        public int? CobOvertimeMostRecentYear { get { return _cobOvertimeMostRecentYear; } set { _cobOvertimeMostRecentYear = value; } }
        private DirtyValue<decimal?> _cobOvertimePreviousAmount1;
        public decimal? CobOvertimePreviousAmount1 { get { return _cobOvertimePreviousAmount1; } set { _cobOvertimePreviousAmount1 = value; } }
        private DirtyValue<decimal?> _cobOvertimePreviousAmount2;
        public decimal? CobOvertimePreviousAmount2 { get { return _cobOvertimePreviousAmount2; } set { _cobOvertimePreviousAmount2 = value; } }
        private DirtyValue<int?> _cobOvertimePreviousMonths1;
        public int? CobOvertimePreviousMonths1 { get { return _cobOvertimePreviousMonths1; } set { _cobOvertimePreviousMonths1 = value; } }
        private DirtyValue<int?> _cobOvertimePreviousMonths2;
        public int? CobOvertimePreviousMonths2 { get { return _cobOvertimePreviousMonths2; } set { _cobOvertimePreviousMonths2 = value; } }
        private DirtyValue<int?> _cobOvertimePreviousYear1;
        public int? CobOvertimePreviousYear1 { get { return _cobOvertimePreviousYear1; } set { _cobOvertimePreviousYear1 = value; } }
        private DirtyValue<int?> _cobOvertimePreviousYear2;
        public int? CobOvertimePreviousYear2 { get { return _cobOvertimePreviousYear2; } set { _cobOvertimePreviousYear2 = value; } }
        private DirtyValue<decimal?> _cobProjectedIncomeProjectedBonuses;
        public decimal? CobProjectedIncomeProjectedBonuses { get { return _cobProjectedIncomeProjectedBonuses; } set { _cobProjectedIncomeProjectedBonuses = value; } }
        private DirtyValue<decimal?> _cobProjectedIncomeProjectedCostLivingAdjustment;
        public decimal? CobProjectedIncomeProjectedCostLivingAdjustment { get { return _cobProjectedIncomeProjectedCostLivingAdjustment; } set { _cobProjectedIncomeProjectedCostLivingAdjustment = value; } }
        private DirtyValue<decimal?> _cobProjectedIncomeProjectedNewJobIncome;
        public decimal? CobProjectedIncomeProjectedNewJobIncome { get { return _cobProjectedIncomeProjectedNewJobIncome; } set { _cobProjectedIncomeProjectedNewJobIncome = value; } }
        private DirtyValue<decimal?> _cobProjectedIncomeProjectedPerformanceRaises;
        public decimal? CobProjectedIncomeProjectedPerformanceRaises { get { return _cobProjectedIncomeProjectedPerformanceRaises; } set { _cobProjectedIncomeProjectedPerformanceRaises = value; } }
        private DirtyValue<decimal?> _cobProjectedIncomeTotalProjectedIncome;
        public decimal? CobProjectedIncomeTotalProjectedIncome { get { return _cobProjectedIncomeTotalProjectedIncome; } set { _cobProjectedIncomeTotalProjectedIncome = value; } }
        private DirtyValue<string> _dUCaseIDorLPAUSKey;
        public string DUCaseIDorLPAUSKey { get { return _dUCaseIDorLPAUSKey; } set { _dUCaseIDorLPAUSKey = value; } }
        private DirtyValue<DateTime?> _firstSubmissionDate;
        public DateTime? FirstSubmissionDate { get { return _firstSubmissionDate; } set { _firstSubmissionDate = value; } }
        private DirtyValue<string> _firstSubmissionTime;
        public string FirstSubmissionTime { get { return _firstSubmissionTime; } set { _firstSubmissionTime = value; } }
        private DirtyValue<string> _freddieDocClass;
        public string FreddieDocClass { get { return _freddieDocClass; } set { _freddieDocClass = value; } }
        private DirtyValue<decimal?> _housingRatio;
        public decimal? HousingRatio { get { return _housingRatio; } set { _housingRatio = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _isEmpty;
        public bool? IsEmpty { get { return _isEmpty; } set { _isEmpty = value; } }
        private DirtyValue<DateTime?> _submissionDate;
        public DateTime? SubmissionDate { get { return _submissionDate; } set { _submissionDate = value; } }
        private DirtyValue<string> _submissionNumber;
        public string SubmissionNumber { get { return _submissionNumber; } set { _submissionNumber = value; } }
        private DirtyValue<string> _submissionTime;
        public string SubmissionTime { get { return _submissionTime; } set { _submissionTime = value; } }
        private DirtyValue<string> _submittedBy;
        public string SubmittedBy { get { return _submittedBy; } set { _submittedBy = value; } }
        private DirtyValue<decimal?> _totalExpenseRatio;
        public decimal? TotalExpenseRatio { get { return _totalExpenseRatio; } set { _totalExpenseRatio = value; } }
        private DirtyValue<decimal?> _totalHousingPayment;
        public decimal? TotalHousingPayment { get { return _totalHousingPayment; } set { _totalHousingPayment = value; } }
        private DirtyValue<decimal?> _totalMonthlyAssets;
        public decimal? TotalMonthlyAssets { get { return _totalMonthlyAssets; } set { _totalMonthlyAssets = value; } }
        private DirtyValue<decimal?> _totalMonthlyDebt;
        public decimal? TotalMonthlyDebt { get { return _totalMonthlyDebt; } set { _totalMonthlyDebt = value; } }
        private DirtyValue<decimal?> _totalMonthlyIncome;
        public decimal? TotalMonthlyIncome { get { return _totalMonthlyIncome; } set { _totalMonthlyIncome = value; } }
        private DirtyValue<string> _underwritingRiskAssessOther;
        public string UnderwritingRiskAssessOther { get { return _underwritingRiskAssessOther; } set { _underwritingRiskAssessOther = value; } }
        private DirtyValue<string> _underwritingRiskAssessType;
        public string UnderwritingRiskAssessType { get { return _underwritingRiskAssessType; } set { _underwritingRiskAssessType = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _aTRQMBorrowerIndex.Dirty
                    || _aUSRecommendation.Dirty
                    || _aUSVersion.Dirty
                    || _borBonusAverageOvertime.Dirty
                    || _borBonusMostRecentAmount.Dirty
                    || _borBonusMostRecentMonths.Dirty
                    || _borBonusMostRecentYear.Dirty
                    || _borBonusPreviousAmount1.Dirty
                    || _borBonusPreviousAmount2.Dirty
                    || _borBonusPreviousMonths1.Dirty
                    || _borBonusPreviousMonths2.Dirty
                    || _borBonusPreviousYear1.Dirty
                    || _borBonusPreviousYear2.Dirty
                    || _borCommissionAverageOvertime.Dirty
                    || _borCommissionMostRecentAmount.Dirty
                    || _borCommissionMostRecentMonths.Dirty
                    || _borCommissionMostRecentYear.Dirty
                    || _borCommissionPreviousAmount1.Dirty
                    || _borCommissionPreviousAmount2.Dirty
                    || _borCommissionPreviousMonths1.Dirty
                    || _borCommissionPreviousMonths2.Dirty
                    || _borCommissionPreviousYear1.Dirty
                    || _borCommissionPreviousYear2.Dirty
                    || _borContingentLiabilitiesLiabilityAmount1.Dirty
                    || _borContingentLiabilitiesLiabilityAmount2.Dirty
                    || _borContingentLiabilitiesLiabilityAmount3.Dirty
                    || _borContingentLiabilitiesLiabilityDescription1.Dirty
                    || _borContingentLiabilitiesLiabilityDescription2.Dirty
                    || _borContingentLiabilitiesLiabilityDescription3.Dirty
                    || _borContingentLiabilitiesTotalLiabilityAmount.Dirty
                    || _borCosignedObligationsCarLoanPayment.Dirty
                    || _borCosignedObligationsMortgagePayment.Dirty
                    || _borCosignedObligationsOtherPayment.Dirty
                    || _borCosignedObligationsOtherPaymentDescription.Dirty
                    || _borCosignedObligationsStudentLoanPayment.Dirty
                    || _borCosignedObligationsTotalCoMortgagorLiabilities.Dirty
                    || _borDividendAverageDividend.Dirty
                    || _borDividendPreviousAmount1.Dirty
                    || _borDividendPreviousAmount2.Dirty
                    || _borDividendPreviousMonths1.Dirty
                    || _borDividendPreviousMonths2.Dirty
                    || _borDividendPreviousYear1.Dirty
                    || _borDividendPreviousYear2.Dirty
                    || _borDividendRequiredForCashAmount.Dirty
                    || _borInterestAverageDividend.Dirty
                    || _borInterestPreviousAmount1.Dirty
                    || _borInterestPreviousAmount2.Dirty
                    || _borInterestPreviousMonths1.Dirty
                    || _borInterestPreviousMonths2.Dirty
                    || _borInterestPreviousYear1.Dirty
                    || _borInterestPreviousYear2.Dirty
                    || _borInterestRequiredForCashAmount.Dirty
                    || _borMilitaryAllowanceClothingAllowance.Dirty
                    || _borMilitaryAllowanceOtherAllowance.Dirty
                    || _borMilitaryAllowanceOtherAllowanceDescription.Dirty
                    || _borMilitaryAllowanceQuartersAllowance.Dirty
                    || _borMilitaryAllowanceRationsAllowance.Dirty
                    || _borMilitaryAllowanceTotalAllowance.Dirty
                    || _borMilitaryAllowanceVariableHousingAllowance.Dirty
                    || _borMilitaryBasePay.Dirty
                    || _borMilitaryCombatPay.Dirty
                    || _borMilitaryFlightPay.Dirty
                    || _borMilitaryHazardPay.Dirty
                    || _borMilitaryOverseasPay.Dirty
                    || _borMilitaryPropPay.Dirty
                    || _borMilitaryTotalPay.Dirty
                    || _borMonthlyEmplymentIncomeBaseIncome.Dirty
                    || _borMonthlyEmplymentIncomeBonuseIncome.Dirty
                    || _borMonthlyEmplymentIncomeCommissionIncome.Dirty
                    || _borMonthlyEmplymentIncomeDividendInterestIncome.Dirty
                    || _borMonthlyEmplymentIncomeOtherIncome1.Dirty
                    || _borMonthlyEmplymentIncomeOtherIncome2.Dirty
                    || _borMonthlyEmplymentIncomeOvertimeIncome.Dirty
                    || _borMonthlyEmplymentIncomeTotalEmploymentIncome.Dirty
                    || _borNonEmploymentIncomeGovtAssitProgramIncome.Dirty
                    || _borNonEmploymentIncomeHomeownSubsidyIncome.Dirty
                    || _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome.Dirty
                    || _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome.Dirty
                    || _borNonEmploymentIncomeMilitaryIncome.Dirty
                    || _borNonEmploymentIncomeMtgCreditCertificateIncome.Dirty
                    || _borNonEmploymentIncomeTotalNonEmploymentIncome.Dirty
                    || _borNonEmploymentIncomeVABenefitIncome.Dirty
                    || _borNonTaxableIncomeChildSupportIncome.Dirty
                    || _borNonTaxableIncomeDisabilityIncome.Dirty
                    || _borNonTaxableIncomeFedGovtEmplRetirementIncome.Dirty
                    || _borNonTaxableIncomeMilitaryAllowances.Dirty
                    || _borNonTaxableIncomeOtherIncome.Dirty
                    || _borNonTaxableIncomePublicAssistPayments.Dirty
                    || _borNonTaxableIncomeRailroadRetirementBenefits.Dirty
                    || _borNonTaxableIncomeSocialSecurityIncome.Dirty
                    || _borNonTaxableIncomeStateGovtEmplRetirementIncome.Dirty
                    || _borNonTaxableIncomeTotalNonTaxableIncome.Dirty
                    || _borOtherNotesReceivableIncome.Dirty
                    || _borOtherOtherIncome.Dirty
                    || _borOtherParttimeIncome.Dirty
                    || _borOtherRetirementIncome.Dirty
                    || _borOtherSeasonalIncome.Dirty
                    || _borOtherSocialSecurityIncome.Dirty
                    || _borOtherTipIncome.Dirty
                    || _borOtherTrustIncome.Dirty
                    || _borOtherUnemploymentIncome.Dirty
                    || _borOvertimeAverageOvertime.Dirty
                    || _borOvertimeMostRecentAmount.Dirty
                    || _borOvertimeMostRecentMonths.Dirty
                    || _borOvertimeMostRecentYear.Dirty
                    || _borOvertimePreviousAmount1.Dirty
                    || _borOvertimePreviousAmount2.Dirty
                    || _borOvertimePreviousMonths1.Dirty
                    || _borOvertimePreviousMonths2.Dirty
                    || _borOvertimePreviousYear1.Dirty
                    || _borOvertimePreviousYear2.Dirty
                    || _borProjectedIncomeProjectedBonuses.Dirty
                    || _borProjectedIncomeProjectedCostLivingAdjustment.Dirty
                    || _borProjectedIncomeProjectedNewJobIncome.Dirty
                    || _borProjectedIncomeProjectedPerformanceRaises.Dirty
                    || _borProjectedIncomeTotalProjectedIncome.Dirty
                    || _cobBonusAverageOvertime.Dirty
                    || _cobBonusMostRecentAmount.Dirty
                    || _cobBonusMostRecentMonths.Dirty
                    || _cobBonusMostRecentYear.Dirty
                    || _cobBonusPreviousAmount1.Dirty
                    || _cobBonusPreviousAmount2.Dirty
                    || _cobBonusPreviousMonths1.Dirty
                    || _cobBonusPreviousMonths2.Dirty
                    || _cobBonusPreviousYear1.Dirty
                    || _cobBonusPreviousYear2.Dirty
                    || _cobCommissionAverageOvertime.Dirty
                    || _cobCommissionMostRecentAmount.Dirty
                    || _cobCommissionMostRecentMonths.Dirty
                    || _cobCommissionMostRecentYear.Dirty
                    || _cobCommissionPreviousAmount1.Dirty
                    || _cobCommissionPreviousAmount2.Dirty
                    || _cobCommissionPreviousMonths1.Dirty
                    || _cobCommissionPreviousMonths2.Dirty
                    || _cobCommissionPreviousYear1.Dirty
                    || _cobCommissionPreviousYear2.Dirty
                    || _cobDividendAverageDividend.Dirty
                    || _cobDividendPreviousAmount1.Dirty
                    || _cobDividendPreviousAmount2.Dirty
                    || _cobDividendPreviousMonths1.Dirty
                    || _cobDividendPreviousMonths2.Dirty
                    || _cobDividendPreviousYear1.Dirty
                    || _cobDividendPreviousYear2.Dirty
                    || _cobDividendRequiredForCashAmount.Dirty
                    || _cobInterestAverageDividend.Dirty
                    || _cobInterestPreviousAmount1.Dirty
                    || _cobInterestPreviousAmount2.Dirty
                    || _cobInterestPreviousMonths1.Dirty
                    || _cobInterestPreviousMonths2.Dirty
                    || _cobInterestPreviousYear1.Dirty
                    || _cobInterestPreviousYear2.Dirty
                    || _cobInterestRequiredForCashAmount.Dirty
                    || _cobMilitaryAllowanceClothingAllowance.Dirty
                    || _cobMilitaryAllowanceOtherAllowance.Dirty
                    || _cobMilitaryAllowanceQuartersAllowance.Dirty
                    || _cobMilitaryAllowanceRationsAllowance.Dirty
                    || _cobMilitaryAllowanceTotalAllowance.Dirty
                    || _cobMilitaryAllowanceVariableHousingAllowance.Dirty
                    || _cobMilitaryBasePay.Dirty
                    || _cobMilitaryCombatPay.Dirty
                    || _cobMilitaryFlightPay.Dirty
                    || _cobMilitaryHazardPay.Dirty
                    || _cobMilitaryOverseasPay.Dirty
                    || _cobMilitaryPropPay.Dirty
                    || _cobMilitaryTotalPay.Dirty
                    || _cobMonthlyEmplymentIncomeBaseIncome.Dirty
                    || _cobMonthlyEmplymentIncomeBonuseIncome.Dirty
                    || _cobMonthlyEmplymentIncomeCommissionIncome.Dirty
                    || _cobMonthlyEmplymentIncomeDividendInterestIncome.Dirty
                    || _cobMonthlyEmplymentIncomeOtherIncome1.Dirty
                    || _cobMonthlyEmplymentIncomeOtherIncome2.Dirty
                    || _cobMonthlyEmplymentIncomeOvertimeIncome.Dirty
                    || _cobMonthlyEmplymentIncomeTotalEmploymentIncome.Dirty
                    || _cobNonEmploymentIncomeGovtAssitProgramIncome.Dirty
                    || _cobNonEmploymentIncomeHomeownSubsidyIncome.Dirty
                    || _cobNonEmploymentIncomeMilitaryIncome.Dirty
                    || _cobNonEmploymentIncomeMtgCreditCertificateIncome.Dirty
                    || _cobNonEmploymentIncomeTotalNonEmploymentIncome.Dirty
                    || _cobNonEmploymentIncomeVABenefitIncome.Dirty
                    || _cobNonTaxableIncomeChildSupportIncome.Dirty
                    || _cobNonTaxableIncomeDisabilityIncome.Dirty
                    || _cobNonTaxableIncomeFedGovtEmplRetirementIncome.Dirty
                    || _cobNonTaxableIncomeMilitaryAllowances.Dirty
                    || _cobNonTaxableIncomeOtherIncome.Dirty
                    || _cobNonTaxableIncomePublicAssistPayments.Dirty
                    || _cobNonTaxableIncomeRailroadRetirementBenefits.Dirty
                    || _cobNonTaxableIncomeSocialSecurityIncome.Dirty
                    || _cobNonTaxableIncomeStateGovtEmplRetirementIncome.Dirty
                    || _cobNonTaxableIncomeTotalNonTaxableIncome.Dirty
                    || _cobOtherNotesReceivableIncome.Dirty
                    || _cobOtherOtherIncome.Dirty
                    || _cobOtherParttimeIncome.Dirty
                    || _cobOtherRetirementIncome.Dirty
                    || _cobOtherSeasonalIncome.Dirty
                    || _cobOtherSocialSecurityIncome.Dirty
                    || _cobOtherTipIncome.Dirty
                    || _cobOtherTrustIncome.Dirty
                    || _cobOtherUnemploymentIncome.Dirty
                    || _cobOvertimeAverageOvertime.Dirty
                    || _cobOvertimeMostRecentAmount.Dirty
                    || _cobOvertimeMostRecentMonths.Dirty
                    || _cobOvertimeMostRecentYear.Dirty
                    || _cobOvertimePreviousAmount1.Dirty
                    || _cobOvertimePreviousAmount2.Dirty
                    || _cobOvertimePreviousMonths1.Dirty
                    || _cobOvertimePreviousMonths2.Dirty
                    || _cobOvertimePreviousYear1.Dirty
                    || _cobOvertimePreviousYear2.Dirty
                    || _cobProjectedIncomeProjectedBonuses.Dirty
                    || _cobProjectedIncomeProjectedCostLivingAdjustment.Dirty
                    || _cobProjectedIncomeProjectedNewJobIncome.Dirty
                    || _cobProjectedIncomeProjectedPerformanceRaises.Dirty
                    || _cobProjectedIncomeTotalProjectedIncome.Dirty
                    || _dUCaseIDorLPAUSKey.Dirty
                    || _firstSubmissionDate.Dirty
                    || _firstSubmissionTime.Dirty
                    || _freddieDocClass.Dirty
                    || _housingRatio.Dirty
                    || _id.Dirty
                    || _isEmpty.Dirty
                    || _submissionDate.Dirty
                    || _submissionNumber.Dirty
                    || _submissionTime.Dirty
                    || _submittedBy.Dirty
                    || _totalExpenseRatio.Dirty
                    || _totalHousingPayment.Dirty
                    || _totalMonthlyAssets.Dirty
                    || _totalMonthlyDebt.Dirty
                    || _totalMonthlyIncome.Dirty
                    || _underwritingRiskAssessOther.Dirty
                    || _underwritingRiskAssessType.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _aTRQMBorrowerIndex.Dirty = value;
                _aUSRecommendation.Dirty = value;
                _aUSVersion.Dirty = value;
                _borBonusAverageOvertime.Dirty = value;
                _borBonusMostRecentAmount.Dirty = value;
                _borBonusMostRecentMonths.Dirty = value;
                _borBonusMostRecentYear.Dirty = value;
                _borBonusPreviousAmount1.Dirty = value;
                _borBonusPreviousAmount2.Dirty = value;
                _borBonusPreviousMonths1.Dirty = value;
                _borBonusPreviousMonths2.Dirty = value;
                _borBonusPreviousYear1.Dirty = value;
                _borBonusPreviousYear2.Dirty = value;
                _borCommissionAverageOvertime.Dirty = value;
                _borCommissionMostRecentAmount.Dirty = value;
                _borCommissionMostRecentMonths.Dirty = value;
                _borCommissionMostRecentYear.Dirty = value;
                _borCommissionPreviousAmount1.Dirty = value;
                _borCommissionPreviousAmount2.Dirty = value;
                _borCommissionPreviousMonths1.Dirty = value;
                _borCommissionPreviousMonths2.Dirty = value;
                _borCommissionPreviousYear1.Dirty = value;
                _borCommissionPreviousYear2.Dirty = value;
                _borContingentLiabilitiesLiabilityAmount1.Dirty = value;
                _borContingentLiabilitiesLiabilityAmount2.Dirty = value;
                _borContingentLiabilitiesLiabilityAmount3.Dirty = value;
                _borContingentLiabilitiesLiabilityDescription1.Dirty = value;
                _borContingentLiabilitiesLiabilityDescription2.Dirty = value;
                _borContingentLiabilitiesLiabilityDescription3.Dirty = value;
                _borContingentLiabilitiesTotalLiabilityAmount.Dirty = value;
                _borCosignedObligationsCarLoanPayment.Dirty = value;
                _borCosignedObligationsMortgagePayment.Dirty = value;
                _borCosignedObligationsOtherPayment.Dirty = value;
                _borCosignedObligationsOtherPaymentDescription.Dirty = value;
                _borCosignedObligationsStudentLoanPayment.Dirty = value;
                _borCosignedObligationsTotalCoMortgagorLiabilities.Dirty = value;
                _borDividendAverageDividend.Dirty = value;
                _borDividendPreviousAmount1.Dirty = value;
                _borDividendPreviousAmount2.Dirty = value;
                _borDividendPreviousMonths1.Dirty = value;
                _borDividendPreviousMonths2.Dirty = value;
                _borDividendPreviousYear1.Dirty = value;
                _borDividendPreviousYear2.Dirty = value;
                _borDividendRequiredForCashAmount.Dirty = value;
                _borInterestAverageDividend.Dirty = value;
                _borInterestPreviousAmount1.Dirty = value;
                _borInterestPreviousAmount2.Dirty = value;
                _borInterestPreviousMonths1.Dirty = value;
                _borInterestPreviousMonths2.Dirty = value;
                _borInterestPreviousYear1.Dirty = value;
                _borInterestPreviousYear2.Dirty = value;
                _borInterestRequiredForCashAmount.Dirty = value;
                _borMilitaryAllowanceClothingAllowance.Dirty = value;
                _borMilitaryAllowanceOtherAllowance.Dirty = value;
                _borMilitaryAllowanceOtherAllowanceDescription.Dirty = value;
                _borMilitaryAllowanceQuartersAllowance.Dirty = value;
                _borMilitaryAllowanceRationsAllowance.Dirty = value;
                _borMilitaryAllowanceTotalAllowance.Dirty = value;
                _borMilitaryAllowanceVariableHousingAllowance.Dirty = value;
                _borMilitaryBasePay.Dirty = value;
                _borMilitaryCombatPay.Dirty = value;
                _borMilitaryFlightPay.Dirty = value;
                _borMilitaryHazardPay.Dirty = value;
                _borMilitaryOverseasPay.Dirty = value;
                _borMilitaryPropPay.Dirty = value;
                _borMilitaryTotalPay.Dirty = value;
                _borMonthlyEmplymentIncomeBaseIncome.Dirty = value;
                _borMonthlyEmplymentIncomeBonuseIncome.Dirty = value;
                _borMonthlyEmplymentIncomeCommissionIncome.Dirty = value;
                _borMonthlyEmplymentIncomeDividendInterestIncome.Dirty = value;
                _borMonthlyEmplymentIncomeOtherIncome1.Dirty = value;
                _borMonthlyEmplymentIncomeOtherIncome2.Dirty = value;
                _borMonthlyEmplymentIncomeOvertimeIncome.Dirty = value;
                _borMonthlyEmplymentIncomeTotalEmploymentIncome.Dirty = value;
                _borNonEmploymentIncomeGovtAssitProgramIncome.Dirty = value;
                _borNonEmploymentIncomeHomeownSubsidyIncome.Dirty = value;
                _borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome.Dirty = value;
                _borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome.Dirty = value;
                _borNonEmploymentIncomeMilitaryIncome.Dirty = value;
                _borNonEmploymentIncomeMtgCreditCertificateIncome.Dirty = value;
                _borNonEmploymentIncomeTotalNonEmploymentIncome.Dirty = value;
                _borNonEmploymentIncomeVABenefitIncome.Dirty = value;
                _borNonTaxableIncomeChildSupportIncome.Dirty = value;
                _borNonTaxableIncomeDisabilityIncome.Dirty = value;
                _borNonTaxableIncomeFedGovtEmplRetirementIncome.Dirty = value;
                _borNonTaxableIncomeMilitaryAllowances.Dirty = value;
                _borNonTaxableIncomeOtherIncome.Dirty = value;
                _borNonTaxableIncomePublicAssistPayments.Dirty = value;
                _borNonTaxableIncomeRailroadRetirementBenefits.Dirty = value;
                _borNonTaxableIncomeSocialSecurityIncome.Dirty = value;
                _borNonTaxableIncomeStateGovtEmplRetirementIncome.Dirty = value;
                _borNonTaxableIncomeTotalNonTaxableIncome.Dirty = value;
                _borOtherNotesReceivableIncome.Dirty = value;
                _borOtherOtherIncome.Dirty = value;
                _borOtherParttimeIncome.Dirty = value;
                _borOtherRetirementIncome.Dirty = value;
                _borOtherSeasonalIncome.Dirty = value;
                _borOtherSocialSecurityIncome.Dirty = value;
                _borOtherTipIncome.Dirty = value;
                _borOtherTrustIncome.Dirty = value;
                _borOtherUnemploymentIncome.Dirty = value;
                _borOvertimeAverageOvertime.Dirty = value;
                _borOvertimeMostRecentAmount.Dirty = value;
                _borOvertimeMostRecentMonths.Dirty = value;
                _borOvertimeMostRecentYear.Dirty = value;
                _borOvertimePreviousAmount1.Dirty = value;
                _borOvertimePreviousAmount2.Dirty = value;
                _borOvertimePreviousMonths1.Dirty = value;
                _borOvertimePreviousMonths2.Dirty = value;
                _borOvertimePreviousYear1.Dirty = value;
                _borOvertimePreviousYear2.Dirty = value;
                _borProjectedIncomeProjectedBonuses.Dirty = value;
                _borProjectedIncomeProjectedCostLivingAdjustment.Dirty = value;
                _borProjectedIncomeProjectedNewJobIncome.Dirty = value;
                _borProjectedIncomeProjectedPerformanceRaises.Dirty = value;
                _borProjectedIncomeTotalProjectedIncome.Dirty = value;
                _cobBonusAverageOvertime.Dirty = value;
                _cobBonusMostRecentAmount.Dirty = value;
                _cobBonusMostRecentMonths.Dirty = value;
                _cobBonusMostRecentYear.Dirty = value;
                _cobBonusPreviousAmount1.Dirty = value;
                _cobBonusPreviousAmount2.Dirty = value;
                _cobBonusPreviousMonths1.Dirty = value;
                _cobBonusPreviousMonths2.Dirty = value;
                _cobBonusPreviousYear1.Dirty = value;
                _cobBonusPreviousYear2.Dirty = value;
                _cobCommissionAverageOvertime.Dirty = value;
                _cobCommissionMostRecentAmount.Dirty = value;
                _cobCommissionMostRecentMonths.Dirty = value;
                _cobCommissionMostRecentYear.Dirty = value;
                _cobCommissionPreviousAmount1.Dirty = value;
                _cobCommissionPreviousAmount2.Dirty = value;
                _cobCommissionPreviousMonths1.Dirty = value;
                _cobCommissionPreviousMonths2.Dirty = value;
                _cobCommissionPreviousYear1.Dirty = value;
                _cobCommissionPreviousYear2.Dirty = value;
                _cobDividendAverageDividend.Dirty = value;
                _cobDividendPreviousAmount1.Dirty = value;
                _cobDividendPreviousAmount2.Dirty = value;
                _cobDividendPreviousMonths1.Dirty = value;
                _cobDividendPreviousMonths2.Dirty = value;
                _cobDividendPreviousYear1.Dirty = value;
                _cobDividendPreviousYear2.Dirty = value;
                _cobDividendRequiredForCashAmount.Dirty = value;
                _cobInterestAverageDividend.Dirty = value;
                _cobInterestPreviousAmount1.Dirty = value;
                _cobInterestPreviousAmount2.Dirty = value;
                _cobInterestPreviousMonths1.Dirty = value;
                _cobInterestPreviousMonths2.Dirty = value;
                _cobInterestPreviousYear1.Dirty = value;
                _cobInterestPreviousYear2.Dirty = value;
                _cobInterestRequiredForCashAmount.Dirty = value;
                _cobMilitaryAllowanceClothingAllowance.Dirty = value;
                _cobMilitaryAllowanceOtherAllowance.Dirty = value;
                _cobMilitaryAllowanceQuartersAllowance.Dirty = value;
                _cobMilitaryAllowanceRationsAllowance.Dirty = value;
                _cobMilitaryAllowanceTotalAllowance.Dirty = value;
                _cobMilitaryAllowanceVariableHousingAllowance.Dirty = value;
                _cobMilitaryBasePay.Dirty = value;
                _cobMilitaryCombatPay.Dirty = value;
                _cobMilitaryFlightPay.Dirty = value;
                _cobMilitaryHazardPay.Dirty = value;
                _cobMilitaryOverseasPay.Dirty = value;
                _cobMilitaryPropPay.Dirty = value;
                _cobMilitaryTotalPay.Dirty = value;
                _cobMonthlyEmplymentIncomeBaseIncome.Dirty = value;
                _cobMonthlyEmplymentIncomeBonuseIncome.Dirty = value;
                _cobMonthlyEmplymentIncomeCommissionIncome.Dirty = value;
                _cobMonthlyEmplymentIncomeDividendInterestIncome.Dirty = value;
                _cobMonthlyEmplymentIncomeOtherIncome1.Dirty = value;
                _cobMonthlyEmplymentIncomeOtherIncome2.Dirty = value;
                _cobMonthlyEmplymentIncomeOvertimeIncome.Dirty = value;
                _cobMonthlyEmplymentIncomeTotalEmploymentIncome.Dirty = value;
                _cobNonEmploymentIncomeGovtAssitProgramIncome.Dirty = value;
                _cobNonEmploymentIncomeHomeownSubsidyIncome.Dirty = value;
                _cobNonEmploymentIncomeMilitaryIncome.Dirty = value;
                _cobNonEmploymentIncomeMtgCreditCertificateIncome.Dirty = value;
                _cobNonEmploymentIncomeTotalNonEmploymentIncome.Dirty = value;
                _cobNonEmploymentIncomeVABenefitIncome.Dirty = value;
                _cobNonTaxableIncomeChildSupportIncome.Dirty = value;
                _cobNonTaxableIncomeDisabilityIncome.Dirty = value;
                _cobNonTaxableIncomeFedGovtEmplRetirementIncome.Dirty = value;
                _cobNonTaxableIncomeMilitaryAllowances.Dirty = value;
                _cobNonTaxableIncomeOtherIncome.Dirty = value;
                _cobNonTaxableIncomePublicAssistPayments.Dirty = value;
                _cobNonTaxableIncomeRailroadRetirementBenefits.Dirty = value;
                _cobNonTaxableIncomeSocialSecurityIncome.Dirty = value;
                _cobNonTaxableIncomeStateGovtEmplRetirementIncome.Dirty = value;
                _cobNonTaxableIncomeTotalNonTaxableIncome.Dirty = value;
                _cobOtherNotesReceivableIncome.Dirty = value;
                _cobOtherOtherIncome.Dirty = value;
                _cobOtherParttimeIncome.Dirty = value;
                _cobOtherRetirementIncome.Dirty = value;
                _cobOtherSeasonalIncome.Dirty = value;
                _cobOtherSocialSecurityIncome.Dirty = value;
                _cobOtherTipIncome.Dirty = value;
                _cobOtherTrustIncome.Dirty = value;
                _cobOtherUnemploymentIncome.Dirty = value;
                _cobOvertimeAverageOvertime.Dirty = value;
                _cobOvertimeMostRecentAmount.Dirty = value;
                _cobOvertimeMostRecentMonths.Dirty = value;
                _cobOvertimeMostRecentYear.Dirty = value;
                _cobOvertimePreviousAmount1.Dirty = value;
                _cobOvertimePreviousAmount2.Dirty = value;
                _cobOvertimePreviousMonths1.Dirty = value;
                _cobOvertimePreviousMonths2.Dirty = value;
                _cobOvertimePreviousYear1.Dirty = value;
                _cobOvertimePreviousYear2.Dirty = value;
                _cobProjectedIncomeProjectedBonuses.Dirty = value;
                _cobProjectedIncomeProjectedCostLivingAdjustment.Dirty = value;
                _cobProjectedIncomeProjectedNewJobIncome.Dirty = value;
                _cobProjectedIncomeProjectedPerformanceRaises.Dirty = value;
                _cobProjectedIncomeTotalProjectedIncome.Dirty = value;
                _dUCaseIDorLPAUSKey.Dirty = value;
                _firstSubmissionDate.Dirty = value;
                _firstSubmissionTime.Dirty = value;
                _freddieDocClass.Dirty = value;
                _housingRatio.Dirty = value;
                _id.Dirty = value;
                _isEmpty.Dirty = value;
                _submissionDate.Dirty = value;
                _submissionNumber.Dirty = value;
                _submissionTime.Dirty = value;
                _submittedBy.Dirty = value;
                _totalExpenseRatio.Dirty = value;
                _totalHousingPayment.Dirty = value;
                _totalMonthlyAssets.Dirty = value;
                _totalMonthlyDebt.Dirty = value;
                _totalMonthlyIncome.Dirty = value;
                _underwritingRiskAssessOther.Dirty = value;
                _underwritingRiskAssessType.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}