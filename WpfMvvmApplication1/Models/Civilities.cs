using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    public class Civilities
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public static string IDtoValue(int i)
        {
            return _listCivilities[i].Value;
        }
        
        private enum civilitiesenum { None = 0, M = 1, Mme = 2 }

        /// <summary>
        /// for initially populate checkbox with possible values
        /// </summary>
        private static readonly List<Gender> _listCivilities = new List<Gender> { new Gender { Id = 0, Value = "" }, new Gender { Id = 1, Value = "M." }, new Gender { Id = 2, Value = "Mme." } };
        public ObservableCollection<Gender> ListCivilities
        {
            get { return _listCivilities.ToObservableCollection(); }
        }

    }
}