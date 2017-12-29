using UnityEngine;
using System.Collections;

public class DobleSalto : MonoBehaviour {

	public ControladorPersonaje controladorPersonaje;
	public GameObject Particula;
	public GameObject Particula2;
	public GameObject Onda;
	public GameObject laser;

	// Use this for initialization
	void Start () {
		controladorPersonaje.DOBLESALTO = false;
		Onda.SetActive (false);
		laser.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
			

			controladorPersonaje.DOBLESALTO = true;
			Destroy(Particula);
			Particula2.particleSystem.startColor = Color.green;
			Onda.SetActive(true);
			laser.SetActive(true);
		} else {
			

		}
		
		
		
		
	}

}
