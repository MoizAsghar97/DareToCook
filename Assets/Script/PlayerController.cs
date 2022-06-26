using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 //private Rigidbody2D rb2D;
    //private float thrust = 10.0f;
    public float moveSpeed = 5f;
    public float hitPoints = 100f;
    private Rigidbody2D rb;
    public SpriteRenderer playerImage;
      // Reference to the main camera that we see the game world through
    private Camera mainCamera;

    // Half the width of the player's character image
    private float playerHalfWidth;

    // The game screen's right and left edges, used to block the player from going outside screen boundaries
    private float rightScreenEdge;
    private float leftScreenEdge;

    private float maxPosX;
    private float minPosX;

    private void Start()
    {
        rb = gameObject.AddComponent<Rigidbody2D>();
        gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        // Get the main camera reference from the Camera class
        mainCamera = Camera.main;

        // Calculate the half-width from the player's image boundaries along the horizontal x-axis. The bounds are the total width so we split them in 2
        playerHalfWidth = playerImage.bounds.size.x * 0.5f;

        // Get the right-most point on the game screen which is its width (as 'mainCamera.pixelWidth'),
        // and project that point from the screen to the game world (using 'ScreenToWorldPoint' function from the main camera).
        // This gives us that same point's coordinates, but inside the game world where game objects also live and move
        rightScreenEdge = mainCamera.ScreenToWorldPoint(new Vector2(mainCamera.pixelWidth, 0)).x;

        // Do the same for the left-most point on the game screen, which happens to be 0 on the screen
        leftScreenEdge = mainCamera.ScreenToWorldPoint(Vector2.zero).x;

		// Calculate the maximum and minimum possible X values for the players position along the X-axis
		// Taking into account the player's own width so it stays completely on screen
        maxPosX = rightScreenEdge - playerHalfWidth;
        minPosX = leftScreenEdge + playerHalfWidth;
  
    }
    
    void FixedUpdate() 
    { 
        Vector2 movement = Vector2.zero;
        float inputHl = Input.GetAxis("Horizontal");
        Vector2 currentPos = gameObject.transform.position;
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
               movement.x = (transform.right*Time.deltaTime*moveSpeed).x;
               transform.position = new Vector2(rb.position.x - 1, rb.position.y);
         }

        if(Input.GetKey(KeyCode.RightArrow) )
        {
            movement.x = (transform.right*Time.deltaTime*moveSpeed).x;
            transform.position = new Vector2(rb.position.x + 1, rb.position.y);
        }
        rb.AddForce(movement);   
       
    }
}
