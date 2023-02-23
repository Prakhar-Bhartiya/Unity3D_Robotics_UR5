using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Preprocessor : MonoBehaviour
{
    public GameObject reader;
    public string fileName = "Solution.txt"; //Put the file in root Asset folder
    public string processedDataPath = "ProcessedSolution.txt"; // Replace this with the path and filename you want to use
    List<List<float>> data;

    private void setData()
    {
        data = reader.GetComponent<FileReader>().ReadData(fileName);
    }


    IEnumerator GetWayPoints()
    {
        setData();

        string jointEulerAngles_all_frame = "";

        foreach (List<float> data_per_frame in data)
        {
            //re initialize the local container for each frame
            string jointEulerAngles_per_frame = "";
            for (int i=0; i<data_per_frame.Count; i++)
            {
                switch(i)
                {
                    case 0:
                        try
                        {
                            jointEulerAngles_per_frame += (new Vector3(0.0f, (-1.0f) * (float)(data_per_frame[0] * (180.0 / Math.PI)), 0.0f)).ToString() + " | ";
                        }
                        catch (Exception e)
                        {
                            Debug.Log("Exception:" + e);
                        }

                        break;

                    case 1:
                        try
                        {
                            jointEulerAngles_per_frame += (new Vector3(0.0f, 0.0f, 90.0f + (float)(data_per_frame[1] * (180.0 / Math.PI)))).ToString() + " | ";
                        }
                        catch (Exception e)
                        {
                            Debug.Log("Exception:" + e);
                        }

                        break;

                    case 2:
                        try
                        {
                            jointEulerAngles_per_frame += (new Vector3(0.0f, 0.0f, (float)(data_per_frame[2] * (180.0 / Math.PI)))).ToString() + " | ";
                        }
                        catch (Exception e)
                        {
                            Debug.Log("Exception:" + e);
                        }

                        break;

                    case 3:
                        try
                        {
                            jointEulerAngles_per_frame += (new Vector3(0.0f, 0.0f, 90.0f + (float)(data_per_frame[3] * (180.0 / Math.PI)))).ToString() + " | ";
                        }
                        catch (Exception e)
                        {
                            Debug.Log("Exception:" + e);
                        }

                        break;

                    case 4:
                        try
                        {
                            jointEulerAngles_per_frame += (new Vector3(0.0f, (-1.0f) * (float)(data_per_frame[4] * (180.0 / Math.PI)), 0f)).ToString() + " | ";
                        }
                        catch (Exception e)
                        {
                            Debug.Log("Exception:" + e);
                        }

                        break;

                    case 5:
                        try
                        {
                            jointEulerAngles_per_frame += (new Vector3(0.0f, 0.0f, (float)(data_per_frame[5] * (180.0 / Math.PI)))).ToString() + " | ";
                        }
                        catch (Exception e)
                        {
                            Debug.Log("Exception:" + e);
                        }

                        break;

                    default:
                        Debug.Log("Error in conversion!!!!");
                        break;

                }
            }

            jointEulerAngles_all_frame += jointEulerAngles_per_frame + "\n";
        }

        // put to file
       

        // Write the data to the file
        File.WriteAllText(Application.dataPath + "/" + processedDataPath, jointEulerAngles_all_frame);

        yield return null;
    }


    private void Start()
    {
         // Read data from file and set it

        //reader.GetComponent<FileReader>().printData();

        StartCoroutine(GetWayPoints());

        Debug.Log("Done preprocessing!");


    }

}
  
