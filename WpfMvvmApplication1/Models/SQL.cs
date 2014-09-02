using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using Npgsql;
using WpfMvvmApplication1.Helpers;

namespace WpfMvvmApplication1.Models
{
    class SQL
    {
        //string constants, for use on SQL connections, SQL children read, SQL families read
        private const string sConnection = "SERVER=localhost;DATABASE=ags;UID=ags;PASSWORD=Fadila1980;";

        private const string sSQLchildren =
            @"SELECT ""ID"", ""NOM"", ""PRENOM"", ""DATENAISSANCE"", ""SEXEID"" FROM ""ENFANTS"" ORDER BY ""ID"";";

        private const string sSQLfamilies = @"SELECT ""ID"", ""NOM"" FROM ""FAMILLES"";";

        //SQL reader
        private static NpgsqlDataReader readSQL(string sSQLstring)
        {
            NpgsqlConnection Connection = new NpgsqlConnection(sConnection);
            Connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sSQLstring, Connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            Connection.Close();
            return reader;
        }

        /// <summary>
        /// SQL update - write field for ID listed
        /// </summary>
        public static void UpdateFields(string sTable, string sField, object sValue, int iId)
        {
            string uSQL = string.Format(@"UPDATE ""{0}"" SET ""{1}""=@Value WHERE ""ID"" = {2}; ", sTable, sField, iId);

            NpgsqlConnection Connection = new NpgsqlConnection(sConnection);
            NpgsqlCommand command = Connection.CreateCommand();
            command.CommandText = uSQL;
            command.Parameters.AddWithValue("@Value", sValue);
            Connection.Open();
            command.ExecuteNonQuery();
            Connection.Close();
        }

        /// <summary>
        /// query SQL, return all children in an ObservableCollection for use by ViewModel
        /// </summary>
        public static ObservableCollection<Children> listChildren()
        {
            ObservableCollection<Children> allChildren = new ObservableCollection<Children>();
            var reader = readSQL(sSQLchildren);
            while (reader.Read())
            {
                int sId = int.Parse(reader["ID"].ToString());
                string sNom = reader["NOM"].ToString();
                string sPrenom = reader["PRENOM"].ToString();
                string sDateNaissance = String.Format("{0:MM/dd/yyyy}", reader["DATENAISSANCE"]);
                DateTime dDateNaissance = DateTime.Parse(sDateNaissance);
                int sSexe = int.Parse(reader["SEXEID"].ToString());

                allChildren.Add(new Children(
                    sId,
                    sNom,
                    sPrenom,
                    dDateNaissance,
                    sSexe
                    ));
            }
            return allChildren;
        }

        /// <summary>
        /// query SQL, return all families in an ObservableCollection for use by ViewModel
        /// </summary>
        public static ObservableCollection<Family> listFamilies()
        {
            ObservableCollection<Family> listFamilies = new ObservableCollection<Family>();
            var reader = readSQL(sSQLfamilies);
            while (reader.Read())
            {
                int iId = int.Parse(reader["ID"].ToString());
                string sNom = reader["NOM"].ToString();

                listFamilies.Add(new Family(iId,sNom));
            }
            return listFamilies;
        }

    }
}
