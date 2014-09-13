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
    [EdmEntityType(NamespaceName="agsModel", Name="FAMILYQUOTIENTS")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class FAMILYQUOTIENTS : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new FAMILYQUOTIENTS object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static FAMILYQUOTIENTS CreateFAMILYQUOTIENTS(global::System.Int64 id)
        {
            FAMILYQUOTIENTS fAMILYQUOTIENTS = new FAMILYQUOTIENTS();
            fAMILYQUOTIENTS.ID = id;
            return fAMILYQUOTIENTS;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        [DataMember()]
        public global::System.Int64 ID
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
        private global::System.Int64 _ID;
        partial void OnIDChanging(global::System.Int64 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Int32> YEAR
        {
            get
            {
                return _YEAR;
            }
            set
            {
                OnYEARChanging(value);
                ReportPropertyChanging("YEAR");
                _YEAR = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("YEAR");
                OnYEARChanged();
            }
        }
        private Nullable<global::System.Int32> _YEAR;
        partial void OnYEARChanging(Nullable<global::System.Int32> value);
        partial void OnYEARChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
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
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public Nullable<global::System.Single> FAMILYQUOTIENT
        {
            get
            {
                return _FAMILYQUOTIENT;
            }
            set
            {
                OnFAMILYQUOTIENTChanging(value);
                ReportPropertyChanging("FAMILYQUOTIENT");
                _FAMILYQUOTIENT = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FAMILYQUOTIENT");
                OnFAMILYQUOTIENTChanged();
            }
        }
        private Nullable<global::System.Single> _FAMILYQUOTIENT;
        partial void OnFAMILYQUOTIENTChanging(Nullable<global::System.Single> value);
        partial void OnFAMILYQUOTIENTChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("agsModel", "familyfk", "FAMILIES")]
        public FAMILIES FAMILIES
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<FAMILIES>("agsModel.familyfk", "FAMILIES").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<FAMILIES>("agsModel.familyfk", "FAMILIES").Value = value;
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
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<FAMILIES>("agsModel.familyfk", "FAMILIES");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<FAMILIES>("agsModel.familyfk", "FAMILIES", value);
                }
            }
        }

        #endregion

    }
}