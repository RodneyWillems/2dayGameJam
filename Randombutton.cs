using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randombutton : MonoBehaviour
{
    public static KeyCode Pushkey;

    private void Start()
    {
        Generatekey(); 
    }

    private void Update()
    {
        if (Input.GetKeyDown(Pushkey))
        {
            Debug.Log("Key has been pressed");
            Generatekey(); 
        }
    }

    private void Generatekey()
    {
      
        Pushkey = (KeyCode)UnityEngine.Random.Range((int)KeyCode.A, (int)KeyCode.Z + 1);
        Debug.Log("Random key code: " + Pushkey);
    }
}