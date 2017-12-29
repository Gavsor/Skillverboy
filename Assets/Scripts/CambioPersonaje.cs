using UnityEngine;
using System.Collections;

public class CambioPersonaje : MonoBehaviour {

	public GameObject Humano;
	public GameObject Roboto;
	public CameraFollow  camerafollow;
	public Transform particula;
	public float particulasEn=1.9f;
	public float cambioEn= 5.3f;


	public GameObject camara ;





	// Use this for initialization
	void Start () {

		Humano.SetActive (true);
		Roboto.SetActive (false);




	}
	
	// Update is called once per frame
	void Update () {


	}


	void OnTriggerEnter2D(Collider2D cambio){
				if (cambio.tag == "Player") {





			Invoke("particulas",particulasEn);

			Humano.SetActive (false);


			Invoke("cambio",cambioEn);




				}
		}


	void particulas(){
	
		Instantiate(particula, transform.position, transform.rotation);
	}



	void cambio(){


		Roboto.SetActive (true);	
		
		
		camerafollow.playe = false;		

	}




	
}
