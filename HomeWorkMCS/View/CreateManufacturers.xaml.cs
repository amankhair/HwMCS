using HomeWorkMCS.BAL;
using HomeWorkMCS.DAL;
using System;
using System.Windows;
using System.Windows.Controls;

namespace HomeWorkMCS.View
{
    /// <summary>
    /// Interaction logic for CreateManufacturers.xaml
    /// </summary>
    public partial class CreateManufacturers : Page
    {
        Methods _methods = new Methods();

        public CreateManufacturers()
        {
            InitializeComponent();
        }

        private void CreateManufacturer_OnClick(object sender, RoutedEventArgs e)
        {


            TablesManufacturer tm = new TablesManufacturer();
            tm.intManufacturerID = int.Parse(manufacturerIdBox.Text);
            tm.strManufacturerChecklistId = manufacturerCheclistIdBox.Text;
            tm.strName = nameBox.Text;

            _methods.AddnewManufacturer(tm);
            try
            {
                MessageBox.Show("Создано");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
