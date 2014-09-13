using System;
using System.ComponentModel;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WpfMvvmApplication1.Models
{
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="agsModel", Name="FAMILIES")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class FAMILIES : EntityObject, INotifyPropertyChanged
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new FAMILIES object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static FAMILIES CreateFAMILIES(global::System.Int32 id)
        {
            FAMILIES fAMILIES = new FAMILIES();
            fAMILIES.ID = id;
            return fAMILIES;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public global::System.String LASTNAME
        {
            get
            {
                return _LASTNAME;
            }
            set
            {
                OnLASTNAMEChanging(value);
                ReportPropertyChanging("LASTNAME");
                _LASTNAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LASTNAME");
                OnLASTNAMEChanged();
            }
        }
        private global::System.String _LASTNAME;
        partial void OnLASTNAMEChanging(global::System.String value);
        partial void OnLASTNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public global::System.String FIRSTNAME
        {
            get
            {
                return _FIRSTNAME;
            }
            set
            {
                OnFIRSTNAMEChanging(value);
                ReportPropertyChanging("FIRSTNAME");
                _FIRSTNAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FIRSTNAME");
                OnFIRSTNAMEChanged();
            }
        }
        private global::System.String _FIRSTNAME;
        partial void OnFIRSTNAMEChanging(global::System.String value);
        partial void OnFIRSTNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public global::System.String ADRESS
        {
            get
            {
                return _ADRESS;
            }
            set
            {
                OnADRESSChanging(value);
                ReportPropertyChanging("ADRESS");
                _ADRESS = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ADRESS");
                OnADRESSChanged();
            }
        }
        private global::System.String _ADRESS;
        partial void OnADRESSChanging(global::System.String value);
        partial void OnADRESSChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
        [DataMember()]
        public Nullable<global::System.Int32> CITYID
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

        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;

        private Nullable<global::System.Int32> _CITYID;
        partial void OnCITYIDChanging(Nullable<global::System.Int32> value);
        partial void OnCITYIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public global::System.String TEL1
        {
            get
            {
                return _TEL1;
            }
            set
            {
                OnTEL1Changing(value);
                ReportPropertyChanging("TEL1");
                _TEL1 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TEL1");
                OnTEL1Changed();
            }
        }
        private global::System.String _TEL1;
        partial void OnTEL1Changing(global::System.String value);
        partial void OnTEL1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public global::System.String TEL2
        {
            get
            {
                return _TEL2;
            }
            set
            {
                OnTEL2Changing(value);
                ReportPropertyChanging("TEL2");
                _TEL2 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TEL2");
                OnTEL2Changed();
            }
        }
        private global::System.String _TEL2;
        partial void OnTEL2Changing(global::System.String value);
        partial void OnTEL2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public global::System.String TEL3
        {
            get
            {
                return _TEL3;
            }
            set
            {
                OnTEL3Changing(value);
                ReportPropertyChanging("TEL3");
                _TEL3 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TEL3");
                OnTEL3Changed();
            }
        }
        private global::System.String _TEL3;
        partial void OnTEL3Changing(global::System.String value);
        partial void OnTEL3Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("agsModel", "famfk", "CHILDRENS")]
        public EntityCollection<CHILDRENS> CHILDRENS
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<CHILDRENS>("agsModel.famfk", "CHILDRENS");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<CHILDRENS>("agsModel.famfk", "CHILDRENS", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("agsModel", "cityfk", "CITIES")]
        public CITIES CITIES
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CITIES>("agsModel.cityfk", "CITIES").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CITIES>("agsModel.cityfk", "CITIES").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<CITIES> CITIESReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CITIES>("agsModel.cityfk", "CITIES");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CITIES>("agsModel.cityfk", "CITIES", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("agsModel", "familyfk", "FAMILYQUOTIENTS")]
        public EntityCollection<FAMILYQUOTIENTS> FAMILYQUOTIENTS
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FAMILYQUOTIENTS>("agsModel.familyfk", "FAMILYQUOTIENTS");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FAMILYQUOTIENTS>("agsModel.familyfk", "FAMILYQUOTIENTS", value);
                }
            }
        }

        #endregion

    }
}