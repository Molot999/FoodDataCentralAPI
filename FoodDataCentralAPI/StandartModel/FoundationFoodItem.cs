using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class FoundationFoodItem : FoodItem
    {
        public int fdcId;
        public string dataType { get; }
        public string description;
        public string foodClass;
        public string footNote;
        public bool isHistoricalReference;
        public string ndbNumber;
        public string publicationDate;
        public string scientificName;
        public FoodCategory foodCategory;
        public FoodComponent[] foodComponents;
        public FoodNutrient[] foodNutrients;
        public FoodPortion[] foodPortions;
        public InputFoodFoundation[] inputFoods;
        public NutrientConversationFactors[] nutrientConversationFactors;
    }
}
