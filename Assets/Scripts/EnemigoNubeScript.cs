using UnityEngine;
using System.Collections;

public class EnemigoNubeScript : MonoBehaviour {



	private ArmaScript arma;
	private EnemigoNubeScript nube;

	void Awake()

	{
		arma = GetComponentInChildren<ArmaScript> ();

		nube = GetComponentInChildren<EnemigoNubeScript>();
		}


	void Start () {

		//arma.Ataque(true);			
		nube.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (arma != null && arma.PuedeAtacarr)
		{
			arma.Ataque(true);
			}	

	}


	void OnTriggerEnter2D(Collider2D cambio){
	if (cambio.tag == "Player") {
		
			
			nube.enabled = true;
			
			
	}
	}




}
