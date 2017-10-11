using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class StateLicense : IDirty
    {
        private DirtyValue<string> _aK;
        public string AK { get { return _aK; } set { _aK = value; } }
        private DirtyValue<string> _aL;
        public string AL { get { return _aL; } set { _aL = value; } }
        private DirtyValue<string> _aR;
        public string AR { get { return _aR; } set { _aR = value; } }
        private DirtyValue<string> _aZ;
        public string AZ { get { return _aZ; } set { _aZ = value; } }
        private DirtyValue<string> _cA;
        public string CA { get { return _cA; } set { _cA = value; } }
        private DirtyValue<string> _cO;
        public string CO { get { return _cO; } set { _cO = value; } }
        private DirtyValue<string> _cT;
        public string CT { get { return _cT; } set { _cT = value; } }
        private DirtyValue<string> _dC;
        public string DC { get { return _dC; } set { _dC = value; } }
        private DirtyValue<string> _dE;
        public string DE { get { return _dE; } set { _dE = value; } }
        private DirtyValue<string> _fL;
        public string FL { get { return _fL; } set { _fL = value; } }
        private DirtyValue<string> _gA;
        public string GA { get { return _gA; } set { _gA = value; } }
        private DirtyValue<string> _gU;
        public string GU { get { return _gU; } set { _gU = value; } }
        private DirtyValue<string> _hI;
        public string HI { get { return _hI; } set { _hI = value; } }
        private DirtyValue<string> _iA;
        public string IA { get { return _iA; } set { _iA = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _idaho;
        public string Idaho { get { return _idaho; } set { _idaho = value; } }
        private DirtyValue<string> _iL;
        public string IL { get { return _iL; } set { _iL = value; } }
        private DirtyValue<string> _iN;
        public string IN { get { return _iN; } set { _iN = value; } }
        private DirtyValue<string> _kS;
        public string KS { get { return _kS; } set { _kS = value; } }
        private DirtyValue<string> _kY;
        public string KY { get { return _kY; } set { _kY = value; } }
        private DirtyValue<string> _lA;
        public string LA { get { return _lA; } set { _lA = value; } }
        private DirtyValue<string> _mA;
        public string MA { get { return _mA; } set { _mA = value; } }
        private DirtyValue<string> _mD;
        public string MD { get { return _mD; } set { _mD = value; } }
        private DirtyValue<string> _mE;
        public string ME { get { return _mE; } set { _mE = value; } }
        private DirtyValue<string> _mI;
        public string MI { get { return _mI; } set { _mI = value; } }
        private DirtyValue<string> _mN;
        public string MN { get { return _mN; } set { _mN = value; } }
        private DirtyValue<string> _mO;
        public string MO { get { return _mO; } set { _mO = value; } }
        private DirtyValue<string> _mS;
        public string MS { get { return _mS; } set { _mS = value; } }
        private DirtyValue<string> _mT;
        public string MT { get { return _mT; } set { _mT = value; } }
        private DirtyValue<string> _nC;
        public string NC { get { return _nC; } set { _nC = value; } }
        private DirtyValue<string> _nD;
        public string ND { get { return _nD; } set { _nD = value; } }
        private DirtyValue<string> _nE;
        public string NE { get { return _nE; } set { _nE = value; } }
        private DirtyValue<string> _nH;
        public string NH { get { return _nH; } set { _nH = value; } }
        private DirtyValue<string> _nJ;
        public string NJ { get { return _nJ; } set { _nJ = value; } }
        private DirtyValue<string> _nM;
        public string NM { get { return _nM; } set { _nM = value; } }
        private DirtyValue<string> _nV;
        public string NV { get { return _nV; } set { _nV = value; } }
        private DirtyValue<string> _nY;
        public string NY { get { return _nY; } set { _nY = value; } }
        private DirtyValue<string> _oH;
        public string OH { get { return _oH; } set { _oH = value; } }
        private DirtyValue<string> _oK;
        public string OK { get { return _oK; } set { _oK = value; } }
        private DirtyValue<string> _oR;
        public string OR { get { return _oR; } set { _oR = value; } }
        private DirtyValue<string> _pA;
        public string PA { get { return _pA; } set { _pA = value; } }
        private DirtyValue<string> _pR;
        public string PR { get { return _pR; } set { _pR = value; } }
        private DirtyValue<string> _rI;
        public string RI { get { return _rI; } set { _rI = value; } }
        private DirtyValue<string> _sC;
        public string SC { get { return _sC; } set { _sC = value; } }
        private DirtyValue<string> _sD;
        public string SD { get { return _sD; } set { _sD = value; } }
        private DirtyValue<string> _stateLicenseType;
        public string StateLicenseType { get { return _stateLicenseType; } set { _stateLicenseType = value; } }
        private DirtyValue<string> _tN;
        public string TN { get { return _tN; } set { _tN = value; } }
        private DirtyValue<string> _tX;
        public string TX { get { return _tX; } set { _tX = value; } }
        private DirtyValue<string> _uT;
        public string UT { get { return _uT; } set { _uT = value; } }
        private DirtyValue<string> _vA;
        public string VA { get { return _vA; } set { _vA = value; } }
        private DirtyValue<string> _vI;
        public string VI { get { return _vI; } set { _vI = value; } }
        private DirtyValue<string> _vT;
        public string VT { get { return _vT; } set { _vT = value; } }
        private DirtyValue<string> _wA;
        public string WA { get { return _wA; } set { _wA = value; } }
        private DirtyValue<string> _wI;
        public string WI { get { return _wI; } set { _wI = value; } }
        private DirtyValue<string> _wV;
        public string WV { get { return _wV; } set { _wV = value; } }
        private DirtyValue<string> _wY;
        public string WY { get { return _wY; } set { _wY = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _aK.Dirty
                    || _aL.Dirty
                    || _aR.Dirty
                    || _aZ.Dirty
                    || _cA.Dirty
                    || _cO.Dirty
                    || _cT.Dirty
                    || _dC.Dirty
                    || _dE.Dirty
                    || _fL.Dirty
                    || _gA.Dirty
                    || _gU.Dirty
                    || _hI.Dirty
                    || _iA.Dirty
                    || _id.Dirty
                    || _idaho.Dirty
                    || _iL.Dirty
                    || _iN.Dirty
                    || _kS.Dirty
                    || _kY.Dirty
                    || _lA.Dirty
                    || _mA.Dirty
                    || _mD.Dirty
                    || _mE.Dirty
                    || _mI.Dirty
                    || _mN.Dirty
                    || _mO.Dirty
                    || _mS.Dirty
                    || _mT.Dirty
                    || _nC.Dirty
                    || _nD.Dirty
                    || _nE.Dirty
                    || _nH.Dirty
                    || _nJ.Dirty
                    || _nM.Dirty
                    || _nV.Dirty
                    || _nY.Dirty
                    || _oH.Dirty
                    || _oK.Dirty
                    || _oR.Dirty
                    || _pA.Dirty
                    || _pR.Dirty
                    || _rI.Dirty
                    || _sC.Dirty
                    || _sD.Dirty
                    || _stateLicenseType.Dirty
                    || _tN.Dirty
                    || _tX.Dirty
                    || _uT.Dirty
                    || _vA.Dirty
                    || _vI.Dirty
                    || _vT.Dirty
                    || _wA.Dirty
                    || _wI.Dirty
                    || _wV.Dirty
                    || _wY.Dirty;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _aK.Dirty = value;
                _aL.Dirty = value;
                _aR.Dirty = value;
                _aZ.Dirty = value;
                _cA.Dirty = value;
                _cO.Dirty = value;
                _cT.Dirty = value;
                _dC.Dirty = value;
                _dE.Dirty = value;
                _fL.Dirty = value;
                _gA.Dirty = value;
                _gU.Dirty = value;
                _hI.Dirty = value;
                _iA.Dirty = value;
                _id.Dirty = value;
                _idaho.Dirty = value;
                _iL.Dirty = value;
                _iN.Dirty = value;
                _kS.Dirty = value;
                _kY.Dirty = value;
                _lA.Dirty = value;
                _mA.Dirty = value;
                _mD.Dirty = value;
                _mE.Dirty = value;
                _mI.Dirty = value;
                _mN.Dirty = value;
                _mO.Dirty = value;
                _mS.Dirty = value;
                _mT.Dirty = value;
                _nC.Dirty = value;
                _nD.Dirty = value;
                _nE.Dirty = value;
                _nH.Dirty = value;
                _nJ.Dirty = value;
                _nM.Dirty = value;
                _nV.Dirty = value;
                _nY.Dirty = value;
                _oH.Dirty = value;
                _oK.Dirty = value;
                _oR.Dirty = value;
                _pA.Dirty = value;
                _pR.Dirty = value;
                _rI.Dirty = value;
                _sC.Dirty = value;
                _sD.Dirty = value;
                _stateLicenseType.Dirty = value;
                _tN.Dirty = value;
                _tX.Dirty = value;
                _uT.Dirty = value;
                _vA.Dirty = value;
                _vI.Dirty = value;
                _vT.Dirty = value;
                _wA.Dirty = value;
                _wI.Dirty = value;
                _wV.Dirty = value;
                _wY.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}