//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfMvvmApplication1.Models.POCO
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class CHILDRENS
    {
        public string LASTNAME { get; set; }
        public string FIRSTNAME { get; set; }
        public Nullable<System.DateTime> BIRTHDATE { get; set; }
        public Nullable<int> FAMILYID { get; set; }
        public Nullable<int> GENDERID { get; set; }
        public Nullable<bool> EMT { get; set; }
        public Nullable<bool> HOSPITAL { get; set; }
        public Nullable<bool> CLINIC { get; set; }
        public Nullable<int> CLINICID { get; set; }
        public Nullable<bool> BEPHOTOGRAPHY { get; set; }
        public Nullable<bool> PUBLICATIONPHOTOGRAPHY { get; set; }
        public Nullable<bool> OFFOUTPUTSSTRUCTURE { get; set; }
        public Nullable<bool> SWIM { get; set; }
        public Nullable<bool> BIKEOUTINGS { get; set; }
        public Nullable<bool> BOATOUTINGS { get; set; }
        public Nullable<int> MEDECINEID { get; set; }
        public int ID { get; set; }
    
        public virtual FAMILIES FAMILIES { get; set; }
    }
}