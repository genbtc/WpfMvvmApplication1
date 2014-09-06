using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    public class Gender
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public static string IDtoValue(int i)
        {
            return listGenders[i].Value;
        }
        
        private enum genderenum { None = 0, Homme = 1, Femme = 2 }

        /// <summary>
        /// for initially populate checkbox with possible values
        /// </summary>
        private static readonly List<Gender> listGenders = new List<Gender> { new Gender { Id = 0, Value = "" }, new Gender { Id = 1, Value = "Homme" }, new Gender { Id = 2, Value = "Femme" } };
        public ObservableCollection<Gender> ListGenders
        {
            get { return listGenders.ToObservableCollection(); }
        }

    }
}