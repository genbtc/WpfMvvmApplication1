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
    [EdmEntityType(NamespaceName="agsModel", Name="CHILDRENS")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class CHILDRENS : EntityObject, INotifyPropertyChanged
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CHILDRENS object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static CHILDRENS CreateCHILDRENS(global::System.Int32 id)
        {
            CHILDRENS cHILDRENS = new CHILDRENS();
            cHILDRENS.ID = id;
            return cHILDRENS;
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
        public Nullable<global::System.DateTime> BIRTHDATE
        {
            get
            {
                return _BIRTHDATE;
            }
            set
            {
                OnBIRTHDATEChanging(value);
                ReportPropertyChanging("BIRTHDATE");
                _BIRTHDATE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BIRTHDATE");
                OnBIRTHDATEChanged();
            }
        }
        private Nullable<global::System.DateTime> _BIRTHDATE;
        partial void OnBIRTHDATEChanging(Nullable<global::System.DateTime> value);
        partial void OnBIRTHDATEChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty = false, IsNullable = true)]
        [DataMember()]
        public Nullable<global::System.Int32> FAMILYID
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

        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private Nullable<global::System.Int32> _FAMILYID;
        partial void OnFAMILYIDChanging(Nullable<global::System.Int32> value);
        partial void OnFAMILYIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Int32> GENDERID
        {
            get
            {
                return _GENDERID;
            }
            set
            {
                OnGENDERIDChanging(value);
                ReportPropertyChanging("GENDERID");
                _GENDERID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("GENDERID");
                OnGENDERIDChanged();
            }
        }
        private Nullable<global::System.Int32> _GENDERID;
        partial void OnGENDERIDChanging(Nullable<global::System.Int32> value);
        partial void OnGENDERIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Boolean> EMT
        {
            get
            {
                return _EMT;
            }
            set
            {
                OnEMTChanging(value);
                ReportPropertyChanging("EMT");
                _EMT = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EMT");
                OnEMTChanged();
            }
        }
        private Nullable<global::System.Boolean> _EMT;
        partial void OnEMTChanging(Nullable<global::System.Boolean> value);
        partial void OnEMTChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Boolean> HOSPITAL
        {
            get
            {
                return _HOSPITAL;
            }
            set
            {
                OnHOSPITALChanging(value);
                ReportPropertyChanging("HOSPITAL");
                _HOSPITAL = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("HOSPITAL");
                OnHOSPITALChanged();
            }
        }
        private Nullable<global::System.Boolean> _HOSPITAL;
        partial void OnHOSPITALChanging(Nullable<global::System.Boolean> value);
        partial void OnHOSPITALChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Boolean> CLINIC
        {
            get
            {
                return _CLINIC;
            }
            set
            {
                OnCLINICChanging(value);
                ReportPropertyChanging("CLINIC");
                _CLINIC = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CLINIC");
                OnCLINICChanged();
            }
        }
        private Nullable<global::System.Boolean> _CLINIC;
        partial void OnCLINICChanging(Nullable<global::System.Boolean> value);
        partial void OnCLINICChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Int32> CLINICID
        {
            get
            {
                return _CLINICID;
            }
            set
            {
                OnCLINICIDChanging(value);
                ReportPropertyChanging("CLINICID");
                _CLINICID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CLINICID");
                OnCLINICIDChanged();
            }
        }
        private Nullable<global::System.Int32> _CLINICID;
        partial void OnCLINICIDChanging(Nullable<global::System.Int32> value);
        partial void OnCLINICIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Boolean> BEPHOTOGRAPHY
        {
            get
            {
                return _BEPHOTOGRAPHY;
            }
            set
            {
                OnBEPHOTOGRAPHYChanging(value);
                ReportPropertyChanging("BEPHOTOGRAPHY");
                _BEPHOTOGRAPHY = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BEPHOTOGRAPHY");
                OnBEPHOTOGRAPHYChanged();
            }
        }
        private Nullable<global::System.Boolean> _BEPHOTOGRAPHY;
        partial void OnBEPHOTOGRAPHYChanging(Nullable<global::System.Boolean> value);
        partial void OnBEPHOTOGRAPHYChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Boolean> PUBLICATIONPHOTOGRAPHY
        {
            get
            {
                return _PUBLICATIONPHOTOGRAPHY;
            }
            set
            {
                OnPUBLICATIONPHOTOGRAPHYChanging(value);
                ReportPropertyChanging("PUBLICATIONPHOTOGRAPHY");
                _PUBLICATIONPHOTOGRAPHY = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PUBLICATIONPHOTOGRAPHY");
                OnPUBLICATIONPHOTOGRAPHYChanged();
            }
        }
        private Nullable<global::System.Boolean> _PUBLICATIONPHOTOGRAPHY;
        partial void OnPUBLICATIONPHOTOGRAPHYChanging(Nullable<global::System.Boolean> value);
        partial void OnPUBLICATIONPHOTOGRAPHYChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Boolean> OFFOUTPUTSSTRUCTURE
        {
            get
            {
                return _OFFOUTPUTSSTRUCTURE;
            }
            set
            {
                OnOFFOUTPUTSSTRUCTUREChanging(value);
                ReportPropertyChanging("OFFOUTPUTSSTRUCTURE");
                _OFFOUTPUTSSTRUCTURE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OFFOUTPUTSSTRUCTURE");
                OnOFFOUTPUTSSTRUCTUREChanged();
            }
        }
        private Nullable<global::System.Boolean> _OFFOUTPUTSSTRUCTURE;
        partial void OnOFFOUTPUTSSTRUCTUREChanging(Nullable<global::System.Boolean> value);
        partial void OnOFFOUTPUTSSTRUCTUREChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Boolean> SWIM
        {
            get
            {
                return _SWIM;
            }
            set
            {
                OnSWIMChanging(value);
                ReportPropertyChanging("SWIM");
                _SWIM = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SWIM");
                OnSWIMChanged();
            }
        }
        private Nullable<global::System.Boolean> _SWIM;
        partial void OnSWIMChanging(Nullable<global::System.Boolean> value);
        partial void OnSWIMChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Boolean> BIKEOUTINGS
        {
            get
            {
                return _BIKEOUTINGS;
            }
            set
            {
                OnBIKEOUTINGSChanging(value);
                ReportPropertyChanging("BIKEOUTINGS");
                _BIKEOUTINGS = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BIKEOUTINGS");
                OnBIKEOUTINGSChanged();
            }
        }
        private Nullable<global::System.Boolean> _BIKEOUTINGS;
        partial void OnBIKEOUTINGSChanging(Nullable<global::System.Boolean> value);
        partial void OnBIKEOUTINGSChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Boolean> BOATOUTINGS
        {
            get
            {
                return _BOATOUTINGS;
            }
            set
            {
                OnBOATOUTINGSChanging(value);
                ReportPropertyChanging("BOATOUTINGS");
                _BOATOUTINGS = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BOATOUTINGS");
                OnBOATOUTINGSChanged();
            }
        }
        private Nullable<global::System.Boolean> _BOATOUTINGS;
        partial void OnBOATOUTINGSChanging(Nullable<global::System.Boolean> value);
        partial void OnBOATOUTINGSChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Int32> MEDECINEID
        {
            get
            {
                return _MEDECINEID;
            }
            set
            {
                OnMEDECINEIDChanging(value);
                ReportPropertyChanging("MEDECINEID");
                _MEDECINEID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MEDECINEID");
                OnMEDECINEIDChanged();
            }
        }
        private Nullable<global::System.Int32> _MEDECINEID;
        partial void OnMEDECINEIDChanging(Nullable<global::System.Int32> value);
        partial void OnMEDECINEIDChanged();
    
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
        [EdmRelationshipNavigationProperty("agsModel", "famfk", "FAMILIES")]
        public FAMILIES FAMILIES
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<FAMILIES>("agsModel.famfk", "FAMILIES").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<FAMILIES>("agsModel.famfk", "FAMILIES").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [Browsable(false)]
        [DataMember()]
        public EntityReference<FAMILIES> FAMILIESReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<FAMILIES>("agsModel.famfk", "FAMILIES");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<FAMILIES>("agsModel.famfk", "FAMILIES", value);
                }
            }
        }

        #endregion

    }
}