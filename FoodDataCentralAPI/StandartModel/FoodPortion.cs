using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDataCentralAPI.StandartModel
{
    public class FoodPortion
    {
        public int id;
        public float amount;
        public int dataPoints;
        public float gramWeight;
        public int minYearAcquired;
        public string modifier;
        public string portionDescription;
        public int sequenceNumber;
        public MeasureUnit measureUnit;
    }
}
