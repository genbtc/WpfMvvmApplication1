using System;
using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    public class Children : NotificationObject
    {
     #region Ctor

        public Children(int id,
                        string lastname,
                        string firstname,
                        DateTime birthDate,
                        int sexId,
                        int familyId = -1 //default if none specified (like in listChildren())  but when
                                            // ChargeEnfant is called, it is used
                        )
        {
            Id = id;
            Lastname = lastname;
            Firstname = firstname;
            BirthDate = birthDate;
            SexId = sexId;
            FamilyId = familyId;
        }

        public Children(int id,
                        string lastname, 
                        string firstname, 
                        DateTime birthDate,
                        int sexId, 
                        int familyId, 
                        int medecineId,
                        bool samu, 
                        bool hospital, 
                        bool clinic, 
                        int clinicId, 
                        bool bePhotography, 
                        bool publicationPhotography, 
                        bool offOutputsStructure, 
                        bool swim,
                        bool bikeOutings,
                        bool boatOutings)
        {
            Id = id;
            Lastname = lastname;
            Firstname = firstname;
            BirthDate = birthDate;
            SexId = sexId;
            FamilyId = familyId;
            MedecineId = medecineId;
            Samu = samu;
            Hospital = hospital;
            Clinic = clinic;
            ClinicId = clinicId;
            BePhotography = bePhotography;
            PublicationPhotography = publicationPhotography;
            OffOutputsStructure = offOutputsStructure;
            Swim = swim;
            BikeOutings = bikeOutings;
            BoatOutings = boatOutings;

            GenderName = Gender.IDtoValue(_sexId);
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

        #region BirthDate

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (_birthDate != value)
                {
                    _birthDate = value;
                    RaisePropertyChanged(() => BirthDate);
                }
            }
        }

        #endregion

        #region Samu

        private bool _samu;
        public bool Samu
        {
            get { return _samu; }
            set
            {
                if (_samu != value)
                {
                    _samu = value;
                    RaisePropertyChanged(() => Samu);
                }
            }
        }

        #endregion

        #region Hospital

        private bool _hospital;
        public bool Hospital
        {
            get { return _hospital; }
            set
            {
                if (_hospital != value)
                {
                    _hospital = value;
                    RaisePropertyChanged(() => Hospital);
                }
            }
        }

        #endregion

        #region Clinic

        private bool _clinic;
        public bool Clinic
        {
            get { return _clinic; }
            set
            {
                if (_clinic != value)
                {
                    _clinic = value;
                    RaisePropertyChanged(() => Clinic);
                }
            }
        }

        #endregion

        #region ClinicId

        private int _clinicId;
        public int ClinicId
        {
            get { return _clinicId; }
            set
            {
                if (_clinicId != value)
                {
                    _clinicId = value;
                    RaisePropertyChanged(() => ClinicId);
                }
            }
        }

        #endregion

        #region BePhotography

        private bool _bePhotography;
        public bool BePhotography
        {
            get { return _bePhotography; }
            set
            {
                if (_bePhotography != value)
                {
                    _bePhotography = value;
                    RaisePropertyChanged(() => BePhotography);
                }
            }
        }

        #endregion

        #region PublicationPhotography

        private bool _publicationPhotography;
        public bool PublicationPhotography
        {
            get { return _publicationPhotography; }
            set
            {
                if (_publicationPhotography != value)
                {
                    _publicationPhotography = value;
                    RaisePropertyChanged(() => PublicationPhotography);
                }
            }
        }

        #endregion

        #region OffOutputsStructure

        private bool _offOutputsStructure;
        public bool OffOutputsStructure
        {
            get { return _offOutputsStructure; }
            set
            {
                if (_offOutputsStructure != value)
                {
                    _offOutputsStructure = value;
                    RaisePropertyChanged(() => OffOutputsStructure);
                }
            }
        }

        #endregion

        #region Swim

        private bool _swim;
        public bool Swim
        {
            get { return _swim; }
            set
            {
                if (_swim != value)
                {
                    _swim = value;
                    RaisePropertyChanged(() => Swim);
                }
            }
        }

        #endregion

        #region BikeOutings

        private bool _bikeOutings;
        public bool BikeOutings
        {
            get { return _bikeOutings; }
            set
            {
                if (_bikeOutings != value)
                {
                    _bikeOutings = value;
                    RaisePropertyChanged(() => BikeOutings);
                }
            }
        }

        #endregion

        #region BoatOuttings

        private bool _boatOutings;
        public bool BoatOutings
        {
            get { return _boatOutings; }
            set
            {
                if (_boatOutings != value)
                {
                    _boatOutings = value;
                    RaisePropertyChanged(() => BoatOutings);
                }
            }
        }

        #endregion

        #region Age

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    RaisePropertyChanged(() => Age);
                }
            }
        }

        #endregion

        #region SexId

        private int _sexId;
        public int SexId
        {
            get { return _sexId; }
            set
            {
                if (_sexId != value)
                {
                    _sexId = value;
                    RaisePropertyChanged(() => SexId);
                }
            }
        }

        #endregion

        #region FamilyId

        private int _familyId;
        public int FamilyId
        {
            get { return _familyId; }
            set
            {
                if (_familyId != value)
                {
                    _familyId = value;
                    RaisePropertyChanged(() => FamilyId);
                }
            }
        }

        #endregion

        #region MedecineId

        private int _medecineId;
        public int MedecineId
        {
            get { return _medecineId; }
            set
            {
                if (_medecineId != value)
                {
                    _medecineId = value;
                    RaisePropertyChanged(() => MedecineId);
                }
            }
        }


        #endregion

        #region GenderName
        private string _gendername;
        public string GenderName
        {
            get { return _gendername; }
            set
            {
                if (_gendername != value)
                {
                    _gendername = value;
                    RaisePropertyChanged(() => GenderName);
                }
            }
        }
        #endregion

    }
}
