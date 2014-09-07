using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Objects;
using System.Windows.Data;
using System.Windows.Input;
using WpfMvvmApplication1.Helpers;

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
        }

        #endregion

        #region EF Query
        private void GetCitiesViewSource()
        {
            // Load data into CHILDREN
            this.citiesQuery = this.GetCitiesQuery(this.agsEntities);
            this._citiesViewSource = new CollectionViewSource();
            this._citiesViewSource.Source = this.citiesQuery.Execute(MergeOption.AppendOnly);
            this._citiesViewSource.View.Refresh();
            //and into an observable collection
            foreach (CITY thing in agsEntities.CITIES)
                CityCollection.Add(thing);
        }

        private void GetFamilyViewSource()
        {
            // Load data into FAMILIES
            this.familiesQuery = this.GetFamiliesQuery(this.agsEntities);

            this._familiesViewSource = new CollectionViewSource();
            this._familiesComboBoxViewSource = new CollectionViewSource();

            this._familiesViewSource.Source = this.familiesQuery.Execute(MergeOption.AppendOnly);
            
            //this._familiesComboBoxViewSource.Source = this.GetFamiliesQuery(this.agsEntities).Execute(MergeOption.AppendOnly);

            //and into an observable collection
            foreach (FAMILY thing in agsEntities.FAMILIES)
                FamilyCollection.Add(thing);

            this._familiesViewSource.Source = FamilyCollection;
            this._familiesViewSource.SortDescriptions.Add(new SortDescription("ID", ListSortDirection.Ascending));
            this._familiesComboBoxViewSource.Source = FamilyCollection;
            this._familiesComboBoxViewSource.SortDescriptions.Add(new SortDescription("ID", ListSortDirection.Ascending));
            this._familiesViewSource.View.Refresh();
            this._familiesComboBoxViewSource.View.Refresh();

        }
        private void GetChildrenViewSource()
        {
            // Load data into CHILDREN
            this.childrenQuery = this.GetChildrenQuery(this.agsEntities);
            this._childrenViewSource = new CollectionViewSource();
            this._childrenViewSource.Source = this.childrenQuery.Execute(MergeOption.AppendOnly);
            this._childrenViewSource.View.Refresh();
            //and into an observable collection
            foreach (CHILDREN thing in agsEntities.CHILDRENS)
                ChildrenCollection.Add(thing);
        }

        private ObjectQuery<FAMILY> familiesQuery;
        private ObjectQuery<FAMILY> GetFamiliesQuery(agsEntities agsEntitiesparam)
        {
            familiesQuery = agsEntitiesparam.FAMILIES;
            return familiesQuery;
        }

        private ObjectQuery<CHILDREN> childrenQuery;
        private ObjectQuery<CHILDREN> GetChildrenQuery(agsEntities agsEntitiesparam)
        {
            childrenQuery = agsEntitiesparam.CHILDRENS;
            return childrenQuery;
        }

        private ObjectQuery<CITY> citiesQuery;
        private ObjectQuery<CITY> GetCitiesQuery(agsEntities agsEntitiesparam)
        {
            citiesQuery = agsEntitiesparam.CITIES;
            return citiesQuery;
        }

        #endregion

        #region Commands

        //private void TestChildNames()
        //{
        //    using (var db = new agsEntities())
        //    {
        //        IQueryable<CHILDREN> childQuery = from product in db.CHILDRENS
        //            select product;

        //        Console.WriteLine("Children Names:");
        //        foreach (var child in childQuery)
        //            Console.WriteLine(child.FIRSTNAME + child.LASTNAME);
        //    }
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
            foreach (CHILDREN some in this.ChildrenCollection)
            {
                if (some.ID == 0)
                {
                    this.agsEntities.CHILDRENS.AddObject(some);
                }
            }
            //this.agsEntities.Refresh(RefreshMode.ClientWins, this.ChildrenCollection);
            this.agsEntities.SaveChanges();
        }

        private void SaveFamilytoDB()
        {
            //this.agsEntities.SaveChanges();
            //this.agsEntities.Refresh(RefreshMode.StoreWins, this.familiesQuery);
            foreach (FAMILY some in this.FamilyCollection)
            {
                if (some.ID == 0)
                {
                    this.agsEntities.FAMILIES.AddObject(some);
                }
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