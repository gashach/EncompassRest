using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsItemize : IDirty
    {
        private DirtyValue<string> _date;
        public string Date { get { return _date; } set { _date = value; } }
        private DirtyValue<decimal?> _escrowPaymentBalance;
        public decimal? EscrowPaymentBalance { get { return _escrowPaymentBalance; } set { _escrowPaymentBalance = value; } }
        private DirtyValue<string> _escrowPaymentDescription;
        public string EscrowPaymentDescription { get { return _escrowPaymentDescription; } set { _escrowPaymentDescription = value; } }
        private DirtyValue<decimal?> _escrowPaymentFrom;
        public decimal? EscrowPaymentFrom { get { return _escrowPaymentFrom; } set { _escrowPaymentFrom = value; } }
        private DirtyValue<decimal?> _escrowPaymentTo;
        public decimal? EscrowPaymentTo { get { return _escrowPaymentTo; } set { _escrowPaymentTo = value; } }
        private DirtyValue<int?> _hud1EsItemizeIndex;
        public int? Hud1EsItemizeIndex { get { return _hud1EsItemizeIndex; } set { _hud1EsItemizeIndex = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _date.Dirty
                    || _escrowPaymentBalance.Dirty
                    || _escrowPaymentDescription.Dirty
                    || _escrowPaymentFrom.Dirty
                    || _escrowPaymentTo.Dirty
                    || _hud1EsItemizeIndex.Dirty
                    || _id.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _date.Dirty = value;
                _escrowPaymentBalance.Dirty = value;
                _escrowPaymentDescription.Dirty = value;
                _escrowPaymentFrom.Dirty = value;
                _escrowPaymentTo.Dirty = value;
                _hud1EsItemizeIndex.Dirty = value;
                _id.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}