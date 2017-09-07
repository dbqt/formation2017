using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    // Dectection de collision
    void OnCollisionEnter(Collision collision)
    {
        // Creer un tag
        // Si on a une collision avec autre chose qu'une projectile, autodestruction
        if (!collision.gameObject.CompareTag("Projectile"))
        {
            Destroy(this.gameObject);
        }
    }
}
