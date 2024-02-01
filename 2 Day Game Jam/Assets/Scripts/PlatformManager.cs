using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] GameObject startPoint;
    [SerializeField] GameObject platformPrefab;
    [SerializeField] int maxTime;
    [SerializeField] int Time;
    [SerializeField] float maxY;
    [SerializeField] float minY;

    void FixedUpdate()
    {
        if (Time >= maxTime)
        {
            Debug.Log("Creating Platform");
            
            Instantiate(platformPrefab, new Vector3(startPoint.transform.position.x, Random.Range(minY, maxY), 0), Quaternion.identity ,transform.parent);
            Time = 0;
        } else
        {
            Time++;
        }
    }
}
