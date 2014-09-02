//using System;
//using System.Collections.Generic;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Documents;
//using System.Data;
//using Npgsql;


//namespace WpfApplication1
//{

//    public partial class Enfants : Window
//    {

//        public class MyItem
//        {
//            public int Id { get; set; }
//            public string Nom { get; set; }
//            public string Prenom { get; set; }
//            public string DateNaissance { get; set; }
//            public string Sexe { get; set; }
//        }


//        public class Famille
//        {
//            public int Id { get; set; }
//            public string Nom { get; set; }
//        }

//        public class Sexe
//        {
//            public int Id { get; set; }
//            public string Value { get; set; }
//        }


//        public Enfants()
//        {
//            InitializeComponent();
//            listEnfant();
//            listFamille();
//            listSexe();
//        }

//        public void listSexe()
//        {
//            List<Sexe> lstSexes = new List<Sexe>();
//            lstSexes.Add(new Sexe { Id = 1, Value = "Homme" });
//            lstSexes.Add(new Sexe { Id = 2, Value = "Femme" });
//            this.cbSexe.ItemsSource = lstSexes;
//            this.cbSexe.DisplayMemberPath = "Value";
//            this.cbSexe.SelectedValuePath = "Id";
//        }

//        int iEnfantSelect = 0;


//        public void ChargeEnfant(long iEnfant)
//        {

//            NpgsqlConnection Connection = new NpgsqlConnection(sConnection);

//            // Charge la liste des familles : cbFamille
//            //this.cbFamille.ItemsSource = LoadCombobox(@"SELECT ""ID"", ""NOM"" FROM ""FAMILLES""; ").DefaultView;
//            //this.cbFamille.DisplayMemberPath = "NOM";


//            // Charge les informations de l'enfant

//            Connection.Open();
//            string sSQLenfant = @"SELECT ""ID"", 
//                                         ""NOM"", 
//                                         ""PRENOM"", 
//                                         ""DATENAISSANCE"", 
//                                         ""SEXEID"", 
//                                         ""FAMILLEID"" 
//                                  FROM ""ENFANTS"" 
//                                  WHERE ""ID""=" + iEnfant + "; ";

//            NpgsqlCommand cmd = new NpgsqlCommand(sSQLenfant, Connection);
//            NpgsqlDataReader reader = cmd.ExecuteReader();
//            while (reader.Read())
//            {
//                string sNom = reader["NOM"].ToString();
//                string sPrenom = reader["PRENOM"].ToString();
//                DateTime dtNaissance = Convert.ToDateTime(reader["DATENAISSANCE"]);
//                int iSexe = int.Parse(reader["SEXEID"].ToString());
//                int iFamille = int.Parse(reader["FAMILLEID"].ToString());

//                tbNom.Text = sNom;
//                tbPrenom.Text = sPrenom;
//                dtpNaissance.Text = dtNaissance.ToString();

//                // Famille de l'enfant
//                this.cbFamille.SelectedValue = iFamille;
//                ChargeEnfantFamille(iFamille);

//                // Sexe de l'enfant
//                this.cbSexe.SelectedValue = iSexe;

//            }
//            Connection.Close();

//        }

//        // Charge les informations de la famille de l'enfant
//        public void ChargeEnfantFamille(long iFamille)
//        {
//            string sAdresse = "";
//            string sCp = "";
//            string sCommune = "";
//            string sTel1 = "";
//            string sTel2 = "";
//            string sTel3 = "";

//            NpgsqlConnection Connection = new NpgsqlConnection(sConnection);
//            Connection.Open();
//            string sSQL = @"SELECT ""FAMILLES"".""ID"", 
//                                   ""FAMILLES"".""NOM"", 
//                                   ""FAMILLES"".""ADRESSE"", 
//                                   ""FAMILLES"".""COMMUNEID"",
//                                   ""FAMILLES"".""TEL1"",
//                                   ""FAMILLES"".""TEL2"", 
//                                   ""FAMILLES"".""TEL3"",
//                                   ""COMMUNES"".""CP"", 
//                                   ""COMMUNES"".""COMMUNE"" 
//                            FROM   ""FAMILLES"", ""COMMUNES"" 
//                            WHERE  ""FAMILLES"".""COMMUNEID""=""COMMUNES"".""ID"" 
//                              AND  ""FAMILLES"".""ID""=" + iFamille + "; ";

//            NpgsqlCommand cmd = new NpgsqlCommand(sSQL, Connection);
//            NpgsqlDataReader reader = cmd.ExecuteReader();
//            while (reader.Read())
//            {
//                sAdresse = reader["ADRESSE"].ToString();
//                sCp = reader["CP"].ToString();
//                sCommune = reader["COMMUNE"].ToString();
//                sTel1 = reader["TEL1"].ToString();
//                sTel2 = reader["TEL2"].ToString();
//                sTel3 = reader["TEL3"].ToString();
//            }
//            reader.Close();
//            Connection.Close();

