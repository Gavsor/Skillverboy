using UnityEngine;
using System.Collections;

public class PlataformaAparece : MonoBehaviour {

	public ColliderPlataforma ColliderPlataforma;


	public bool pisoaparece;


	private Camaleon camaleon;


	void awake(){
		camaleon = GetComponentInChildren<Camaleon>();
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



		if (pisoaparece == true) {
				
			ColliderPlataforma.PisoActivado = true;
		}

		if (pisoaparece == false) {
		
		
			ColliderPlataforma.PisoActivado = false;
		}








	
	}
	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
			
			
						pisoaparece = true;

			
				} else {
				
			pisoaparece = false;
		}




}
}
