﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour {

    public float speedMax = 1f;
    public float minX, maxX, minZ, maxZ;

	// Use this for initialization
	void Start () {
        // Creer une vitesse en x,z random et l'appliquer au rigidbody
        // ...
	}
	
	// Update is called once per frame
	void Update () {
		// Prendre les bornes et appliquer la teleportation
        /*Vector3 currentPos = this.gameObject.transform.position;
        if (currentPos.x < minX) currentPos.x = maxX;
        if (currentPos.x > maxX) currentPos.x = minX;
        if (currentPos.z < minZ) currentPos.z = maxZ;
        if (currentPos.z > maxZ) currentPos.z = minZ;
        this.gameObject.transform.position = currentPos;*/
	}
}
