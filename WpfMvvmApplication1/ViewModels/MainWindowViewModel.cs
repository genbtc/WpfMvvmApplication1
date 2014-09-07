using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Objects;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Windows.Data;
using System.Windows.Input;
using WpfMvvmApplication1.Helpers;
using WpfMvvmApplication1.Models;

namespace WpfMvvmApplication1.ViewModels
{
    public class MainWindowViewModel : NotificationObject
    {
        #region Properties
        private CollectionViewSource _familiesViewSource;
        public CollectionViewSource FamiliesViewSource
        {
            get
            {
                if (_familiesViewSource == null)
                    GetFamilyViewSource();
                return _familiesViewSource;
            }
        }

        private CollectionViewSource _familiesComboBoxViewSource;
        public CollectionViewSource FamiliesComboBoxViewSource
        {
            get
            {
                if (_familiesComboBoxViewSource == null)
                    GetFamilyViewSource();
                return _familiesViewSource;
            }
        }

        private CollectionViewSource _citiesViewSource;
        public CollectionViewSource CitiesViewSource
        {
            get
            {
                if (_citiesViewSource == null)
                    GetCitiesViewSource();
                return _citiesViewSource;
            }
        }


        private CollectionViewSource _childrenViewSource;
        public CollectionViewSource ChildrenViewSource
        {
            get
            {
                if (_childrenViewSource == null)
                    GetChildrenViewSource();
                return _childrenViewSource;
            }
        }

        private ObservableCollection<FAMILY> _familyCollection = new ObservableCollection<FAMILY>();
        public ObservableCollection<FAMILY> FamilyCollection
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

        private ObservableCollection<CHILDREN> _childrenCollection = new ObservableCollection<CHILDREN>();
        public ObservableCollection<CHILDREN> ChildrenCollection
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

        private ObservableCollection<CITY> _cityCollection = new ObservableCollection<CITY>();
        public ObservableCollection<CITY> CityCollection
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
        
        #endregion

        #region Constructor

        private agsEntities agsEntities = new agsEntities("metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=Npgsql;provider connection string='PORT=5432;TIMEOUT=15;POOLING=True;MINPOOLSIZE=1;MAXPOOLSIZE=20;COMMANDTIMEOUT=20;COMPATIBLE=2.2.0.0;HOST=localhost;DATABASE=ags;USER ID=ags;PASSWORD=Fadila1980'");

        public MainWindowViewModel()
        {
            //ChildrenCollection = new ChildrenCollection {Collection = SQL.listChildren()};
            //FamilyCollection = SQL.listFamilies();
            GetChildrenViewSource();
            GetFamilyViewSource();
            GetCitiesViewSource();
        }

        #endregion

        #region EF Query
        private void GetCitiesViewSource()
        {
            CityCollection = new ObservableCollection<CITY>(agsEntities.CITIES);
            // Load data into CHILDREN
            var citiesQuery = agsEntities.CITIES;
            this._citiesViewSource = new CollectionViewSource();
            this._citiesViewSource.Source = citiesQuery.Execute(MergeOption.AppendOnly);
            this._citiesViewSource.View.Refresh();
        }

        private void GetFamilyViewSource()
        {
            FamilyCollection = new ObservableCollection<FAMILY>(agsEntities.FAMILIES);
            // Load data into FAMILIES
            var familiesQuery = agsEntities.FAMILIES;
            this._familiesViewSource = new CollectionViewSource();
            this._familiesViewSource.Source = familiesQuery.Execute(MergeOption.AppendOnly);
            this._familiesViewSource.View.Refresh();
            this._familiesViewSource.Source = FamilyCollection;
            this._familiesViewSource.SortDescriptions.Add(new SortDescription("ID", ListSortDirection.Ascending));

            this._familiesComboBoxViewSource = new CollectionViewSource();
            //this._familiesComboBoxViewSource.Source = this.GetFamiliesQuery(this.agsEntities).Execute(MergeOption.AppendOnly);
            
            this._familiesComboBoxViewSource.Source = FamilyCollection;
            this._familiesComboBoxViewSource.SortDescriptions.Add(new SortDescription("ID", ListSortDirection.Ascending));
            this._familiesComboBoxViewSource.View.Refresh();

        }
        private void GetChildrenViewSource()
        {
            // Load data into CHILDREN
            ChildrenCollection = new ObservableCollection<CHILDREN>(agsEntities.CHILDRENS);
            var childrenQuery = agsEntities.CHILDRENS;
            this._childrenViewSource = new CollectionViewSource();
            this._childrenViewSource.Source = childrenQuery.Execute(MergeOption.AppendOnly);
            this._childrenViewSource.View.Refresh();
        }

        private IQueryable MapChildrentoCity()
        {
            var childrenQuery = agsEntities.CHILDRENS;
            var familiesQuery = agsEntities.FAMILIES;
            var citiesQuery = agsEntities.CITIES;
            
            var query1 = from child in childrenQuery
                        join fam in familiesQuery on child.FAMILYID equals fam.ID
                        select new {child.ID , fam.CITYID};
            var query2 = from fam in familiesQuery
                        join cit in citiesQuery on fam.CITYID equals cit.ID
                        select new {fam.CITYID , cit.CITY1};
            var query3 = from a in query1 
                        join b in query2 on a.CITYID equals b.CITYID 
                        select new {a.ID, b.CITY1};
            var query4 = from c in query3
                join d in citiesQuery on c.CITY1 equals d.CITY1
                select new {c.ID, d.CP};
            return query4;        
        }

        #endregion

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
            //this.agsEntities.SaveChanges();
            //this.agsEntities.Refresh(RefreshMode.StoreWins, this.childrenQuery);
            foreach (CHILDREN some in this.ChildrenCollection.Where(some => some.ID == 0))
            {
                this.agsEntities.CHILDRENS.AddObject(some);
            }
            //this.agsEntities.Refresh(RefreshMode.ClientWins, this.ChildrenCollection);
            this.agsEntities.SaveChanges();
        }

        private void SaveFamilytoDB()
        {
            //this.agsEntities.SaveChanges();
            //this.agsEntities.Refresh(RefreshMode.StoreWins, this.familiesQuery);
            foreach (FAMILY some in this.FamilyCollection.Where(some => some.ID == 0))
            {
                this.agsEntities.FAMILIES.AddObject(some);
            }
            //this.agsEntities.Refresh(RefreshMode.ClientWins, this.FamilyCollection);
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