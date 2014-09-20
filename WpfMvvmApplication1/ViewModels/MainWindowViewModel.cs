using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Input;
using WpfMvvmApplication1.Helpers;
using WpfMvvmApplication1.Models;

namespace WpfMvvmApplication1.ViewModels
{
    public class MainWindowViewModel : NotificationObject
    {

        #region Properties
        
        //purposefully doesnt have an INotify.
        public ObservableCollection<FAMILIES> FamiliesBox { get; set; }

        private ObservableCollection<FAMILIES> _familiesCollection;

        public ObservableCollection<FAMILIES> FamiliesCollection
        {
            get { return _familiesCollection; }
            set
            {
                if (_familiesCollection == value) return;
                _familiesCollection = value;
                FamiliesBox = new ObservableCollection<FAMILIES>(_familiesCollection);
                RaisePropertyChanged(() => FamiliesCollection);
            }
        }

        private ObservableCollection<CHILDRENS> _childrensCollection;

        public ObservableCollection<CHILDRENS> ChildrensCollection
        {
            get { return _childrensCollection; }
            set
            {
                if (_childrensCollection == value) return;
                _childrensCollection = value;
                RaisePropertyChanged(() => ChildrensCollection);
            }
        }

        private ObservableCollection<CITIES> _citiesCollection;

        public ObservableCollection<CITIES> CitiesCollection
        {
            get { return _citiesCollection; }
            set
            {
                if (_citiesCollection == value) return;
                _citiesCollection = value;
                RaisePropertyChanged(() => CitiesCollection);
            }
        }

        private ObservableCollection<FAMILYQUOTIENTS> _familyquotientsCollection;

        public ObservableCollection<FAMILYQUOTIENTS> FamilyquotientsCollection
        {
            get { return _familyquotientsCollection; }
            set
            {
                if (_familyquotientsCollection == value) return;
                _familyquotientsCollection = value;
                RaisePropertyChanged(() => FamilyquotientsCollection);
            }
        }

        private ObservableCollection<MEDECINES> _medecinsCollection;

        public ObservableCollection<MEDECINES> MedecinsCollection
        {
            get { return _medecinsCollection; }
            set
            {
                if (_medecinsCollection == value) return;
                _medecinsCollection = value;
                RaisePropertyChanged(() => MedecinsCollection);
            }
        }

        private ObservableCollection<CIVILITIES> _civilitiesCollection;

        public ObservableCollection<CIVILITIES> CivilitiesCollection
        {
            get { return _civilitiesCollection; }
            set
            {
                if (_civilitiesCollection == value) return;
                _civilitiesCollection = value;
                RaisePropertyChanged(() => CivilitiesCollection);
            }
        }

        //private CollectionView _familiesViewSource;

        //public CollectionView FamiliesViewSource
        //{
        //    get { return _familiesViewSource; }
        //    set
        //    {
        //        _familiesViewSource = value;
        //        RaisePropertyChanged(() => FamiliesViewSource);
        //    }
        //}

        //private CollectionView _childrenViewSource;

        //public CollectionView ChildrenViewSource
        //{
        //    get { return _childrenViewSource; }
        //    set
        //    {
        //        _childrenViewSource = value;
        //        RaisePropertyChanged(() => ChildrenViewSource);
        //    }
        //}

        #endregion

        #region EF Query

        private void SortFamiliesViewSource()
        {
            CollectionViewSource.GetDefaultView(FamiliesCollection)
                .SortDescriptions.Add(new SortDescription("ID", ListSortDirection.Ascending));
        }

        private void SortChildrenViewSource()
        {
            CollectionViewSource.GetDefaultView(ChildrensCollection)
                .SortDescriptions.Add(new SortDescription("ID", ListSortDirection.Ascending));
        }
        private void SortCitiesViewSource()
        {
            CollectionViewSource.GetDefaultView(CitiesCollection)
                .SortDescriptions.Add(new SortDescription("ID", ListSortDirection.Ascending));
        }

        #endregion

        #region Constructor

        private EF EF;

        public MainWindowViewModel()
        {
            this.EF = new EF();
            //Fill Collections
            GetCitiesCollection();
            GetFamiliesCollection();
            GetChildrensCollection();
            GetFamilyquotientsCollection();
            GetMedecinsCollection();
            GetCivilitiesCollection();

            //create custom randomized specific data(edit the function-then comment out).
            //RandomizeData();

            //Sort Views
            SortChildrenViewSource();
            SortFamiliesViewSource();
            SortCitiesViewSource();
            
            //tracks item additions and deletions, and saves to the database when that occurs.
            this.FamiliesCollection.CollectionChanged += ItemCollection_CollectionChanged;
            this.ChildrensCollection.CollectionChanged += ItemCollection_CollectionChanged;
            //_selectRowCommand = new RelayCommand(SelectionHasChanged);    //not used yet.
        }

        //private void SelectionHasChanged()
        //{ }

