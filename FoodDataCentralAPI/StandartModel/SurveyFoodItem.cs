using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class SurveyFoodItem : FoodItem
    {
        public int fdcId;
        public string dataType { get; }
        public string description;
        public string foodClass;
        public string foodCode;
        public string publicationDate;
        public string startDate;
        public FoodAttribute[] foodAttributes;
        public FoodPortion[] foodPortion;
        public InputFoodSurvey[] inputFoods;
        public WweiaFoodCategory wweiaFoodCategory;
    }
}
