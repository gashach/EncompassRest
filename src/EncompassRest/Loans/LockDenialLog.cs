#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class LockDenialLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _alertIndicator;
        public bool? AlertIndicator { get => _alertIndicator; set => _alertIndicator = value; }
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get => _alerts ?? (_alerts = new DirtyList<LogAlert>()); set => _alerts = new DirtyList<LogAlert>(value); }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get => _commentList ?? (_commentList = new DirtyList<LogComment>()); set => _commentList = new DirtyList<LogComment>(value); }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get => _dateUtc; set => _dateUtc = value; }
        private DirtyValue<string> _deniedBy;
        public string DeniedBy { get => _deniedBy; set => _deniedBy = value; }
        private DirtyValue<string> _deniedById;
        public string DeniedById { get => _deniedById; set => _deniedById = value; }
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
        private DirtyValue<string> _timeDenied;
        public string TimeDenied { get => _timeDenied; set => _timeDenied = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _alertIndicator.Dirty
                    || _comments.Dirty
                    || _dateUtc.Dirty
                    || _deniedBy.Dirty
                    || _deniedById.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _requestGuid.Dirty
                    || _systemId.Dirty
                    || _timeDenied.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true;
            }
            set
            {
                _alertIndicator.Dirty = value;
                _comments.Dirty = value;
                _dateUtc.Dirty = value;
                _deniedBy.Dirty = value;
                _deniedById.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _requestGuid.Dirty = value;
                _systemId.Dirty = value;
                _timeDenied.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
            }
        }
    }
}