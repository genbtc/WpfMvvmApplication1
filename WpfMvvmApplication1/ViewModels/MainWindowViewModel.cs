using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
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

        private ObservableCollection<Family> _familyCollection;
        public ObservableCollection<Family> FamilyCollection
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
            foreach (Children row in ChildrensCollection.Collection)
            {
                SQL.UpdateDBChild(row);
            }
        }
        
        #region Constructor

        public MainWindowViewModel()
        {
            //RandomizeData();
            //ChildrensCollection = new ChildrenCollection();
            ChildrensCollection = new ChildrenCollection {Collection = SQL.listChildren()};
            FamilyCollection = SQL.listFamilies();
        }
        #endregion

        #region Commands

        public ICommand DoNothingCommand { get { return new DelegateCommand(OnDoNothing, CanExecuteDoNothing); } }

        public ICommand UpdateDB { get { return new DelegateCommand(UpdateSqlrow); } }

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

            FamilyCollection = new ObservableCollection<Family>();

            for (var i = 0; i < 2; i++)
            {
                FamilyCollection.Add(new Family(
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