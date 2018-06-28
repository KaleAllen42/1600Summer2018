using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAmmo : MonoBehaviour
{

   
    public List<GameObject> Ammo;
   
    	

	private void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < Ammo.Count; i++)
            {
              Ammo[i].SetActive((true));
            }
            
            //Instantiate(Ammo);
        }       
	}
}
