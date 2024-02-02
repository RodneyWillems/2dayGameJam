using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private KeyCode currentKey;
    [SerializeField] private bool jumping;
    [SerializeField] private float jumpForce, jumpTime;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private GameObject DeathMenu;

    private float jumpingTimer;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        DeathMenu.SetActive(false);
    }
    private KeyCode Generatekey()
    {
        currentKey = (KeyCode)UnityEngine.Random.Range((int)KeyCode.A, (int)KeyCode.Z + 1);
        Debug.Log("Random key code: " + currentKey);
        return currentKey;
    }

    private void jump()
    {
        //transform.Translate(0, jumpForce * Time.deltaTime, 0);
        rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Generatekey();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "DeathFloor")
        {
            DeathMenu.SetActive(true);
            Destroy(gameObject);
        }
        jumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(currentKey) && jumping == false)
        {
            jumping = true;
            jump();
        }
        text.text = "Currentkey: " + currentKey.ToString();
    }
}
