using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponHandler : MonoBehaviour
{
    [SerializeField] private GameObject weaponLogicLeft;
    [SerializeField] private GameObject weaponLogicRight;

    public void EnableWeaponLeft()
    {
        weaponLogicLeft.SetActive(true);
    }

    public void DisableWeaponLeft()
    {
        weaponLogicLeft.SetActive(false);
    }

    public void EnableWeaponRight()
    {
        weaponLogicRight.SetActive(true);
    }

    public void DisableWeaponRight()
    {
        weaponLogicRight.SetActive(false);
    }
}
