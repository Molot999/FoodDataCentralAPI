using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class SearchResult
    {
        public FoodSearchCriteria foodSearchCriteria;
        public int totalHits;
        public int currentPage;
        public int totalPages;
        public SearchResultFood[] foods; 
    }
}
