using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileReader : MonoBehaviour
{
    //Holds all the value from "Solution.txt" file
    List<List<float>> data = new List<List<float>>();

    public List<List<float>> ReadData(string fileName)
    {
        //Store data in [[j1 j2 j3 j4 j5 j6] x num of frames]
        

        // Define the file path
        string filePath = Application.dataPath + "/" + fileName;

        // Check if the file exists
        if (File.Exists(filePath))
        {
            // Read the text from the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] inputArray = line.Split(',');

                    // Convert each string in the array to a float and add it to a list of floats
                    List<float> floatList = new List<float>();
                    foreach (string input in inputArray)
                    {
                        float floatValue = float.Parse(input);
                        floatList.Add(floatValue);
                    }
                    data.Add(floatList);

                }
            }

        }
        else
        {
            Debug.Log("File not found");
        }

        return data;
    }

    public void printData()
    {
        foreach(List<float> joints_data in data)
        {
            string res = "";
            foreach(float value in joints_data)
            {
                res += value.ToString() + " | ";
            }
            Debug.Log(res);
        }
    }
}
