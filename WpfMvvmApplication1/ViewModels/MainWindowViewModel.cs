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
        
        #endregion

        #region Constructor

        public agsEntities agsEntities = new agsEntities("metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=Npgsql;provider connection string='PORT=5432;TIMEOUT=15;POOLING=True;MINPOOLSIZE=1;MAXPOOLSIZE=20;COMMANDTIMEOUT=20;COMPATIBLE=2.2.0.0;HOST=localhost;DATABASE=ags;USER ID=ags;PASSWORD=Fadila1980'");

        public MainWindowViewModel()
        {
            //ChildrenCollection = new ChildrenCollection {Collection = SQL.listChildren()};
            //FamilyCollection = SQL.listFamilies();
        }

        #endregion

        #region EF Query
        private void GetCitiesViewSource()
        {
            // Load data into CHILDREN
            this.CitiesQuery = this.GetCitiesQuery(this.agsEntities);
            this._citiesViewSource = new CollectionViewSource();
            this._citiesViewSource.Source = this.CitiesQuery.Execute(MergeOption.AppendOnly);
            this._citiesViewSource.View.Refresh();
        }

        private void GetFamilyViewSource()
        {
            // Load data into FAMILIES
            this.FamiliesQuery = this.GetFAMILIESQuery(this.agsEntities);

            this._familiesViewSource = new CollectionViewSource();
            this._familiesComboBoxViewSource = new CollectionViewSource();

            this._familiesViewSource.Source = this.FamiliesQuery.Execute(MergeOption.AppendOnly);
            this._familiesViewSource.SortDescriptions.Add(new SortDescription("ID", ListSortDirection.Descending));
            this._familiesComboBoxViewSource.Source = this.GetFAMILIESQuery(this.agsEntities).Execute(MergeOption.AppendOnly);

            this._familiesViewSource.View.Refresh();
            this._familiesComboBoxViewSource.View.Refresh();
            //and into an observable collection
            //foreach (FAMILY thing in agsEntities.FAMILIES)
            //    FamilyCollection.Add(thing);

        }
        private void GetChildrenViewSource()
        {
            // Load data into CHILDREN
            this.ChildrenQuery = this.GetCHILDRENQuery(this.agsEntities);
            this._childrenViewSource = new CollectionViewSource();
            this._childrenViewSource.Source = this.ChildrenQuery.Execute(MergeOption.AppendOnly);
            this._childrenViewSource.View.Refresh();
        }

        public ObjectQuery<FAMILY> FamiliesQuery;
        public ObjectQuery<FAMILY> GetFAMILIESQuery(agsEntities agsEntities)
        {
            ObjectQuery<FAMILY> fAMILIESQuery = agsEntities.FAMILIES;
            return fAMILIESQuery;
        }

        public ObjectQuery<CHILDREN> ChildrenQuery;
        public ObjectQuery<CHILDREN> GetCHILDRENQuery(agsEntities agsEntities)
        {
            ObjectQuery<CHILDREN> CHILDRENQuery = agsEntities.CHILDRENS;
            return CHILDRENQuery;
        }

        public ObjectQuery<CITY> CitiesQuery;
        public ObjectQuery<CITY> GetCitiesQuery(agsEntities agsEntities)
        {
            ObjectQuery<CITY> CitiesQuery = agsEntities.CITIES;
            return CitiesQuery;
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
            this.agsEntities.SaveChanges();
            this.agsEntities.Refresh(RefreshMode.StoreWins, this.ChildrenQuery);
        }

        private void SaveFamilytoDB()
        {
            this.agsEntities.SaveChanges();
            this.agsEntities.Refresh(RefreshMode.StoreWins, this.FamiliesQuery);
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