using System.Windows;
using System.Windows.Data;
using ExtendedGrid.Microsoft.Windows.Controls;

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
            FamilyDataGrid.ExportToCsv("FamilyDataGrid", @"C:\Users\EOFL\Desktop\test.txt", true);
        }

        private void PresenceGridSelectLastRow_Click(object sender, RoutedEventArgs e)
        {
            PresenceDataGrid.SelectedIndex = PresenceDataGrid.Items.Count - 1;
            PresenceDataGrid.SelectedIndex++; //has to be like this.
            PresenceDataGrid.ScrollIntoView(CollectionView.NewItemPlaceholder);
        }

        private void FamilyGridSelectLastRow_Click(object sender, RoutedEventArgs e)
        {
            //if (FamilyDataGrid.Items.Count <= 0)
            //    return;
            //ICollectionView view = CollectionViewSource.GetDefaultView(((MainWindowViewModel)DataContext).FamiliesCollection);
            //view.MoveCurrentToLast();
            //FamilyDataGrid.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
            //if (FamilyDataGrid.SelectedIndex < FamilyDataGrid.Items.Count)
            //    FamilyDataGrid.SelectedIndex++;
            //      -----or------
            //var border = VisualTreeHelper.GetChild(FamilyDataGrid, 0) as Decorator;
            //if (border == null)
            //    return;
            //var scroll = border.Child as ScrollViewer;
            //if (scroll != null)
            //    scroll.ScrollToEnd();
            //      -----or------
            FamilyDataGrid.SelectedIndex = FamilyDataGrid.Items.Count - 1;
            FamilyDataGrid.SelectedIndex++; //has to be like this.
            FamilyDataGrid.ScrollIntoView(CollectionView.NewItemPlaceholder);
        }

        private void ChildrenGridSelectLastRow_Click(object sender, RoutedEventArgs e)
        {
            ChildrenDataGrid.SelectedIndex = ChildrenDataGrid.Items.Count - 1;
            ChildrenDataGrid.SelectedIndex++; //has to be like this.
            ChildrenDataGrid.ScrollIntoView(CollectionView.NewItemPlaceholder);
        }

        private void CitiesGridSelectLastRow_Click(object sender, RoutedEventArgs e)
        {
            CitiesDataGrid.SelectedIndex = CitiesDataGrid.Items.Count - 1;
            CitiesDataGrid.SelectedIndex++; //has to be like this.
            CitiesDataGrid.ScrollIntoView(CollectionView.NewItemPlaceholder);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FamilyDataGrid.RowDetailsVisibilityMode = 
                FamilyDataGrid.RowDetailsVisibilityMode != 
                    DataGridRowDetailsVisibilityMode.Collapsed ? 
                        DataGridRowDetailsVisibilityMode.Collapsed : DataGridRowDetailsVisibilityMode.VisibleWhenSelected;
        }
    }
}