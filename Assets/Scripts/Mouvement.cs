using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour {

    // Vitesse de deplacement, la valeur est donnee dans l'inspecteur
    public float Vitesse;

    public float minX, maxX, minZ, maxZ;
	
	// Update is called once per frame
	void Update () {
        // Lire les entrees
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Creer un vecteur de direction de deplacement
        Vector3 deplacement = new Vector3(horizontal, 0f, vertical);

        // Appliquer le deplacement sur le transform de cet objet.
        this.gameObject.transform.Translate(deplacement * Vitesse * Time.deltaTime);

        // Prendre les bornes et appliquer la teleportation
        Vector3 currentPos = this.gameObject.transform.position;
        if (currentPos.x < minX) currentPos.x = maxX;
        if (currentPos.x > maxX) currentPos.x = minX;
        if (currentPos.z < minZ) currentPos.z = maxZ;
        if (currentPos.z > maxZ) currentPos.z = minZ;
        this.gameObject.transform.position = currentPos;
    }
}
