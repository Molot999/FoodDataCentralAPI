using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class FoodNutrient
    {
        public int id;
        public float amount;
        public int dataPoints;
        public float min;
        public float max;
        public float median;
        public string type;
        public Nutrient nutrient;
        public FoodNutrientDerivation foodNutrientDeravation;
        public NutrientAnalysisDetails nutrientAnalysisDetails;
    }
}
