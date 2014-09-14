using System.Collections.ObjectModel;
using System.Data.Objects;
using System.Linq;
using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    class EF : NotificationObject
    {
        internal agsEntities agsEntities;

        public EF()
        {
            //agsEntities = new agsEntities("metadata=res://*/Models.Model1.csdl|res://*/Models.Model1.ssdl|res://*/Models.Model1.msl;provider=Npgsql;provider connection string='PORT=5432;TIMEOUT=15;POOLING=True;MINPOOLSIZE=1;MAXPOOLSIZE=20;COMMANDTIMEOUT=20;COMPATIBLE=2.2.0.0;HOST=localhost;DATABASE=ags;USER ID=ags;PASSWORD=Fadila1980'");
            //agsEntities = new agsEntities("metadata=res://WpfMvvmApplication1/Models.Model1.csdl|res://WpfMvvmApplication1/Models.Model1.ssdl|res://WpfMvvmApplication1/Models.Model1.msl;provider=Npgsql;provider connection string='PORT=5432;TIMEOUT=15;POOLING=True;MINPOOLSIZE=1;MAXPOOLSIZE=20;COMMANDTIMEOUT=20;COMPATIBLE=2.2.0.0;HOST=localhost;DATABASE=ags;USER ID=ags;PASSWORD=Fadila1980'");
            agsEntities = new agsEntities();
        }

        internal void SaveToDb()
        {
            this.agsEntities.SaveChanges();
        }

        internal void Refresh(ObservableCollection<CHILDRENS> ChildrensCollection,
            ObservableCollection<FAMILIES> FamiliesCollection)
        {
            //this.agsEntities.Refresh(RefreshMode.StoreWins, this.agsEntities.CHILDRENS);
            this.agsEntities.Refresh(RefreshMode.StoreWins, this.agsEntities.FAMILIES);
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
