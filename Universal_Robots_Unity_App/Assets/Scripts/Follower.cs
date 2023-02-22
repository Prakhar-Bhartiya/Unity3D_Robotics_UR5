using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public Vector3[] points;
    public EndOfPathInstruction end;

    //Create a path from given vector3 points
    private VertexPath GetVertexPath(Vector3[] points, bool closedPath)
    {
        BezierPath bezierPath = new BezierPath(points, closedPath, PathSpace.xyz);

        return new VertexPath(bezierPath, transform);
    }

    //Following script
    public float speed;
    float step;
    private int currentPointIndex = 0;
    
    private IEnumerator follow(Vector3[] midPoints)
    {
        while (currentPointIndex < midPoints.Length)
        {
            Vector3 currentPoint = midPoints[currentPointIndex];
            Vector3 nextPoint = (currentPointIndex == midPoints.Length - 1) ? transform.position : midPoints[currentPointIndex + 1];
            float distance = Vector3.Distance(transform.position, currentPoint);

            while (distance > 0.01f)
            {
                transform.position = Vector3.MoveTowards(transform.position, currentPoint, speed * Time.deltaTime);
                distance = Vector3.Distance(transform.position, currentPoint);
                yield return null;
            }

            currentPointIndex++;
        }

    }

    void Start()
    {
        VertexPath vertexPath = GetVertexPath(points, false);
        StartCoroutine(follow(vertexPath.localPoints));
    }

}
