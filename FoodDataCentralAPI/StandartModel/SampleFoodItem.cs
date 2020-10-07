using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class SampleFoodItem : FoodItem
    {
        public int fdcId;
        public string dataType { get; }
        public string description;
        public string foodClass;
        public string publicationDate;
        public FoodCategory[] foodAttributes;
    }
}
