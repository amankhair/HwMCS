using HomeWorkMCS.BAL;
using System.Windows.Controls;

namespace HomeWorkMCS.View
{
    /// <summary>
    /// Interaction logic for PrintEquipments.xaml
    /// </summary>
    public partial class PrintEquipments : Page
    {
        Methods m = new Methods();

        public PrintEquipments()
        {
            InitializeComponent();
            EquipmentList.ItemsSource = m.GetEquipments();
        }
    }
}
