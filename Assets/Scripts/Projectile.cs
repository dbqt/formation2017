using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    // Dectection de collision
    void OnTriggerEnter(Collider other)
    {
        // Creer un tag "Asteroide"
        // Si on a une collision avec une asteroide, detruire l'asteroide
        //...

        // Si on a une collision avec autre chose qu'une projectile, autodestruction
        /*if (!other.gameObject.CompareTag("Projectile"))
        {
            Destroy(this.gameObject);
        }*/
    }

}
