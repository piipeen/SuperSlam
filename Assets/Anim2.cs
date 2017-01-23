using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Anim2 : MonoBehaviour
{
    public List<Sprite> spriteList;
    SpriteRenderer spriterenderer;
    public float delay = 0f;
    public float waitTime = 0.5f;
    public int index;
    public bool mer = true;
    public bool anim = false;
    // Use this for initialization  
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            anim = true;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            anim = true;
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            anim = false;
            index = 0;
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            anim = false;
            index = 0;
        }

        if (delay <= Time.time && anim == true)
        {
            spriterenderer.sprite = spriteList[index];
            index++;

            if (index >= spriteList.Count)
            {
                index = 0;
            }
            delay = Time.time + waitTime;
        }
    }
}
