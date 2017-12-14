#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class FannieMae : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _cltv;
        public decimal? Cltv { get => _cltv; set => _cltv = value; }
        private DirtyValue<string> _collateralUnderwriterScore;
        public string CollateralUnderwriterScore { get => _collateralUnderwriterScore; set => _collateralUnderwriterScore = value; }
        private DirtyValue<StringEnumValue<Community2ndRepaymentStructure>> _community2ndRepaymentStructure;
        public StringEnumValue<Community2ndRepaymentStructure> Community2ndRepaymentStructure { get => _community2ndRepaymentStructure; set => _community2ndRepaymentStructure = value; }
        private DirtyValue<bool?> _communityLending;
        public bool? CommunityLending { get => _communityLending; set => _communityLending = value; }
        private DirtyValue<string> _duVersion;
        public string DuVersion { get => _duVersion; set => _duVersion = value; }
        private DirtyValue<string> _eCStatus1003;
        public string ECStatus1003 { get => _eCStatus1003; set => _eCStatus1003 = value; }
        private DirtyValue<decimal?> _hcltv;
        public decimal? Hcltv { get => _hcltv; set => _hcltv = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _interestedPartyContribution;
        public decimal? InterestedPartyContribution { get => _interestedPartyContribution; set => _interestedPartyContribution = value; }
        private DirtyValue<decimal?> _ltv;
        public decimal? Ltv { get => _ltv; set => _ltv = value; }
        private DirtyValue<string> _mornetPlusCaseFileId;
        public string MornetPlusCaseFileId { get => _mornetPlusCaseFileId; set => _mornetPlusCaseFileId = value; }
        private DirtyValue<string> _propertyInspectionWaiverMessage;
        public string PropertyInspectionWaiverMessage { get => _propertyInspectionWaiverMessage; set => _propertyInspectionWaiverMessage = value; }
        private DirtyValue<bool?> _startUpMortgage;
        public bool? StartUpMortgage { get => _startUpMortgage; set => _startUpMortgage = value; }
        private DirtyValue<string> _uCDCollectionStatus;
        public string UCDCollectionStatus { get => _uCDCollectionStatus; set => _uCDCollectionStatus = value; }
        private DirtyValue<string> _uCDPStatus;
        public string UCDPStatus { get => _uCDPStatus; set => _uCDPStatus = value; }
        private DirtyValue<string> _uLDDECStatus;
        public string ULDDECStatus { get => _uLDDECStatus; set => _uLDDECStatus = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _cltv.Dirty
                    || _collateralUnderwriterScore.Dirty
                    || _community2ndRepaymentStructure.Dirty
                    || _communityLending.Dirty
                    || _duVersion.Dirty
                    || _eCStatus1003.Dirty
                    || _hcltv.Dirty
                    || _id.Dirty
                    || _interestedPartyContribution.Dirty
                    || _ltv.Dirty
                    || _mornetPlusCaseFileId.Dirty
                    || _propertyInspectionWaiverMessage.Dirty
                    || _startUpMortgage.Dirty
                    || _uCDCollectionStatus.Dirty
                    || _uCDPStatus.Dirty
                    || _uLDDECStatus.Dirty;
            }
            set
            {
                _cltv.Dirty = value;
                _collateralUnderwriterScore.Dirty = value;
                _community2ndRepaymentStructure.Dirty = value;
                _communityLending.Dirty = value;
                _duVersion.Dirty = value;
                _eCStatus1003.Dirty = value;
                _hcltv.Dirty = value;
                _id.Dirty = value;
                _interestedPartyContribution.Dirty = value;
                _ltv.Dirty = value;
                _mornetPlusCaseFileId.Dirty = value;
                _propertyInspectionWaiverMessage.Dirty = value;
                _startUpMortgage.Dirty = value;
                _uCDCollectionStatus.Dirty = value;
                _uCDPStatus.Dirty = value;
                _uLDDECStatus.Dirty = value;
            }
        }
    }
}