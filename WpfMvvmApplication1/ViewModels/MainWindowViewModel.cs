using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using WpfMvvmApplication1.Helpers;
using WpfMvvmApplication1.Models;

namespace WpfMvvmApplication1.ViewModels
{
    public class MainWindowViewModel : NotificationObject
    {

    #region Properties

        private ObservableCollection<FAMILIES> _familiesCollection;
        public ObservableCollection<FAMILIES> FamiliesCollection
        {
            get { return _familiesCollection; }
            set
            {
                if (_familiesCollection == value) return;
                _familiesCollection = value;
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
        public ObservableCollection<FAMILYQUOTIENTS> FAMILYQUOTIENTSCollection
        {
            get { return _familyquotientsCollection; }
            set
            {
                if (_familyquotientsCollection == value) return;
                _familyquotientsCollection = value;
                RaisePropertyChanged(() => FAMILYQUOTIENTSCollection);
            }
        }
 
        private ObservableCollection<MEDECINS> _medecinsCollection;
        public ObservableCollection<MEDECINS> MedecinsCollection
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
        public ObservableCollection<CIVILITIES> CIVILITIESCollection
        {
            get { return _civilitiesCollection; }
            set
            {
                if (_civilitiesCollection == value) return;
                _civilitiesCollection = value;
                RaisePropertyChanged(() => CIVILITIESCollection);
            }
        }

    #endregion

        #region Constructor

        private EF EF;

        public MainWindowViewModel()
        {
            this.EF = new EF();
            GetCitiesCollection();
            GetFamilyCollection();
            GetChildrenCollection();
            GetFamilyquotientsCollection();
            GetMedecinCollection();
            GetCivilitiesCollection();
        }

        #endregion

        #region EF Query

        private void GetCivilitiesCollection()
        {
            CIVILITIESCollection = new ObservableCollection<CIVILITIES>(EF.agsEntities.CIVILITIES);
        }

        private void GetMedecinCollection()
        {
            MedecinsCollection = new ObservableCollection<MEDECINS>(EF.agsEntities.MEDECINS);
        }

        private void GetFamilyquotientsCollection()
        {
            FAMILYQUOTIENTSCollection = new ObservableCollection<FAMILYQUOTIENTS>(EF.agsEntities.FAMILYQUOTIENTS);
        }

        private void GetCitiesCollection()
        {
            CitiesCollection = new ObservableCollection<CITIES>(EF.agsEntities.CITIES);
        }

        private void GetFamilyCollection()
        {
            FamiliesCollection = new ObservableCollection<FAMILIES>(EF.agsEntities.FAMILIES);
        }

        private void GetChildrenCollection()
        {
            ChildrensCollection = new ObservableCollection<CHILDRENS>(EF.agsEntities.CHILDRENS);
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

        #region Command Handlers
        public ICommand SaveFamily { get { return new DelegateCommand(SaveFamilytoDb); } }
        public ICommand SaveChildren { get { return new DelegateCommand(SaveChildrentoDb); } }
        #endregion

        #region Commands
        private void SaveFamilytoDb() { EF.SaveChildrentoDB(ChildrensCollection); }
        private void SaveChildrentoDb() { EF.SaveFamilytoDB(FamiliesCollection); }
        #endregion
        
    }
}