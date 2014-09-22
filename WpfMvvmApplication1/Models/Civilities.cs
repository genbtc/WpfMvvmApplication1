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
        
        /// <summary>
        /// for initially populate checkbox with possible values
        /// </summary>
        private static readonly List<Civilities> _listCivilities = new List<Civilities> { new Civilities { Id = 0, Value = "" }, new Civilities { Id = 1, Value = "M." }, new Civilities { Id = 2, Value = "Mme." } };
        public ObservableCollection<Civilities> ListCivilities
        {
            get { return _listCivilities.ToObservableCollection(); }
        }

    }
}