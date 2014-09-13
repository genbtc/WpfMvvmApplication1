using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WpfMvvmApplication1.Models
{
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="agsModel", Name="CITIES")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class CITIES : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CITIES object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="cITY">Initial value of the CITY property.</param>
        /// <param name="cP">Initial value of the CP property.</param>
        public static CITIES CreateCITIES(global::System.Int32 id, global::System.String cITY, global::System.String cP)
        {
            CITIES cITIES = new CITIES();
            cITIES.ID = id;
            cITIES.CITY = cITY;
            cITIES.CP = cP;
            return cITIES;
        }

        #endregion

        #region Primitive Properties
    
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
        public global::System.String CITY
        {
            get
            {
                return _CITY;
            }
            set
            {
                OnCITYChanging(value);
                ReportPropertyChanging("CITY");
                _CITY = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CITY");
                OnCITYChanged();
            }
        }
        private global::System.String _CITY;
        partial void OnCITYChanging(global::System.String value);
        partial void OnCITYChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=false)]
        [DataMember()]
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
                _CP = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CP");
                OnCPChanged();
            }
        }
        private global::System.String _CP;
        partial void OnCPChanging(global::System.String value);
        partial void OnCPChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnore()]
        [SoapIgnore()]
        [DataMember()]
        [EdmRelationshipNavigationProperty("agsModel", "cityfk", "FAMILIES")]
        public EntityCollection<FAMILIES> FAMILIES
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<FAMILIES>("agsModel.cityfk", "FAMILIES");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<FAMILIES>("agsModel.cityfk", "FAMILIES", value);
                }
            }
        }

        #endregion

    }
}