using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WpfMvvmApplication1.Models
{
    class EF
    {
        internal agsEntities agsEntities;

        public EF()
        {
            agsEntities = new agsEntities("metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=Npgsql;provider connection string='PORT=5432;TIMEOUT=15;POOLING=True;MINPOOLSIZE=1;MAXPOOLSIZE=20;COMMANDTIMEOUT=20;COMPATIBLE=2.2.0.0;HOST=localhost;DATABASE=ags;USER ID=ags;PASSWORD=Fadila1980'");
        }

        internal void SaveChildrentoDB(ObservableCollection<CHILDRENS> ChildrensCollection)
        {
            foreach (CHILDRENS some in ChildrensCollection.Where(some => some.ID == 0))
            {
                this.agsEntities.CHILDRENS.AddObject(some);
            }
            this.agsEntities.SaveChanges();
        }

        internal void SaveFamilytoDB(ObservableCollection<FAMILIES> FamiliesCollection)
        {
            foreach (FAMILIES some in FamiliesCollection.Where(some => some.ID == 0))
            {
                this.agsEntities.FAMILIES.AddObject(some);
            }
            this.agsEntities.SaveChanges();
        }
    }
}
