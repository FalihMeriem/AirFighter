using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bullet;
    private bool canShoot = true;

    private void Update()
    {
        if (Input.GetButton("Fire1") && canShoot)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            canShoot = false;
            StartCoroutine(ResetShoot());
        }
    }

    private IEnumerator ResetShoot()
    {
        yield return new WaitForSeconds(0.2f); // Adjust this delay as needed
        canShoot = true;
    }
    
    
    // public GameObject bullet;

//     private void Update()
//     {
//         if(Input.GetButton("Fire1"))
//         {
//             Instantiate(bullet, transform.position, Quaternion.identity);
//         }
        
//     }
}
