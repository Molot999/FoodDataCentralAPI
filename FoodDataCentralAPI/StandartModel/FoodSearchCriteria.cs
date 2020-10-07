using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class FoodSearchCriteria
    {
        public string query;
        public string[] dataType = new string[] { };
        public int pageSize;
        public int pageNumber;
        public string sortBy;
        public string sortOrder;
        public string brandOwner;
    }
}
