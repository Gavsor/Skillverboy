using UnityEngine;
using System.Collections;

public class CambiaVelocidad : MonoBehaviour {


	public ControladorAndroide controladorandroide;

	public float velocidadcambiada = 35f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
			

			controladorandroide.velocidad = velocidadcambiada;
			
			
			
		}
	}



}
