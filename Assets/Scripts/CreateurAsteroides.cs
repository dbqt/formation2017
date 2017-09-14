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
		Invoke("CreerAsteroide", Random.Range(minTemps, maxTemps));
	}


    public void CreerAsteroide() {

        // Initialiser la position
        Vector3 position = Vector3.zero;
        int mur = Random.Range(0,3);
        switch (mur) {
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
        }

        // Creer l'asteroide
        Instantiate(AsteroidPrefab, position, Quaternion.identity);

        // Prochain appel de CreerAsteroide
        Invoke("CreerAsteroide", Random.Range(minTemps, maxTemps));
    }
}
