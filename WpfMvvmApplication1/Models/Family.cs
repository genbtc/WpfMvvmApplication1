using System;
using System.Windows.Media;
using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    public class Family : NotificationObject
    {
        #region Ctor

        public Family(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

        public Family(int id,
                      string lastname,
                      string firstname,
                      string address,
                      string cityid                        
                      )
        {
            Id = id;
            Lastname = lastname;
            Firstname = firstname;
            Address = address;
            CityId = cityid;
        }
        #endregion

        #region Id

        private int _id;
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

        #endregion
        
        #region nom

        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set
            {
                if (_nom != value)
                {
                    _nom = value;
                    RaisePropertyChanged(() => Nom);
                }
            }
        }
        #endregion

        #region LastName

        private string _lastname;
        public string Lastname
        {
            get { return _lastname; }
            set
            {
                if (_lastname != value)
                {
                    _lastname = value;
                    RaisePropertyChanged(() => Lastname);
                }
            }
        }

        #endregion

        #region FirstName

        private string _firstname;
        public string Firstname
        {
            get { return _firstname; }
            set
            {
                if (_firstname != value)
                {
                    _firstname = value;
                    RaisePropertyChanged(() => Firstname);
                }
            }
        }

        #endregion

        #region Address

        private string _address;
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

        #endregion

        #region CityId

        private string _cityId;


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

        #endregion


    }
}
