using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject Platform;
    public float SpeedPlatform;
    private Transform currentPoint;
    public Transform[] points;
    public int pointSelection;
    void Start()
    {
        currentPoint = points[pointSelection];
    }

    // Update is called once per frame
    void Update()
    {
        Platform.transform.position = Vector3.MoveTowards(Platform.transform.position, currentPoint.position, Time.deltaTime * SpeedPlatform);
        if(Platform.transform.position == currentPoint.position)
        {
            pointSelection++;
            if(pointSelection == points.Length)
            {
                pointSelection = 0;
            }
            currentPoint = points[pointSelection];
        }
    }
}
