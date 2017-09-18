using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateurAsteroides : MonoBehaviour {

    public float minX, maxX, minZ, maxZ;

    [Header("Temps entre la creation d'asteroide")]
    public float minTemps;
    public float maxTemps;

    public GameObject AsteroidPrefab;

	// Use this for initialization
	void Start () {

        // Premier appel pour creer un asteroide
		//Invoke("CreerAsteroide", Random.Range(minTemps, maxTemps));
	}


    public void CreerAsteroide() {

        // Initialiser la position
        // Creer un vecteur zero
        // ...

        // Choisir un mur au hasard entre 0 et 3
        // ...

        // Faire un switch sur le mur et appliquer les positions
        /*switch (mur) {
            case 0:
                position.x = Random.Range(minX, maxX);
                position.z = minZ;
                break;
            case 1:
                position.x = Random.Range(minX, maxX);
                position.z = maxZ;
                break;
            case 2:
                position.x = minX;
                position.z = Random.Range(minZ, maxZ);
                break;
            default:
                position.x = maxX;
                position.z = Random.Range(minZ, maxZ);
            break;
        }*/

        // Creer l'asteroide avec Instantiate et la nouvelle position
        // ...

        // Prochain appel de CreerAsteroide apres un temps random
        // ...
    }
}
