using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulater : MonoBehaviour
{
    public GameObject exec_var;
    private string linkTag;
    private List<List<Vector3>> data;

    public void initiate()
    {
       
        linkTag = gameObject.tag;
        data = exec_var.GetComponent<Executor>().data;

        StartCoroutine(RotateToTarget());
    }

    public float rotationSpeed = 1f;


    IEnumerator rotation(Vector3 targetRotation)
    {
        while (transform.localEulerAngles != targetRotation)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(targetRotation), rotationSpeed * Time.deltaTime);
            
            yield return null;
        }
    }

    IEnumerator RotateToTarget()
    {
        
        for(int i=0; i<data.Count; i++)
        {
            switch (linkTag)
            {
                case "Link1":
            
                    StartCoroutine(rotation(data[i][0]));
                    break;
                case "Link2":
                    StartCoroutine(rotation(data[i][1]));
                    break;
                case "Link3":
                    StartCoroutine(rotation(data[i][2]));
                    break;
                case "Link4":
                    StartCoroutine(rotation(data[i][3]));
                    break;
                case "Link5":
                    StartCoroutine(rotation(data[i][4]));
                    break;
                case "Link6":
                    StartCoroutine(rotation(data[i][5]));
                    break;
            }
            yield return new WaitForSeconds(0.5f);

        }
        

    }


    
}
