using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float minX;
    public float maxX;
    
    public float minY;
    public float maxY;
  
    public float bulletSpeed;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);
        if(transform.position.y> maxY || transform.position.y< minY || transform.position.x<minX || transform.position.x>maxX)
        {
            Destroy(gameObject);
        }
    }


}
