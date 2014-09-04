using System;

namespace WpfMvvmApplication1.Helpers
{
    class ToAge
    {
        public static int Age(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthday.Year;
            if (now < birthday.AddYears(age)) age--;

            return age;
        }

    }
}
