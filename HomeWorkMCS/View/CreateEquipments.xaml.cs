using HomeWorkMCS.DAL
    ;
using System;
using System.Windows;
using System.Windows.Controls;

namespace HomeWorkMCS.View
{
    /// <summary>
    /// Interaction logic for CreateEquipments.xaml
    /// </summary>
    public partial class CreateEquipments : Page
    {
        public CreateEquipments()
        {
            InitializeComponent();
        }

        private void CreateEquipment_OnClick(object sender, RoutedEventArgs e)
        {
            newEquipment eq = new newEquipment();
            eq.intGarageRoom = garageRoomBox.Text; //?
            eq.intManufacturerID = int.Parse(manufacturerIdBox.Text);
            eq.intModelID = int.Parse(modelIdBox.Text);
            eq.strSerialNo = serialNoBox.Text;
            eq.CreateDate = Convert.ToDateTime(createDateBox.Text); //?
            eq.intMetered = int.Parse(meteredBox.Text);
            eq.LastDate = Convert.ToDateTime(lastDateBox.Text);

            try
            {
                MessageBox.Show("Успех!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
