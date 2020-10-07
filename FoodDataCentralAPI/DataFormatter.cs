using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using FoodDataCentralAPI.StandartModel;
using Newtonsoft.Json;

namespace FoodDataCentralAPI
{
    static class DataFormatter
    {
        public static byte[] ConvertToBytes(string json) => Encoding.Default.GetBytes(json);
        public static string SerializeToJson(object obj) => JsonConvert.SerializeObject(obj);

        public static T DeserializeJson<T>(string json) => JsonConvert.DeserializeObject<T>(json);

        public static void DetermineFoodItemsType(ArrayList foodItemList)
        {
            for (int i = 0; i < foodItemList.Count-1; i++)
            {
                string dataType = (foodItemList[i] as FoodItem).dataType;

                if (dataType == "Abridged") foodItemList[i] = (AbridgedFoodItem)foodItemList[i];
                else if (dataType == "Branded") foodItemList[i] = (BrandedFoodItem)foodItemList[i];
                else if (dataType == "Foundation") foodItemList[i] = (FoundationFoodItem)foodItemList[i];
                else if (dataType == "SR Legacy") foodItemList[i] = (SRLegacyFoodItem)foodItemList[i];
                else if (dataType.Contains("Survey")) foodItemList[i] = (SurveyFoodItem)foodItemList[i];

                else throw new Exception("Could not determine the type of foodItem");
            }
        }
    }
}
