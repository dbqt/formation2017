using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour {

    // Vitesse de deplacement, la valeur est donnee dans l'inspecteur
    public float Vitesse;
	
	// Update is called once per frame
	void Update () {
        // Lire les entrees
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Creer un vecteur de direction de deplacement
        Vector3 deplacement = new Vector3(horizontal, 0f, vertical);

        // Appliquer le deplacement sur le transform de cet objet.
        this.gameObject.transform.Translate(deplacement * Vitesse * Time.deltaTime);
    }
}
