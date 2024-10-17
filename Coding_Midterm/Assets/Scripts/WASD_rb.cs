using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene(2);
        }

        //GameManager.instance.StartGame();

        if (collision.transform.tag == "Exit2")
        {
            SceneManager.LoadScene(3);
        }

        if (collision.transform.tag == "Death")
        {
            SceneManager.LoadScene(2);
        }

        if (collision.transform.tag == "Trophy")
        {
            SceneManager.LoadScene("End");
        }
    }

}
