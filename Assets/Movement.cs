using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float acceleration = 2.0f;
    public float jump = 1000.0f;
    public bool grounded = true;
    public bool flip = true;
    SpriteRenderer spriterenderer;
    public int jumps = 3;
    public float maxSpeed;
    public float dash;
    public bool aDown = false;
    public bool dDown = false;
    public bool wDown = false;
    public bool sDown = false;
    public float dashDelay;
    public float canDash;

    // Use this for initialization
    void Start ()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        dashDelay = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKey(KeyCode.D))
        {
            spriterenderer.flipX = false;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            spriterenderer.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && jumps >= 1) //Om man trycker på space OCH den är "grounded", Hoppa
        {
            rigidbody2D.AddForce(Vector2.up * jump); //Hopp
            Debug.Log("jump!");
            jumps = jumps -1; //Grounded är false
        }
        //float speedX = Input.GetAxis("Horizontal"); //Hastighet X

        if (Input.GetKey(KeyCode.D))
        {
            if(rigidbody2D.velocity.x < maxSpeed)
            {
                rigidbody2D.AddForce(Vector2.right * Input.GetAxis("Horizontal") * acceleration);
            }
            else
            {
                Vector2 temp = rigidbody2D.velocity;
                temp.x = maxSpeed;
                rigidbody2D.velocity = temp;
            }
         
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (rigidbody2D.velocity.x > -maxSpeed)
            {
                rigidbody2D.AddForce(Vector2.left * Input.GetAxis("Horizontal") * -acceleration);
            }
            else
            {
                Vector2 temp = rigidbody2D.velocity;
                temp.x = -maxSpeed;
                rigidbody2D.velocity = temp;
            }
         }
            if (Input.GetKeyDown(KeyCode.A))
            {
                aDown = true;
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                aDown = false;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                dDown = true;
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                dDown = false;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                wDown = true;
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                wDown = false;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                sDown = true;
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                sDown = false;
            }



            if (Input.GetKey(KeyCode.LeftShift) && (dDown == true) && (dashDelay <= Time.time))
            {
            transform.position = new Vector2(transform.position.x + dash, transform.position.y);

            dashDelay = Time.time + canDash;
            }

        if (Input.GetKey(KeyCode.LeftShift) && (aDown == true) && (dashDelay <= Time.time))
        {
            transform.position = new Vector2(transform.position.x - dash, transform.position.y);


            dashDelay = Time.time + canDash;
        }
             
            if (Input.GetKey(KeyCode.LeftShift) && (wDown == true) && (dashDelay <= Time.time))
            {
                 transform.position = new Vector2(transform.position.x, transform.position.y + dash);
                 dashDelay = Time.time + canDash;
            }
             
            if (Input.GetKey(KeyCode.LeftShift) && (sDown == true) && (dashDelay <= Time.time))
            {
                 transform.position = new Vector2(transform.position.x, transform.position.y - dash);
                 dashDelay = Time.time + canDash;
            }
        /* if (Input.GetKey(KeyCode.D))
         {
             rigidbody2D.AddForce(transform.right * speed);
         }
         if (Input.GetKey(KeyCode.A))
         {
             rigidbody2D.AddForce(transform.)
         }*/
        // rigidbody2D.velocity = new Vectro2(speedX * speed, rigidbody2D.velocity.y); //Hastigheten på Horizontal och Vertical
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            jumps = 3;
        }
    }
}
