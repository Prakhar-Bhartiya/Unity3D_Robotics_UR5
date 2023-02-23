using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Executor : MonoBehaviour
{
    public string fileName = "Processed_Solution.txt";
    public List<List<Vector3>> data = new List<List<Vector3>>();

    public static Vector3 StringToVector3(string sVector)
    {
        // Remove the parentheses
        if (sVector.StartsWith("(") && sVector.EndsWith(")"))
        {
            sVector = sVector.Substring(1, sVector.Length - 2);
        }

        // split the items
        string[] sArray = sVector.Split(',');

        // store as a Vector3
        Vector3 result = new Vector3(
            float.Parse(sArray[0]),
            float.Parse(sArray[1]),
            float.Parse(sArray[2]));

        return result;
    }



    private void stream()
    {
        // Define the file path

        string filePath = Application.dataPath + "/" + fileName;

        if(File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while((line = reader.ReadLine()) != null)
                {
                   
                    string[] inputArray = line.Split(" | ");

                    List<Vector3> vec3List = new List<Vector3>();

                     for(int i=0; i<inputArray.Length-1; i++)
                    {
                        //Process string to vector3
                        //Debug.Log(inputArray[i]);
                        vec3List.Add(StringToVector3(inputArray[i]));

                    }

                    data.Add(vec3List);                   

                }
            }
        }
        else
        {
            Debug.Log("Not able to find Preprocessed file");
        }

        Debug.Log("Proceed with Simulation");
    }

    private void Start()
    {
        stream();
    }



}
