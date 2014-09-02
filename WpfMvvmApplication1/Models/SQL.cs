using System;
using System.Collections.ObjectModel;
using Npgsql;

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
            reader.Close();
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
            reader.Close();
            return listFamilies;
        }


        /// <summary>
        /// Load One Child
        /// </summary>
        public Children ChargeEnfant(int iEnfant)
        {
            // ???????????????????????????????????????????????
            // Charge la liste des familles : cbFamille
            //this.cbFamille.ItemsSource = LoadCombobox(@"SELECT ""ID"", ""NOM"" FROM ""FAMILLES""; ").DefaultView;
            //this.cbFamille.DisplayMemberPath = "NOM";
            //???????????????????????????????????????????????

            Children oneChild = null;

            // Charge les informations de l'enfant
            string sSQLenfant = @"SELECT ""ID"", 
                                                     ""NOM"", 
                                                     ""PRENOM"", 
                                                     ""DATENAISSANCE"", 
                                                     ""SEXEID"", 
                                                     ""FAMILLEID"" 
                                              FROM ""ENFANTS"" 
                                              WHERE ""ID""=" + iEnfant + "; ";
            var reader = readSQL(sSQLenfant);
            while (reader.Read())
            {
                string sNom = reader["NOM"].ToString();
                string sPrenom = reader["PRENOM"].ToString();
                DateTime dtNaissance = Convert.ToDateTime(reader["DATENAISSANCE"]);
                int iSexe = int.Parse(reader["SEXEID"].ToString());
                
                int iFamille = int.Parse(reader["FAMILLEID"].ToString());


                oneChild = new Children(
                                iEnfant,
                                sNom,
                                sPrenom,
                                dtNaissance,
                                iSexe,
                                iFamille
                                );
            }
            //
            //  NOT ACTIVE YET 
            // 
            //tbNom.Text = sNom;
            //tbPrenom.Text = sPrenom;
            //dtpNaissance.Text = dtNaissance.ToString();

            //// Famille de l'enfant
            //this.cbFamille.SelectedValue = iFamille;
            //ChargeEnfantFamille(iFamille);

            //// Sexe de l'enfant
            //this.cbSexe.SelectedValue = iSexe;
            reader.Close();
            return oneChild;
        }

        /// <summary>
        /// Load one Family. (Charge les informations de la famille de l'enfant)
        /// </summary>
        public Address ChargeEnfantFamille(int iFamille)
        {
            Address oneAddress = null;

            string sSQLChargeEnfant = @"SELECT ""FAMILLES"".""ID"", 
                                           ""FAMILLES"".""NOM"", 
                                           ""FAMILLES"".""ADRESSE"", 
                                           ""FAMILLES"".""COMMUNEID"",
                                           ""FAMILLES"".""TEL1"",
                                           ""FAMILLES"".""TEL2"", 
                                           ""FAMILLES"".""TEL3"",
                                           ""COMMUNES"".""CP"", 
                                           ""COMMUNES"".""COMMUNE"" 
                                    FROM   ""FAMILLES"", ""COMMUNES"" 
                                    WHERE  ""FAMILLES"".""COMMUNEID""=""COMMUNES"".""ID"" 
                                      AND  ""FAMILLES"".""ID""=" + iFamille + "; ";

            var reader = readSQL(sSQLChargeEnfant);
            while (reader.Read())
            {
                string sName = reader["NOM"].ToString();
                string sAdresse = reader["ADRESSE"].ToString();
                string sTel1 = reader["TEL1"].ToString();
                string sTel2 = reader["TEL2"].ToString();
                string sTel3 = reader["TEL3"].ToString();
                string sCp = reader["CP"].ToString();
                string sCommune = reader["COMMUNE"].ToString();
                oneAddress = new Address(
                    iFamille,   //id#
                    sName,
                    sAdresse,
                    sCp,
                    sCommune,
                    sTel1,
                    sTel2,
                    sTel3
                    );
            }
            //
            //  NOT ACTIVE YET 
            // 
            //            this.tbAdresse.Text = sAdresse;
            //            this.tbCp.Text = sCp;
            //            this.tbCommune.Text = sCommune;
            //            this.tbTel1.Text = sTel1;
            //            this.tbTel2.Text = sTel2;
            //            this.tbTel3.Text = sTel3;
            reader.Close();
            return oneAddress;
        }

    }
}
