using System;
using System.Windows.Media;
using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    public class Family : NotificationObject
    {
        #region Ctor
        public Family(int id,
                      string lastname,
                      string firstname,
                      string adress,
                      string cityid                        
                      )
        {
            Id = id;
            Lastname = lastname;
            Firstname = firstname;
            Adress = adress;
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

        #region Adress

        private string _adress;
        public string Adress
        {
            get { return _adress; }
            set
            {
                if (_adress != value)
                {
                    _adress = value;
                    RaisePropertyChanged(() => Adress);
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
