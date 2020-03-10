using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            int sum = 0;

            foreach (int temp in _temperatures)
            {
                sum += temp;
            }

            int tempCount = _temperatures.Count;
            int averageTemp = sum / tempCount;

            return averageTemp;
        }

        public int TempsAboveThreshold(int threshold)
        {
            int aboveThreshold = 0;

            foreach (int temp in _temperatures)
            {
                if (temp > threshold)
                {
                    aboveThreshold++;
                }
            }

            return aboveThreshold;
        }

        public int TempsBelowThreshold(int threshold)
        {
            int belowThreshold = 0;

            foreach (int temp in _temperatures)
            {
                if (temp < threshold)
                {
                    belowThreshold++;
                }
            }

            return belowThreshold;
        }

        public int TempsAtThreshold(int threshold)
        {
            int atThreshold = 0;

            foreach (int temp in _temperatures)
            {
                if (temp == threshold)
                {
                    atThreshold++; 
                }
            }

            return atThreshold;
        }

        public int NumberOfTemperatures()
        {
            return _temperatures.Count;
        }
    }
}