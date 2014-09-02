using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfMvvmApplication1.Helpers;
using WpfMvvmApplication1.Models;

namespace WpfMvvmApplication1.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        #region Properties

        #region MyDateTime

        private DateTime _myDateTime;
        public DateTime MyDateTime
        {
            get { return _myDateTime; }
            set
            {
                if (_myDateTime != value)
                {
                    _myDateTime = value;
                    RaisePropertyChanged(() => MyDateTime);
                }
            }
        }

        #endregion

        #region PersonsCollection

        private ObservableCollection<Person> _personsCollection;
        public ObservableCollection<Person> PersonsCollection
        {
            get { return _personsCollection; }
            set
            {
                if (_personsCollection != value)
                {
                    _personsCollection = value;
                    RaisePropertyChanged(() => PersonsCollection);
                }
            }
        }

        #endregion

        #region ChildrensCollection

        private ObservableCollection<Children> _childrensCollection;
        public ObservableCollection<Children> ChildrensCollection
        {
            get { return _childrensCollection; }
            set
            {
                if (_childrensCollection != value)
                {
                    _childrensCollection = value;
                    RaisePropertyChanged(() => ChildrensCollection);
                }
            }
        }

        #endregion

        #region ListGenders
        public List<Gender> ListGenders
        {
            get { return listGenders; }
        }

        private readonly List<Gender> listGenders = new List<Gender> { new Gender { Id = 1, Value = "Homme" }, new Gender { Id = 2, Value = "Femme" } };
        #endregion

        #endregion

        #region Commands

        public ICommand RefreshDateCommand { get { return new DelegateCommand(OnRefreshDate); } }
        public ICommand RefreshPersonsCommand { get { return new DelegateCommand(OnRefreshPersons); } }
        public ICommand DoNothingCommand { get { return new DelegateCommand(OnDoNothing, CanExecuteDoNothing); } }

        #endregion

        #region Ctor
        public MainWindowViewModel()
        {
            RandomizeData();
        }
        #endregion

        #region Command Handlers

        private void OnRefreshDate()
        {
            MyDateTime = DateTime.Now;
        }

        private void OnRefreshPersons()
        {
            RandomizeData();
        }

        private void OnDoNothing()
        {
        }

        private bool CanExecuteDoNothing()
        {
            return false;
        }

        #endregion

        private void RandomizeData()
        {
            ChildrensCollection = new ObservableCollection<Children>();

            for (var i = 0; i < 10; i++)
            {
                ChildrensCollection.Add(new Children(
                    RandomHelper.RandomInt(1, 3),
                    RandomHelper.RandomString(10, true),
                    RandomHelper.RandomString(10, true),
                    RandomHelper.RandomDate(new DateTime(1980, 1, 1), DateTime.Now),
                    RandomHelper.RandomInt(1, 3),
                    RandomHelper.RandomInt(1, 50),
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
        }
    }
}