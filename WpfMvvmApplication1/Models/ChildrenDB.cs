using System;
using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    public class ChildrenDB : NotificationObject
    {
        #region Constructor

        public ChildrenDB()
        {}

        public ChildrenDB(int id,
            string lastname,
            string firstname,
            DateTime birthdate,
            int genderid,
            int familyid,
            int medecineid,
            bool emt,
            bool hospital,
            bool clinic,
            int clinicid,
            bool bephotography,
            bool publicationphotography,
            bool offoutputsstructure,
            bool swim,
            bool bikeoutings,
            bool boatoutings)
        {
            ID = id;
            LASTNAME = lastname;
            FIRSTNAME = firstname;
            BIRTHDATE = birthdate;
            GENDERID = genderid;
            FAMILYID = familyid;
            MEDECINEID = medecineid;
            EMT = emt;
            HOSPITAL = hospital;
            CLINIC = clinic;
            CLINICID = clinicid;
            BEPHOTOGRAPHY = bephotography;
            PUBLICATIONPHOTOGRAPHY = publicationphotography;
            OFFOUTPUTSSTRUCTURE = offoutputsstructure;
            SWIM = swim;
            BIKEOUTINGS = bikeoutings;
            BOATOUTINGS = boatoutings;

            //GENDERNAME = Gender.IDtoValue(_genderId);
        }

        #endregion

        #region Id

        private int _id;

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

        #endregion

        #region LastName

        private string _lastname;

        public string LASTNAME
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                RaisePropertyChanged(() => LASTNAME);
            }
        }

        #endregion

        #region FirstName

        private string _firstname;

        public string FIRSTNAME
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                RaisePropertyChanged(() => FIRSTNAME);
            }
        }

        #endregion

        #region BirthDate

        private DateTime _birthDate;

        public DateTime BIRTHDATE
        {
            get { return _birthDate; }
            set
            {
                if (_birthDate != value)
                {
                    _birthDate = value;
//                    AGE = ToAge.Age(_birthDate);
                    RaisePropertyChanged(() => BIRTHDATE);
                }
            }
        }

        #endregion

        #region Emt

        private bool _emt;

        public bool EMT
        {
            get { return _emt; }
            set
            {
                if (_emt != value)
                {
                    _emt = value;
                    RaisePropertyChanged(() => EMT);
                }
            }
        }

        #endregion

        #region Hospital

        private bool _hospital;

        public bool HOSPITAL
        {
            get { return _hospital; }
            set
            {
                if (_hospital != value)
                {
                    _hospital = value;
                    RaisePropertyChanged(() => HOSPITAL);
                }
            }
        }

        #endregion

        #region Clinic

        private bool _clinic;

        public bool CLINIC
        {
            get { return _clinic; }
            set
            {
                if (_clinic != value)
                {
                    _clinic = value;
                    RaisePropertyChanged(() => CLINIC);
                }
            }
        }

        #endregion

        #region ClinicId

        private int _clinicId;

        public int CLINICID
        {
            get { return _clinicId; }
            set
            {
                if (_clinicId != value)
                {
                    _clinicId = value;
                    RaisePropertyChanged(() => CLINICID);
                }
            }
        }

        #endregion

        #region BePhotography

        private bool _bePhotography;

        public bool BEPHOTOGRAPHY
        {
            get { return _bePhotography; }
            set
            {
                if (_bePhotography != value)
                {
                    _bePhotography = value;
                    RaisePropertyChanged(() => BEPHOTOGRAPHY);
                }
            }
        }

        #endregion

        #region PublicationPhotography

        private bool _publicationPhotography;

        public bool PUBLICATIONPHOTOGRAPHY
        {
            get { return _publicationPhotography; }
            set
            {
                if (_publicationPhotography != value)
                {
                    _publicationPhotography = value;
                    RaisePropertyChanged(() => PUBLICATIONPHOTOGRAPHY);
                }
            }
        }

        #endregion

        #region OffOutputsStructure

        private bool _offOutputsStructure;

        public bool OFFOUTPUTSSTRUCTURE
        {
            get { return _offOutputsStructure; }
            set
            {
                if (_offOutputsStructure != value)
                {
                    _offOutputsStructure = value;
                    RaisePropertyChanged(() => OFFOUTPUTSSTRUCTURE);
                }
            }
        }

        #endregion

        #region Swim

        private bool _swim;

        public bool SWIM
        {
            get { return _swim; }
            set
            {
                if (_swim != value)
                {
                    _swim = value;
                    RaisePropertyChanged(() => SWIM);
                }
            }
        }

        #endregion

        #region BikeOutings

        private bool _bikeOutings;

        public bool BIKEOUTINGS
        {
            get { return _bikeOutings; }
            set
            {
                if (_bikeOutings != value)
                {
                    _bikeOutings = value;
                    RaisePropertyChanged(() => BIKEOUTINGS);
                }
            }
        }

        #endregion

        #region BoatOuttings

        private bool _boatOutings;

        public bool BOATOUTINGS
        {
            get { return _boatOutings; }
            set
            {
                if (_boatOutings != value)
                {
                    _boatOutings = value;
                    RaisePropertyChanged(() => BOATOUTINGS);
                }
            }
        }

        #endregion

        //#region Age

        //private int _age;

        //public int AGE
        //{
        //    get { return _age; }
        //    set
        //    {
        //        if (_age != value)
        //        {
        //            _age = value;
        //            RaisePropertyChanged(() => AGE);
        //        }
        //    }
        //}

        //#endregion

        #region GenderId

        private int _genderId;

        public int GENDERID
        {
            get { return _genderId; }
            set
            {
                if (_genderId != value)
                {
                    _genderId = value;
//                    GENDERNAME = Gender.IDtoValue(_genderId);
                    RaisePropertyChanged(() => GENDERID);
                }
            }
        }

        #endregion

        #region FamilyId

        private int _familyId;

        public int FAMILYID
        {
            get { return _familyId; }
            set
            {
                if (_familyId != value)
                {
                    _familyId = value;
                    RaisePropertyChanged(() => FAMILYID);
                }
            }
        }

        #endregion

        #region MedecineId

        private int _medecineId;

        public int MEDECINEID
        {
            get { return _medecineId; }
            set
            {
                if (_medecineId != value)
                {
                    _medecineId = value;
                    RaisePropertyChanged(() => MEDECINEID);
                }
            }
        }

        #endregion

        //#region GenderName

        //private string _gendername;

        //public string GENDERNAME
        //{
        //    get { return _gendername; }
        //    set
        //    {
        //        if (_gendername != value)
        //        {
        //            _gendername = value;
        //            RaisePropertyChanged(() => GENDERNAME);
        //        }
        //    }
        //}

        //#endregion
    }
}