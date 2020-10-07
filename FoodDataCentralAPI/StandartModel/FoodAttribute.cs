using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class FoodAttribute
    {
        public int id;
        public int sequenceNumber;
        public string value;
        public (int id, string name, string description) FoodAttributeType;
    }
}
