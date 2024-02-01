using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private KeyCode currentKey;
    [SerializeField] private bool jumping;
    [SerializeField] private float jumpForce, jumpTime;

    private float jumpingTimer;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private KeyCode Generatekey()
    {
        currentKey = (KeyCode)UnityEngine.Random.Range((int)KeyCode.A, (int)KeyCode.Z + 1);
        Debug.Log("Random key code: " + currentKey);
        return currentKey;
    }

    private void jump()
    {
        transform.Translate(0, jumpForce * Time.deltaTime, 0);
        //rb.AddForce(Vector3.up * jumpForce);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Generatekey();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(currentKey) && jumping == false)
        {
            jumping = true;
        }
        if (jumping == true)
        {
            jump();
            jumpingTimer += Time.deltaTime;
            if (jumpingTimer > jumpTime)
            {
                jumpingTimer = 0;
                jumping = false;
            }
        }
    }
}
