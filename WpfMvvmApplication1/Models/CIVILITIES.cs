using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace WpfMvvmApplication1.Models
{
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="agsModel", Name="CIVILITIES")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class CIVILITIES : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CIVILITIES object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static CIVILITIES CreateCIVILITIES(global::System.Int64 id)
        {
            CIVILITIES cIVILITIES = new CIVILITIES();
            cIVILITIES.ID = id;
            return cIVILITIES;
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
        public global::System.String CIVILITY
        {
            get
            {
                return _CIVILITY;
            }
            set
            {
                OnCIVILITYChanging(value);
                ReportPropertyChanging("CIVILITY");
                _CIVILITY = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CIVILITY");
                OnCIVILITYChanged();
            }
        }
        private global::System.String _CIVILITY;
        partial void OnCIVILITYChanging(global::System.String value);
        partial void OnCIVILITYChanged();

        #endregion

    
    }
}