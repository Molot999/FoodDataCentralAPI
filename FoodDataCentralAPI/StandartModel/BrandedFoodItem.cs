using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class BrandedFoodItem : FoodItem
    {
        public int fdcId;
        public string availableDate;
        public string dataSource;
        public string dataType { get; }
        public string description;
        public string foodClass;
        public string gtinUpc;
        public string householdServingFullText;
        public string ingredients;
        public string modifiedDate;
        public string publicationDate;
        public float servingSize;
        public string servingSizeUnit;
        public string brandedFoodCategory;
        public FoodNutrient[] foodNutrients;
        public FoodUpdateLog[] foodUpdateLog;
        public (float fat, float saturatedFat, float transFat, float cholesterol, float carbonhydrates, float fiber, float sugars, float protein, float calcium, float iron, float postassium, float calories) labelNutrients;
    }
}
