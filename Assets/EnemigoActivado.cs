using UnityEngine;
using System.Collections;

public class EnemigoActivado : MonoBehaviour {


	public GameObject robotActivado;

	// Use this for initialization
	void Start () {

	

		robotActivado.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
			robotActivado.SetActive (true);
		}
}
}