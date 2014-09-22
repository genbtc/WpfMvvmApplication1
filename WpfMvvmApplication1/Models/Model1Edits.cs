
namespace WpfMvvmApplication1.Models
{
<<<<<<< Updated upstream
    public partial class CHILDREN 
=======
    public partial class CHILDREN
>>>>>>> Stashed changes
    {
        partial void OnFAMILYIDChanged()
        {
            OnPropertyChanged("FAMILIES");
        }
        bool _etiselected;
        public bool ETISelected
        {
            get
            {
                return _etiselected;
            }
            set
            {
                if (_etiselected == value)
                    return;
                _etiselected = value;
                OnPropertyChanged("ETISelected");
                OnPropertyChanged("DetailsVisibility");
            }
        }
        public System.Windows.Visibility DetailsVisibility
        {
            get
            {
                return ETISelected ? System.Windows.Visibility.Visible : System.Windows.Visibility.Collapsed;
            }
            set { var bindingdummysetter = value; }
        } 
    }

    public partial class FAMILIES
    {
        partial void OnCITYIDChanged()
        {
            OnPropertyChanged("CITIES");
        }

        partial void OnCIVILITYIDChanged()
        {
            OnPropertyChanged("CIVILITIES");
        }

        partial void OnPARTNERCIVILITYIDChanged()
        {
            OnPropertyChanged("CIVILITIES");
        }

        partial void OnPAYERCIVILITYIDChanged()
        {
            OnPropertyChanged("CIVILITIES");
        }

        bool _etiselected;
        public bool ETISelected
        {
            get
            {
                return _etiselected;
            }
            set
            {
                if (_etiselected == value) 
                    return;
                _etiselected = value;
                OnPropertyChanged("ETISelected");
                OnPropertyChanged("DetailsVisibility");
            }
        }
        public System.Windows.Visibility DetailsVisibility
        {
            get
            {
                return ETISelected ? System.Windows.Visibility.Visible : System.Windows.Visibility.Collapsed;
            }
            set { var bindingdummysetter = value; }
        } 
    }
}
