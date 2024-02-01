using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatfromScript : MonoBehaviour
{
    [SerializeField] GameObject endPoint;
    [SerializeField] float speed;
    private void Start()
    {
        endPoint = GameObject.FindGameObjectWithTag("endPoint");
    }

    
    void FixedUpdate()
    {
        if (transform.position.x <= endPoint.transform.position.x)
        {
            Destroy(gameObject);
        } else
        {
            transform.position = new Vector2 (transform.position.x - speed*Time.deltaTime, transform.position.y);
        }
    }
}
