using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class NinjiaMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Text coinCounter, heartCounter;
    public int coinAmount, heartAmount;
    
   
    Vector2 movement;

    // Start is called before the first frame update
    void Start ()
    {
        coinAmount = 0;
        heartAmount = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        //Player can use the keyboard to move character
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //Show the coins and heart on the scene
        coinCounter.text = ("Coins:" + coinAmount);
        heartCounter.text = ("Hearts:" + heartAmount);
    }
    void FixedUpdate()
    {
        //Formular for moving
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //Move direction of Ninja
        if (movement == Vector2.left ){
            transform.localScale = new Vector3 (-1,1,1);
            
        }else if (movement == Vector2.right ){
            transform.localScale = new Vector3 (1,1,1);
        }
    }
    //If the character is death, the game will start over again
    public void Death ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } 
    
    void OnTriggerEnter2D(Collider2D co)
    {
        //Coin is counted 10 points
        if (co.GetComponent<Coin>())
        {
            coinAmount += 10;
        }
        //Heart is counted 1 
        if (co.GetComponent<Heart>())
        {
            heartAmount += 1;
        }
        //When the Ninja touch the Enemy, it will disappear
        if (co.GetComponent<EnemyMove>())
        {
            Destroy(gameObject);
            Death();
        }
    }
}

 
    



