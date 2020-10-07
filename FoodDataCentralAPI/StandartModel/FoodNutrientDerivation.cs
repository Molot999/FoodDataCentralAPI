using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class FoodNutrientDerivation
    {
        public int id;
        public string code;
        public string description;
        public FoodNutrientSource FoodNutrientSource;
    }
}
