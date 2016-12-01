using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NapSackObject;

namespace KnapSackDriver
{

    class Program
    {
        // get the data;
        static String[] linesDataSet = System.IO.File.ReadAllLines("knap2.txt");

        // result array;
        static int[] dataSetInt;

        // N and W variables;
        static int inputSize, weightCap = 0;

        // BackNap Object
        static NapSack BK;

        static void Main(string[] args)
        {
            // Step One: Convert Data to int form and get N (input size) and W (Weight Capacity of KnapSack bag);
            stepOne();

            // Step Two: Create BackNap Object and run the solution;
            stepTwo();

            // Step Three: Solve;
            BK.solve();

        }


         



        // Neat Functions

        static void stepOne()
        {
            int[] dataInt = convertStringToIntArray(linesDataSet);
            int[] lineOne = getNW(dataSetInt);
        }

        static void stepTwo()
        {
            BK = new NapSack(-1, inputSize, weightCap, 0, 0, linesDataSet);
        }





        // Background Helper Functions;

            // String to Int Array Converter;
        static int[] convertStringToIntArray(String[] stringArray)
        {
            string[] result = linesDataSet[0].Split(' ');
            int[] resultInt = Array.ConvertAll<string, int>(result, Int32.Parse);
            dataSetInt = resultInt;
            return resultInt;
        }

            // Set N and W;
        static int[] getNW(int[] data)
        {
            string lineNW = linesDataSet[0];
            string[] lineNWArray = lineNW.Split(' ');
            int[] lineNWIntArray = Array.ConvertAll<string, int>(lineNWArray, int.Parse);

            inputSize = lineNWIntArray[0];
            weightCap = lineNWIntArray[1];

            return lineNWIntArray;
        }
    }
}
