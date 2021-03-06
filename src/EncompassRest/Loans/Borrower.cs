#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Borrower : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _acountChekAssetId;
        public string AcountChekAssetId { get => _acountChekAssetId; set => _acountChekAssetId = value; }
        private DirtyValue<int?> _ageAtApplicationYearsCount;
        public int? AgeAtApplicationYearsCount { get => _ageAtApplicationYearsCount; set => _ageAtApplicationYearsCount = value; }
        private DirtyValue<string> _aliasName;
        public string AliasName { get => _aliasName; set => _aliasName = value; }
        private DirtyValue<bool?> _alimonyChildSupportObligationIndicator;
        public bool? AlimonyChildSupportObligationIndicator { get => _alimonyChildSupportObligationIndicator; set => _alimonyChildSupportObligationIndicator = value; }
        private DirtyValue<string> _altId;
        public string AltId { get => _altId; set => _altId = value; }
        private DirtyValue<string> _applicantType;
        public string ApplicantType { get => _applicantType; set => _applicantType = value; }
        private Application _application;
        public Application Application { get => _application ?? (_application = new Application()); set => _application = value; }
        private DirtyValue<StringEnumValue<ApplicationTakenMethodType>> _applicationTakenMethodType;
        public StringEnumValue<ApplicationTakenMethodType> ApplicationTakenMethodType { get => _applicationTakenMethodType; set => _applicationTakenMethodType = value; }
        private DirtyValue<string> _assetRepAndWarrantyMessage;
        public string AssetRepAndWarrantyMessage { get => _assetRepAndWarrantyMessage; set => _assetRepAndWarrantyMessage = value; }
        private DirtyValue<bool?> _assetRepAndWarrantyReliefAvailable;
        public bool? AssetRepAndWarrantyReliefAvailable { get => _assetRepAndWarrantyReliefAvailable; set => _assetRepAndWarrantyReliefAvailable = value; }
        private DirtyValue<bool?> _authorizedCreditReportIndicator;
        public bool? AuthorizedCreditReportIndicator { get => _authorizedCreditReportIndicator; set => _authorizedCreditReportIndicator = value; }
        private DirtyValue<bool?> _authorizedToSignIndicator;
        public bool? AuthorizedToSignIndicator { get => _authorizedToSignIndicator; set => _authorizedToSignIndicator = value; }
        private DirtyValue<string> _bankAccountNumber;
        public string BankAccountNumber { get => _bankAccountNumber; set => _bankAccountNumber = value; }
        private DirtyValue<StringEnumValue<BankAccountType>> _bankAccountType;
        public StringEnumValue<BankAccountType> BankAccountType { get => _bankAccountType; set => _bankAccountType = value; }
        private DirtyValue<string> _bankContactAddress;
        public string BankContactAddress { get => _bankContactAddress; set => _bankContactAddress = value; }
        private DirtyValue<string> _bankContactCity;
        public string BankContactCity { get => _bankContactCity; set => _bankContactCity = value; }
        private DirtyValue<string> _bankContactName;
        public string BankContactName { get => _bankContactName; set => _bankContactName = value; }
        private DirtyValue<string> _bankContactPostalCode;
        public string BankContactPostalCode { get => _bankContactPostalCode; set => _bankContactPostalCode = value; }
        private DirtyValue<string> _bankContactState;
        public string BankContactState { get => _bankContactState; set => _bankContactState = value; }
        private DirtyValue<bool?> _bankruptcyIndicator;
        public bool? BankruptcyIndicator { get => _bankruptcyIndicator; set => _bankruptcyIndicator = value; }
        private DirtyValue<StringEnumValue<BankruptcyForeclosureStatus>> _bankruptcyStatus;
        public StringEnumValue<BankruptcyForeclosureStatus> BankruptcyStatus { get => _bankruptcyStatus; set => _bankruptcyStatus = value; }
        private DirtyValue<decimal?> _baseMonthlyIncomeAmount;
        public decimal? BaseMonthlyIncomeAmount { get => _baseMonthlyIncomeAmount; set => _baseMonthlyIncomeAmount = value; }
        private DirtyValue<DateTime?> _birthDate;
        public DateTime? BirthDate { get => _birthDate; set => _birthDate = value; }
        private DirtyValue<bool?> _borrowedDownPaymentIndicator;
        public bool? BorrowedDownPaymentIndicator { get => _borrowedDownPaymentIndicator; set => _borrowedDownPaymentIndicator = value; }
        private DirtyValue<DateTime?> _borrowerConsentRequestDate;
        public DateTime? BorrowerConsentRequestDate { get => _borrowerConsentRequestDate; set => _borrowerConsentRequestDate = value; }
        private DirtyValue<int?> _borrowerIndex;
        public int? BorrowerIndex { get => _borrowerIndex; set => _borrowerIndex = value; }
        private DirtyValue<StringEnumValue<BorrowerType>> _borrowerType;
        public StringEnumValue<BorrowerType> BorrowerType { get => _borrowerType; set => _borrowerType = value; }
        private DirtyValue<StringEnumValue<BorrowerType>> _borrowerTypeInSummary;
        public StringEnumValue<BorrowerType> BorrowerTypeInSummary { get => _borrowerTypeInSummary; set => _borrowerTypeInSummary = value; }
        private DirtyValue<string> _caivrsIdentifier;
        public string CaivrsIdentifier { get => _caivrsIdentifier; set => _caivrsIdentifier = value; }
        private DirtyValue<string> _citizenshipResidencyType;
        public string CitizenshipResidencyType { get => _citizenshipResidencyType; set => _citizenshipResidencyType = value; }
        private DirtyValue<bool?> _coMakerEndorserOfNoteIndicator;
        public bool? CoMakerEndorserOfNoteIndicator { get => _coMakerEndorserOfNoteIndicator; set => _coMakerEndorserOfNoteIndicator = value; }
        private DirtyValue<string> _commentOfCreditReport;
        public string CommentOfCreditReport { get => _commentOfCreditReport; set => _commentOfCreditReport = value; }
        private DirtyValue<bool?> _confirmedCRDIL;
        public bool? ConfirmedCRDIL { get => _confirmedCRDIL; set => _confirmedCRDIL = value; }
        private DirtyValue<bool?> _confirmedCRFCEC;
        public bool? ConfirmedCRFCEC { get => _confirmedCRFCEC; set => _confirmedCRFCEC = value; }
        private DirtyValue<bool?> _confirmedCRFCIncorrect;
        public bool? ConfirmedCRFCIncorrect { get => _confirmedCRFCIncorrect; set => _confirmedCRFCIncorrect = value; }
        private DirtyValue<bool?> _confirmedCRPFS;
        public bool? ConfirmedCRPFS { get => _confirmedCRPFS; set => _confirmedCRPFS = value; }
        private DirtyValue<bool?> _confirmedOther;
        public bool? ConfirmedOther { get => _confirmedOther; set => _confirmedOther = value; }
        private DirtyValue<string> _confirmedOtherDescription;
        public string ConfirmedOtherDescription { get => _confirmedOtherDescription; set => _confirmedOtherDescription = value; }
        private DirtyValue<bool?> _creditCounseling;
        public bool? CreditCounseling { get => _creditCounseling; set => _creditCounseling = value; }
        private DirtyValue<DateTime?> _creditReceivedDate;
        public DateTime? CreditReceivedDate { get => _creditReceivedDate; set => _creditReceivedDate = value; }
        private DirtyValue<StringEnumValue<CreditReportAuthorizationMethod>> _creditReportAuthorizationMethod;
        public StringEnumValue<CreditReportAuthorizationMethod> CreditReportAuthorizationMethod { get => _creditReportAuthorizationMethod; set => _creditReportAuthorizationMethod = value; }
        private DirtyValue<bool?> _creditScoreIndicator;
        public bool? CreditScoreIndicator { get => _creditScoreIndicator; set => _creditScoreIndicator = value; }
        private DirtyValue<DateTime?> _dateAuthorizedCreditReport;
        public DateTime? DateAuthorizedCreditReport { get => _dateAuthorizedCreditReport; set => _dateAuthorizedCreditReport = value; }
        private DirtyValue<DateTime?> _dateOfBankruptcy;
        public DateTime? DateOfBankruptcy { get => _dateOfBankruptcy; set => _dateOfBankruptcy = value; }
        private DirtyValue<DateTime?> _dateOfForeclosure;
        public DateTime? DateOfForeclosure { get => _dateOfForeclosure; set => _dateOfForeclosure = value; }
        private DirtyValue<bool?> _declarationsJIndicator;
        public bool? DeclarationsJIndicator { get => _declarationsJIndicator; set => _declarationsJIndicator = value; }
        private DirtyValue<bool?> _declarationsKIndicator;
        public bool? DeclarationsKIndicator { get => _declarationsKIndicator; set => _declarationsKIndicator = value; }
        private DirtyValue<int?> _dependentCount;
        public int? DependentCount { get => _dependentCount; set => _dependentCount = value; }
        private DirtyValue<string> _dependentsAgesDescription;
        public string DependentsAgesDescription { get => _dependentsAgesDescription; set => _dependentsAgesDescription = value; }
        private DirtyValue<bool?> _disabledIndicator;
        public bool? DisabledIndicator { get => _disabledIndicator; set => _disabledIndicator = value; }
        private DirtyValue<string> _emailAddressText;
        public string EmailAddressText { get => _emailAddressText; set => _emailAddressText = value; }
        private DirtyValue<int?> _equifax120Days;
        public int? Equifax120Days { get => _equifax120Days; set => _equifax120Days = value; }
        private DirtyValue<int?> _equifax150Days;
        public int? Equifax150Days { get => _equifax150Days; set => _equifax150Days = value; }
        private DirtyValue<int?> _equifax30Days;
        public int? Equifax30Days { get => _equifax30Days; set => _equifax30Days = value; }
        private DirtyValue<int?> _equifax60Days;
        public int? Equifax60Days { get => _equifax60Days; set => _equifax60Days = value; }
        private DirtyValue<int?> _equifax90Days;
        public int? Equifax90Days { get => _equifax90Days; set => _equifax90Days = value; }
        private DirtyValue<bool?> _equifaxCreditScoreForDisclosure;
        public bool? EquifaxCreditScoreForDisclosure { get => _equifaxCreditScoreForDisclosure; set => _equifaxCreditScoreForDisclosure = value; }
        private DirtyValue<int?> _equifaxCreditScoreRanksPercent;
        public int? EquifaxCreditScoreRanksPercent { get => _equifaxCreditScoreRanksPercent; set => _equifaxCreditScoreRanksPercent = value; }
        private DirtyValue<DateTime?> _equifaxDatePulled;
        public DateTime? EquifaxDatePulled { get => _equifaxDatePulled; set => _equifaxDatePulled = value; }
        private DirtyValue<string> _equifaxFactorCode1;
        public string EquifaxFactorCode1 { get => _equifaxFactorCode1; set => _equifaxFactorCode1 = value; }
        private DirtyValue<string> _equifaxFactorCode2;
        public string EquifaxFactorCode2 { get => _equifaxFactorCode2; set => _equifaxFactorCode2 = value; }
        private DirtyValue<string> _equifaxFactorCode3;
        public string EquifaxFactorCode3 { get => _equifaxFactorCode3; set => _equifaxFactorCode3 = value; }
        private DirtyValue<string> _equifaxFactorCode4;
        public string EquifaxFactorCode4 { get => _equifaxFactorCode4; set => _equifaxFactorCode4 = value; }
        private DirtyValue<string> _equifaxFactorCode5;
        public string EquifaxFactorCode5 { get => _equifaxFactorCode5; set => _equifaxFactorCode5 = value; }
        private DirtyValue<string> _equifaxKeyFactor1;
        public string EquifaxKeyFactor1 { get => _equifaxKeyFactor1; set => _equifaxKeyFactor1 = value; }
        private DirtyValue<string> _equifaxKeyFactor2;
        public string EquifaxKeyFactor2 { get => _equifaxKeyFactor2; set => _equifaxKeyFactor2 = value; }
        private DirtyValue<string> _equifaxKeyFactor3;
        public string EquifaxKeyFactor3 { get => _equifaxKeyFactor3; set => _equifaxKeyFactor3 = value; }
        private DirtyValue<string> _equifaxKeyFactor4;
        public string EquifaxKeyFactor4 { get => _equifaxKeyFactor4; set => _equifaxKeyFactor4 = value; }
        private DirtyValue<string> _equifaxKeyFactor5;
        public string EquifaxKeyFactor5 { get => _equifaxKeyFactor5; set => _equifaxKeyFactor5 = value; }
        private DirtyValue<bool?> _equifaxMaterialTermsCreditByScore;
        public bool? EquifaxMaterialTermsCreditByScore { get => _equifaxMaterialTermsCreditByScore; set => _equifaxMaterialTermsCreditByScore = value; }
        private DirtyValue<string> _equifaxScore;
        public string EquifaxScore { get => _equifaxScore; set => _equifaxScore = value; }
        private DirtyValue<int?> _experian120Days;
        public int? Experian120Days { get => _experian120Days; set => _experian120Days = value; }
        private DirtyValue<int?> _experian150Days;
        public int? Experian150Days { get => _experian150Days; set => _experian150Days = value; }
        private DirtyValue<int?> _experian30Days;
        public int? Experian30Days { get => _experian30Days; set => _experian30Days = value; }
        private DirtyValue<int?> _experian60Days;
        public int? Experian60Days { get => _experian60Days; set => _experian60Days = value; }
        private DirtyValue<int?> _experian90Days;
        public int? Experian90Days { get => _experian90Days; set => _experian90Days = value; }
        private DirtyValue<string> _experianCreditScore;
        public string ExperianCreditScore { get => _experianCreditScore; set => _experianCreditScore = value; }
        private DirtyValue<bool?> _experianCreditScoreForDisclosure;
        public bool? ExperianCreditScoreForDisclosure { get => _experianCreditScoreForDisclosure; set => _experianCreditScoreForDisclosure = value; }
        private DirtyValue<int?> _experianCreditScoreRanksPercent;
        public int? ExperianCreditScoreRanksPercent { get => _experianCreditScoreRanksPercent; set => _experianCreditScoreRanksPercent = value; }
        private DirtyValue<DateTime?> _experianDatePulled;
        public DateTime? ExperianDatePulled { get => _experianDatePulled; set => _experianDatePulled = value; }
        private DirtyValue<string> _experianFactorCode1;
        public string ExperianFactorCode1 { get => _experianFactorCode1; set => _experianFactorCode1 = value; }
        private DirtyValue<string> _experianFactorCode2;
        public string ExperianFactorCode2 { get => _experianFactorCode2; set => _experianFactorCode2 = value; }
        private DirtyValue<string> _experianFactorCode3;
        public string ExperianFactorCode3 { get => _experianFactorCode3; set => _experianFactorCode3 = value; }
        private DirtyValue<string> _experianFactorCode4;
        public string ExperianFactorCode4 { get => _experianFactorCode4; set => _experianFactorCode4 = value; }
        private DirtyValue<string> _experianFactorCode5;
        public string ExperianFactorCode5 { get => _experianFactorCode5; set => _experianFactorCode5 = value; }
        private DirtyValue<string> _experianKeyFactor1;
        public string ExperianKeyFactor1 { get => _experianKeyFactor1; set => _experianKeyFactor1 = value; }
        private DirtyValue<string> _experianKeyFactor2;
        public string ExperianKeyFactor2 { get => _experianKeyFactor2; set => _experianKeyFactor2 = value; }
        private DirtyValue<string> _experianKeyFactor3;
        public string ExperianKeyFactor3 { get => _experianKeyFactor3; set => _experianKeyFactor3 = value; }
        private DirtyValue<string> _experianKeyFactor4;
        public string ExperianKeyFactor4 { get => _experianKeyFactor4; set => _experianKeyFactor4 = value; }
        private DirtyValue<string> _experianKeyFactor5;
        public string ExperianKeyFactor5 { get => _experianKeyFactor5; set => _experianKeyFactor5 = value; }
        private DirtyValue<bool?> _experianMaterialTermsCreditByScore;
        public bool? ExperianMaterialTermsCreditByScore { get => _experianMaterialTermsCreditByScore; set => _experianMaterialTermsCreditByScore = value; }
        private DirtyValue<string> _firstName;
        public string FirstName { get => _firstName; set => _firstName = value; }
        private DirtyValue<string> _firstNameWithMiddleName;
        public string FirstNameWithMiddleName { get => _firstNameWithMiddleName; set => _firstNameWithMiddleName = value; }
        private DirtyValue<bool?> _firstTimeHomeBuyer;
        public bool? FirstTimeHomeBuyer { get => _firstTimeHomeBuyer; set => _firstTimeHomeBuyer = value; }
        private DirtyValue<DateTime?> _foreclosureSatisfied;
        public DateTime? ForeclosureSatisfied { get => _foreclosureSatisfied; set => _foreclosureSatisfied = value; }
        private DirtyValue<StringEnumValue<BankruptcyForeclosureStatus>> _foreclosureStatus;
        public StringEnumValue<BankruptcyForeclosureStatus> ForeclosureStatus { get => _foreclosureStatus; set => _foreclosureStatus = value; }
        private DirtyValue<string> _freddieMacPerson1;
        public string FreddieMacPerson1 { get => _freddieMacPerson1; set => _freddieMacPerson1 = value; }
        private DirtyValue<string> _freddieMacPerson2;
        public string FreddieMacPerson2 { get => _freddieMacPerson2; set => _freddieMacPerson2 = value; }
        private DirtyValue<string> _fullName;
        public string FullName { get => _fullName; set => _fullName = value; }
        private DirtyValue<string> _fullNameWithSuffix;
        public string FullNameWithSuffix { get => _fullNameWithSuffix; set => _fullNameWithSuffix = value; }
        private DirtyValue<decimal?> _highestCreditLimit;
        public decimal? HighestCreditLimit { get => _highestCreditLimit; set => _highestCreditLimit = value; }
        private DirtyValue<string> _hmda2003OtherRaceNationalOriginDescription;
        public string Hmda2003OtherRaceNationalOriginDescription { get => _hmda2003OtherRaceNationalOriginDescription; set => _hmda2003OtherRaceNationalOriginDescription = value; }
        private DirtyValue<StringEnumValue<Hmda2003RaceNationalOriginType>> _hmda2003RaceNationalOriginType;
        public StringEnumValue<Hmda2003RaceNationalOriginType> Hmda2003RaceNationalOriginType { get => _hmda2003RaceNationalOriginType; set => _hmda2003RaceNationalOriginType = value; }
        private DirtyValue<bool?> _hmdaAfricanAmericanIndicator;
        public bool? HmdaAfricanAmericanIndicator { get => _hmdaAfricanAmericanIndicator; set => _hmdaAfricanAmericanIndicator = value; }
        private DirtyValue<StringEnumValue<HmdaAge>> _hmdaAge;
        public StringEnumValue<HmdaAge> HmdaAge { get => _hmdaAge; set => _hmdaAge = value; }
        private DirtyValue<bool?> _hmdaAmericanIndianIndicator;
        public bool? HmdaAmericanIndianIndicator { get => _hmdaAmericanIndianIndicator; set => _hmdaAmericanIndianIndicator = value; }
        private DirtyValue<string> _hmdaAmericanIndianTribe;
        public string HmdaAmericanIndianTribe { get => _hmdaAmericanIndianTribe; set => _hmdaAmericanIndianTribe = value; }
        private DirtyValue<bool?> _hmdaAsianIndianIndicator;
        public bool? HmdaAsianIndianIndicator { get => _hmdaAsianIndianIndicator; set => _hmdaAsianIndianIndicator = value; }
        private DirtyValue<bool?> _hmdaAsianIndicator;
        public bool? HmdaAsianIndicator { get => _hmdaAsianIndicator; set => _hmdaAsianIndicator = value; }
        private DirtyValue<bool?> _hmdaAsianOtherRaceIndicator;
        public bool? HmdaAsianOtherRaceIndicator { get => _hmdaAsianOtherRaceIndicator; set => _hmdaAsianOtherRaceIndicator = value; }
        private DirtyValue<bool?> _hmdaChineseIndicator;
        public bool? HmdaChineseIndicator { get => _hmdaChineseIndicator; set => _hmdaChineseIndicator = value; }
        private DirtyValue<StringEnumValue<HmdaCreditScoreForDecisionMaking>> _hmdaCreditScoreForDecisionMaking;
        public StringEnumValue<HmdaCreditScoreForDecisionMaking> HmdaCreditScoreForDecisionMaking { get => _hmdaCreditScoreForDecisionMaking; set => _hmdaCreditScoreForDecisionMaking = value; }
        private DirtyValue<StringEnumValue<HmdaCreditScoringModel>> _hmdaCreditScoringModel;
        public StringEnumValue<HmdaCreditScoringModel> HmdaCreditScoringModel { get => _hmdaCreditScoringModel; set => _hmdaCreditScoringModel = value; }
        private DirtyValue<bool?> _hmdaCubanIndicator;
        public bool? HmdaCubanIndicator { get => _hmdaCubanIndicator; set => _hmdaCubanIndicator = value; }
        private DirtyValue<bool?> _hmdaEthnicityDoNotWishIndicator;
        public bool? HmdaEthnicityDoNotWishIndicator { get => _hmdaEthnicityDoNotWishIndicator; set => _hmdaEthnicityDoNotWishIndicator = value; }
        private DirtyValue<bool?> _hmdaEthnicityHispanicLatinoIndicator;
        public bool? HmdaEthnicityHispanicLatinoIndicator { get => _hmdaEthnicityHispanicLatinoIndicator; set => _hmdaEthnicityHispanicLatinoIndicator = value; }
        private DirtyValue<bool?> _hmdaEthnicityNotApplicableIndicator;
        public bool? HmdaEthnicityNotApplicableIndicator { get => _hmdaEthnicityNotApplicableIndicator; set => _hmdaEthnicityNotApplicableIndicator = value; }
        private DirtyValue<bool?> _hmdaEthnicityNotHispanicLatinoIndicator;
        public bool? HmdaEthnicityNotHispanicLatinoIndicator { get => _hmdaEthnicityNotHispanicLatinoIndicator; set => _hmdaEthnicityNotHispanicLatinoIndicator = value; }
        private DirtyValue<string> _hmdaEthnicityReportedField1;
        public string HmdaEthnicityReportedField1 { get => _hmdaEthnicityReportedField1; set => _hmdaEthnicityReportedField1 = value; }
        private DirtyValue<string> _hmdaEthnicityReportedField2;
        public string HmdaEthnicityReportedField2 { get => _hmdaEthnicityReportedField2; set => _hmdaEthnicityReportedField2 = value; }
        private DirtyValue<string> _hmdaEthnicityReportedField3;
        public string HmdaEthnicityReportedField3 { get => _hmdaEthnicityReportedField3; set => _hmdaEthnicityReportedField3 = value; }
        private DirtyValue<string> _hmdaEthnicityReportedField4;
        public string HmdaEthnicityReportedField4 { get => _hmdaEthnicityReportedField4; set => _hmdaEthnicityReportedField4 = value; }
        private DirtyValue<string> _hmdaEthnicityReportedField5;
        public string HmdaEthnicityReportedField5 { get => _hmdaEthnicityReportedField5; set => _hmdaEthnicityReportedField5 = value; }
        private DirtyValue<StringEnumValue<HmdaEthnicityType>> _hmdaEthnicityType;
        public StringEnumValue<HmdaEthnicityType> HmdaEthnicityType { get => _hmdaEthnicityType; set => _hmdaEthnicityType = value; }
        private DirtyValue<bool?> _hmdaFilipinoIndicator;
        public bool? HmdaFilipinoIndicator { get => _hmdaFilipinoIndicator; set => _hmdaFilipinoIndicator = value; }
        private DirtyValue<StringEnumValue<HmdaGenderType>> _hmdaGenderType;
        public StringEnumValue<HmdaGenderType> HmdaGenderType { get => _hmdaGenderType; set => _hmdaGenderType = value; }
        private DirtyValue<bool?> _hmdaGendertypeDoNotWishIndicator;
        public bool? HmdaGendertypeDoNotWishIndicator { get => _hmdaGendertypeDoNotWishIndicator; set => _hmdaGendertypeDoNotWishIndicator = value; }
        private DirtyValue<bool?> _hmdaGendertypeFemaleIndicator;
        public bool? HmdaGendertypeFemaleIndicator { get => _hmdaGendertypeFemaleIndicator; set => _hmdaGendertypeFemaleIndicator = value; }
        private DirtyValue<bool?> _hmdaGendertypeMaleIndicator;
        public bool? HmdaGendertypeMaleIndicator { get => _hmdaGendertypeMaleIndicator; set => _hmdaGendertypeMaleIndicator = value; }
        private DirtyValue<bool?> _hmdaGendertypeNotApplicableIndicator;
        public bool? HmdaGendertypeNotApplicableIndicator { get => _hmdaGendertypeNotApplicableIndicator; set => _hmdaGendertypeNotApplicableIndicator = value; }
        private DirtyValue<bool?> _hmdaGuamanianOrChamorroIndicator;
        public bool? HmdaGuamanianOrChamorroIndicator { get => _hmdaGuamanianOrChamorroIndicator; set => _hmdaGuamanianOrChamorroIndicator = value; }
        private DirtyValue<bool?> _hmdaHispanicLatinoOtherOriginIndicator;
        public bool? HmdaHispanicLatinoOtherOriginIndicator { get => _hmdaHispanicLatinoOtherOriginIndicator; set => _hmdaHispanicLatinoOtherOriginIndicator = value; }
        private DirtyValue<bool?> _hmdaJapaneseIndicator;
        public bool? HmdaJapaneseIndicator { get => _hmdaJapaneseIndicator; set => _hmdaJapaneseIndicator = value; }
        private DirtyValue<bool?> _hmdaKoreanIndicator;
        public bool? HmdaKoreanIndicator { get => _hmdaKoreanIndicator; set => _hmdaKoreanIndicator = value; }
        private DirtyValue<bool?> _hmdaMexicanIndicator;
        public bool? HmdaMexicanIndicator { get => _hmdaMexicanIndicator; set => _hmdaMexicanIndicator = value; }
        private DirtyValue<bool?> _hmdaNativeHawaiianIndicator;
        public bool? HmdaNativeHawaiianIndicator { get => _hmdaNativeHawaiianIndicator; set => _hmdaNativeHawaiianIndicator = value; }
        private DirtyValue<bool?> _hmdaNoCoApplicantIndicator;
        public bool? HmdaNoCoApplicantIndicator { get => _hmdaNoCoApplicantIndicator; set => _hmdaNoCoApplicantIndicator = value; }
        private DirtyValue<bool?> _hmdaNotApplicableIndicator;
        public bool? HmdaNotApplicableIndicator { get => _hmdaNotApplicableIndicator; set => _hmdaNotApplicableIndicator = value; }
        private DirtyValue<bool?> _hmdaNotProvidedIndicator;
        public bool? HmdaNotProvidedIndicator { get => _hmdaNotProvidedIndicator; set => _hmdaNotProvidedIndicator = value; }
        private DirtyValue<string> _hmdaOtherAsianRace;
        public string HmdaOtherAsianRace { get => _hmdaOtherAsianRace; set => _hmdaOtherAsianRace = value; }
        private DirtyValue<string> _hmdaOtherHispanicLatinoOrigin;
        public string HmdaOtherHispanicLatinoOrigin { get => _hmdaOtherHispanicLatinoOrigin; set => _hmdaOtherHispanicLatinoOrigin = value; }
        private DirtyValue<string> _hmdaOtherPacificIslanderRace;
        public string HmdaOtherPacificIslanderRace { get => _hmdaOtherPacificIslanderRace; set => _hmdaOtherPacificIslanderRace = value; }
        private DirtyValue<string> _hmdaOtherScoringModel;
        public string HmdaOtherScoringModel { get => _hmdaOtherScoringModel; set => _hmdaOtherScoringModel = value; }
        private DirtyValue<bool?> _hmdaPacificIslanderIndicator;
        public bool? HmdaPacificIslanderIndicator { get => _hmdaPacificIslanderIndicator; set => _hmdaPacificIslanderIndicator = value; }
        private DirtyValue<bool?> _hmdaPacificIslanderOtherIndicator;
        public bool? HmdaPacificIslanderOtherIndicator { get => _hmdaPacificIslanderOtherIndicator; set => _hmdaPacificIslanderOtherIndicator = value; }
        private DirtyValue<bool?> _hmdaPuertoRicanIndicator;
        public bool? HmdaPuertoRicanIndicator { get => _hmdaPuertoRicanIndicator; set => _hmdaPuertoRicanIndicator = value; }
        private DirtyValue<string> _hmdaRaceReportedField1;
        public string HmdaRaceReportedField1 { get => _hmdaRaceReportedField1; set => _hmdaRaceReportedField1 = value; }
        private DirtyValue<string> _hmdaRaceReportedField2;
        public string HmdaRaceReportedField2 { get => _hmdaRaceReportedField2; set => _hmdaRaceReportedField2 = value; }
        private DirtyValue<string> _hmdaRaceReportedField3;
        public string HmdaRaceReportedField3 { get => _hmdaRaceReportedField3; set => _hmdaRaceReportedField3 = value; }
        private DirtyValue<string> _hmdaRaceReportedField4;
        public string HmdaRaceReportedField4 { get => _hmdaRaceReportedField4; set => _hmdaRaceReportedField4 = value; }
        private DirtyValue<string> _hmdaRaceReportedField5;
        public string HmdaRaceReportedField5 { get => _hmdaRaceReportedField5; set => _hmdaRaceReportedField5 = value; }
        private DirtyValue<bool?> _hmdaRefusalIndicator;
        public bool? HmdaRefusalIndicator { get => _hmdaRefusalIndicator; set => _hmdaRefusalIndicator = value; }
        private DirtyValue<bool?> _hmdaSamoanIndicator;
        public bool? HmdaSamoanIndicator { get => _hmdaSamoanIndicator; set => _hmdaSamoanIndicator = value; }
        private DirtyValue<bool?> _hmdaVietnameseIndicator;
        public bool? HmdaVietnameseIndicator { get => _hmdaVietnameseIndicator; set => _hmdaVietnameseIndicator = value; }
        private DirtyValue<bool?> _hmdaWhiteIndicator;
        public bool? HmdaWhiteIndicator { get => _hmdaWhiteIndicator; set => _hmdaWhiteIndicator = value; }
        private DirtyValue<bool?> _homeownerPastThreeYearsIndicator;
        public bool? HomeownerPastThreeYearsIndicator { get => _homeownerPastThreeYearsIndicator; set => _homeownerPastThreeYearsIndicator = value; }
        private DirtyValue<string> _homePhoneNumber;
        public string HomePhoneNumber { get => _homePhoneNumber; set => _homePhoneNumber = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _incomeRepAndWarrantyMessage;
        public string IncomeRepAndWarrantyMessage { get => _incomeRepAndWarrantyMessage; set => _incomeRepAndWarrantyMessage = value; }
        private DirtyValue<bool?> _incomeRepAndWarrantyReliefAvailable;
        public bool? IncomeRepAndWarrantyReliefAvailable { get => _incomeRepAndWarrantyReliefAvailable; set => _incomeRepAndWarrantyReliefAvailable = value; }
        private DirtyValue<bool?> _intentToOccupyIndicator;
        public bool? IntentToOccupyIndicator { get => _intentToOccupyIndicator; set => _intentToOccupyIndicator = value; }
        private DirtyValue<string> _intuitReportId;
        public string IntuitReportId { get => _intuitReportId; set => _intuitReportId = value; }
        private DirtyValue<bool?> _isBaseIncomeAvailable;
        public bool? IsBaseIncomeAvailable { get => _isBaseIncomeAvailable; set => _isBaseIncomeAvailable = value; }
        private DirtyValue<bool?> _isBonusAvailable;
        public bool? IsBonusAvailable { get => _isBonusAvailable; set => _isBonusAvailable = value; }
        private DirtyValue<bool?> _isBorrower;
        public bool? IsBorrower { get => _isBorrower; set => _isBorrower = value; }
        private DirtyValue<bool?> _isCommissionAvailable;
        public bool? IsCommissionAvailable { get => _isCommissionAvailable; set => _isCommissionAvailable = value; }
        private DirtyValue<StringEnumValue<YNOrNA>> _isEthnicityBasedOnVisual;
        public StringEnumValue<YNOrNA> IsEthnicityBasedOnVisual { get => _isEthnicityBasedOnVisual; set => _isEthnicityBasedOnVisual = value; }
        private DirtyValue<bool?> _isOvertimeAvailable;
        public bool? IsOvertimeAvailable { get => _isOvertimeAvailable; set => _isOvertimeAvailable = value; }
        private DirtyValue<StringEnumValue<YNOrNA>> _isRaceBasedOnVisual;
        public StringEnumValue<YNOrNA> IsRaceBasedOnVisual { get => _isRaceBasedOnVisual; set => _isRaceBasedOnVisual = value; }
        private DirtyValue<bool?> _isSelfEmployed;
        public bool? IsSelfEmployed { get => _isSelfEmployed; set => _isSelfEmployed = value; }
        private DirtyValue<StringEnumValue<YNOrNA>> _isSexBasedOnVisual;
        public StringEnumValue<YNOrNA> IsSexBasedOnVisual { get => _isSexBasedOnVisual; set => _isSexBasedOnVisual = value; }
        private DirtyValue<bool?> _isSocialSecurityAvailable;
        public bool? IsSocialSecurityAvailable { get => _isSocialSecurityAvailable; set => _isSocialSecurityAvailable = value; }
        private DirtyValue<string> _lastName;
        public string LastName { get => _lastName; set => _lastName = value; }
        private DirtyValue<string> _lastNameWithSuffix;
        public string LastNameWithSuffix { get => _lastNameWithSuffix; set => _lastNameWithSuffix = value; }
        private DirtyValue<bool?> _loanForeclosureOrJudgementIndicator;
        public bool? LoanForeclosureOrJudgementIndicator { get => _loanForeclosureOrJudgementIndicator; set => _loanForeclosureOrJudgementIndicator = value; }
        private DirtyValue<string> _lpdGsa;
        public string LpdGsa { get => _lpdGsa; set => _lpdGsa = value; }
        private DirtyValue<bool?> _mailingAddressSameAsPresentIndicator;
        public bool? MailingAddressSameAsPresentIndicator { get => _mailingAddressSameAsPresentIndicator; set => _mailingAddressSameAsPresentIndicator = value; }
        private DirtyValue<StringEnumValue<MaritalStatusType>> _maritalStatusType;
        public StringEnumValue<MaritalStatusType> MaritalStatusType { get => _maritalStatusType; set => _maritalStatusType = value; }
        private DirtyValue<int?> _middleCreditScore;
        public int? MiddleCreditScore { get => _middleCreditScore; set => _middleCreditScore = value; }
        private DirtyValue<string> _middleFicoScore;
        public string MiddleFicoScore { get => _middleFicoScore; set => _middleFicoScore = value; }
        private DirtyValue<string> _middleName;
        public string MiddleName { get => _middleName; set => _middleName = value; }
        private DirtyValue<string> _minFicoScore;
        public string MinFicoScore { get => _minFicoScore; set => _minFicoScore = value; }
        private DirtyValue<string> _mobilePhone;
        public string MobilePhone { get => _mobilePhone; set => _mobilePhone = value; }
        private DirtyValue<bool?> _mortgageOnCredit;
        public bool? MortgageOnCredit { get => _mortgageOnCredit; set => _mortgageOnCredit = value; }
        private DirtyValue<string> _nameToObtainLoanFromRHS;
        public string NameToObtainLoanFromRHS { get => _nameToObtainLoanFromRHS; set => _nameToObtainLoanFromRHS = value; }
        private DirtyValue<string> _nearestRelativeAddress;
        public string NearestRelativeAddress { get => _nearestRelativeAddress; set => _nearestRelativeAddress = value; }
        private DirtyValue<string> _nearestRelativeCity;
        public string NearestRelativeCity { get => _nearestRelativeCity; set => _nearestRelativeCity = value; }
        private DirtyValue<string> _nearestRelativeName;
        public string NearestRelativeName { get => _nearestRelativeName; set => _nearestRelativeName = value; }
        private DirtyValue<string> _nearestRelativePhone;
        public string NearestRelativePhone { get => _nearestRelativePhone; set => _nearestRelativePhone = value; }
        private DirtyValue<string> _nearestRelativePostalCode;
        public string NearestRelativePostalCode { get => _nearestRelativePostalCode; set => _nearestRelativePostalCode = value; }
        private DirtyValue<string> _nearestRelativeRelationship;
        public string NearestRelativeRelationship { get => _nearestRelativeRelationship; set => _nearestRelativeRelationship = value; }
        private DirtyValue<string> _nearestRelativeState;
        public string NearestRelativeState { get => _nearestRelativeState; set => _nearestRelativeState = value; }
        private DirtyValue<bool?> _no3rdPartyEmailIndicator;
        public bool? No3rdPartyEmailIndicator { get => _no3rdPartyEmailIndicator; set => _no3rdPartyEmailIndicator = value; }
        private DirtyValue<bool?> _noCoApplicantEthnicityIndicator;
        public bool? NoCoApplicantEthnicityIndicator { get => _noCoApplicantEthnicityIndicator; set => _noCoApplicantEthnicityIndicator = value; }
        private DirtyValue<bool?> _noCoApplicantIndicator;
        public bool? NoCoApplicantIndicator { get => _noCoApplicantIndicator; set => _noCoApplicantIndicator = value; }
        private DirtyValue<bool?> _noCoApplicantSexIndicator;
        public bool? NoCoApplicantSexIndicator { get => _noCoApplicantSexIndicator; set => _noCoApplicantSexIndicator = value; }
        private DirtyValue<int?> _numberofTradelines;
        public int? NumberofTradelines { get => _numberofTradelines; set => _numberofTradelines = value; }
        private DirtyValue<bool?> _obtainLoanFromRHSIndicator;
        public bool? ObtainLoanFromRHSIndicator { get => _obtainLoanFromRHSIndicator; set => _obtainLoanFromRHSIndicator = value; }
        private DirtyValue<StringEnumValue<OpenBankruptcy>> _openBankruptcy2;
        public StringEnumValue<OpenBankruptcy> OpenBankruptcy2 { get => _openBankruptcy2; set => _openBankruptcy2 = value; }
        private DirtyValue<decimal?> _otherMonthlyIncomeAmount;
        public decimal? OtherMonthlyIncomeAmount { get => _otherMonthlyIncomeAmount; set => _otherMonthlyIncomeAmount = value; }
        private DirtyValue<decimal?> _otherSumAmount;
        public decimal? OtherSumAmount { get => _otherSumAmount; set => _otherSumAmount = value; }
        private DirtyValue<bool?> _outstandingJudgementsIndicator;
        public bool? OutstandingJudgementsIndicator { get => _outstandingJudgementsIndicator; set => _outstandingJudgementsIndicator = value; }
        private DirtyValue<bool?> _partyToLawsuitIndicator;
        public bool? PartyToLawsuitIndicator { get => _partyToLawsuitIndicator; set => _partyToLawsuitIndicator = value; }
        private DirtyValue<int?> _pass120Days;
        public int? Pass120Days { get => _pass120Days; set => _pass120Days = value; }
        private DirtyValue<int?> _pass150Days;
        public int? Pass150Days { get => _pass150Days; set => _pass150Days = value; }
        private DirtyValue<int?> _pass30Days;
        public int? Pass30Days { get => _pass30Days; set => _pass30Days = value; }
        private DirtyValue<int?> _pass60Days;
        public int? Pass60Days { get => _pass60Days; set => _pass60Days = value; }
        private DirtyValue<int?> _pass90Days;
        public int? Pass90Days { get => _pass90Days; set => _pass90Days = value; }
        private DirtyValue<string> _personFaxNumber;
        public string PersonFaxNumber { get => _personFaxNumber; set => _personFaxNumber = value; }
        private DirtyValue<decimal?> _personHoursPerWeek;
        public decimal? PersonHoursPerWeek { get => _personHoursPerWeek; set => _personHoursPerWeek = value; }
        private DirtyValue<decimal?> _personIncomeAmount;
        public decimal? PersonIncomeAmount { get => _personIncomeAmount; set => _personIncomeAmount = value; }
        private DirtyValue<string> _personIncomeFrequencyType;
        public string PersonIncomeFrequencyType { get => _personIncomeFrequencyType; set => _personIncomeFrequencyType = value; }
        private DirtyValue<decimal?> _personMonthlyIncome;
        public decimal? PersonMonthlyIncome { get => _personMonthlyIncome; set => _personMonthlyIncome = value; }
        private DirtyValue<bool?> _pIWAccepted;
        public bool? PIWAccepted { get => _pIWAccepted; set => _pIWAccepted = value; }
        private DirtyValue<string> _pIWMessage;
        public string PIWMessage { get => _pIWMessage; set => _pIWMessage = value; }
        private DirtyValue<StringEnumValue<OccupancyIntent>> _poaOccupancyIntent;
        public StringEnumValue<OccupancyIntent> PoaOccupancyIntent { get => _poaOccupancyIntent; set => _poaOccupancyIntent = value; }
        private DirtyValue<string> _poaSignatureText;
        public string PoaSignatureText { get => _poaSignatureText; set => _poaSignatureText = value; }
        private DirtyValue<decimal?> _positiveCashFlow;
        public decimal? PositiveCashFlow { get => _positiveCashFlow; set => _positiveCashFlow = value; }
        private DirtyValue<string> _powerOfAttorneyName;
        public string PowerOfAttorneyName { get => _powerOfAttorneyName; set => _powerOfAttorneyName = value; }
        private DirtyValue<string> _powerOfAttorneyTitleDescription;
        public string PowerOfAttorneyTitleDescription { get => _powerOfAttorneyTitleDescription; set => _powerOfAttorneyTitleDescription = value; }
        private DirtyValue<bool?> _presentlyDelinquentIndicator;
        public bool? PresentlyDelinquentIndicator { get => _presentlyDelinquentIndicator; set => _presentlyDelinquentIndicator = value; }
        private DirtyValue<DateTime?> _priorBankruptcy2;
        public DateTime? PriorBankruptcy2 { get => _priorBankruptcy2; set => _priorBankruptcy2 = value; }
        private DirtyValue<bool?> _priorForeclosure;
        public bool? PriorForeclosure { get => _priorForeclosure; set => _priorForeclosure = value; }
        private DirtyValue<StringEnumValue<PriorPropertyTitleType>> _priorPropertyTitleType;
        public StringEnumValue<PriorPropertyTitleType> PriorPropertyTitleType { get => _priorPropertyTitleType; set => _priorPropertyTitleType = value; }
        private DirtyValue<StringEnumValue<PriorPropertyUsageType>> _priorPropertyUsageType;
        public StringEnumValue<PriorPropertyUsageType> PriorPropertyUsageType { get => _priorPropertyUsageType; set => _priorPropertyUsageType = value; }
        private DirtyValue<bool?> _propertyForeclosedPastSevenYearsIndicator;
        public bool? PropertyForeclosedPastSevenYearsIndicator { get => _propertyForeclosedPastSevenYearsIndicator; set => _propertyForeclosedPastSevenYearsIndicator = value; }
        private DirtyValue<string> _relationshipDescription;
        public string RelationshipDescription { get => _relationshipDescription; set => _relationshipDescription = value; }
        private DirtyValue<bool?> _relationshipWithRDEmployeeIndicator;
        public bool? RelationshipWithRDEmployeeIndicator { get => _relationshipWithRDEmployeeIndicator; set => _relationshipWithRDEmployeeIndicator = value; }
        private DirtyValue<int?> _schoolingTermYears;
        public int? SchoolingTermYears { get => _schoolingTermYears; set => _schoolingTermYears = value; }
        private DirtyValue<bool?> _sSA89BackgroundCheckIndicator;
        public bool? SSA89BackgroundCheckIndicator { get => _sSA89BackgroundCheckIndicator; set => _sSA89BackgroundCheckIndicator = value; }
        private DirtyValue<bool?> _sSA89BankingServiceIndicator;
        public bool? SSA89BankingServiceIndicator { get => _sSA89BankingServiceIndicator; set => _sSA89BankingServiceIndicator = value; }
        private DirtyValue<bool?> _sSA89CreditCheckIndicator;
        public bool? SSA89CreditCheckIndicator { get => _sSA89CreditCheckIndicator; set => _sSA89CreditCheckIndicator = value; }
        private DirtyValue<bool?> _sSA89LicenseRequirementIndicator;
        public bool? SSA89LicenseRequirementIndicator { get => _sSA89LicenseRequirementIndicator; set => _sSA89LicenseRequirementIndicator = value; }
        private DirtyValue<bool?> _sSA89MortgageServiceIndicator;
        public bool? SSA89MortgageServiceIndicator { get => _sSA89MortgageServiceIndicator; set => _sSA89MortgageServiceIndicator = value; }
        private DirtyValue<bool?> _sSA89OtherIndicator;
        public bool? SSA89OtherIndicator { get => _sSA89OtherIndicator; set => _sSA89OtherIndicator = value; }
        private DirtyValue<decimal?> _subtotalLiquidAssetsMinusGiftAmount;
        public decimal? SubtotalLiquidAssetsMinusGiftAmount { get => _subtotalLiquidAssetsMinusGiftAmount; set => _subtotalLiquidAssetsMinusGiftAmount = value; }
        private DirtyValue<string> _suffixToName;
        public string SuffixToName { get => _suffixToName; set => _suffixToName = value; }
        private DirtyValue<string> _tax4506LastInvestor;
        public string Tax4506LastInvestor { get => _tax4506LastInvestor; set => _tax4506LastInvestor = value; }
        private DirtyValue<string> _tax4506LastOrderNumber;
        public string Tax4506LastOrderNumber { get => _tax4506LastOrderNumber; set => _tax4506LastOrderNumber = value; }
        private DirtyValue<int?> _tax4506LastOrderYear1;
        public int? Tax4506LastOrderYear1 { get => _tax4506LastOrderYear1; set => _tax4506LastOrderYear1 = value; }
        private DirtyValue<int?> _tax4506LastOrderYear2;
        public int? Tax4506LastOrderYear2 { get => _tax4506LastOrderYear2; set => _tax4506LastOrderYear2 = value; }
        private DirtyValue<int?> _tax4506LastOrderYear3;
        public int? Tax4506LastOrderYear3 { get => _tax4506LastOrderYear3; set => _tax4506LastOrderYear3 = value; }
        private DirtyValue<int?> _tax4506LastOrderYear4;
        public int? Tax4506LastOrderYear4 { get => _tax4506LastOrderYear4; set => _tax4506LastOrderYear4 = value; }
        private DirtyValue<string> _tax4506LastProductsOrdered;
        public string Tax4506LastProductsOrdered { get => _tax4506LastProductsOrdered; set => _tax4506LastProductsOrdered = value; }
        private DirtyValue<string> _tax4506LastStatus;
        public string Tax4506LastStatus { get => _tax4506LastStatus; set => _tax4506LastStatus = value; }
        private DirtyValue<string> _tax4506LastTranscriptType;
        public string Tax4506LastTranscriptType { get => _tax4506LastTranscriptType; set => _tax4506LastTranscriptType = value; }
        private DirtyValue<string> _tax4506LastUserIDWhoOrdered;
        public string Tax4506LastUserIDWhoOrdered { get => _tax4506LastUserIDWhoOrdered; set => _tax4506LastUserIDWhoOrdered = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyIncome1;
        public decimal? Tax4506TotalYearlyIncome1 { get => _tax4506TotalYearlyIncome1; set => _tax4506TotalYearlyIncome1 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyIncome2;
        public decimal? Tax4506TotalYearlyIncome2 { get => _tax4506TotalYearlyIncome2; set => _tax4506TotalYearlyIncome2 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyIncome3;
        public decimal? Tax4506TotalYearlyIncome3 { get => _tax4506TotalYearlyIncome3; set => _tax4506TotalYearlyIncome3 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyIncome4;
        public decimal? Tax4506TotalYearlyIncome4 { get => _tax4506TotalYearlyIncome4; set => _tax4506TotalYearlyIncome4 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyJointIncome1;
        public decimal? Tax4506TotalYearlyJointIncome1 { get => _tax4506TotalYearlyJointIncome1; set => _tax4506TotalYearlyJointIncome1 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyJointIncome2;
        public decimal? Tax4506TotalYearlyJointIncome2 { get => _tax4506TotalYearlyJointIncome2; set => _tax4506TotalYearlyJointIncome2 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyJointIncome3;
        public decimal? Tax4506TotalYearlyJointIncome3 { get => _tax4506TotalYearlyJointIncome3; set => _tax4506TotalYearlyJointIncome3 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyJointIncome4;
        public decimal? Tax4506TotalYearlyJointIncome4 { get => _tax4506TotalYearlyJointIncome4; set => _tax4506TotalYearlyJointIncome4 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceIncome1;
        public decimal? Tax4506TotalYearlyVarianceIncome1 { get => _tax4506TotalYearlyVarianceIncome1; set => _tax4506TotalYearlyVarianceIncome1 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceIncome2;
        public decimal? Tax4506TotalYearlyVarianceIncome2 { get => _tax4506TotalYearlyVarianceIncome2; set => _tax4506TotalYearlyVarianceIncome2 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceIncome3;
        public decimal? Tax4506TotalYearlyVarianceIncome3 { get => _tax4506TotalYearlyVarianceIncome3; set => _tax4506TotalYearlyVarianceIncome3 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceIncome4;
        public decimal? Tax4506TotalYearlyVarianceIncome4 { get => _tax4506TotalYearlyVarianceIncome4; set => _tax4506TotalYearlyVarianceIncome4 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceJointIncome1;
        public decimal? Tax4506TotalYearlyVarianceJointIncome1 { get => _tax4506TotalYearlyVarianceJointIncome1; set => _tax4506TotalYearlyVarianceJointIncome1 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceJointIncome2;
        public decimal? Tax4506TotalYearlyVarianceJointIncome2 { get => _tax4506TotalYearlyVarianceJointIncome2; set => _tax4506TotalYearlyVarianceJointIncome2 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceJointIncome3;
        public decimal? Tax4506TotalYearlyVarianceJointIncome3 { get => _tax4506TotalYearlyVarianceJointIncome3; set => _tax4506TotalYearlyVarianceJointIncome3 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceJointIncome4;
        public decimal? Tax4506TotalYearlyVarianceJointIncome4 { get => _tax4506TotalYearlyVarianceJointIncome4; set => _tax4506TotalYearlyVarianceJointIncome4 = value; }
        private DirtyValue<string> _taxIdentificationIdentifier;
        public string TaxIdentificationIdentifier { get => _taxIdentificationIdentifier; set => _taxIdentificationIdentifier = value; }
        private DirtyValue<decimal?> _totalLiabilitiesBalanceAmount;
        public decimal? TotalLiabilitiesBalanceAmount { get => _totalLiabilitiesBalanceAmount; set => _totalLiabilitiesBalanceAmount = value; }
        private DirtyValue<decimal?> _totalMonthlyIncomeAmount;
        public decimal? TotalMonthlyIncomeAmount { get => _totalMonthlyIncomeAmount; set => _totalMonthlyIncomeAmount = value; }
        private DirtyValue<decimal?> _totalMonthlyIncomeMinusNetRentalAmount;
        public decimal? TotalMonthlyIncomeMinusNetRentalAmount { get => _totalMonthlyIncomeMinusNetRentalAmount; set => _totalMonthlyIncomeMinusNetRentalAmount = value; }
        private DirtyValue<decimal?> _totalPresentHousingExpenseAmount;
        public decimal? TotalPresentHousingExpenseAmount { get => _totalPresentHousingExpenseAmount; set => _totalPresentHousingExpenseAmount = value; }
        private DirtyValue<string> _transactionPurposeDescription;
        public string TransactionPurposeDescription { get => _transactionPurposeDescription; set => _transactionPurposeDescription = value; }
        private DirtyValue<int?> _transUnion120Days;
        public int? TransUnion120Days { get => _transUnion120Days; set => _transUnion120Days = value; }
        private DirtyValue<int?> _transUnion150Days;
        public int? TransUnion150Days { get => _transUnion150Days; set => _transUnion150Days = value; }
        private DirtyValue<int?> _transUnion30Days;
        public int? TransUnion30Days { get => _transUnion30Days; set => _transUnion30Days = value; }
        private DirtyValue<int?> _transUnion60Days;
        public int? TransUnion60Days { get => _transUnion60Days; set => _transUnion60Days = value; }
        private DirtyValue<int?> _transUnion90Days;
        public int? TransUnion90Days { get => _transUnion90Days; set => _transUnion90Days = value; }
        private DirtyValue<bool?> _transUnionCreditScoreForDisclosure;
        public bool? TransUnionCreditScoreForDisclosure { get => _transUnionCreditScoreForDisclosure; set => _transUnionCreditScoreForDisclosure = value; }
        private DirtyValue<int?> _transUnionCreditScoreRanksPercent;
        public int? TransUnionCreditScoreRanksPercent { get => _transUnionCreditScoreRanksPercent; set => _transUnionCreditScoreRanksPercent = value; }
        private DirtyValue<DateTime?> _transUnionDatePulled;
        public DateTime? TransUnionDatePulled { get => _transUnionDatePulled; set => _transUnionDatePulled = value; }
        private DirtyValue<string> _transUnionFactorCode1;
        public string TransUnionFactorCode1 { get => _transUnionFactorCode1; set => _transUnionFactorCode1 = value; }
        private DirtyValue<string> _transUnionFactorCode2;
        public string TransUnionFactorCode2 { get => _transUnionFactorCode2; set => _transUnionFactorCode2 = value; }
        private DirtyValue<string> _transUnionFactorCode3;
        public string TransUnionFactorCode3 { get => _transUnionFactorCode3; set => _transUnionFactorCode3 = value; }
        private DirtyValue<string> _transUnionFactorCode4;
        public string TransUnionFactorCode4 { get => _transUnionFactorCode4; set => _transUnionFactorCode4 = value; }
        private DirtyValue<string> _transUnionFactorCode5;
        public string TransUnionFactorCode5 { get => _transUnionFactorCode5; set => _transUnionFactorCode5 = value; }
        private DirtyValue<string> _transUnionKeyFactor1;
        public string TransUnionKeyFactor1 { get => _transUnionKeyFactor1; set => _transUnionKeyFactor1 = value; }
        private DirtyValue<string> _transUnionKeyFactor2;
        public string TransUnionKeyFactor2 { get => _transUnionKeyFactor2; set => _transUnionKeyFactor2 = value; }
        private DirtyValue<string> _transUnionKeyFactor3;
        public string TransUnionKeyFactor3 { get => _transUnionKeyFactor3; set => _transUnionKeyFactor3 = value; }
        private DirtyValue<string> _transUnionKeyFactor4;
        public string TransUnionKeyFactor4 { get => _transUnionKeyFactor4; set => _transUnionKeyFactor4 = value; }
        private DirtyValue<string> _transUnionKeyFactor5;
        public string TransUnionKeyFactor5 { get => _transUnionKeyFactor5; set => _transUnionKeyFactor5 = value; }
        private DirtyValue<bool?> _transUnionMaterialTermsCreditByScore;
        public bool? TransUnionMaterialTermsCreditByScore { get => _transUnionMaterialTermsCreditByScore; set => _transUnionMaterialTermsCreditByScore = value; }
        private DirtyValue<string> _transUnionScore;
        public string TransUnionScore { get => _transUnionScore; set => _transUnionScore = value; }
        private DirtyValue<decimal?> _userDefinedIncome;
        public decimal? UserDefinedIncome { get => _userDefinedIncome; set => _userDefinedIncome = value; }
        private DirtyValue<decimal?> _vaFederalTaxAmount;
        public decimal? VaFederalTaxAmount { get => _vaFederalTaxAmount; set => _vaFederalTaxAmount = value; }
        private DirtyValue<int?> _validDaysForConsentCount;
        public int? ValidDaysForConsentCount { get => _validDaysForConsentCount; set => _validDaysForConsentCount = value; }
        private DirtyValue<bool?> _valueRepAndWarrantyAvailable;
        public bool? ValueRepAndWarrantyAvailable { get => _valueRepAndWarrantyAvailable; set => _valueRepAndWarrantyAvailable = value; }
        private DirtyValue<string> _valueRepAndWarrantyMessage;
        public string ValueRepAndWarrantyMessage { get => _valueRepAndWarrantyMessage; set => _valueRepAndWarrantyMessage = value; }
        private DirtyValue<decimal?> _vaNetTakeHomePayAmount;
        public decimal? VaNetTakeHomePayAmount { get => _vaNetTakeHomePayAmount; set => _vaNetTakeHomePayAmount = value; }
        private DirtyValue<decimal?> _vaOtherAmount;
        public decimal? VaOtherAmount { get => _vaOtherAmount; set => _vaOtherAmount = value; }
        private DirtyValue<decimal?> _vaOtherNetIncomeAmount;
        public decimal? VaOtherNetIncomeAmount { get => _vaOtherNetIncomeAmount; set => _vaOtherNetIncomeAmount = value; }
        private DirtyValue<decimal?> _vaRetirementAmount;
        public decimal? VaRetirementAmount { get => _vaRetirementAmount; set => _vaRetirementAmount = value; }
        private DirtyValue<decimal?> _vaStateTaxAmount;
        public decimal? VaStateTaxAmount { get => _vaStateTaxAmount; set => _vaStateTaxAmount = value; }
        private DirtyValue<decimal?> _vaTotalIncomeDeductionsAmount;
        public decimal? VaTotalIncomeDeductionsAmount { get => _vaTotalIncomeDeductionsAmount; set => _vaTotalIncomeDeductionsAmount = value; }
        private DirtyValue<decimal?> _vaTotalNetIncomeAmount;
        public decimal? VaTotalNetIncomeAmount { get => _vaTotalNetIncomeAmount; set => _vaTotalNetIncomeAmount = value; }
        private DirtyValue<string> _vendor1;
        public string Vendor1 { get => _vendor1; set => _vendor1 = value; }
        private DirtyValue<string> _vendor10;
        public string Vendor10 { get => _vendor10; set => _vendor10 = value; }
        private DirtyValue<string> _vendor11;
        public string Vendor11 { get => _vendor11; set => _vendor11 = value; }
        private DirtyValue<string> _vendor12;
        public string Vendor12 { get => _vendor12; set => _vendor12 = value; }
        private DirtyValue<string> _vendor2;
        public string Vendor2 { get => _vendor2; set => _vendor2 = value; }
        private DirtyValue<string> _vendor3;
        public string Vendor3 { get => _vendor3; set => _vendor3 = value; }
        private DirtyValue<string> _vendor4;
        public string Vendor4 { get => _vendor4; set => _vendor4 = value; }
        private DirtyValue<string> _vendor5;
        public string Vendor5 { get => _vendor5; set => _vendor5 = value; }
        private DirtyValue<string> _vendor6;
        public string Vendor6 { get => _vendor6; set => _vendor6 = value; }
        private DirtyValue<string> _vendor7;
        public string Vendor7 { get => _vendor7; set => _vendor7 = value; }
        private DirtyValue<string> _vendor8;
        public string Vendor8 { get => _vendor8; set => _vendor8 = value; }
        private DirtyValue<string> _vendor9;
        public string Vendor9 { get => _vendor9; set => _vendor9 = value; }
        private DirtyValue<StringEnumValue<VestingTrusteeOfType>> _vestingTrusteeOfType;
        public StringEnumValue<VestingTrusteeOfType> VestingTrusteeOfType { get => _vestingTrusteeOfType; set => _vestingTrusteeOfType = value; }
        private DirtyValue<bool?> _veteranIndicator;
        public bool? VeteranIndicator { get => _veteranIndicator; set => _veteranIndicator = value; }
        private DirtyValue<string> _workEmailAddress;
        public string WorkEmailAddress { get => _workEmailAddress; set => _workEmailAddress = value; }
        private DirtyValue<int?> _yearsofCreditOnFile;
        public int? YearsofCreditOnFile { get => _yearsofCreditOnFile; set => _yearsofCreditOnFile = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _acountChekAssetId.Dirty
                    || _ageAtApplicationYearsCount.Dirty
                    || _aliasName.Dirty
                    || _alimonyChildSupportObligationIndicator.Dirty
                    || _altId.Dirty
                    || _applicantType.Dirty
                    || _applicationTakenMethodType.Dirty
                    || _assetRepAndWarrantyMessage.Dirty
                    || _assetRepAndWarrantyReliefAvailable.Dirty
                    || _authorizedCreditReportIndicator.Dirty
                    || _authorizedToSignIndicator.Dirty
                    || _bankAccountNumber.Dirty
                    || _bankAccountType.Dirty
                    || _bankContactAddress.Dirty
                    || _bankContactCity.Dirty
                    || _bankContactName.Dirty
                    || _bankContactPostalCode.Dirty
                    || _bankContactState.Dirty
                    || _bankruptcyIndicator.Dirty
                    || _bankruptcyStatus.Dirty
                    || _baseMonthlyIncomeAmount.Dirty
                    || _birthDate.Dirty
                    || _borrowedDownPaymentIndicator.Dirty
                    || _borrowerConsentRequestDate.Dirty
                    || _borrowerIndex.Dirty
                    || _borrowerType.Dirty
                    || _borrowerTypeInSummary.Dirty
                    || _caivrsIdentifier.Dirty
                    || _citizenshipResidencyType.Dirty
                    || _coMakerEndorserOfNoteIndicator.Dirty
                    || _commentOfCreditReport.Dirty
                    || _confirmedCRDIL.Dirty
                    || _confirmedCRFCEC.Dirty
                    || _confirmedCRFCIncorrect.Dirty
                    || _confirmedCRPFS.Dirty
                    || _confirmedOther.Dirty
                    || _confirmedOtherDescription.Dirty
                    || _creditCounseling.Dirty
                    || _creditReceivedDate.Dirty
                    || _creditReportAuthorizationMethod.Dirty
                    || _creditScoreIndicator.Dirty
                    || _dateAuthorizedCreditReport.Dirty
                    || _dateOfBankruptcy.Dirty
                    || _dateOfForeclosure.Dirty
                    || _declarationsJIndicator.Dirty
                    || _declarationsKIndicator.Dirty
                    || _dependentCount.Dirty
                    || _dependentsAgesDescription.Dirty
                    || _disabledIndicator.Dirty
                    || _emailAddressText.Dirty
                    || _equifax120Days.Dirty
                    || _equifax150Days.Dirty
                    || _equifax30Days.Dirty
                    || _equifax60Days.Dirty
                    || _equifax90Days.Dirty
                    || _equifaxCreditScoreForDisclosure.Dirty
                    || _equifaxCreditScoreRanksPercent.Dirty
                    || _equifaxDatePulled.Dirty
                    || _equifaxFactorCode1.Dirty
                    || _equifaxFactorCode2.Dirty
                    || _equifaxFactorCode3.Dirty
                    || _equifaxFactorCode4.Dirty
                    || _equifaxFactorCode5.Dirty
                    || _equifaxKeyFactor1.Dirty
                    || _equifaxKeyFactor2.Dirty
                    || _equifaxKeyFactor3.Dirty
                    || _equifaxKeyFactor4.Dirty
                    || _equifaxKeyFactor5.Dirty
                    || _equifaxMaterialTermsCreditByScore.Dirty
                    || _equifaxScore.Dirty
                    || _experian120Days.Dirty
                    || _experian150Days.Dirty
                    || _experian30Days.Dirty
                    || _experian60Days.Dirty
                    || _experian90Days.Dirty
                    || _experianCreditScore.Dirty
                    || _experianCreditScoreForDisclosure.Dirty
                    || _experianCreditScoreRanksPercent.Dirty
                    || _experianDatePulled.Dirty
                    || _experianFactorCode1.Dirty
                    || _experianFactorCode2.Dirty
                    || _experianFactorCode3.Dirty
                    || _experianFactorCode4.Dirty
                    || _experianFactorCode5.Dirty
                    || _experianKeyFactor1.Dirty
                    || _experianKeyFactor2.Dirty
                    || _experianKeyFactor3.Dirty
                    || _experianKeyFactor4.Dirty
                    || _experianKeyFactor5.Dirty
                    || _experianMaterialTermsCreditByScore.Dirty
                    || _firstName.Dirty
                    || _firstNameWithMiddleName.Dirty
                    || _firstTimeHomeBuyer.Dirty
                    || _foreclosureSatisfied.Dirty
                    || _foreclosureStatus.Dirty
                    || _freddieMacPerson1.Dirty
                    || _freddieMacPerson2.Dirty
                    || _fullName.Dirty
                    || _fullNameWithSuffix.Dirty
                    || _highestCreditLimit.Dirty
                    || _hmda2003OtherRaceNationalOriginDescription.Dirty
                    || _hmda2003RaceNationalOriginType.Dirty
                    || _hmdaAfricanAmericanIndicator.Dirty
                    || _hmdaAge.Dirty
                    || _hmdaAmericanIndianIndicator.Dirty
                    || _hmdaAmericanIndianTribe.Dirty
                    || _hmdaAsianIndianIndicator.Dirty
                    || _hmdaAsianIndicator.Dirty
                    || _hmdaAsianOtherRaceIndicator.Dirty
                    || _hmdaChineseIndicator.Dirty
                    || _hmdaCreditScoreForDecisionMaking.Dirty
                    || _hmdaCreditScoringModel.Dirty
                    || _hmdaCubanIndicator.Dirty
                    || _hmdaEthnicityDoNotWishIndicator.Dirty
                    || _hmdaEthnicityHispanicLatinoIndicator.Dirty
                    || _hmdaEthnicityNotApplicableIndicator.Dirty
                    || _hmdaEthnicityNotHispanicLatinoIndicator.Dirty
                    || _hmdaEthnicityReportedField1.Dirty
                    || _hmdaEthnicityReportedField2.Dirty
                    || _hmdaEthnicityReportedField3.Dirty
                    || _hmdaEthnicityReportedField4.Dirty
                    || _hmdaEthnicityReportedField5.Dirty
                    || _hmdaEthnicityType.Dirty
                    || _hmdaFilipinoIndicator.Dirty
                    || _hmdaGenderType.Dirty
                    || _hmdaGendertypeDoNotWishIndicator.Dirty
                    || _hmdaGendertypeFemaleIndicator.Dirty
                    || _hmdaGendertypeMaleIndicator.Dirty
                    || _hmdaGendertypeNotApplicableIndicator.Dirty
                    || _hmdaGuamanianOrChamorroIndicator.Dirty
                    || _hmdaHispanicLatinoOtherOriginIndicator.Dirty
                    || _hmdaJapaneseIndicator.Dirty
                    || _hmdaKoreanIndicator.Dirty
                    || _hmdaMexicanIndicator.Dirty
                    || _hmdaNativeHawaiianIndicator.Dirty
                    || _hmdaNoCoApplicantIndicator.Dirty
                    || _hmdaNotApplicableIndicator.Dirty
                    || _hmdaNotProvidedIndicator.Dirty
                    || _hmdaOtherAsianRace.Dirty
                    || _hmdaOtherHispanicLatinoOrigin.Dirty
                    || _hmdaOtherPacificIslanderRace.Dirty
                    || _hmdaOtherScoringModel.Dirty
                    || _hmdaPacificIslanderIndicator.Dirty
                    || _hmdaPacificIslanderOtherIndicator.Dirty
                    || _hmdaPuertoRicanIndicator.Dirty
                    || _hmdaRaceReportedField1.Dirty
                    || _hmdaRaceReportedField2.Dirty
                    || _hmdaRaceReportedField3.Dirty
                    || _hmdaRaceReportedField4.Dirty
                    || _hmdaRaceReportedField5.Dirty
                    || _hmdaRefusalIndicator.Dirty
                    || _hmdaSamoanIndicator.Dirty
                    || _hmdaVietnameseIndicator.Dirty
                    || _hmdaWhiteIndicator.Dirty
                    || _homeownerPastThreeYearsIndicator.Dirty
                    || _homePhoneNumber.Dirty
                    || _id.Dirty
                    || _incomeRepAndWarrantyMessage.Dirty
                    || _incomeRepAndWarrantyReliefAvailable.Dirty
                    || _intentToOccupyIndicator.Dirty
                    || _intuitReportId.Dirty
                    || _isBaseIncomeAvailable.Dirty
                    || _isBonusAvailable.Dirty
                    || _isBorrower.Dirty
                    || _isCommissionAvailable.Dirty
                    || _isEthnicityBasedOnVisual.Dirty
                    || _isOvertimeAvailable.Dirty
                    || _isRaceBasedOnVisual.Dirty
                    || _isSelfEmployed.Dirty
                    || _isSexBasedOnVisual.Dirty
                    || _isSocialSecurityAvailable.Dirty
                    || _lastName.Dirty
                    || _lastNameWithSuffix.Dirty
                    || _loanForeclosureOrJudgementIndicator.Dirty
                    || _lpdGsa.Dirty
                    || _mailingAddressSameAsPresentIndicator.Dirty
                    || _maritalStatusType.Dirty
                    || _middleCreditScore.Dirty
                    || _middleFicoScore.Dirty
                    || _middleName.Dirty
                    || _minFicoScore.Dirty
                    || _mobilePhone.Dirty
                    || _mortgageOnCredit.Dirty
                    || _nameToObtainLoanFromRHS.Dirty
                    || _nearestRelativeAddress.Dirty
                    || _nearestRelativeCity.Dirty
                    || _nearestRelativeName.Dirty
                    || _nearestRelativePhone.Dirty
                    || _nearestRelativePostalCode.Dirty
                    || _nearestRelativeRelationship.Dirty
                    || _nearestRelativeState.Dirty
                    || _no3rdPartyEmailIndicator.Dirty
                    || _noCoApplicantEthnicityIndicator.Dirty
                    || _noCoApplicantIndicator.Dirty
                    || _noCoApplicantSexIndicator.Dirty
                    || _numberofTradelines.Dirty
                    || _obtainLoanFromRHSIndicator.Dirty
                    || _openBankruptcy2.Dirty
                    || _otherMonthlyIncomeAmount.Dirty
                    || _otherSumAmount.Dirty
                    || _outstandingJudgementsIndicator.Dirty
                    || _partyToLawsuitIndicator.Dirty
                    || _pass120Days.Dirty
                    || _pass150Days.Dirty
                    || _pass30Days.Dirty
                    || _pass60Days.Dirty
                    || _pass90Days.Dirty
                    || _personFaxNumber.Dirty
                    || _personHoursPerWeek.Dirty
                    || _personIncomeAmount.Dirty
                    || _personIncomeFrequencyType.Dirty
                    || _personMonthlyIncome.Dirty
                    || _pIWAccepted.Dirty
                    || _pIWMessage.Dirty
                    || _poaOccupancyIntent.Dirty
                    || _poaSignatureText.Dirty
                    || _positiveCashFlow.Dirty
                    || _powerOfAttorneyName.Dirty
                    || _powerOfAttorneyTitleDescription.Dirty
                    || _presentlyDelinquentIndicator.Dirty
                    || _priorBankruptcy2.Dirty
                    || _priorForeclosure.Dirty
                    || _priorPropertyTitleType.Dirty
                    || _priorPropertyUsageType.Dirty
                    || _propertyForeclosedPastSevenYearsIndicator.Dirty
                    || _relationshipDescription.Dirty
                    || _relationshipWithRDEmployeeIndicator.Dirty
                    || _schoolingTermYears.Dirty
                    || _sSA89BackgroundCheckIndicator.Dirty
                    || _sSA89BankingServiceIndicator.Dirty
                    || _sSA89CreditCheckIndicator.Dirty
                    || _sSA89LicenseRequirementIndicator.Dirty
                    || _sSA89MortgageServiceIndicator.Dirty
                    || _sSA89OtherIndicator.Dirty
                    || _subtotalLiquidAssetsMinusGiftAmount.Dirty
                    || _suffixToName.Dirty
                    || _tax4506LastInvestor.Dirty
                    || _tax4506LastOrderNumber.Dirty
                    || _tax4506LastOrderYear1.Dirty
                    || _tax4506LastOrderYear2.Dirty
                    || _tax4506LastOrderYear3.Dirty
                    || _tax4506LastOrderYear4.Dirty
                    || _tax4506LastProductsOrdered.Dirty
                    || _tax4506LastStatus.Dirty
                    || _tax4506LastTranscriptType.Dirty
                    || _tax4506LastUserIDWhoOrdered.Dirty
                    || _tax4506TotalYearlyIncome1.Dirty
                    || _tax4506TotalYearlyIncome2.Dirty
                    || _tax4506TotalYearlyIncome3.Dirty
                    || _tax4506TotalYearlyIncome4.Dirty
                    || _tax4506TotalYearlyJointIncome1.Dirty
                    || _tax4506TotalYearlyJointIncome2.Dirty
                    || _tax4506TotalYearlyJointIncome3.Dirty
                    || _tax4506TotalYearlyJointIncome4.Dirty
                    || _tax4506TotalYearlyVarianceIncome1.Dirty
                    || _tax4506TotalYearlyVarianceIncome2.Dirty
                    || _tax4506TotalYearlyVarianceIncome3.Dirty
                    || _tax4506TotalYearlyVarianceIncome4.Dirty
                    || _tax4506TotalYearlyVarianceJointIncome1.Dirty
                    || _tax4506TotalYearlyVarianceJointIncome2.Dirty
                    || _tax4506TotalYearlyVarianceJointIncome3.Dirty
                    || _tax4506TotalYearlyVarianceJointIncome4.Dirty
                    || _taxIdentificationIdentifier.Dirty
                    || _totalLiabilitiesBalanceAmount.Dirty
                    || _totalMonthlyIncomeAmount.Dirty
                    || _totalMonthlyIncomeMinusNetRentalAmount.Dirty
                    || _totalPresentHousingExpenseAmount.Dirty
                    || _transactionPurposeDescription.Dirty
                    || _transUnion120Days.Dirty
                    || _transUnion150Days.Dirty
                    || _transUnion30Days.Dirty
                    || _transUnion60Days.Dirty
                    || _transUnion90Days.Dirty
                    || _transUnionCreditScoreForDisclosure.Dirty
                    || _transUnionCreditScoreRanksPercent.Dirty
                    || _transUnionDatePulled.Dirty
                    || _transUnionFactorCode1.Dirty
                    || _transUnionFactorCode2.Dirty
                    || _transUnionFactorCode3.Dirty
                    || _transUnionFactorCode4.Dirty
                    || _transUnionFactorCode5.Dirty
                    || _transUnionKeyFactor1.Dirty
                    || _transUnionKeyFactor2.Dirty
                    || _transUnionKeyFactor3.Dirty
                    || _transUnionKeyFactor4.Dirty
                    || _transUnionKeyFactor5.Dirty
                    || _transUnionMaterialTermsCreditByScore.Dirty
                    || _transUnionScore.Dirty
                    || _userDefinedIncome.Dirty
                    || _vaFederalTaxAmount.Dirty
                    || _validDaysForConsentCount.Dirty
                    || _valueRepAndWarrantyAvailable.Dirty
                    || _valueRepAndWarrantyMessage.Dirty
                    || _vaNetTakeHomePayAmount.Dirty
                    || _vaOtherAmount.Dirty
                    || _vaOtherNetIncomeAmount.Dirty
                    || _vaRetirementAmount.Dirty
                    || _vaStateTaxAmount.Dirty
                    || _vaTotalIncomeDeductionsAmount.Dirty
                    || _vaTotalNetIncomeAmount.Dirty
                    || _vendor1.Dirty
                    || _vendor10.Dirty
                    || _vendor11.Dirty
                    || _vendor12.Dirty
                    || _vendor2.Dirty
                    || _vendor3.Dirty
                    || _vendor4.Dirty
                    || _vendor5.Dirty
                    || _vendor6.Dirty
                    || _vendor7.Dirty
                    || _vendor8.Dirty
                    || _vendor9.Dirty
                    || _vestingTrusteeOfType.Dirty
                    || _veteranIndicator.Dirty
                    || _workEmailAddress.Dirty
                    || _yearsofCreditOnFile.Dirty
                    || _application?.Dirty == true;
            }
            set
            {
                _acountChekAssetId.Dirty = value;
                _ageAtApplicationYearsCount.Dirty = value;
                _aliasName.Dirty = value;
                _alimonyChildSupportObligationIndicator.Dirty = value;
                _altId.Dirty = value;
                _applicantType.Dirty = value;
                _applicationTakenMethodType.Dirty = value;
                _assetRepAndWarrantyMessage.Dirty = value;
                _assetRepAndWarrantyReliefAvailable.Dirty = value;
                _authorizedCreditReportIndicator.Dirty = value;
                _authorizedToSignIndicator.Dirty = value;
                _bankAccountNumber.Dirty = value;
                _bankAccountType.Dirty = value;
                _bankContactAddress.Dirty = value;
                _bankContactCity.Dirty = value;
                _bankContactName.Dirty = value;
                _bankContactPostalCode.Dirty = value;
                _bankContactState.Dirty = value;
                _bankruptcyIndicator.Dirty = value;
                _bankruptcyStatus.Dirty = value;
                _baseMonthlyIncomeAmount.Dirty = value;
                _birthDate.Dirty = value;
                _borrowedDownPaymentIndicator.Dirty = value;
                _borrowerConsentRequestDate.Dirty = value;
                _borrowerIndex.Dirty = value;
                _borrowerType.Dirty = value;
                _borrowerTypeInSummary.Dirty = value;
                _caivrsIdentifier.Dirty = value;
                _citizenshipResidencyType.Dirty = value;
                _coMakerEndorserOfNoteIndicator.Dirty = value;
                _commentOfCreditReport.Dirty = value;
                _confirmedCRDIL.Dirty = value;
                _confirmedCRFCEC.Dirty = value;
                _confirmedCRFCIncorrect.Dirty = value;
                _confirmedCRPFS.Dirty = value;
                _confirmedOther.Dirty = value;
                _confirmedOtherDescription.Dirty = value;
                _creditCounseling.Dirty = value;
                _creditReceivedDate.Dirty = value;
                _creditReportAuthorizationMethod.Dirty = value;
                _creditScoreIndicator.Dirty = value;
                _dateAuthorizedCreditReport.Dirty = value;
                _dateOfBankruptcy.Dirty = value;
                _dateOfForeclosure.Dirty = value;
                _declarationsJIndicator.Dirty = value;
                _declarationsKIndicator.Dirty = value;
                _dependentCount.Dirty = value;
                _dependentsAgesDescription.Dirty = value;
                _disabledIndicator.Dirty = value;
                _emailAddressText.Dirty = value;
                _equifax120Days.Dirty = value;
                _equifax150Days.Dirty = value;
                _equifax30Days.Dirty = value;
                _equifax60Days.Dirty = value;
                _equifax90Days.Dirty = value;
                _equifaxCreditScoreForDisclosure.Dirty = value;
                _equifaxCreditScoreRanksPercent.Dirty = value;
                _equifaxDatePulled.Dirty = value;
                _equifaxFactorCode1.Dirty = value;
                _equifaxFactorCode2.Dirty = value;
                _equifaxFactorCode3.Dirty = value;
                _equifaxFactorCode4.Dirty = value;
                _equifaxFactorCode5.Dirty = value;
                _equifaxKeyFactor1.Dirty = value;
                _equifaxKeyFactor2.Dirty = value;
                _equifaxKeyFactor3.Dirty = value;
                _equifaxKeyFactor4.Dirty = value;
                _equifaxKeyFactor5.Dirty = value;
                _equifaxMaterialTermsCreditByScore.Dirty = value;
                _equifaxScore.Dirty = value;
                _experian120Days.Dirty = value;
                _experian150Days.Dirty = value;
                _experian30Days.Dirty = value;
                _experian60Days.Dirty = value;
                _experian90Days.Dirty = value;
                _experianCreditScore.Dirty = value;
                _experianCreditScoreForDisclosure.Dirty = value;
                _experianCreditScoreRanksPercent.Dirty = value;
                _experianDatePulled.Dirty = value;
                _experianFactorCode1.Dirty = value;
                _experianFactorCode2.Dirty = value;
                _experianFactorCode3.Dirty = value;
                _experianFactorCode4.Dirty = value;
                _experianFactorCode5.Dirty = value;
                _experianKeyFactor1.Dirty = value;
                _experianKeyFactor2.Dirty = value;
                _experianKeyFactor3.Dirty = value;
                _experianKeyFactor4.Dirty = value;
                _experianKeyFactor5.Dirty = value;
                _experianMaterialTermsCreditByScore.Dirty = value;
                _firstName.Dirty = value;
                _firstNameWithMiddleName.Dirty = value;
                _firstTimeHomeBuyer.Dirty = value;
                _foreclosureSatisfied.Dirty = value;
                _foreclosureStatus.Dirty = value;
                _freddieMacPerson1.Dirty = value;
                _freddieMacPerson2.Dirty = value;
                _fullName.Dirty = value;
                _fullNameWithSuffix.Dirty = value;
                _highestCreditLimit.Dirty = value;
                _hmda2003OtherRaceNationalOriginDescription.Dirty = value;
                _hmda2003RaceNationalOriginType.Dirty = value;
                _hmdaAfricanAmericanIndicator.Dirty = value;
                _hmdaAge.Dirty = value;
                _hmdaAmericanIndianIndicator.Dirty = value;
                _hmdaAmericanIndianTribe.Dirty = value;
                _hmdaAsianIndianIndicator.Dirty = value;
                _hmdaAsianIndicator.Dirty = value;
                _hmdaAsianOtherRaceIndicator.Dirty = value;
                _hmdaChineseIndicator.Dirty = value;
                _hmdaCreditScoreForDecisionMaking.Dirty = value;
                _hmdaCreditScoringModel.Dirty = value;
                _hmdaCubanIndicator.Dirty = value;
                _hmdaEthnicityDoNotWishIndicator.Dirty = value;
                _hmdaEthnicityHispanicLatinoIndicator.Dirty = value;
                _hmdaEthnicityNotApplicableIndicator.Dirty = value;
                _hmdaEthnicityNotHispanicLatinoIndicator.Dirty = value;
                _hmdaEthnicityReportedField1.Dirty = value;
                _hmdaEthnicityReportedField2.Dirty = value;
                _hmdaEthnicityReportedField3.Dirty = value;
                _hmdaEthnicityReportedField4.Dirty = value;
                _hmdaEthnicityReportedField5.Dirty = value;
                _hmdaEthnicityType.Dirty = value;
                _hmdaFilipinoIndicator.Dirty = value;
                _hmdaGenderType.Dirty = value;
                _hmdaGendertypeDoNotWishIndicator.Dirty = value;
                _hmdaGendertypeFemaleIndicator.Dirty = value;
                _hmdaGendertypeMaleIndicator.Dirty = value;
                _hmdaGendertypeNotApplicableIndicator.Dirty = value;
                _hmdaGuamanianOrChamorroIndicator.Dirty = value;
                _hmdaHispanicLatinoOtherOriginIndicator.Dirty = value;
                _hmdaJapaneseIndicator.Dirty = value;
                _hmdaKoreanIndicator.Dirty = value;
                _hmdaMexicanIndicator.Dirty = value;
                _hmdaNativeHawaiianIndicator.Dirty = value;
                _hmdaNoCoApplicantIndicator.Dirty = value;
                _hmdaNotApplicableIndicator.Dirty = value;
                _hmdaNotProvidedIndicator.Dirty = value;
                _hmdaOtherAsianRace.Dirty = value;
                _hmdaOtherHispanicLatinoOrigin.Dirty = value;
                _hmdaOtherPacificIslanderRace.Dirty = value;
                _hmdaOtherScoringModel.Dirty = value;
                _hmdaPacificIslanderIndicator.Dirty = value;
                _hmdaPacificIslanderOtherIndicator.Dirty = value;
                _hmdaPuertoRicanIndicator.Dirty = value;
                _hmdaRaceReportedField1.Dirty = value;
                _hmdaRaceReportedField2.Dirty = value;
                _hmdaRaceReportedField3.Dirty = value;
                _hmdaRaceReportedField4.Dirty = value;
                _hmdaRaceReportedField5.Dirty = value;
                _hmdaRefusalIndicator.Dirty = value;
                _hmdaSamoanIndicator.Dirty = value;
                _hmdaVietnameseIndicator.Dirty = value;
                _hmdaWhiteIndicator.Dirty = value;
                _homeownerPastThreeYearsIndicator.Dirty = value;
                _homePhoneNumber.Dirty = value;
                _id.Dirty = value;
                _incomeRepAndWarrantyMessage.Dirty = value;
                _incomeRepAndWarrantyReliefAvailable.Dirty = value;
                _intentToOccupyIndicator.Dirty = value;
                _intuitReportId.Dirty = value;
                _isBaseIncomeAvailable.Dirty = value;
                _isBonusAvailable.Dirty = value;
                _isBorrower.Dirty = value;
                _isCommissionAvailable.Dirty = value;
                _isEthnicityBasedOnVisual.Dirty = value;
                _isOvertimeAvailable.Dirty = value;
                _isRaceBasedOnVisual.Dirty = value;
                _isSelfEmployed.Dirty = value;
                _isSexBasedOnVisual.Dirty = value;
                _isSocialSecurityAvailable.Dirty = value;
                _lastName.Dirty = value;
                _lastNameWithSuffix.Dirty = value;
                _loanForeclosureOrJudgementIndicator.Dirty = value;
                _lpdGsa.Dirty = value;
                _mailingAddressSameAsPresentIndicator.Dirty = value;
                _maritalStatusType.Dirty = value;
                _middleCreditScore.Dirty = value;
                _middleFicoScore.Dirty = value;
                _middleName.Dirty = value;
                _minFicoScore.Dirty = value;
                _mobilePhone.Dirty = value;
                _mortgageOnCredit.Dirty = value;
                _nameToObtainLoanFromRHS.Dirty = value;
                _nearestRelativeAddress.Dirty = value;
                _nearestRelativeCity.Dirty = value;
                _nearestRelativeName.Dirty = value;
                _nearestRelativePhone.Dirty = value;
                _nearestRelativePostalCode.Dirty = value;
                _nearestRelativeRelationship.Dirty = value;
                _nearestRelativeState.Dirty = value;
                _no3rdPartyEmailIndicator.Dirty = value;
                _noCoApplicantEthnicityIndicator.Dirty = value;
                _noCoApplicantIndicator.Dirty = value;
                _noCoApplicantSexIndicator.Dirty = value;
                _numberofTradelines.Dirty = value;
                _obtainLoanFromRHSIndicator.Dirty = value;
                _openBankruptcy2.Dirty = value;
                _otherMonthlyIncomeAmount.Dirty = value;
                _otherSumAmount.Dirty = value;
                _outstandingJudgementsIndicator.Dirty = value;
                _partyToLawsuitIndicator.Dirty = value;
                _pass120Days.Dirty = value;
                _pass150Days.Dirty = value;
                _pass30Days.Dirty = value;
                _pass60Days.Dirty = value;
                _pass90Days.Dirty = value;
                _personFaxNumber.Dirty = value;
                _personHoursPerWeek.Dirty = value;
                _personIncomeAmount.Dirty = value;
                _personIncomeFrequencyType.Dirty = value;
                _personMonthlyIncome.Dirty = value;
                _pIWAccepted.Dirty = value;
                _pIWMessage.Dirty = value;
                _poaOccupancyIntent.Dirty = value;
                _poaSignatureText.Dirty = value;
                _positiveCashFlow.Dirty = value;
                _powerOfAttorneyName.Dirty = value;
                _powerOfAttorneyTitleDescription.Dirty = value;
                _presentlyDelinquentIndicator.Dirty = value;
                _priorBankruptcy2.Dirty = value;
                _priorForeclosure.Dirty = value;
                _priorPropertyTitleType.Dirty = value;
                _priorPropertyUsageType.Dirty = value;
                _propertyForeclosedPastSevenYearsIndicator.Dirty = value;
                _relationshipDescription.Dirty = value;
                _relationshipWithRDEmployeeIndicator.Dirty = value;
                _schoolingTermYears.Dirty = value;
                _sSA89BackgroundCheckIndicator.Dirty = value;
                _sSA89BankingServiceIndicator.Dirty = value;
                _sSA89CreditCheckIndicator.Dirty = value;
                _sSA89LicenseRequirementIndicator.Dirty = value;
                _sSA89MortgageServiceIndicator.Dirty = value;
                _sSA89OtherIndicator.Dirty = value;
                _subtotalLiquidAssetsMinusGiftAmount.Dirty = value;
                _suffixToName.Dirty = value;
                _tax4506LastInvestor.Dirty = value;
                _tax4506LastOrderNumber.Dirty = value;
                _tax4506LastOrderYear1.Dirty = value;
                _tax4506LastOrderYear2.Dirty = value;
                _tax4506LastOrderYear3.Dirty = value;
                _tax4506LastOrderYear4.Dirty = value;
                _tax4506LastProductsOrdered.Dirty = value;
                _tax4506LastStatus.Dirty = value;
                _tax4506LastTranscriptType.Dirty = value;
                _tax4506LastUserIDWhoOrdered.Dirty = value;
                _tax4506TotalYearlyIncome1.Dirty = value;
                _tax4506TotalYearlyIncome2.Dirty = value;
                _tax4506TotalYearlyIncome3.Dirty = value;
                _tax4506TotalYearlyIncome4.Dirty = value;
                _tax4506TotalYearlyJointIncome1.Dirty = value;
                _tax4506TotalYearlyJointIncome2.Dirty = value;
                _tax4506TotalYearlyJointIncome3.Dirty = value;
                _tax4506TotalYearlyJointIncome4.Dirty = value;
                _tax4506TotalYearlyVarianceIncome1.Dirty = value;
                _tax4506TotalYearlyVarianceIncome2.Dirty = value;
                _tax4506TotalYearlyVarianceIncome3.Dirty = value;
                _tax4506TotalYearlyVarianceIncome4.Dirty = value;
                _tax4506TotalYearlyVarianceJointIncome1.Dirty = value;
                _tax4506TotalYearlyVarianceJointIncome2.Dirty = value;
                _tax4506TotalYearlyVarianceJointIncome3.Dirty = value;
                _tax4506TotalYearlyVarianceJointIncome4.Dirty = value;
                _taxIdentificationIdentifier.Dirty = value;
                _totalLiabilitiesBalanceAmount.Dirty = value;
                _totalMonthlyIncomeAmount.Dirty = value;
                _totalMonthlyIncomeMinusNetRentalAmount.Dirty = value;
                _totalPresentHousingExpenseAmount.Dirty = value;
                _transactionPurposeDescription.Dirty = value;
                _transUnion120Days.Dirty = value;
                _transUnion150Days.Dirty = value;
                _transUnion30Days.Dirty = value;
                _transUnion60Days.Dirty = value;
                _transUnion90Days.Dirty = value;
                _transUnionCreditScoreForDisclosure.Dirty = value;
                _transUnionCreditScoreRanksPercent.Dirty = value;
                _transUnionDatePulled.Dirty = value;
                _transUnionFactorCode1.Dirty = value;
                _transUnionFactorCode2.Dirty = value;
                _transUnionFactorCode3.Dirty = value;
                _transUnionFactorCode4.Dirty = value;
                _transUnionFactorCode5.Dirty = value;
                _transUnionKeyFactor1.Dirty = value;
                _transUnionKeyFactor2.Dirty = value;
                _transUnionKeyFactor3.Dirty = value;
                _transUnionKeyFactor4.Dirty = value;
                _transUnionKeyFactor5.Dirty = value;
                _transUnionMaterialTermsCreditByScore.Dirty = value;
                _transUnionScore.Dirty = value;
                _userDefinedIncome.Dirty = value;
                _vaFederalTaxAmount.Dirty = value;
                _validDaysForConsentCount.Dirty = value;
                _valueRepAndWarrantyAvailable.Dirty = value;
                _valueRepAndWarrantyMessage.Dirty = value;
                _vaNetTakeHomePayAmount.Dirty = value;
                _vaOtherAmount.Dirty = value;
                _vaOtherNetIncomeAmount.Dirty = value;
                _vaRetirementAmount.Dirty = value;
                _vaStateTaxAmount.Dirty = value;
                _vaTotalIncomeDeductionsAmount.Dirty = value;
                _vaTotalNetIncomeAmount.Dirty = value;
                _vendor1.Dirty = value;
                _vendor10.Dirty = value;
                _vendor11.Dirty = value;
                _vendor12.Dirty = value;
                _vendor2.Dirty = value;
                _vendor3.Dirty = value;
                _vendor4.Dirty = value;
                _vendor5.Dirty = value;
                _vendor6.Dirty = value;
                _vendor7.Dirty = value;
                _vendor8.Dirty = value;
                _vendor9.Dirty = value;
                _vestingTrusteeOfType.Dirty = value;
                _veteranIndicator.Dirty = value;
                _workEmailAddress.Dirty = value;
                _yearsofCreditOnFile.Dirty = value;
                if (_application != null) _application.Dirty = value;
            }
        }
    }
}