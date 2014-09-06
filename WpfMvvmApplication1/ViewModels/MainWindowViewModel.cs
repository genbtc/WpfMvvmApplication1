using System;
using System.Collections.ObjectModel;
using System.Data.Objects;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Npgsql;
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

        #endregion

        #region Constructor

        public agsEntities agsEntities = new agsEntities();

        public MainWindowViewModel()
        {
            //RandomizeData();
            //ChildrenCollection = new ChildrenCollection {Collection = SQL.listChildren()};
            //FamilyCollection = SQL.listFamilies();
        }

        #endregion

        #region EF Query

        private void GetFamilyViewSource()
        {
            // Load data into FAMILIES
            this.FamiliesQuery = this.GetFAMILIESQuery(this.agsEntities);
            this._familiesViewSource = new CollectionViewSource();
            this._familiesViewSource.Source = this.FamiliesQuery.Execute(MergeOption.AppendOnly);
            this._familiesViewSource.View.Refresh();
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