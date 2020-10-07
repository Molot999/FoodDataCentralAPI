using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class SearchResultFood
    {
        public int fdcId;
        public string dataType;
        public string description;
        public string foodCode;
        public AbridgedFoodNutrient[] FoodNutrients;
        public string publicationDate;
        public string scientificName;
        public string brandOwner;
        public string gtinUpc;
        public string ingredients;
        public string ndbNumber;
        public string additionalDescriptions;
        public string allHighlightFields;
        public float score;
    }
}
