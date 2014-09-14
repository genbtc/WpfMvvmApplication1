namespace WpfMvvmApplication1.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new MainWindowViewModel();
        }

        private void button1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.FamilyDataGrid.Items.Refresh();
        }

        private void ExcelExport_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            FamilyDataGrid.ExportToCsv("FamilyDataGrid", @"C:\Users\Activ-Design\Desktop\test.txt", true);
        }
    }
}