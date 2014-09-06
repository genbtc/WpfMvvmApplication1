﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace WpfMvvmApplication1
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class agsEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new agsEntities object using the connection string found in the 'agsEntities' section of the application configuration file.
        /// </summary>
        public agsEntities() : base("name=agsEntities", "agsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = false;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new agsEntities object.
        /// </summary>
        public agsEntities(string connectionString) : base(connectionString, "agsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = false;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new agsEntities object.
        /// </summary>
        public agsEntities(EntityConnection connection) : base(connection, "agsEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = false;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CHILDREN> CHILDRENS
        {
            get
            {
                if ((_CHILDRENS == null))
                {
                    _CHILDRENS = base.CreateObjectSet<CHILDREN>("CHILDRENS");
                }
                return _CHILDRENS;
            }
        }
        private ObjectSet<CHILDREN> _CHILDRENS;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CITY> CITIES
        {
            get
            {
                if ((_CITIES == null))
                {
                    _CITIES = base.CreateObjectSet<CITY>("CITIES");
                }
                return _CITIES;
            }
        }
        private ObjectSet<CITY> _CITIES;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<FAMILY> FAMILIES
        {
            get
            {
                if ((_FAMILIES == null))
                {
                    _FAMILIES = base.CreateObjectSet<FAMILY>("FAMILIES");
                }
                return _FAMILIES;
            }
        }
        private ObjectSet<FAMILY> _FAMILIES;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CHILDRENS EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCHILDRENS(CHILDREN cHILDREN)
        {
            base.AddObject("CHILDRENS", cHILDREN);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CITIES EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCITIES(CITY cITY)
        {
            base.AddObject("CITIES", cITY);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the FAMILIES EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToFAMILIES(FAMILY fAMILY)
        {
            base.AddObject("FAMILIES", fAMILY);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="agsModel", Name="CHILDREN")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CHILDREN : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CHILDREN object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static CHILDREN CreateCHILDREN(global::System.Int32 id)
        {
            CHILDREN cHILDREN = new CHILDREN();
            cHILDREN.ID = id;
            return cHILDREN;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> FAMILYID
        {
            get
            {
                return _FAMILYID;
            }
            set
            {
                OnFAMILYIDChanging(value);
                ReportPropertyChanging("FAMILYID");
                _FAMILYID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FAMILYID");
                OnFAMILYIDChanged();
            }
        }
        private Nullable<global::System.Int32> _FAMILYID;
        partial void OnFAMILYIDChanging(Nullable<global::System.Int32> value);
        partial void OnFAMILYIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="agsModel", Name="CITY")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CITY : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CITY object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static CITY CreateCITY(global::System.Int32 id)
        {
            CITY cITY = new CITY();
            cITY.ID = id;
            return cITY;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CITY1
        {
            get
            {
                return _CITY1;
            }
            set
            {
                OnCITY1Changing(value);
                ReportPropertyChanging("CITY1");
                _CITY1 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CITY1");
                OnCITY1Changed();
            }
        }
        private global::System.String _CITY1;
        partial void OnCITY1Changing(global::System.String value);
        partial void OnCITY1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CP
        {
            get
            {
                return _CP;
            }
            set
            {
                OnCPChanging(value);
                ReportPropertyChanging("CP");
                _CP = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CP");
                OnCPChanged();
            }
        }
        private global::System.String _CP;
        partial void OnCPChanging(global::System.String value);
        partial void OnCPChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="agsModel", Name="FAMILY")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class FAMILY : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new FAMILY object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static FAMILY CreateFAMILY(global::System.Int32 id)
        {
            FAMILY fAMILY = new FAMILY();
            fAMILY.ID = id;
            return fAMILY;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> CITYID
        {
            get
            {
                return _CITYID;
            }
            set
            {
                OnCITYIDChanging(value);
                ReportPropertyChanging("CITYID");
                _CITYID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CITYID");
                OnCITYIDChanged();
            }
        }
        private Nullable<global::System.Int32> _CITYID;
        partial void OnCITYIDChanging(Nullable<global::System.Int32> value);
        partial void OnCITYIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
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

        #endregion

    
    }

    #endregion

    
}
