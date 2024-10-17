using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD_rb : MonoBehaviour
{
    //Variables 
    public float forceAmt = 2f;

    private Rigidbody2D rb; 

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            rb.AddForce(Vector2.up * forceAmt);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * forceAmt);
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            rb.AddForce(Vector2.down * forceAmt);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * forceAmt);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Make the cube change color when it hits  player 2 cube 
        if (collision.transform.tag == "Exit")
        {
            //Find the color component of the item and change it to cyan
            GetComponent<SpriteRenderer>().color = Color.green;
        }

        GameManager.instance.StartGame();
    }


}
