using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float PlayerSpeed;

    public float minX;
    public float maxX;
    
    public float minY;
    public float maxY;
  

    // Update is called once per frame
    void Update()
    {
       float moveX = Input.GetAxis("Horizontal")  * Time.deltaTime * PlayerSpeed;
       float moveY = Input.GetAxis("Vertical")  * Time.deltaTime * PlayerSpeed;
        
        float newX = Mathf.Clamp(transform.position.x + moveX, minX, maxX);
        float newY = Mathf.Clamp(transform.position.y + moveY, minY, maxY);

        transform.position = new Vector2(newX, newY);
    }
}
