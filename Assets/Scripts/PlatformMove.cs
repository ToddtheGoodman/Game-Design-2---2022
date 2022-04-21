using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{

    public Transform[] wayPoints;

    public float moveSpeed;

    public int wayPointIndex;

    public Transform lastWayPoint;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = wayPoints[wayPointIndex].position;
    }

    // Update is called once per frame
    void Update()
    {
        WayPointMove();
    }

    void WayPointMove()
    {
        if (wayPointIndex <= wayPoints.Length -1)
        {
            transform.position = Vector3.MoveTowards(transform.position, wayPoints[wayPointIndex].position, moveSpeed * Time.deltaTime);
        }

        if (transform.position == wayPoints[wayPointIndex].position)
        {
            wayPointIndex += 1;
            if (wayPointIndex == wayPoints.Length)
            {
                wayPointIndex = 0;
            }
        }
        
    }

}
