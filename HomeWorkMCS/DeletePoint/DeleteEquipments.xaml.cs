using HomeWorkMCS.BAL;
using HomeWorkMCS.DAL;
using System.Windows;
using System.Windows.Controls;

namespace HomeWorkMCS.DeletePoint
{
    /// <summary>
    /// Interaction logic for DeleteEquipments.xaml
    /// </summary>
    public partial class DeleteEquipments : Page
    {
        Methods mt = new Methods();

        public DeleteEquipments()
        {
            InitializeComponent();
            EquipmentList.ItemsSource = mt.GetEquipments();
        }

        private void Delete_OnClick(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(ManIdBox.Text);
            string serNo = SerialNoBox.Text;

            var list = mt.FindEquipments(id, serNo);

            foreach (newEquipment eq in list)
            {
                eq.intEquipmentID = int.Parse(ManIdBox.Text);
                eq.intGarageRoom = GarageRoomBox.Text;
                eq.intManufacturerID = int.Parse(ManIdBox.Text);
                eq.intModelID = int.Parse(ModelIdBox.Text);
                eq.strManufYear = ManufYearBox.Text;
                eq.strSerialNo = SerialNoBox.Text;
                //eq.CreateDate = CreateDateBox.Text;
                eq.intMetered = int.Parse(MeteredBox.Text);
                //eq.LastDate = LastDateBox.Text;

                mt.DeleteEquipment(eq);
            }
        }
    }
}
