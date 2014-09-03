using System;
using System.Data;
using System.Collections.ObjectModel;
using Npgsql;

namespace WpfMvvmApplication1.Models
{
    class SQL
    {
        //string constants, for use on SQL connections, SQL children read, SQL families read
        private const string sConnection = "SERVER=localhost;DATABASE=ags;UID=ags;PASSWORD=Fadila1980;";

        private const string sSQLchildren = @"SELECT ""ID"",
                                                    ""LASTNAME"",
                                                    ""FIRSTNAME"",
                                                    ""BIRTHDATE"",
                                                    ""GENDERID"",
                                                    ""FAMILYID"",
                                                    ""MEDECINEID"",
                                                    ""EMT"",
                                                    ""HOSPITAL"",
                                                    ""CLINIC"",
                                                    ""CLINICID"",
                                                    ""BEPHOTOGRAPHY"",
                                                    ""PUBLICATIONPHOTOGRAPHY"",
                                                    ""OFFOUTPUTSSTRUCTURE"",
                                                    ""SWIM"",
                                                    ""BIKEOUTINGS"",
                                                    ""BOATOUTINGS""
                                             FROM ""CHILDRENS"" ORDER BY ""ID"";";

        private const string sSQLfamilies = @"SELECT ""FAMILIES"".""ID"",
                                                    ""FAMILIES"".""LASTNAME"",
                                                    ""FAMILIES"".""FIRSTNAME"",
                                                    ""FAMILIES"".""ADRESS"",
                                                    ""FAMILIES"".""CITYID"",
                                                    ""CITIES"".""CP"",
                                                    ""CITIES"".""CITY"",
                                                    ""FAMILIES"".""TEL1"",
                                                    ""FAMILIES"".""TEL2"",
                                                    ""FAMILIES"".""TEL3""
                                             FROM   ""FAMILIES"", ""CITIES""
                                             WHERE  ""FAMILIES"".""CITYID""=""CITIES"".""ID""; ";

        //SQL reader
        private static DataTable readSQL(string sSQLstring)
        {
            DataTable dt = new DataTable();
            NpgsqlConnection Connection = new NpgsqlConnection(sConnection);
            Connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sSQLstring, Connection);
            dt.Load(cmd.ExecuteReader());
            Connection.Close();
            return dt;
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
            foreach (DataRow row in reader.Rows)
            {
                int sId = int.Parse(row["ID"].ToString());
                string sLastName = row["LASTNAME"].ToString();
                string sFirstName = row["FIRSTNAME"].ToString();
                DateTime dtBirthDate = DateTime.Parse(String.Format("{0:MM/dd/yyyy}", row["BIRTHDATE"]));
                int iSexe = int.Parse(row["GENDERID"].ToString());
                int iFamily = int.Parse(row["FAMILYID"].ToString());
                int iMedecine = int.Parse(row["MEDECINEID"].ToString());
                bool bEmt = bool.Parse(row["EMT"].ToString());
                bool bHospital = bool.Parse(row["HOSPITAL"].ToString());
                bool bClinic = bool.Parse(row["CLINIC"].ToString());
                int iClinic = int.Parse(row["CLINICID"].ToString());
                bool bBePhotography = bool.Parse(row["BEPHOTOGRAPHY"].ToString());
                bool bPublicationPhotography = bool.Parse(row["PUBLICATIONPHOTOGRAPHY"].ToString());
                bool bOffOutputsStructure = bool.Parse(row["OFFOUTPUTSSTRUCTURE"].ToString());
                bool bSwim = bool.Parse(row["SWIM"].ToString());
                bool bBikeOutings = bool.Parse(row["BIKEOUTINGS"].ToString());
                bool bBoatOutings = bool.Parse(row["BOATOUTINGS"].ToString());

                allChildren.Add(new Children(
                    sId,
                    sLastName,
                    sFirstName,
                    dtBirthDate,
                    iSexe,
                    iFamily,
                    iMedecine,
                    bEmt,
                    bHospital,
                    bClinic,
                    iClinic,
                    bBePhotography,
                    bPublicationPhotography,
                    bOffOutputsStructure,
                    bSwim,
                    bBikeOutings,
                    bBoatOutings
                    ));
            }
            //reader.Close();
            return allChildren;
        }

        /// <summary>
        /// query SQL, return all children in an ObservableCollection for use by ViewModel
        /// </summary>
        public static ObservableCollection<Family> listFamilies()
        {
            ObservableCollection<Family> allFamily = new ObservableCollection<Family>();
            var reader = readSQL(sSQLfamilies);
            foreach (DataRow row in reader.Rows)
            {
                int iId = int.Parse(row["ID"].ToString());
                string sLastName = row["LASTNAME"].ToString();
                string sFirstName = row["FIRSTNAME"].ToString();
                string sAdress = row["ADRESS"].ToString();
                int iCity = int.Parse(row["CITYID"].ToString());
                string sCP = row["CP"].ToString();
                string sCity = row["CITY"].ToString();
                string sTel1 = row["TEL1"].ToString();
                string sTel2 = row["TEL2"].ToString();
                string sTel3 = row["TEL3"].ToString();

                allFamily.Add(new Family(
                    iId,
                    sLastName,
                    sFirstName,
                    sAdress,
                    iCity,
                    sCity,
                    sCP,
                    sTel1,
                    sTel2,
                    sTel3
                    ));
                //var one = new Family
                //{
                //    Id = iId,
                //    LastName = sLastName,
                //    FirstName = sFirstName,
                //    Address = sAdress,
                //    CityId = iCity,
                //    City = sCity,
                //    Cp = sCP,
                //    Tel1 = sTel1,
                //    Tel2 = sTel2,
                //    Tel3 = sTel3
                //};
                //allFamily.Add(one);
            }
            return allFamily;
        }


