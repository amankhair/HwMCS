using HomeWorkMCS.DAL;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkMCS.BAL
{
    public class Methods
    {
        MainDB db = new MainDB();

        public List<newEquipment> GetEquipments()
        {
            return db.newEquipment.ToList();
        }

        public List<newEquipment> FindEquipments(int id, string serNo)
        {
            return db.newEquipment.Where(w => w.intEquipmentID == id && w.strSerialNo == serNo).ToList();
        }

        public void DeleteEquipment(newEquipment eq)
        {
            db.newEquipment.Remove(eq);
            db.SaveChanges();
        }

        //----------- Manufacturers methods ----------------//

        public List<TablesManufacturer> GeTablesManufacturers()
        {
            return db.TablesManufacturer.ToList();
        }

        public List<TablesManufacturer> Names { get; set; }

        public List<TablesManufacturer> GetNames()
        {
            return Names = db.TablesManufacturer.ToList();
        }

        public void AddnewManufacturer(TablesManufacturer tm)
        {
            db.TablesManufacturer.Add(tm);
            db.SaveChanges();
        }

        public List<TablesManufacturer> FindManufacturers(int id, string name)
        {
            return db.TablesManufacturer.Where(w => w.intManufacturerID == id && w.strName == name).ToList();
        }

        public void DeleteManufacturer(TablesManufacturer tm)
        {
            db.TablesManufacturer.Remove(tm);
            db.SaveChanges();
        }

        //----------------------TableModels methods -----------------//

        public List<TablesModel> GetTablesModels()
        {
            return db.TablesModel.ToList();
        }
    }
}
