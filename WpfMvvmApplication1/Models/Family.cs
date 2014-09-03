using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    public class Family : NotificationObject
    {
        #region Ctor

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
                    _tel3 = value;
                    RaisePropertyChanged(() => Tel3);
                }
            }
        }
    }
}