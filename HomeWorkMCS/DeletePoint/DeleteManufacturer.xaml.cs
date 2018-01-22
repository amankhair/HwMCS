using HomeWorkMCS.BAL;
using HomeWorkMCS.DAL;
using System.Windows;
using System.Windows.Controls;

namespace HomeWorkMCS.DeletePoint
{
    /// <summary>
    /// Interaction logic for DeleteManufacturer.xaml
    /// </summary>
    public partial class DeleteManufacturer : Page
    {
        Methods mt = new Methods();

        public DeleteManufacturer()
        {
            InitializeComponent();
            ManufacturerList.ItemsSource = mt.GeTablesManufacturers();
        }

        private void Delete_OnClick(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(ManIdBox.Text);
            string name = NameBox.Text;

            var list = mt.FindManufacturers(id, name);

            foreach (TablesManufacturer tm in list)
            {
                if ((ManIdBox.Text != "") && (NameBox.Text != ""))
                {
                    tm.intManufacturerID = id;
                    tm.strName = name;

                    mt.DeleteManufacturer(tm);
                    MessageBox.Show("Nice!");
                }
                else
                {
                    MessageBox.Show("Выберите пункт");
                }
            }



        }


    }
}
