using UnityEngine;
using System.Collections;

public class ColliderPlataforma : MonoBehaviour {
	public bool PisoActivado;
	public GameObject Objeto;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
			
		if (PisoActivado == true) {


			Objeto.collider2D.enabled = true;
				
		} 



		if (PisoActivado == false) {
			Objeto.collider2D.enabled = false;

		}



	}
}
