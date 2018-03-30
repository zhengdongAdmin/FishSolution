using System;
using System.Collections.Generic;
using System.Text;

namespace FishEntity
{
    public class CargoFeedbackSheetEntity
    {
        public CargoFeedbackSheetEntity() { }
        private int _id;
        private string _code;
        private string _sponsor;
        private string _acceptor;
        private string _processresult;
        private string _evaluation;
        private string _attendance;
        private string _review;
        private string _remarks;
        private DateTime? _modifytime;
        private string _modifyman;
        private DateTime? _createtime;
        private string _createman;
        private string _ConfirmTheWeight;
        private string _codeContract;
        private string _Numbering;
        public string codeContract
        {
            get
            {
                return _codeContract;
            }
            set
            {
                _codeContract = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Code
        {
            get
            {
                return _code;
            }

            set
            {
                _code = value;
            }
        }

        public string Sponsor
        {
            get
            {
                return _sponsor;
            }

            set
            {
                _sponsor = value;
            }
        }

        public string Acceptor
        {
            get
            {
                return _acceptor;
            }

            set
            {
                _acceptor = value;
            }
        }

        public string Processresult
        {
            get
            {
                return _processresult;
            }

            set
            {
                _processresult = value;
            }
        }

        public string Evaluation
        {
            get
            {
                return _evaluation;
            }

            set
            {
                _evaluation = value;
            }
        }

        public string Attendance
        {
            get
            {
                return _attendance;
            }

            set
            {
                _attendance = value;
            }
        }

        public string Review
        {
            get
            {
                return _review;
            }

            set
            {
                _review = value;
            }
        }

        public string Remarks
        {
            get
            {
                return _remarks;
            }

            set
            {
                _remarks = value;
            }
        }

        public DateTime? Modifytime
        {
            get
            {
                return _modifytime;
            }

            set
            {
                _modifytime = value;
            }
        }

        public string Modifyman
        {
            get
            {
                return _modifyman;
            }

            set
            {
                _modifyman = value;
            }
        }

        public DateTime? Createtime
        {
            get
            {
                return _createtime;
            }

            set
            {
                _createtime = value;
            }
        }

        public string Createman
        {
            get
            {
                return _createman;
            }

            set
            {
                _createman = value;
            }
        }

        public string ConfirmTheWeight
        {
            get
            {
                return _ConfirmTheWeight;
            }

            set
            {
                _ConfirmTheWeight = value;
            }
        }
        /// <summary>
        ///编号
        /// </summary>
        public string Numbering
        {
            get
            {
                return _Numbering;
            }

            set
            {
                _Numbering = value;
            }
        }
    }
}
