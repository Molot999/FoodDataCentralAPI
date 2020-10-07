using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class InputFoodSurvey
    {
        public int id;
        public float amount;
        public string foodDescription;
        public int ingredientCode;
        public string ingredientDescription;
        public float ingredientWeight;
        public string portionCode;
        public string portionDescription;
        public int sequenceNumber;
        public int surveyFlag;
        public string unit;
        public object inputFood;
        public RetentionFactor retentionFactor;
    }
}
