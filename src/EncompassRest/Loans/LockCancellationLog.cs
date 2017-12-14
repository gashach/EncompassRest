#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class LockCancellationLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _alertIndicator;
        public bool? AlertIndicator { get => _alertIndicator; set => _alertIndicator = value; }
        private DirtyValue<string> _alertsXml;
        public string AlertsXml { get => _alertsXml; set => _alertsXml = value; }
        private DirtyValue<string> _cancelledBy;
        public string CancelledBy { get => _cancelledBy; set => _cancelledBy = value; }
        private DirtyValue<string> _cancelledById;
        public string CancelledById { get => _cancelledById; set => _cancelledById = value; }
        private DirtyValue<string> _commentListXml;
        public string CommentListXml { get => _commentListXml; set => _commentListXml = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => _fileAttachmentsMigrated = value; }
        private DirtyValue<string> _guid;
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => _isSystemSpecificIndicator = value; }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get => _logRecordIndex; set => _logRecordIndex = value; }
        private DirtyValue<string> _requestGuid;
        public string RequestGuid { get => _requestGuid; set => _requestGuid = value; }
        private DirtyValue<string> _systemId;
        public string SystemId { get => _systemId; set => _systemId = value; }
        private DirtyValue<string> _timeCancelled;
        public string TimeCancelled { get => _timeCancelled; set => _timeCancelled = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _alertIndicator.Dirty
                    || _alertsXml.Dirty
                    || _cancelledBy.Dirty
                    || _cancelledById.Dirty
                    || _commentListXml.Dirty
                    || _comments.Dirty
                    || _dateUtc.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _requestGuid.Dirty
                    || _systemId.Dirty
                    || _timeCancelled.Dirty;
            }
            set
            {
                _alertIndicator.Dirty = value;
                _alertsXml.Dirty = value;
                _cancelledBy.Dirty = value;
                _cancelledById.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _dateUtc.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _requestGuid.Dirty = value;
                _systemId.Dirty = value;
                _timeCancelled.Dirty = value;
            }
        }
    }
}