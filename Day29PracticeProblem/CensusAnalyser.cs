﻿using IndianStateCensusAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29PracticeProblem
{
    public class CensusAnalyser
    {
        public static int a = 10;
        public enum Country
        {
            INDIA, US, BRAZIL
        }


        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, Country country, string dataHeaders)
        {
            //CensusAnalyser obj = new CensusAnalyser();
            //Console.WriteLine(obj.a);
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
