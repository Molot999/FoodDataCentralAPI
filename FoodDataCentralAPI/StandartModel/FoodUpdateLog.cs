using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class FoodUpdateLog
    {
        public int fcId;
        public string available;
        public string brandOwner;
        public string dataSource;
        public string dataType;
        public string description;
        public string foodClass;
        public string gtinUpc;
        public string householdServingFullText;
        public string ingredients;
        public string modifiedDate;
        public string publicationDate;
        public int servingSize;
        public string servingSizeUnit;
        public string brandedFoodCategory;
        public string changes;
        public FoodAttribute[] foodAttributes;
    }
}
