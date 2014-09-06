using System;
using System.Windows;

namespace WpfMvvmApplication1.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private System.Windows.Data.CollectionViewSource fAMILIESViewSource;
        private WpfMvvmApplication1.agsEntities agsEntities;

        public MainWindow()
        {
            InitializeComponent();
        }

        private System.Data.Objects.ObjectQuery<FAMILY> GetFAMILIESQuery(agsEntities agsEntities)
        {
            // Auto generated code
            System.Data.Objects.ObjectQuery<WpfMvvmApplication1.FAMILY> fAMILIESQuery = agsEntities.FAMILIES;
            // Returns an ObjectQuery.
            return fAMILIESQuery;
        }

        private void CustomChromeWindow_Loaded(object sender, RoutedEventArgs e)
        {

            this.agsEntities = new agsEntities();
            // Load data into FAMILIES. You can modify this code as needed.
            this.fAMILIESViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("fAMILIESViewSource")));
            System.Data.Objects.ObjectQuery<FAMILY> fAMILIESQuery = this.GetFAMILIESQuery(agsEntities);
            this.fAMILIESViewSource.Source = fAMILIESQuery.Execute(System.Data.Objects.MergeOption.AppendOnly);
        }

        private void savefamily_Click(object sender, RoutedEventArgs e)
        {
            this.agsEntities.SaveChanges();
        }

    }
}
