using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class NutrientAnalysisDetails
    {
        public int subSampleId;
        public float amount;
        public int nutrientId;
        public string labMethodDescription;
        public string labMethodOriginalDescription;
        public string labMethodLink;
        public string labMethodTechnique;
        public NutrientAcquisitionDetails[] nutrientAcquisitionDetails; 
    }
}
