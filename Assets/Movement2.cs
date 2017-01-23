using UnityEngine;
using System.Collections;

public class Movement2 : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float speed = 2.0f;
    public float jump = 1000.0f;
    public bool grounded = true;
    public bool flip = true;
    SpriteRenderer spriterenderer;
    public int jumps = 3;
    public float punchX;
    public float punchY;
    public float damageTaken;


    // Use this for initialization
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            spriterenderer.flipX = false;
        }
        else if (Input.GetKey(KeyCode.J))
        {
            spriterenderer.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.RightShift) && jumps >= 1) //Om man trycker på space OCH den är "grounded", Hoppa
        {
            rigidbody2D.AddForce(Vector2.up * jump); //Hopp
            Debug.Log("jump!");
            jumps = jumps - 1; //Grounded är false
        }
        float speedX = Input.GetAxis("Horizontal2"); //Hastighet X
        
        rigidbody2D.velocity = new Vector2(speedX * speed, rigidbody2D.velocity.y); //Hastigheten på Horizontal och Vertical
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            jumps = 3;
        }
        if (coll.gameObject.tag == "punch")
        {
            rigidbody2D.velocity = new Vector2(punchX * damageTaken, rigidbody2D.velocity.y + punchY * damageTaken);
           // rigidbody2D.AddForce(Vector2.up * punchY);
        }
    }
}
