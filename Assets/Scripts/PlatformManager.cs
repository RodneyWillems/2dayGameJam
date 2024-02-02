using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlatformManager : MonoBehaviour
{
    [SerializeField] GameObject startPoint;
    [SerializeField] GameObject platformPrefab;
    [SerializeField] private TextMeshProUGUI pointText;
    [SerializeField] int maxTime;
    [SerializeField] int Time;
    [SerializeField] int spaceBetween;

    [SerializeField] float maxY;
    [SerializeField] float minY;

    [SerializeField] List<GameObject> Platforms = new List<GameObject>();

    private int score;

    void FixedUpdate()
    {
        if (Time >= maxTime)
        {
            int platformPicker = Random.Range(0,Platforms.Count);
            Debug.Log("Creating Platform");
            spaceBetween = Random.Range(-1,3);
            Instantiate(Platforms[platformPicker], new Vector3(startPoint.transform.position.x + spaceBetween, Random.Range(minY, maxY), 0), Quaternion.identity ,transform.parent);
            score++;
            pointText.text = "Score: " + score;
            Time = 0;
        } else
        {
            Time++;
        }
    }
}
