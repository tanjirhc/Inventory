using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Models
{
    public class BaseEquipment
    {
        public string Name { get; set; }
        public int EcCount { get; set; }

        public DateTime EntryDate { get; set;}

        public List<BaseEquipment> ListEquipment { get; set; }

        public BaseEquipment() 
        {
            ListEquipment = new List<BaseEquipment>(); 
        }

        public static List<BaseEquipment> ListEquipmentData()
        {
            List<BaseEquipment> plstData = new List<BaseEquipment>();

            BaseEquipment baseEquipment = new BaseEquipment();
            baseEquipment.Name = "Laptop";
            baseEquipment.EcCount = 5;
            baseEquipment.EntryDate = DateTime.Now.Date;
            plstData.Add(baseEquipment);

            baseEquipment = new BaseEquipment();
            baseEquipment.Name = "Mouse";
            baseEquipment.EcCount = 7;
            baseEquipment.EntryDate = DateTime.Now.Date;
            plstData.Add(baseEquipment);

            baseEquipment = new BaseEquipment();
            baseEquipment.Name = "Keyboard";
            baseEquipment.EcCount = 10;
            baseEquipment.EntryDate = DateTime.Now.Date;
            plstData.Add(baseEquipment);


            return plstData;
        }
    }
}