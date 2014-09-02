using System;
using System.Collections.Generic;
using System.Data;
using Npgsql;

namespace WpfMvvmApplication1.Models
{
    class SQL
    {
        public static readonly string sConnection = "SERVER=localhost;DATABASE=ags;UID=ags;PASSWORD=Fadila1980;";

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

        public static DataTable LoadCombobox(string sSQL)
        {
            //string sSQL = @"SELECT ""ID"", ""NOM"" FROM ""FAMILLES""; ";

            NpgsqlConnection Connection = new NpgsqlConnection(sConnection);
            Connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sSQL, Connection);

            DataTable dt = new DataTable();

            dt.Load(cmd.ExecuteReader());
            Connection.Close();

            DataRow row = dt.NewRow();
            row["ID"] = 0;
            row["NOM"] = ""; //insert a blank row - you can even write something lile  = "Please select bellow...";
            dt.Rows.InsertAt(row, 0); //insert new to to index 0 (on top=

            return dt;

        }

        public static List<Family> listFamilies()
        {
            List<Family> listFamilies = new List<Family>();
            
            NpgsqlConnection Connection = new NpgsqlConnection(sConnection);
            Connection.Open();
            const string sSQL = @"SELECT ""ID"", ""NOM"" FROM ""FAMILLES""; ";

            NpgsqlCommand cmdFamille = new NpgsqlCommand(sSQL, Connection);
            NpgsqlDataReader readerFamille = cmdFamille.ExecuteReader();
            while (readerFamille.Read())
            {
                int iId = int.Parse(readerFamille["ID"].ToString());
                string sNom = readerFamille["NOM"].ToString();

                listFamilies.Add(new Family(iId,sNom));
            }
            Connection.Close();

            return listFamilies;

        }

        public static List<Children> listChildren()
        {
            List<Children> allChildren = new List<Children>();

            NpgsqlConnection Connection = new NpgsqlConnection(sConnection);
            Connection.Open();
            const string sSQL = @"SELECT ""ID"", ""NOM"", ""PRENOM"", ""DATENAISSANCE"", ""SEXEID"" FROM ""ENFANTS"" ORDER BY ""ID"";";

            NpgsqlCommand cmd = new NpgsqlCommand(sSQL, Connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int sId = int.Parse(reader["ID"].ToString());
                string sNom = reader["NOM"].ToString();
                string sPrenom = reader["PRENOM"].ToString();
                string sDateNaissance = String.Format("{0:MM/dd/yyyy}", reader["DATENAISSANCE"]);
                DateTime dDateNaissance = DateTime.Parse(sDateNaissance);
                int sSexe = int.Parse(reader["SEXEID"].ToString());

                //this.lvEnfants.Items.Clear();
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
    }
}
