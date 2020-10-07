using FoodDataCentralAPI.StandartModel;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Net;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace FoodDataCentralAPI
{
    public class FoodDataCentral
    {
        public FoodDataCentral() { }
        public FoodDataCentral(ConnectionData connectionData)
        {
            ConnectionData = connectionData;
        }

        public ConnectionData ConnectionData { get; set; } = new ConnectionData();

        public SearchResultFood GetFood(int fdcId)
        {
            WebResponse fdcResponse = WebRequest.Create(ConnectionData.FormFoodItemFuncUri(fdcId)).GetResponse();
            
            using (StreamReader responseStreamReader = new StreamReader(fdcResponse.GetResponseStream()))
            {
                return DataFormatter.DeserializeJson<SearchResultFood>(responseStreamReader.ReadToEnd());
            }
        }

        public ArrayList GetFoods(FoodsCriteria foodsCriteria)
        {
            WebRequest fdcRequest = WebRequest.Create(ConnectionData.FormFoodsFuncUri());
            SetPrimaryPostRequestOptions(fdcRequest);

            byte[] sendingDataAsBytes = DataFormatter.ConvertToBytes(DataFormatter.SerializeToJson(foodsCriteria));

            using (Stream fdcRequestStream = fdcRequest.GetRequestStream())
                fdcRequestStream.Write(sendingDataAsBytes, 0, sendingDataAsBytes.Length);

            using (StreamReader fdcResponseStreamReader = new StreamReader(fdcRequest.GetResponse().GetResponseStream()))
            {
                ArrayList foodItemList = DataFormatter.DeserializeJson<ArrayList>(fdcResponseStreamReader.ReadToEnd());

                DataFormatter.DetermineFoodItemsType(foodItemList);

                return foodItemList;
            }
        }

        public AbridgedFoodItem[] GetFoodList(FoodListCriteria foodListCriteria)
        {
            WebRequest fdcRequest = WebRequest.Create(ConnectionData.FormFoodListFuncUri());
            SetPrimaryPostRequestOptions(fdcRequest);

            byte[] sendingDataAsBytes = DataFormatter.ConvertToBytes(DataFormatter.SerializeToJson(foodListCriteria));

            using (Stream fdcRequestStream = fdcRequest.GetRequestStream())
                fdcRequestStream.Write(sendingDataAsBytes, 0, sendingDataAsBytes.Length);

            using (StreamReader fdcResponseStreamReader = new StreamReader(fdcRequest.GetResponse().GetResponseStream()))
                return DataFormatter.DeserializeJson<AbridgedFoodItem[]>(fdcResponseStreamReader.ReadToEnd());
        }

        public SearchResult SearchFood(FoodSearchCriteria foodSearchCriteria)
        {
            WebRequest fdcRequest = WebRequest.Create(ConnectionData.FormSearchFoodFuncUri());
            SetPrimaryPostRequestOptions(fdcRequest);

            byte[] sendingDataAsBytes = DataFormatter.ConvertToBytes(DataFormatter.SerializeToJson(foodSearchCriteria));

            using (Stream fdcRequestStream = fdcRequest.GetRequestStream())
                fdcRequestStream.Write(sendingDataAsBytes, 0, sendingDataAsBytes.Length);

            using (StreamReader fdcResponseStreamReader = new StreamReader(fdcRequest.GetResponse().GetResponseStream()))
                return DataFormatter.DeserializeJson<SearchResult>(fdcResponseStreamReader.ReadToEnd());
        }

        private void SetPrimaryPostRequestOptions(WebRequest fdcRequest)
        {
            fdcRequest.Method = "POST";
            fdcRequest.Timeout = 100000;
            fdcRequest.ContentType = "application/json";

        }
    }
} 