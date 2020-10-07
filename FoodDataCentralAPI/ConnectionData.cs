using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using FoodDataCentralAPI.StandartModel;

namespace FoodDataCentralAPI
{
    public class ConnectionData
    {
        private string apiKey;
        public string ApiKey
        {
            get
            {
                if (UseDemoApiKey == true)
                    return "DEMO_KEY";
                else
                    return apiKey;
            }

            set => apiKey = value;
        }
        public bool UseDemoApiKey { get; set; }

        private const string baseUri = "https://api.nal.usda.gov/fdc/v1/";

        public string FormFoodItemFuncUri(int fdcId) => baseUri + $"food/{fdcId}?api_key={ApiKey}";
        public string FormFoodsFuncUri() => baseUri + $"foods?api_key={ApiKey}";
        public string FormFoodListFuncUri() => baseUri + $"foods/list?api_key={ApiKey}";
        public string FormSearchFoodFuncUri() => baseUri + $"foods/search?api_key={ApiKey}";

    }
}