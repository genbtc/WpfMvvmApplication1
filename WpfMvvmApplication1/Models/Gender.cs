using System.Collections.Generic;

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

        public static List<Gender> listGenders = new List<Gender> { new Gender { Id = 0, Value = "" }, new Gender { Id = 1, Value = "Homme" }, new Gender { Id = 2, Value = "Femme" } };

        private enum genderenum { None = 0, Homme = 1, Femme = 2 }
    }
}