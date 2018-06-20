using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsEnums : MonoBehaviour {

      public enum WeaponType
       {
              Axe,
              Club,
              Sword,
              Spear,
              Scimitar,
              SingleSaber,
              DoubleSidedSaber,
              DualSaber,
           
              
       }

    public WeaponObject[] WeaponObjects;
    public WeaponType CurrentWeapon;

    void Update()
    {
        switch (CurrentWeapon)
        {
            case WeaponType.DoubleSidedSaber:
                Debug.Log(WeaponObjects[0].name);
                Debug.Log(WeaponObjects[0].DoDamage());
                break;
            case WeaponType.DualSaber:
                Debug.Log(WeaponObjects[1].name);
                Debug.Log(WeaponObjects[1].DoDamage());
                break;
            case WeaponType.SingleSaber:
                Debug.Log(WeaponObjects[2].name);
                Debug.Log(WeaponObjects[2].DoDamage());
                break;
            case WeaponType.Axe:
                Debug.Log(WeaponObjects[3].name);
                Debug.Log(WeaponObjects[3].DoDamage());
                break;
            case WeaponType.Club:
                Debug.Log(WeaponObjects[4].name);
                Debug.Log(WeaponObjects[4].DoDamage());
                break;
            case WeaponType.Scimitar:
                Debug.Log(WeaponObjects[5].name);
                Debug.Log(WeaponObjects[5].DoDamage());
                break;
            case WeaponType.Spear:
                Debug.Log(WeaponObjects[6].name);
                Debug.Log(WeaponObjects[6].DoDamage());
                break;
            case WeaponType.Sword:
                Debug.Log(WeaponObjects[7].name);
                Debug.Log(WeaponObjects[7].DoDamage());
                break;
        }
    }
    
}
