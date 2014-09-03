using System.Collections.ObjectModel;
using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    public class ChildrenCollection : NotificationObject
    {
        private ObservableCollection<Children> _collection;
        public ObservableCollection<Children> Collection
        {
            get { return _collection; }
            set
            {
                _collection = value;
                RaisePropertyChanged(() => Collection);
            }
        }

        private Children _selectedItem;
        public Children SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                RaisePropertyChanged(() => SelectedItem);
            }            
        }
    }
}