//            this.tbAdresse.Text = sAdresse;
//            this.tbCp.Text = sCp;
//            this.tbCommune.Text = sCommune;
//            this.tbTel1.Text = sTel1;
//            this.tbTel2.Text = sTel2;
//            this.tbTel3.Text = sTel3;

//        }


//        private void Enfants_Load(object sender, EventArgs e)
//        {
//            listEnfant();
//        }

//        private void lvEnfants_Click(object sender, EventArgs e)
//        {

//            DataRowView selectedrow = (DataRowView)lvEnfants.SelectedItem;

//            if (selectedrow != null)
//            {
//                int iEnfantSelect = int.Parse(selectedrow.Row.ItemArray[0].ToString());
//                ChargeEnfant(iEnfantSelect);
//                //Do something with the id.
//            }




//            //iEnfantSelect = int.Parse(lvEnfants.SelectedItems[0].Text);

//        }

//        private void cbFamille_SelectionChangeCommitted(object sender, EventArgs e)
//        {
//            DataRow row = ((DataTable)cbFamille.ItemsSource).Rows[cbFamille.SelectedIndex];
//            int Id = (int)row["ID"];
//            string Name = (string)row["NOM"];

//            UpdateFields("ENFANTS", "FAMILLEID", Id, iEnfantSelect);
//            ChargeEnfantFamille(Id);
//            listEnfant();
//        }

//        private void tbNom_TextChanged(object sender, EventArgs e)
//        {
//        }

//        private void tbPrenom_TextChanged(object sender, EventArgs e)
//        {
//            UpdateFields("ENFANTS", "PRENOM", tbPrenom.Text, iEnfantSelect);
//            listEnfant();
//        }

//        private void dtpNaissance_ValueChanged(object sender, EventArgs e)
//        {
//            UpdateFields("ENFANTS", "DATENAISSANCE", dtpNaissance.Text, iEnfantSelect);
//            listEnfant();
//        }

//        private void btnNew_Click(object sender, EventArgs e)
//        {

//            string iSQL = @"INSERT INTO ""ENFANTS"" (""DATENAISSANCE"", ""FAMILLEID"") VALUES('01/01/2000', 0);";
//            NpgsqlConnection Connection = new NpgsqlConnection(sConnection);
//            NpgsqlCommand command = Connection.CreateCommand();
//            command.CommandText = iSQL;
//            Connection.Open();
//            command.ExecuteNonQuery();
//            Connection.Close();

//            listEnfant();
//        }

//        private void btnNewFamille_Click(object sender, EventArgs e)
//        {
//            //foreach (Form form in Application.OpenForms)
//            //{
//            //    if (form.GetType() == typeof(Familles))
//            //    {
//            //        form.Activate();
//            //        return;
//            //    }
//            //}

//            //Familles fFamilles = new Familles();
//            //fFamilles.Show();
//            //fFamilles.WindowState = FormWindowState.Maximized;

//        }

//        private void cbSexe_SelectionChangeCommitted(object sender, EventArgs e)
//        {
//            DataRow row = ((DataTable)cbSexe.ItemsSource).Rows[cbSexe.SelectedIndex];
//            int Key = (int)row["KEY"];
//            string Value = (string)row["VALUE"];

//            UpdateFields("ENFANTS", "SEXE", Key, iEnfantSelect);
//            listEnfant();

//        }

//        private void lvEnfants_SelectionChanged(object sender, SelectionChangedEventArgs e)
//        {

//            MyItem lvi = ((sender as ListView).SelectedItem as MyItem);
//            iEnfantSelect = lvi.Id;
//            ChargeEnfant(iEnfantSelect);

//        }

//        private void cbFamille_SelectionChanged(object sender, SelectionChangedEventArgs e)
//        {

//            Famille selectedFamille = cbFamille.SelectedItem as Famille;

//            if (selectedFamille != null)
//            {
//                UpdateFields("ENFANTS", "FAMILLEID", selectedFamille.Id, iEnfantSelect);
//            }
//        }

//        private void cbSexe_SelectionChanged(object sender, SelectionChangedEventArgs e)
//        {
//            Sexe selectedSexe = cbSexe.SelectedItem as Sexe;
//            if (selectedSexe != null)
//            {
//                UpdateFields("ENFANTS", "SEXEID", selectedSexe.Id, iEnfantSelect);
//            }


//        }

//        private void tbNom_SelectionChanged(object sender, RoutedEventArgs e)
//        {
//            UpdateFields("ENFANTS", "NOM", tbNom.Text, iEnfantSelect);
//            listEnfant();
//        }
//    }
//}
