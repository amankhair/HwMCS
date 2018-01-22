using HomeWorkMCS.BAL;
using System;
using System.Windows;

namespace HomeWorkMCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Methods MainMethods;

        public MainWindow()
        {
            InitializeComponent();
        }

        //newEquipmet
        private void PrintEquipments_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/PrintEquipments.xaml", UriKind.RelativeOrAbsolute);
        }

        private void CreateEquipments_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/CreateEquipments.xaml", UriKind.RelativeOrAbsolute);
        }

        //TablesManufacturer
        private void PrintManufacturers_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/PrintManufacturers.xaml", UriKind.RelativeOrAbsolute);
        }

        private void CreateManufacturers_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/CreateManufacturers.xaml", UriKind.RelativeOrAbsolute);
        }

        private void PrintModels_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("View/PrintModels.xaml", UriKind.RelativeOrAbsolute);
        }

        private void SaveManufacturer_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteManufacturer_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("DeletePoint/DeleteManufacturer.xaml", UriKind.RelativeOrAbsolute);
        }

        private void DeleteModel_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteEquipments_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = new Uri("DeletePoint/DeleteEquipments.xaml", UriKind.RelativeOrAbsolute);
        }

        private void XmlExport_OnClick(object sender, RoutedEventArgs e)
        {


        }

        private void SoapExport_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
