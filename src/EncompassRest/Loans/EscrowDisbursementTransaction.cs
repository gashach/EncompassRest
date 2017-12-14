#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class EscrowDisbursementTransaction : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _createdById;
        public string CreatedById { get => _createdById; set => _createdById = value; }
        private DirtyValue<string> _createdByName;
        public string CreatedByName { get => _createdByName; set => _createdByName = value; }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => _createdDateTimeUtc = value; }
        private DirtyValue<DateTime?> _disbursementDueDate;
        public DateTime? DisbursementDueDate { get => _disbursementDueDate; set => _disbursementDueDate = value; }
        private DirtyValue<int?> _disbursementNumber;
        public int? DisbursementNumber { get => _disbursementNumber; set => _disbursementNumber = value; }
        private DirtyValue<string> _disbursementType;
        public string DisbursementType { get => _disbursementType; set => _disbursementType = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _institutionName;
        public string InstitutionName { get => _institutionName; set => _institutionName = value; }
        private DirtyValue<string> _modifiedById;
        public string ModifiedById { get => _modifiedById; set => _modifiedById = value; }
        private DirtyValue<string> _modifiedByName;
        public string ModifiedByName { get => _modifiedByName; set => _modifiedByName = value; }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => _modifiedDateTimeUtc = value; }
        private DirtyValue<string> _servicingPaymentMethod;
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => _servicingPaymentMethod = value; }
        private DirtyValue<string> _servicingTransactionType;
        public string ServicingTransactionType { get => _servicingTransactionType; set => _servicingTransactionType = value; }
        private DirtyValue<decimal?> _transactionAmount;
        public decimal? TransactionAmount { get => _transactionAmount; set => _transactionAmount = value; }
        private DirtyValue<DateTime?> _transactionDate;
        public DateTime? TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _comments.Dirty
                    || _createdById.Dirty
                    || _createdByName.Dirty
                    || _createdDateTimeUtc.Dirty
                    || _disbursementDueDate.Dirty
                    || _disbursementNumber.Dirty
                    || _disbursementType.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _institutionName.Dirty
                    || _modifiedById.Dirty
                    || _modifiedByName.Dirty
                    || _modifiedDateTimeUtc.Dirty
                    || _servicingPaymentMethod.Dirty
                    || _servicingTransactionType.Dirty
                    || _transactionAmount.Dirty
                    || _transactionDate.Dirty;
            }
            set
            {
                _comments.Dirty = value;
                _createdById.Dirty = value;
                _createdByName.Dirty = value;
                _createdDateTimeUtc.Dirty = value;
                _disbursementDueDate.Dirty = value;
                _disbursementNumber.Dirty = value;
                _disbursementType.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _institutionName.Dirty = value;
                _modifiedById.Dirty = value;
                _modifiedByName.Dirty = value;
                _modifiedDateTimeUtc.Dirty = value;
                _servicingPaymentMethod.Dirty = value;
                _servicingTransactionType.Dirty = value;
                _transactionAmount.Dirty = value;
                _transactionDate.Dirty = value;
            }
        }
    }
}