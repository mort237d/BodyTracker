using System;

namespace BodyTracker.Model
{
    class Log
    {
        public string Image { get; set; }
        public double Weight { get; set; }
        public double FatPercentage { get; set; }
        public DateTime DateTime { get; set; }

        public Log(string image, double weight, double fatPercentage, DateTime dateTime)
        {
            Image = image;
            Weight = weight;
            FatPercentage = fatPercentage;
            DateTime = dateTime;
        }
    }
}
