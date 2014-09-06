using System.Data.Objects;
using System.Windows;
using System.Windows.Data;
using WpfMvvmApplication1.ViewModels;

namespace WpfMvvmApplication1.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindowViewModel ViewModel;
        private System.Data.Objects.ObjectQuery<FAMILY> fAMILIESQuery;

        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainWindowViewModel();
        }



        private void CustomChromeWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
            // Load data into FAMILIES. You can modify this code as needed.
            ViewModel.FamiliesViewSource = ((CollectionViewSource)(this.FindResource("fAMILIESViewSource")));
            this.fAMILIESQuery = ViewModel.GetFAMILIESQuery(ViewModel.agsEntities);
            ViewModel.FamiliesViewSource.Source = fAMILIESQuery.Execute(System.Data.Objects.MergeOption.AppendOnly);
        }

        private void savefamily_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.agsEntities.SaveChanges();
            ViewModel.agsEntities.Refresh(RefreshMode.StoreWins, this.fAMILIESQuery);

        }

    }
}
