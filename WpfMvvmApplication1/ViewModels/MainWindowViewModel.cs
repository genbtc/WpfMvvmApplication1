using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows.Input;
using Npgsql;
using WpfMvvmApplication1.Helpers;
using WpfMvvmApplication1.Models;

namespace WpfMvvmApplication1.ViewModels
{
    internal class MainWindowViewModel : NotificationObject
    {
        #region Properties

        #region ChildrensCollection

        private ChildrenCollection _childrensCollection;
        public ChildrenCollection ChildrensCollection
        {
            get { return _childrensCollection; }
            set
            {
                _childrensCollection = value;
                RaisePropertyChanged(() => ChildrensCollection);
            }
        }

        #endregion

        #region FamilyCollection

        private ObservableCollection<FamilyDB> _familyCollection;
        public ObservableCollection<FamilyDB> FamilyCollection
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

        #region ListGenders
        /// <summary>
        /// for initially populate checkbox with possible values
        /// </summary>
        public ObservableCollection<Gender> ListGenders
        {
            get { return Gender.listGenders.ToObservableCollection(); }
        }

        
        #endregion

        #endregion

        private void UpdateSqlrow()
        {
            //connection string
            NpgsqlConnection Connection = new NpgsqlConnection(SQL.sConnection);
            
            //open connection once.
            Connection.Open();
            
            //issue many commands
            foreach (Children row in ChildrensCollection.Collection)
            {
                NpgsqlCommand command = Connection.CreateCommand();
                if (row.Id > 0) //if row exist
                    SQL.UpdateDBChild(command, row);
                else            //or not exist, do insert
                    row.Id = SQL.InsertDBChild(command,row);
            }

            //close
            Connection.Close();
        }
        
        #region Constructor

        public MainWindowViewModel()
        {
            //RandomizeData();
            //ChildrensCollection = new ChildrenCollection();
            ChildrensCollection = new ChildrenCollection {Collection = SQL.listChildren()};
            FamilyCollection = SQL.listFamilies();
        }

        private void TestChildNames()
        {
            //using (var db = new agsEntities())
            //{
            //    IQueryable<CHILDREN> childQuery = from product in db.CHILDRENS
            //                                      select product;

            //    Console.WriteLine("Children Names:");
            //    foreach (var child in childQuery)
            //    {
            //        Console.WriteLine(child.FIRSTNAME + child.LASTNAME);
            //    }
            //}
            //using (agsEntities Context = new agsEntities())
            //{
            //    foreach (CHILDREN blog in Context.CHILDRENS)
            //    {
            //        Console.WriteLine(blog.FIRSTNAME + " " + blog.LASTNAME);
            //    }
            //}
            using (var db = new ChildrenContext())
            {
                var children = from a in db.Children
                               where a.LASTNAME.StartsWith("M")
                               orderby a.LASTNAME
                              select a;

                foreach (var child in children)
                {
                    Console.WriteLine(child.FIRSTNAME + child.LASTNAME);
                }
            }
        }

        #endregion

        #region Commands

        public ICommand DoNothingCommand { get { return new DelegateCommand(OnDoNothing, CanExecuteDoNothing); } }
        
        public ICommand UpdateDB { get { return new DelegateCommand(UpdateSqlrow); } }

        public ICommand TestEntity { get { return new DelegateCommand(TestChildNames); } }

        #endregion

        #region Command Handlers

        private void OnDoNothing(){}
        private bool CanExecuteDoNothing(){return false;}

        #endregion

        private void RandomizeData()
        {
            ChildrensCollection.Collection = new ObservableCollection<Children>();

            for (var i = 0; i < 10; i++)
            {
                ChildrensCollection.Collection.Add(new Children(
                    RandomHelper.RandomInt(1, 3),
                    RandomHelper.RandomString(10, true),
                    RandomHelper.RandomString(10, true),
                    RandomHelper.RandomDate(new DateTime(1980, 1, 1), DateTime.Now),
                    RandomHelper.RandomInt(1, 3),
                    RandomHelper.RandomInt(1, 15),
                    RandomHelper.RandomInt(1, 10),
                    RandomHelper.RandomBool(),
                    RandomHelper.RandomBool(),
                    RandomHelper.RandomBool(),
                    RandomHelper.RandomInt(1, 10),
                    RandomHelper.RandomBool(),
                    RandomHelper.RandomBool(),
                    RandomHelper.RandomBool(),
                    RandomHelper.RandomBool(),
                    RandomHelper.RandomBool(),
                    RandomHelper.RandomBool()
                    ));
            }

            FamilyCollection = new ObservableCollection<FamilyDB>();

            for (var i = 0; i < 2; i++)
            {
                FamilyCollection.Add(new FamilyDB(
                    RandomHelper.RandomInt(1, 15),
                    RandomHelper.RandomString(10, true),
                    RandomHelper.RandomString(10, true),
                    RandomHelper.RandomString(10, true),
                    RandomHelper.RandomInt(1, 3),
                    RandomHelper.RandomString(10, true),
                    RandomHelper.RandomString(10, true),
                    RandomHelper.RandomString(10, true),
                    RandomHelper.RandomString(10, true),
                    RandomHelper.RandomString(10, true)
                    ));
            }


        }
    }
}