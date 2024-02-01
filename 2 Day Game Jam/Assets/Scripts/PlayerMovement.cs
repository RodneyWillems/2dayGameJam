using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private KeyCode currentKey;
    [SerializeField] private bool jumping;
    [SerializeField] private float jumpForce;

    private float jumpingTimer;

    // Start is called before the first frame update
    void Start()
    {

    }

    void jump()
    {
        transform.Translate(0, jumpForce * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(currentKey))
        {
            jumping = true;
        }
        if (jumping == true)
        {
            jump();
            jumpingTimer += Time.deltaTime;
            if (jumpingTimer > 0.5)
            {
                jumpingTimer = 0;
                jumping = false;
            }
        }
    }
}
