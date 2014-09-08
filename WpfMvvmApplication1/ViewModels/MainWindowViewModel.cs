using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.ViewModels
{
    public class MainWindowViewModel : NotificationObject
    {
        #region Properties

        private ObservableCollection<FAMILIES> _familyCollection = new ObservableCollection<FAMILIES>();
        public ObservableCollection<FAMILIES> FamilyCollection
        {
            get { return _familyCollection; }
            set
            {
                if (_familyCollection != value)
                {
                    _familyCollection = value;
                    RaisePropertyChanged(() => FamilyCollection);
                }
            }
        }

        private ObservableCollection<CHILDRENS> _childrenCollection = new ObservableCollection<CHILDRENS>();
        public ObservableCollection<CHILDRENS> ChildrenCollection
        {
            get { return _childrenCollection; }
            set
            {
                if (_childrenCollection != value)
                {
                    _childrenCollection = value;
                    RaisePropertyChanged(() => ChildrenCollection);
                }
            }
        }

        private ObservableCollection<CITIES> _cityCollection = new ObservableCollection<CITIES>();
        public ObservableCollection<CITIES> CityCollection
        {
            get { return _cityCollection; }
            set
            {
                if (_cityCollection != value)
                {
                    _cityCollection = value;
                    RaisePropertyChanged(() => CityCollection);
                }
            }
        }

         #region FAMILYQUOTIENTS
        private ObservableCollection<FAMILYQUOTIENTS> _FAMILYQUOTIENTSCollection = new ObservableCollection<FAMILYQUOTIENTS>();
        public ObservableCollection<FAMILYQUOTIENTS> FAMILYQUOTIENTSCollection
        {
            get { return _FAMILYQUOTIENTSCollection; }
            set
            {
                if (_FAMILYQUOTIENTSCollection != value)
                {
                    _FAMILYQUOTIENTSCollection = value;
                    RaisePropertyChanged(() => FAMILYQUOTIENTSCollection);
                }
            }
        }
        #endregion
 
        #region MedecinCollection
        private ObservableCollection<MEDECINS> _medecinCollection = new ObservableCollection<MEDECINS>();
        public ObservableCollection<MEDECINS> MedecinCollection
        {
            get { return _medecinCollection; }
            set
            {
                if (_medecinCollection != value)
                {
                    _medecinCollection = value;
                    RaisePropertyChanged(() => MedecinCollection);
                }
            }
        }
        #endregion
 
        #region CIVILITIESCollection
        private ObservableCollection<CIVILITIES> _CIVILITIESCollection = new ObservableCollection<CIVILITIES>();
        public ObservableCollection<CIVILITIES> CIVILITIESCollection
        {
            get { return _CIVILITIESCollection; }
            set
            {
                if (_CIVILITIESCollection != value)
                {
                    _CIVILITIESCollection = value;
                    RaisePropertyChanged(() => CIVILITIESCollection);
                }
            }
        }
        #endregion
        #endregion
        

        #region Constructor

        private agsEntities agsEntities = new agsEntities("metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=Npgsql;provider connection string='PORT=5432;TIMEOUT=15;POOLING=True;MINPOOLSIZE=1;MAXPOOLSIZE=20;COMMANDTIMEOUT=20;COMPATIBLE=2.2.0.0;HOST=localhost;DATABASE=ags;USER ID=ags;PASSWORD=Fadila1980'");

        public MainWindowViewModel()
        {
            GetCitiesCollection();
            GetFamilyCollection();
            GetChildrenCollection();
            GetFAMILYQUOTIENTSCollection();
            //GetMedecinCollection();
            //GetCIVILITIESCollection();
        }

        #endregion

        #region EF Query

        private void GetCIVILITIESCollection()
        {
            CIVILITIESCollection = new ObservableCollection<CIVILITIES>(agsEntities.CIVILITIES);
        }

        private void GetMedecinCollection()
        {
            MedecinCollection = new ObservableCollection<MEDECINS>(agsEntities.MEDECINS);
        }

        private void GetFAMILYQUOTIENTSCollection()
        {
            FAMILYQUOTIENTSCollection = new ObservableCollection<FAMILYQUOTIENTS>(agsEntities.FAMILYQUOTIENTS);
        }

        private void GetCitiesCollection()
        {
            CityCollection = new ObservableCollection<CITIES>(agsEntities.CITIES);
        }

        private void GetFamilyCollection()
        {
            FamilyCollection = new ObservableCollection<FAMILIES>(agsEntities.FAMILIES);
        }

        private void GetChildrenCollection()
        {
            ChildrenCollection = new ObservableCollection<CHILDRENS>(agsEntities.CHILDRENS);
        }

        #endregion

        //private IQueryable MapChildrentoCity()
        //{
        //    var childrenQuery = agsEntities.CHILDRENS;
        //    var familiesQuery = agsEntities.FAMILIES;
        //    var citiesQuery = agsEntities.CITIES;
            
        //    var query1 = from child in childrenQuery
        //                join fam in familiesQuery on child.FAMILYID equals fam.ID
        //                select new {child.ID , fam.CITYID};
        //    var query2 = from fam in familiesQuery
        //                join cit in citiesQuery on fam.CITYID equals cit.ID
        //                select new {fam.CITYID , cit.CITY1};
        //    var query3 = from a in query1 
        //                join b in query2 on a.CITYID equals b.CITYID 
        //                select new {a.ID, b.CITY1};
        //    var query4 = from c in query3
        //        join d in citiesQuery on c.CITY1 equals d.CITY1
        //        select new {c.ID, d.CP};
        //    return query4;        
        //}

        #region Commands

        //private void TestChildNames()
        //{
        //using (var db = new agsEntities())
        //{
        //    IQueryable<CHILDREN> childQuery = from product in db.CHILDRENS
        //        select product;

        //    Console.WriteLine("Children Names:");
        //    foreach (var child in childQuery)
        //        Console.WriteLine(child.FIRSTNAME + child.LASTNAME);
        //}
        //    using (var Context = new agsEntities())
        //    {
        //        foreach (CHILDREN blog in Context.CHILDRENS)
        //            Console.WriteLine(blog.FIRSTNAME + " " + blog.LASTNAME);
        //    }
        //}

        ////old way
        //private void UpdateSqlrow()
        //{
        //    //connection string
        //    var Connection = new NpgsqlConnection(SQL.sConnection);

        //    //open connection once.
        //    Connection.Open();

        //    //issue many commands
        //    foreach (Children row in ChildrenCollection.Collection)
        //    {
        //        NpgsqlCommand command = Connection.CreateCommand();
        //        if (row.Id > 0) //if row exist
        //            SQL.UpdateDBChild(command, row);
        //        else //or not exist, do insert
        //            row.Id = SQL.InsertDBChild(command, row);
        //    }

        //    //close
        //    Connection.Close();
        //}

        private void SaveChildrentoDB()
        {
            foreach (CHILDRENS some in this.ChildrenCollection.Where(some => some.ID == 0))
            {
                this.agsEntities.CHILDRENS.AddObject(some);
            }
            this.agsEntities.SaveChanges();
        }

        private void SaveFamilytoDB()
        {
            foreach (FAMILIES some in this.FamilyCollection.Where(some => some.ID == 0))
            {
                this.agsEntities.FAMILIES.AddObject(some);
            }
            this.agsEntities.SaveChanges();
        }

        private bool CanExecuteDoNothing()
        {
            return false;
        }

        private void OnDoNothing()
        {}

        #endregion

        #region Command Handlers

        public ICommand SaveFamily
        {
            get { return new DelegateCommand(SaveFamilytoDB); }
        }

        public ICommand SaveChildren
        {
            get { return new DelegateCommand(SaveChildrentoDB); }
        }

        public ICommand DoNothingCommand
        {
            get { return new DelegateCommand(OnDoNothing, CanExecuteDoNothing); }
        }

        #endregion
    }
}