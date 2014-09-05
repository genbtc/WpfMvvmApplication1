using System;
using WpfMvvmApplication1.Helpers;
using Timer = System.Windows.Forms.Timer;

namespace WpfMvvmApplication1.Models
{
    public class FamilyDB : NotificationObject
    {
        #region Ctor

        public FamilyDB()
        {
            newTimer.Tick += newTimer_Tick;
        }

        public FamilyDB(int id,
            string lastname,
            string firstname,
            string adress,
            int cityid,            
            string cp,
            string city,
            string tel1,
            string tel2,
            string tel3
            )
        {
            ID = id;
            LASTNAME = lastname;
            FIRSTNAME = firstname; 
            ADRESS = adress;
            CITYID = cityid;            
            CP = cp;
            CITY = city;
            TEL1 = tel1;
            TEL2 = tel2;
            TEL3 = tel3;
            newTimer.Tick += newTimer_Tick;
        }

        #endregion

        private int _id;
        private string _lastName;
        private string _firstName;
        private string _adress;
        private int _cityId;
        private string _cp;
        private string _city;
        private string _tel1;
        private string _tel2;
        private string _tel3;

        public int ID
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged(() => ID);
                }
            }
        }

        public string LASTNAME
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged(() => LASTNAME);
                }
            }
        }

        public string FIRSTNAME
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged(() => FIRSTNAME);
                }
            }
        }
        
        public string ADRESS
        {
            get { return _adress; }
            set
            {
                if (_adress != value)
                {
                    _adress = value;
                    RaisePropertyChanged(() => ADRESS);
                }
            }
        }

        public int CITYID
        {
            get { return _cityId; }
            set
            {
                if (_cityId != value)
                {
                    _cityId = value;
                    RaisePropertyChanged(() => CITYID);
                }
            }
        }

        public string CP
        {
            get { return _cp; }
            set
            {
                if (_cp != value)
                {
                    _cp = value;
                    RaisePropertyChanged(() => CP);
                }
            }
        }

        public string CITY
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    _city = value;
                    RaisePropertyChanged(() => CITY);
                }
            }
        }




        public string TEL1
        {
            get { return _tel1; }
            set
            {
                if (_tel1 != value)
                {
                    _tel1 = value;
                    RaisePropertyChanged(() => TEL1);
                }
            }
        }

        public string TEL2
        {
            get { return _tel2; }
            set
            {
                if (_tel2 != value)
                {
                    _tel2 = value;
                    RaisePropertyChanged(() => TEL2);
                }
            }
        }

        public string TEL3
        {
            get { return _tel3; }
            set
            {
                if (_tel3 != value)
                {
                    _tel3 = value;
                    RaisePropertyChanged(() => TEL3);
                }
            }
        }

        private readonly Timer newTimer = new Timer { Interval = 3000 };
        private void newTimer_Tick(object sender, EventArgs e)
        {
            this.newTimer.Stop();
        }

        public void SQLUpdate(string sTable, string sField, object sValue, int iId)
        {
            if (this.newTimer.Enabled)
                return;
            this.newTimer.Start();
            SQL.UpdateFields(sTable, sField, sValue, iId);
        }
    }
}