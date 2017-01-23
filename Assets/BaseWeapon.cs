using UnityEngine;
using System.Collections;

public class BaseWeapon : MonoBehaviour
{
    protected int damage;
    protected int ammo;
    protected int clip;
    protected int clipSize;

    public BaseWeapon ()
    {
        damage = 0;
        ammo = 0;
        clip = 0;
        clipSize = 0;
    } 

    public virtual void Shoot ()
    {
        ammo--;
    }

    public virtual void Reload ()
    {
        ammo -= clipSize;
        clip = clipSize;
    }

    public virtual void PickUp ()
    {

    }

    public virtual void Drop()
    {

    }

    public virtual int GetAmmo()
    {
        return ammo;
    }

    public virtual void SetAmmo(int amount)
    {
        ammo = amount;
    }

    public virtual string GetDescription ()
    {
        return "";
    }
}