using System;
using System.Collections.Generic;
using System.Text;
namespace FoodDataCentralAPI.StandartModel
{
    public class SRLegacyFoodItem : FoodItem
    {
        public int fdcId;
        public string dataType { get; }
        public string description;
        public string foodClass;
        public bool isHistoricalReference;
        public string ndbNumber;
        public string publciationDate;
        public string scientificName;
        public FoodCategory foodCategory;
        public FoodNutrient[] foodNutrients;
        public NutrientConversationFactors[] nutrientConversationFactors;
    }
}
