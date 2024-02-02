using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDone : MonoBehaviour
{

    public KeyCode Pushkey;


    void Start()
    {
        Generatekey();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(Pushkey))
        {
            SceneManager.LoadScene("Samplescene");
        }
    }

    public void Generatekey()
    {

        Pushkey = (KeyCode)UnityEngine.Random.Range((int)KeyCode.A, (int)KeyCode.Z + 1);
        Debug.Log("Random key code: " + Pushkey);
    }
}
