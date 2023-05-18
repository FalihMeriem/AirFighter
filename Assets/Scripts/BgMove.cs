using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMove : MonoBehaviour
{
 public Renderer meshRender;
 public float bgSpeed=0.1f;

 private void Update(){
    meshRender.material.mainTextureOffset += new Vector2(0, bgSpeed*Time.deltaTime);
 }

}
