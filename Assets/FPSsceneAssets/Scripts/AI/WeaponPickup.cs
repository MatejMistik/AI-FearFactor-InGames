using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public Transform Player;
    ActiveWeapon activeWeapon;
    public RayCastWeapon weaponPrefab;
    private bool weaponPicked;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        activeWeapon = other.gameObject.GetComponentInParent<ActiveWeapon>();
        if (activeWeapon && !weaponPicked)
        {
            RayCastWeapon newWeapon = Instantiate(weaponPrefab);
            newWeapon.player = Player;
            activeWeapon.Equip(newWeapon);
            weaponPicked = true;
            enabled = false;
           
        }
    }
}