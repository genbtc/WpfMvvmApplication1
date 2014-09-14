using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WpfMvvmApplication1.Models
{
    public partial class CHILDRENS : INotifyPropertyChanged
    {
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
        [DataMember()]
        public Nullable<int> FAMILYID
        {
            get { return _FAMILYID; }
            set
            {
                OnFAMILYIDChanging(value);
                ReportPropertyChanging("FAMILYID");
                _FAMILYID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FAMILYID");
                OnFAMILYIDChanged();
                OnNavigationPropertyChanged("FAMILIES");
            }
        }
        private Nullable<int> _FAMILYID;
        partial void OnFAMILYIDChanging(Nullable<int> value);
        partial void OnFAMILYIDChanged();

        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged { add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
    }



    public partial class FAMILIES : INotifyPropertyChanged
    {
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
        [DataMember()]
        public Nullable<int> CITYID
        {
            get { return _CITYID; }
            set
            {
                OnCITYIDChanging(value);
                ReportPropertyChanging("CITYID");
                _CITYID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CITYID");
                OnCITYIDChanged();
                OnNavigationPropertyChanged("CITIES");
            }
        }
        private Nullable<int> _CITYID;
        partial void OnCITYIDChanging(Nullable<int> value);
        partial void OnCITYIDChanged();

        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged { add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
    }


}
