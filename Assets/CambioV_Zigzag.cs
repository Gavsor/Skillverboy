using UnityEngine;
using System.Collections;

public class CambioV_Zigzag : MonoBehaviour {

	public movent PersonajeZigZag;

	// Use this for initialization
	void Start () {
		
		PersonajeZigZag.VelocidadX = 12;
		PersonajeZigZag.VelocidadY = 12;
	}
	
	// Update is called once per frame
	void Update () {


	}


	IEnumerator Espera()
	{
		PersonajeZigZag.VelocidadX = 30;
		PersonajeZigZag.VelocidadY = 30;
		yield return new WaitForSeconds(0.6f);
		PersonajeZigZag.VelocidadX = 12;
		PersonajeZigZag.VelocidadY = 12;
	}



	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
			
			StartCoroutine ("Espera");

		} 
		
		
		
		
	}
}
