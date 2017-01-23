using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Combat : MonoBehaviour
{
    public Transform punch;
    public Transform thrown;
    public float destroyPunch;
    public float punchDelay;
    public float canPunch;
    public float killPunch;
    public float destroyThrown;
    public float thrownTimer;


    void Start()
    {
        destroyPunch = Time.time;
        destroyThrown = Time.time;
        canPunch = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && Time.time >= canPunch)
        {
            Instantiate(punch, new Vector2(transform.position.x + 1f, transform.position.y - 1f), Quaternion.identity);
            destroyPunch = Time.time + killPunch;
            canPunch = Time.time + punchDelay;
        }
            if (destroyPunch <= Time.time)
            {
                Destroy(GameObject.FindWithTag("punch"));
            }
       
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(thrown, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            destroyThrown = Time.time + thrownTimer;
        }
        if (destroyThrown <= Time.time)
        {
            Destroy(GameObject.FindWithTag("thrown"));
        }
    }
}
 