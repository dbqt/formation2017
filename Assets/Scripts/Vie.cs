using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vie : MonoBehaviour {

    public int nombreViesDepart = 3;

    public int viesRestantes;

    private bool collided;
    private GameObject collidedObject;

	// Use this for initialization
	void Start () {
		viesRestantes = nombreViesDepart;
        collided = false;
	}

    void Update() {
        if(collided) 
        {
            viesRestantes--;
            if (collidedObject != null)
            { 
                Destroy(collidedObject);
            }

            if (viesRestantes <= 0) {
                Debug.Log("Game over!");
                SceneManager.LoadScene("main");

            }
            collided = false;
        }
    }

    // Detection de collision avec le joueur
	void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Asteroide"))
        {
            collidedObject = other.gameObject;
            collided = true;
        }
    }
}
