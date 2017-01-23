using UnityEngine;
using System.Collections;

public class Pistol : BaseWeapon
{
    public Transform dickbutt;

    public Pistol()
    {
        ammo = 98;
        damage = 15;
        clipSize = 14;
        clip = 14;
    }

    public override void Shoot()
    {
        Debug.Log("BANG");
        base.Shoot();
    }

    public override void PickUp()
    {
        Debug.Log("Picked up a pistol");
        base.PickUp();
    }

    public override void Drop()
    {
        Debug.Log("Dropped a pistol");
        base.Drop();
    }

    public override string GetDescription()
    {
        return ("This pistol is useless!");
    }
    void update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(dickbutt, new Vector3(2.0f, 0.3f, 0), Quaternion.identity);
        }
    }
}