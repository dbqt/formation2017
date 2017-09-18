using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vie : MonoBehaviour {

    public int nombreViesDepart = 3;

    public int viesRestantes;

    // References pour les collisions
    private bool collided;
    private GameObject collidedObject;

	// Use this for initialization
	void Start () {
        // Initialiser les valeurs de depart
		viesRestantes = nombreViesDepart;
        collided = false;
	}

    void Update() {
        // S'il y a une collision
        if(collided) 
        {
            // Reduire le nombre de vies
            // ...

            // Si l'objet de collision n'est pas nul, la détuire
            if (collidedObject != null)
            { 
                // ...
            }

            // using Unity.Engine.SceneManagement, load 
            if (viesRestantes <= 0) {
                //...

            }

            // mettre collided = false apres avoir faire le traitement
            collided = false;
        }
    }

    // Detection de collision
	void OnTriggerEnter(Collider other) {
        // si le joueur entre en collision avec un asteroide
        if (other.gameObject.CompareTag("Asteroide"))
        {
            // mettre une reference vers l'objet a collisionner
            //collidedObject = other.gameObject;
            collided = true;
        }
    }
}
