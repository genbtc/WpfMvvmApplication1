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

//        public Enfants()
//        {
//            InitializeComponent();
//            listEnfant();
//            listFamille();
//            listSexe();
//        }

//        int iEnfantSelect = 0;

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