        #endregion

        #region Fill Collections with EF Query

        private void GetCivilitiesCollection()
        {
            CivilitiesCollection = new ObservableCollection<CIVILITIES>(EF.agsEntities.CIVILITIES);
        }

        private void GetMedecinsCollection()
        {
            MedecinsCollection = new ObservableCollection<MEDECINES>(EF.agsEntities.MEDECINES);
        }

        private void GetFamilyquotientsCollection()
        {
            FamilyquotientsCollection = new ObservableCollection<FAMILYQUOTIENTS>(EF.agsEntities.FAMILYQUOTIENTS);
        }

        private void GetCitiesCollection()
        {
            CitiesCollection = new ObservableCollection<CITIES>(EF.agsEntities.CITIES);
        }

        private void GetFamiliesCollection()
        {
            FamiliesCollection = new ObservableCollection<FAMILIES>(EF.agsEntities.FAMILIES);
        }

        private void GetChildrensCollection()
        {
            ChildrensCollection = new ObservableCollection<CHILDRENS>(EF.agsEntities.CHILDRENS);
        }

        #endregion

        #region Command Handlers

        public ICommand SaveFamily
        {
            get { return new DelegateCommand(SaveFamilytoDb); }
        }

        public ICommand SaveChildren
        {
            get { return new DelegateCommand(SaveChildrentoDb); }
        }

        public ICommand SaveAll
        {
            get { return new DelegateCommand(SaveToDb); }
        }

        public ICommand RefreshDb
        {
            get { return new DelegateCommand(RefreshViewDb); }
        }
    
        #endregion

        #region Commands

        private void RefreshViewDb()
        {
            EF.Refresh(ChildrensCollection, FamiliesCollection);
            RaisePropertyChanged(() => ChildrensCollection);
            RaisePropertyChanged(() => FamiliesCollection);
        }

        private void SaveFamilytoDb()
        {
            EF.SaveFamilytoDB(FamiliesCollection);
        }

        private void SaveChildrentoDb()
        {
            EF.SaveChildrentoDB(ChildrensCollection);
        }

        private void SaveToDb()
        {
            EF.SaveToDb();
        }

        #endregion

        //not used yet.
        //private RelayCommand _selectRowCommand;
        //public ICommand SelectRowCommand
        //{
        //    get { return _selectRowCommand; }
        //}

