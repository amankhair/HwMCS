using HomeWorkMCS.BAL;
using System.Windows.Controls;

namespace HomeWorkMCS.View
{
    /// <summary>
    /// Interaction logic for PrintManufacturers.xaml
    /// </summary>
    public partial class PrintManufacturers : Page
    {
        Methods m = new Methods();

        public PrintManufacturers()
        {
            InitializeComponent();
            ManufacturerList.ItemsSource = m.GeTablesManufacturers();
        }
    }
}
