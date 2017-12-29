using UnityEngine;
using System.Collections;

public class DisparandoAmigo : MonoBehaviour {

	public GameObject particula;

	public ActivarDisparoAmigo ActivarDisparoAmigo;

	// Use this for initialization
	void Start () {
		ActivarDisparoAmigo.disparo = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
			
			ActivarDisparoAmigo.disparo=true;
			particula.particleSystem.startSpeed = 20f;
			particula.particleSystem.startSize = 8f;
			//particula.particleSystem.startColor = Color.yellow;

			
		}

}

}