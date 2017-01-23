using UnityEngine;
using System.Collections;

public class ClassUser : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        LazerGun lazer = new LazerGun();
        MachineGun machineGun = new MachineGun();
        Pistol pistol = new Pistol();
        lazer.Shoot();
        machineGun.Shoot();
        pistol.Shoot();

        BaseWeapon someWeapon = new LazerGun();
        BaseWeapon someWeaponTwo = new MachineGun();
        BaseWeapon someWeaponThree = new Pistol();
        someWeapon.PickUp();
        someWeaponTwo.PickUp();
        someWeaponThree.PickUp();
        someWeapon.Reload();
        someWeaponTwo.Reload();
        someWeaponThree.Reload();
        Debug.Log("There is " + someWeapon.GetAmmo().ToString() + "ammo left in the LazerGun");
        Debug.Log("There is " + someWeaponTwo.GetAmmo().ToString() + "ammo left in the MachineGun");
        Debug.Log("There is " + someWeaponThree.GetAmmo().ToString() + "ammo left in the Pistol");
        someWeapon.Shoot();
        someWeaponTwo.Shoot();
        someWeaponThree.Shoot();
        Debug.Log(someWeapon.GetDescription() );
        Debug.Log(someWeaponThree.GetDescription());
        Debug.Log(someWeaponTwo.GetDescription());
        someWeapon.Drop();
        someWeaponTwo.Drop();
        someWeaponThree.Drop();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
