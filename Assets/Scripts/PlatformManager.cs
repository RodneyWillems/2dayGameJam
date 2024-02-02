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

    [SerializeField] List<GameObject> Platforms = new List<GameObject>();

    void FixedUpdate()
    {
        if (Time >= maxTime)
        {
            int platformPicker = Random.Range(0,Platforms.Count);
            Debug.Log("Creating Platform");
            spaceBetween = Random.Range(-3,3);
            Instantiate(Platforms[platformPicker], new Vector3(startPoint.transform.position.x + spaceBetween, Random.Range(minY, maxY), 0), Quaternion.identity ,transform.parent);
            Time = 0;
        } else
        {
            Time++;
        }
    }
}
