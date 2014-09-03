using System;
using WpfMvvmApplication1.Helpers;
using Timer = System.Windows.Forms.Timer;

namespace WpfMvvmApplication1.Models
{
    public class Family : NotificationObject
    {
        #region Ctor

        public Family()
        {
            newTimer.Tick += newTimer_Tick;
        }

        public Family(int id,
            string lastName,
            string firstName,
            string address,
            int cityId,            
            string cp,
            string city,
            string tel1,
            string tel2,
            string tel3
            )
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName; 
            Address = address;
            CityId = cityId;            
            Cp = cp;
            City = city;
            Tel1 = tel1;
            Tel2 = tel2;
            Tel3 = tel3;
            newTimer.Tick += newTimer_Tick;
        }

        #endregion

        private int _id;
        private string _lastName;
        private string _firstName;
        private string _address;
        private int _cityId;
        private string _cp;
        private string _city;
        private string _tel1;
        private string _tel2;
        private string _tel3;

        public int Id
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    //if (_id != null)
                    //    SQL.UpdateFields("FAMILIES", "ID", value, _id);
                    _id = value;
                    RaisePropertyChanged(() => Id);
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    if (_lastName != null)
                        SQL.UpdateFields("FAMILIES", "ADRESS", value, _id);
                    _lastName = value;
                    RaisePropertyChanged(() => LastName);
                }
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    if (_firstName != null)
                        SQL.UpdateFields("FAMILIES", "CITYID", value, _id);
                    _firstName = value;
                    RaisePropertyChanged(() => FirstName);
                }
            }
        }
        
        public string Address
        {
            get { return _address; }
            set
            {
                if (_address != value)
                {
                    if (_address != null)
                        SQL.UpdateFields("FAMILIES", "ADRESS", value, _id);
                    _address = value;
                    RaisePropertyChanged(() => Address);
                }
            }
        }

        public int CityId
        {
            get { return _cityId; }
            set
            {
                if (_cityId != value)
                {
                    if (_cityId != null)
                        SQL.UpdateFields("FAMILIES", "CITYID", value, _id);
                    _cityId = value;
                    RaisePropertyChanged(() => CityId);
                }
            }
        }

        public string Cp
        {
            get { return _cp; }
            set
            {
                if (_cp != value)
                {
                    if (_cp != null)
                        SQL.UpdateFields("FAMILIES", "CP", value, _id);
                    _cp = value;
                    RaisePropertyChanged(() => Cp);
                }
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                if (_city != value)
                {
                    if (_city != null)
                        SQL.UpdateFields("FAMILIES", "CITY", value, _id);
                    _city = value;
                    RaisePropertyChanged(() => City);
                }
            }
        }




        public string Tel1
        {
            get { return _tel1; }
            set
            {
                if (_tel1 != value)
                {
                    if (_tel1 != null)
                        SQL.UpdateFields("FAMILIES", "TEL1", value, _id);
                    _tel1 = value;
                    RaisePropertyChanged(() => Tel1);
                }
            }
        }

        public string Tel2
        {
            get { return _tel2; }
            set
            {
                if (_tel2 != value)
                {
                    if (_tel2 != null)
                        SQL.UpdateFields("FAMILIES", "TEL2", value, _id);
                    _tel2 = value;
                    RaisePropertyChanged(() => Tel2);
                }
            }
        }

        public string Tel3
        {
            get { return _tel3; }
            set
            {
                if (_tel3 != value)
                {
                    if (_tel3 != null)
                        SQL.UpdateFields("FAMILIES", "TEL3", value, _id);
                    _tel3 = value;
                    RaisePropertyChanged(() => Tel3);
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