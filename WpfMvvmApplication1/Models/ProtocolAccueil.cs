using System.Collections.Generic;
using System.Collections.ObjectModel;
using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    public class ProtocolAccueil
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public static string IDtoValue(int i)
        {
            return _listProtocolAccueil[i].Value;
        }

        private static readonly List<ProtocolAccueil> _listProtocolAccueil = new List<ProtocolAccueil> { new ProtocolAccueil { Id = 0, Value = "" }, new ProtocolAccueil { Id = 1, Value = "Spécialisé (MDPH)" }, new ProtocolAccueil { Id = 2, Value = "Spécifique" } };
        public ObservableCollection<ProtocolAccueil> ListProtocolAccueil
        {
            get { return _listProtocolAccueil.ToObservableCollection(); }
        }

    }
}
