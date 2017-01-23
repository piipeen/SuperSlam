using UnityEngine;
using System.Collections;

public class thrown : MonoBehaviour
{
    public float thrownSpeed;
    public bool dDown = false;
    public bool aDown = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKey(KeyCode.D))
          {
              dDown = true;
              aDown = false;
          }
          if (Input.GetKey(KeyCode.A))
          {
              aDown = true;
              dDown = false;
          }


          if (dDown == true)
          {
              transform.position = new Vector2(transform.position.x + thrownSpeed, transform.position.y);
          }
          if (aDown == true)
          {
              transform.position = new Vector2(transform.position.x - thrownSpeed, transform.position.y);
          }
    }
}
        