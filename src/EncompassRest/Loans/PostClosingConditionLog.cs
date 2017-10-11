using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PostClosingConditionLog : IDirty
    {
        private DirtyValue<string> _addedBy;
        public string AddedBy { get { return _addedBy; } set { _addedBy = value; } }
        private DirtyList<LogAlert> _alerts;
        public IList<LogAlert> Alerts { get { return _alerts ?? (_alerts = new DirtyList<LogAlert>()); } set { _alerts = new DirtyList<LogAlert>(value); } }
        private DirtyValue<string> _alertsXml;
        public string AlertsXml { get { return _alertsXml; } set { _alertsXml = value; } }
        private DirtyValue<bool?> _cleared;
        public bool? Cleared { get { return _cleared; } set { _cleared = value; } }
        private DirtyValue<string> _clearedBy;
        public string ClearedBy { get { return _clearedBy; } set { _clearedBy = value; } }
        private DirtyList<LogComment> _commentList;
        public IList<LogComment> CommentList { get { return _commentList ?? (_commentList = new DirtyList<LogComment>()); } set { _commentList = new DirtyList<LogComment>(value); } }
        private DirtyValue<string> _commentListXml;
        public string CommentListXml { get { return _commentListXml; } set { _commentListXml = value; } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<DateTime?> _dateAddedUtc;
        public DateTime? DateAddedUtc { get { return _dateAddedUtc; } set { _dateAddedUtc = value; } }
        private DirtyValue<DateTime?> _dateClearedUtc;
        public DateTime? DateClearedUtc { get { return _dateClearedUtc; } set { _dateClearedUtc = value; } }
        private DirtyValue<DateTime?> _dateExpected;
        public DateTime? DateExpected { get { return _dateExpected; } set { _dateExpected = value; } }
        private DirtyValue<DateTime?> _dateReceived;
        public DateTime? DateReceived { get { return _dateReceived; } set { _dateReceived = value; } }
        private DirtyValue<DateTime?> _dateRequestedUtc;
        public DateTime? DateRequestedUtc { get { return _dateRequestedUtc; } set { _dateRequestedUtc = value; } }
        private DirtyValue<DateTime?> _dateRerequestedUtc;
        public DateTime? DateRerequestedUtc { get { return _dateRerequestedUtc; } set { _dateRerequestedUtc = value; } }
        private DirtyValue<DateTime?> _dateSentUtc;
        public DateTime? DateSentUtc { get { return _dateSentUtc; } set { _dateSentUtc = value; } }
        private DirtyValue<DateTime?> _dateUtc;
        public DateTime? DateUtc { get { return _dateUtc; } set { _dateUtc = value; } }
        private DirtyValue<int?> _daysTillDue;
        public int? DaysTillDue { get { return _daysTillDue; } set { _daysTillDue = value; } }
        private DirtyValue<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private DirtyValue<string> _details;
        public string Details { get { return _details; } set { _details = value; } }
        private DirtyValue<bool?> _expected;
        public bool? Expected { get { return _expected; } set { _expected = value; } }
        private DirtyValue<bool?> _fileAttachmentsMigrated;
        public bool? FileAttachmentsMigrated { get { return _fileAttachmentsMigrated; } set { _fileAttachmentsMigrated = value; } }
        private DirtyValue<string> _guid;
        public string Guid { get { return _guid; } set { _guid = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _isPastDue;
        public bool? IsPastDue { get { return _isPastDue; } set { _isPastDue = value; } }
        private DirtyValue<bool?> _isSystemSpecificIndicator;
        public bool? IsSystemSpecificIndicator { get { return _isSystemSpecificIndicator; } set { _isSystemSpecificIndicator = value; } }
        private DirtyValue<int?> _logRecordIndex;
        public int? LogRecordIndex { get { return _logRecordIndex; } set { _logRecordIndex = value; } }
        private DirtyValue<string> _pairId;
        public string PairId { get { return _pairId; } set { _pairId = value; } }
        private DirtyValue<bool?> _received;
        public bool? Received { get { return _received; } set { _received = value; } }
        private DirtyValue<string> _receivedBy;
        public string ReceivedBy { get { return _receivedBy; } set { _receivedBy = value; } }
        private DirtyValue<string> _recipient;
        public string Recipient { get { return _recipient; } set { _recipient = value; } }
        private DirtyValue<bool?> _requested;
        public bool? Requested { get { return _requested; } set { _requested = value; } }
        private DirtyValue<string> _requestedBy;
        public string RequestedBy { get { return _requestedBy; } set { _requestedBy = value; } }
        private DirtyValue<string> _requestedFrom;
        public string RequestedFrom { get { return _requestedFrom; } set { _requestedFrom = value; } }
        private DirtyValue<bool?> _rerequested;
        public bool? Rerequested { get { return _rerequested; } set { _rerequested = value; } }
        private DirtyValue<string> _rerequestedBy;
        public string RerequestedBy { get { return _rerequestedBy; } set { _rerequestedBy = value; } }
        private DirtyValue<bool?> _sent;
        public bool? Sent { get { return _sent; } set { _sent = value; } }
        private DirtyValue<string> _sentBy;
        public string SentBy { get { return _sentBy; } set { _sentBy = value; } }
        private DirtyValue<string> _source;
        public string Source { get { return _source; } set { _source = value; } }
        private DirtyValue<string> _status;
        public string Status { get { return _status; } set { _status = value; } }
        private DirtyValue<string> _statusDescription;
        public string StatusDescription { get { return _statusDescription; } set { _statusDescription = value; } }
        private DirtyValue<string> _systemId;
        public string SystemId { get { return _systemId; } set { _systemId = value; } }
        private DirtyValue<string> _title;
        public string Title { get { return _title; } set { _title = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _addedBy.Dirty
                    || _alertsXml.Dirty
                    || _cleared.Dirty
                    || _clearedBy.Dirty
                    || _commentListXml.Dirty
                    || _comments.Dirty
                    || _dateAddedUtc.Dirty
                    || _dateClearedUtc.Dirty
                    || _dateExpected.Dirty
                    || _dateReceived.Dirty
                    || _dateRequestedUtc.Dirty
                    || _dateRerequestedUtc.Dirty
                    || _dateSentUtc.Dirty
                    || _dateUtc.Dirty
                    || _daysTillDue.Dirty
                    || _description.Dirty
                    || _details.Dirty
                    || _expected.Dirty
                    || _fileAttachmentsMigrated.Dirty
                    || _guid.Dirty
                    || _id.Dirty
                    || _isPastDue.Dirty
                    || _isSystemSpecificIndicator.Dirty
                    || _logRecordIndex.Dirty
                    || _pairId.Dirty
                    || _received.Dirty
                    || _receivedBy.Dirty
                    || _recipient.Dirty
                    || _requested.Dirty
                    || _requestedBy.Dirty
                    || _requestedFrom.Dirty
                    || _rerequested.Dirty
                    || _rerequestedBy.Dirty
                    || _sent.Dirty
                    || _sentBy.Dirty
                    || _source.Dirty
                    || _status.Dirty
                    || _statusDescription.Dirty
                    || _systemId.Dirty
                    || _title.Dirty
                    || _alerts?.Dirty == true
                    || _commentList?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _addedBy.Dirty = value;
                _alertsXml.Dirty = value;
                _cleared.Dirty = value;
                _clearedBy.Dirty = value;
                _commentListXml.Dirty = value;
                _comments.Dirty = value;
                _dateAddedUtc.Dirty = value;
                _dateClearedUtc.Dirty = value;
                _dateExpected.Dirty = value;
                _dateReceived.Dirty = value;
                _dateRequestedUtc.Dirty = value;
                _dateRerequestedUtc.Dirty = value;
                _dateSentUtc.Dirty = value;
                _dateUtc.Dirty = value;
                _daysTillDue.Dirty = value;
                _description.Dirty = value;
                _details.Dirty = value;
                _expected.Dirty = value;
                _fileAttachmentsMigrated.Dirty = value;
                _guid.Dirty = value;
                _id.Dirty = value;
                _isPastDue.Dirty = value;
                _isSystemSpecificIndicator.Dirty = value;
                _logRecordIndex.Dirty = value;
                _pairId.Dirty = value;
                _received.Dirty = value;
                _receivedBy.Dirty = value;
                _recipient.Dirty = value;
                _requested.Dirty = value;
                _requestedBy.Dirty = value;
                _requestedFrom.Dirty = value;
                _rerequested.Dirty = value;
                _rerequestedBy.Dirty = value;
                _sent.Dirty = value;
                _sentBy.Dirty = value;
                _source.Dirty = value;
                _status.Dirty = value;
                _statusDescription.Dirty = value;
                _systemId.Dirty = value;
                _title.Dirty = value;
                if (_alerts != null) _alerts.Dirty = value;
                if (_commentList != null) _commentList.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}