        //When the collection changes, (Occurs when an item is added, removed, changed, moved, or the entire list is refreshed)
        // (Usually as soon as a blank row is clicked(new,Add) or deleted.)
        // Check for new rows, (ID ==0) then Add the Blank row to the entity context, and SaveChanges (write to DB)
        private void ItemCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Type nodeType = sender.GetType();
            if (nodeType == typeof (ObservableCollection<FAMILIES>))
            {
                var typedcollection = (ObservableCollection<FAMILIES>)sender;
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (FAMILIES somenew in typedcollection.Where(some => some.ID == 0))
                    {
                        EF.agsEntities.FAMILIES.AddObject(somenew);
                    }
                }
                else if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (FAMILIES removeitems in e.OldItems)
                    {
                        EF.agsEntities.FAMILIES.DeleteObject(removeitems);
                    }
                }
                EF.SaveToDb();
                //needs to be created after DB save, so it adds as the permanent ID, at the end of the list, not as ID0 at the beginning.
                FamiliesBox = new ObservableCollection<FAMILIES>((ObservableCollection<FAMILIES>)sender);
                RaisePropertyChanged(() => FamiliesBox);
            }
            else if (nodeType == typeof (ObservableCollection<CHILDRENS>))
            {
                var typedcollection = (ObservableCollection<CHILDRENS>)sender;
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (CHILDRENS somenew in typedcollection.Where(some => some.ID == 0))
                    {
                        EF.agsEntities.CHILDRENS.AddObject(somenew);
                    }
                }
                else if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (CHILDRENS removeitems in e.OldItems)
                    {
                        EF.agsEntities.CHILDRENS.DeleteObject(removeitems);
                    }
                }
                EF.SaveToDb();
            }
        }

        private void RandomizeData()
        {
            Random r = new Random();
            char startletter = 'A';

            for (int f = 0; f < 400; f++)
            {
                var fakefamily = new FAMILIES();
                string alphabet = "ABEFGHILMNOPUVabbcdefghijklmnooppqrstuvwyxzeeeiouea";
                Func<char> randomLetter = () => alphabet[r.Next(alphabet.Length)];
                Func<int, string> makeName =
                    (length) => new string(Enumerable.Range(0, length)
                        .Select(x => x == 0 ? char.ToUpper(randomLetter()) : randomLetter())
                        .ToArray());

                fakefamily.CIVILITYID = RandomHelper.RandomInt(1, 3);
                fakefamily.LASTNAME = makeName(r.Next(7) + 7);
                fakefamily.FIRSTNAME = makeName(r.Next(5) + 5);
                fakefamily.EMAIL = RandomHelper.RandomString(12, true) + "@" + RandomHelper.RandomString(17, true) + ".com";
                fakefamily.SOCIALSECURITYID = RandomHelper.RandomInt(1, 999999999);
                fakefamily.TEL1 = RandomHelper.RandomInt(100, 999) + "-" + RandomHelper.RandomInt(100, 999) + "-" +
                              RandomHelper.RandomInt(1000, 9999);
                fakefamily.TEL2 = RandomHelper.RandomInt(100, 999) + "-" + RandomHelper.RandomInt(100, 999) + "-" +
                              RandomHelper.RandomInt(1000, 9999);
                fakefamily.TEL3 = RandomHelper.RandomInt(100, 999) + "-" + RandomHelper.RandomInt(100, 999) + "-" +
                              RandomHelper.RandomInt(1000, 9999);

                fakefamily.ADDRESS += RandomHelper.RandomInt(1, 9999) + " ";
                for (int i = 1; i <= 2; i++)
                {
                    fakefamily.ADDRESS += RandomHelper.RandomString(12, true) + " " + Path.GetRandomFileName().Replace(".", "");
                    fakefamily.ADDRESS += "\n";
                }
                fakefamily.ADDRESS += makeName(r.Next(7) + 7);
                fakefamily.CITYID = RandomHelper.RandomInt(1, CitiesCollection.Count);

                FamiliesCollection.Add(fakefamily);
                this.EF.agsEntities.FAMILIES.AddObject(fakefamily);
            }

            this.EF.SaveToDb();

            //RandomHelper.RandomString(10, true);
            //RandomHelper.RandomDate(new DateTime(1980, 1, 1), DateTime.Now);
            //RandomHelper.RandomInt(1, 3);
            //RandomHelper.RandomBool();
            for (int t = 0; t < 15; t++)
            {
                for (int f = 0; f < 26; f++)
                {
                    var fakechild = new CHILDRENS();

                    //fakechild.LASTNAME = makeName(r.Next(7) + 7);
                    //fakechild.FIRSTNAME = makeName(r.Next(5) + 5);
                    var nextchar = ((char)(startletter + f)).ToString();
                    var rnlength = RandomHelper.RandomInt(3, 15);
                    fakechild.FIRSTNAME = "";
                    fakechild.LASTNAME = "";
                    for (int rn = 0; rn < rnlength; rn++) 
                    { 
                        fakechild.FIRSTNAME +=(nextchar).ToLower();
                        fakechild.LASTNAME += nextchar;
                    }
                    fakechild.BIRTHDATE = RandomHelper.RandomDate(new DateTime(1980, 1, 1), DateTime.Now);
                    fakechild.GENDERID = RandomHelper.RandomInt(1, 3);
                    fakechild.FAMILYID = RandomHelper.RandomInt(1, 400);
                    ChildrensCollection.Add(fakechild);
                    this.EF.agsEntities.CHILDRENS.AddObject(fakechild);
                }
            }

            this.EF.SaveToDb();

            foreach (CHILDRENS child in ChildrensCollection)
            {
                child.BIRTHDATE = RandomHelper.RandomDate(new DateTime(1930, 1, 1), DateTime.Now);
                child.ALLERGIES = Path.GetRandomFileName().Replace(".", "");
                child.BEPHOTOGRAPHY = RandomHelper.RandomBool();
                child.BIKEOUTINGS = RandomHelper.RandomBool();
                child.BOATOUTINGS = RandomHelper.RandomBool();
                child.CLINIC = RandomHelper.RandomBool();
                child.EMT = RandomHelper.RandomBool();
                child.FAMILYID = RandomHelper.RandomInt(1, 400);
                child.GENDERID = RandomHelper.RandomInt(1, 3);
                child.HOSPITAL = RandomHelper.RandomBool();
                //child.MEDECINEID = 
                child.OFFOUTPUTSSTRUCTURE = RandomHelper.RandomBool();
                child.PUBLICATIONPHOTOGRAPHY = RandomHelper.RandomBool();
                child.SPECIALARRANGEMENTS = Path.GetRandomFileName().Replace(".", "") + Path.GetRandomFileName().Replace(".", "");
                child.SWIM = RandomHelper.RandomBool();
                child.WITHOUTEGG = RandomHelper.RandomBool();
                child.WITHOUTFISH = RandomHelper.RandomBool();
                child.WITHOUTGLUTEN = RandomHelper.RandomBool();
                child.WITHOUTMEAT = RandomHelper.RandomBool();
                child.WITHOUTPORK = RandomHelper.RandomBool();
            }

            this.EF.SaveToDb();
            //RandomHelper.RandomString(10, true);
            //RandomHelper.RandomDate(new DateTime(1980, 1, 1), DateTime.Now);
            //RandomHelper.RandomInt(1, 3);
            //RandomHelper.RandomBool();



        }
    }
}