        /// <summary>
        /// query SQL, return all families in an ObservableCollection for use by ViewModel
        /// </summary>
        //public static ObservableCollection<Family> listFamilies()
        //{
        //    ObservableCollection<Family> listFamilies = new ObservableCollection<Family>();
        //    var reader = readSQL(sSQLfamilies);
        //    foreach(DataRow row in reader.Rows)
        //    {
        //        int iId = int.Parse(row["ID"].ToString());
        //        string sNom = row["LASTNAME"].ToString();

        //        listFamilies.Add(new Family(iId,sNom));
        //    }
        //    return listFamilies;
        //}


        /// <summary>
        /// Load One Child
        /// </summary>
        public Children LoadChildren(int iChildren)
        {
            // ???????????????????????????????????????????????
            // Charge la liste des familles : cbFamille
            //this.cbFamille.ItemsSource = LoadCombobox(@"SELECT ""ID"", ""NOM"" FROM ""FAMILLES""; ").DefaultView;
            //this.cbFamille.DisplayMemberPath = "NOM";
            //???????????????????????????????????????????????

            Children oneChild = null;

            // Charge les informations de l'enfant
            string sSQLchildren = @"SELECT ""ID"",
                                        ""LASTNAME"",
                                        ""FIRSTNAME"",
                                        ""BIRTHDATE"",
                                        ""GENDERID"",
                                        ""FAMILYID"",
                                        ""MEDECINEID"",
                                        ""EMT"",
                                        ""HOSPITAL"",
                                        ""CLINIC"",
                                        ""CLINICID"",
                                        ""BEPHOTOGRAPHY"",
                                        ""PUBLICATIONPHOTOGRAPHY"",
                                        ""OFFOUTPUTSSTRUCTURE"",
                                        ""SWIM"",
                                        ""BIKEOUTINGS"",
                                        ""BOATOUTINGS""
                                 FROM ""CHILDRENS""
                                 WHERE ""ID""=" + iChildren + "; ";
            var reader = readSQL(sSQLchildren);
            foreach (DataRow row in reader.Rows)
            {
                string sLastName = row["LASTNAME"].ToString();
                string sFirstName = row["FIRSTNAME"].ToString();
                DateTime dtBirthDate = Convert.ToDateTime(row["BIRTHDATE"]);
                int iGender = int.Parse(row["GENDERID"].ToString());
                int iFamily = int.Parse(row["FAMILYID"].ToString());
                int iMedecine = int.Parse(row["MEDECINEID"].ToString());
                bool bEmt = bool.Parse(row["EMT"].ToString());
                bool bHospital = bool.Parse(row["HOSPITAL"].ToString());
                bool bClinic = bool.Parse(row["CLINIC"].ToString());
                int iClinic = int.Parse(row["CLINICID"].ToString());
                bool bBePhotography = bool.Parse(row["BEPHOTOGRAPHY"].ToString());
                bool bPublicationPhotography = bool.Parse(row["PUBLICATIONPHOTOGRAPHY"].ToString());
                bool bOffOutputsStructure = bool.Parse(row["OFFOUTPUTSSTRUCTURE"].ToString());
                bool bSwim = bool.Parse(row["SWIM"].ToString());
                bool bBikeOutings = bool.Parse(row["BIKEOUTINGS"].ToString());
                bool bBoatOutings = bool.Parse(row["BOATOUTINGS"].ToString());

                oneChild = new Children(
                                iChildren,
                                sLastName,
                                sFirstName,
                                dtBirthDate,
                                iGender,
                                iFamily,
                                iMedecine,
                                bEmt,
                                bHospital,
                                bClinic,
                                iClinic,
                                bBePhotography,
                                bPublicationPhotography,
                                bOffOutputsStructure,
                                bSwim,
                                bBikeOutings,
                                bBoatOutings
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
            return oneChild;
        }

        /// <summary>
        /// Load one Family. (Charge les informations de la famille de l'enfant)
        /// </summary>
        public Family LoadChildrenFamily(int iFamily)
        {
            Family oneFamily = null;

            string sSQLChargeEnfant = @"SELECT ""FAMILIES"".""ID"",
                                          ""FAMILIES"".""LASTNAME"",
                                          ""FAMILIES"".""FIRSTNAME"",
                                          ""FAMILIES"".""ADRESS"",
                                          ""FAMILIES"".""CITYID"",
                                          ""CITIES"".""CP"",
                                          ""CITIES"".""CITY"",
                                          ""FAMILIES"".""TEL1"",
                                          ""FAMILIES"".""TEL2"",
                                          ""FAMILIES"".""TEL3""
                                   FROM   ""FAMILIES"", ""CITIES""
                                   WHERE  ""FAMILIES"".""CITYID""=""CITIES"".""ID""
                                     AND  ""FAMILIES"".""ID""=" + iFamily + "; ";

            var reader = readSQL(sSQLChargeEnfant);
            foreach (DataRow row in reader.Rows)
            {
                string sLastName = row["LASTNAME"].ToString();
                string sFirstName = row["FIRSTNAME"].ToString();
                string sAdress = row["ADRESS"].ToString();
                int iCity = int.Parse(row["CITYID"].ToString());
                string sCp = row["CP"].ToString();
                string sCity = row["CITY"].ToString();
                string sTel1 = row["TEL1"].ToString();
                string sTel2 = row["TEL2"].ToString();
                string sTel3 = row["TEL3"].ToString();

                oneFamily = new Family(
                    iFamily,   //id#
                    sLastName,
                    sFirstName,
                    sAdress,
                    iCity,
                    sCp,
                    sCity,
                    sTel1,
                    sTel2,
                    sTel3
                    );
            }
            return oneFamily;
        }

    }
}