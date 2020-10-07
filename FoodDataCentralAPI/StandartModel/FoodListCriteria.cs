using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class FoodListCriteria
    {
        public string dataType;
        public int pageSize;
        public int pageNumber;
        public string sortBy;
        public string sortOrder;
    }
}
