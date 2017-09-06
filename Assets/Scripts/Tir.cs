using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tir : MonoBehaviour {

    // Reference vers le prefab de l'objet projectile
    public GameObject PrefabProjectile;

    // Vitesse de deplacement, la valeur est donnee dans l'inspecteur
    public float VitesseDeTir;

	// Update is called once per frame
	void Update () {
        // Detection d'un click
		if (Input.GetButtonDown("Fire1"))
        {
            // Tracer une ligne (ray) de la camera
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            // Detection du point entre la ligne et une surface
            if (Physics.Raycast(ray, out hit))
            {
                // Calcul de la direction du tir
                Vector3 directionDeTir = (hit.point - this.transform.position);

                // Instanciation d'une projectile a la position de cet objet + direction du tir pour eviter de mettre la projectile dans le joueur
                GameObject nouveauProjectile = Instantiate(PrefabProjectile, this.transform.position + directionDeTir.normalized, Quaternion.identity) as GameObject;
                // Donner une vitesse a la projectile
                nouveauProjectile.GetComponent<Rigidbody>().velocity = directionDeTir.normalized * VitesseDeTir;

            }

        }
	}
}
