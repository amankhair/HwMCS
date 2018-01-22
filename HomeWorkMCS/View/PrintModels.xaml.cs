using HomeWorkMCS.BAL;
using System.Windows.Controls;

namespace HomeWorkMCS.View
{
    /// <summary>
    /// Interaction logic for PrintModels.xaml
    /// </summary>
    public partial class PrintModels : Page
    {
        Methods m = new Methods();

        public PrintModels()
        {
            InitializeComponent();
            ModelList.ItemsSource = m.GetTablesModels();
        }
    }
}
