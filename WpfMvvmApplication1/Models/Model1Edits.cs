﻿
namespace WpfMvvmApplication1.Models
{
    public partial class CHILDRENS 
    {
        partial void OnFAMILYIDChanged()
        {
            OnPropertyChanged("FAMILIES");
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
    }
}
