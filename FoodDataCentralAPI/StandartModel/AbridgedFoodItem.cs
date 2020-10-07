using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class AbridgedFoodItem : FoodItem
    {
        public string dataType { get; }
        public string description;
        public int fdcId;
        public AbridgedFoodNutrient[] foodNutrients;
        public string publicationDate;
        public string brandOwner;
        public string gtinUpc;
        public string ndbNumber;
        public string foodCode;
    }
}
