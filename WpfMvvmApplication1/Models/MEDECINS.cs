using System;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;

namespace WpfMvvmApplication1.Models
{
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityType(NamespaceName="agsModel", Name="MEDECINS")]
    [Serializable()]
    [DataContract(IsReference=true)]
    public partial class MEDECINS : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new MEDECINS object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static MEDECINS CreateMEDECINS(global::System.Int32 id)
        {
            MEDECINS mEDECINS = new MEDECINS();
            mEDECINS.ID = id;
            return mEDECINS;
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
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public global::System.String FULLNAME
        {
            get
            {
                return _FULLNAME;
            }
            set
            {
                OnFULLNAMEChanging(value);
                ReportPropertyChanging("FULLNAME");
                _FULLNAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FULLNAME");
                OnFULLNAMEChanged();
            }
        }
        private global::System.String _FULLNAME;
        partial void OnFULLNAMEChanging(global::System.String value);
        partial void OnFULLNAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarProperty(EntityKeyProperty=false, IsNullable=true)]
        [DataMember()]
        public global::System.String TEL
        {
            get
            {
                return _TEL;
            }
            set
            {
                OnTELChanging(value);
                ReportPropertyChanging("TEL");
                _TEL = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("TEL");
                OnTELChanged();
            }
        }
        private global::System.String _TEL;
        partial void OnTELChanging(global::System.String value);
        partial void OnTELChanged();

        #endregion

    
    }
}