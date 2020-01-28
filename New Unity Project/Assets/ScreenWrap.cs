﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
 public float maxX = 10;
 public float minX = -10;
 public float maxZ = 10;
 public float minZ = -10;
void Start(){
}


    void Update(){

Vector3 oldPos = transform.position;

if (transform.position.x > maxX) {
    transform.position = new Vector3(minX, oldPos.y, oldPos.z);
}

if (transform.position.x < minX) {
    transform.position = new Vector3(maxX, oldPos.y, oldPos.z);
}

if (transform.position.z > maxZ) {
    transform.position = new Vector3(oldPos.x, oldPos.y, minZ);
}

if (transform.position.z < minZ) {
    transform.position = new Vector3(oldPos.x, oldPos.y, maxZ);
}
}
}
