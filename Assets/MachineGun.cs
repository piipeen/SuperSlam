using UnityEngine;
using System.Collections;

public class MachineGun : BaseWeapon

{
    public MachineGun()
    {
        ammo = 150;
        damage = 12;
        clipSize = 30;
        clip = 30;
    }

    public override void Shoot()
    {
        Debug.Log("PEW PEW");
        base.Shoot();
    }

    public override void PickUp()
    {
        Debug.Log("Picked up a MachineGun");
        base.PickUp();
    }

    public override void Drop()
    {
        Debug.Log("Dropped a MachineGun");
        base.Drop();
    }

    public override string GetDescription()
    {
        return ("This is a Heavy machinegun");
    }
}
