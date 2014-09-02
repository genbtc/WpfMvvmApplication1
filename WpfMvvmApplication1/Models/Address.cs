using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    public class Address : NotificationObject
    {
        #region Ctor

        public Address(int id,
            string name,
            string address,
            string cp,
            string commune,
            string tel1,
            string tel2,
            string tel3
            )
        {
            Id = id;
            Name = name;
            AddressProperty = address;
            Cp = cp;
            Commune = commune;
            Tel1 = tel1;
            Tel2 = tel2;
            Tel3 = tel3;
        }

        #endregion

        private string _address;
        private string _cityId;
        private string _commune;
        private string _cp;
        private int _id;
        private string _name;
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

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    RaisePropertyChanged(() => Name);
                }
            }
        }

        public string AddressProperty
        {
            get { return _address; }
            set
            {
                if (_address != value)
                {
                    _address = value;
                    RaisePropertyChanged(() => AddressProperty);
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

        public string Commune
        {
            get { return _commune; }
            set
            {
                if (_cityId != value)
                {
                    _cityId = value;
                    RaisePropertyChanged(() => Commune);
                }
            }
        }


        public string CityId
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