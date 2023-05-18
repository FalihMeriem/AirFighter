using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
      //public GameObject Coin;
    // private bool canShoot = true;

    private void FixedUpdate()
    {
        
            Instantiate(gameObject, transform.position, Quaternion.identity);
           
            // canShoot = false;
            // StartCoroutine(ResetShoot());
        
    }

    // private IEnumerator ResetShoot()
    // {
    //     yield return new WaitForSeconds(0.2f); // Adjust this delay as needed
    //     canShoot = true;
    // }
}
