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
    [SerializeField] int spaceBetween;

    [SerializeField] float maxY;
    [SerializeField] float minY;


    void FixedUpdate()
    {
        if (Time >= maxTime)
        {
            Debug.Log("Creating Platform");
            spaceBetween = Random.Range(-3,3);
            Instantiate(platformPrefab, new Vector3(startPoint.transform.position.x + spaceBetween, Random.Range(minY, maxY), 0), Quaternion.identity ,transform.parent);
            Time = 0;
        } else
        {
            Time++;
        }
    }
}
