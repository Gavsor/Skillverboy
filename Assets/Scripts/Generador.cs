using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Generador : MonoBehaviour {

	public GameObject[]obj; //Objeto a generar
	public float tiempomin = 1f;
	public float tiempomax = 2f;
	public float TiempoAGenerar = 2f;
	private bool fin = false;






	// Use this for initialization
	void Start () {

		//NotificationCenter.DefaultCenter().AddObserver(this,"PersonajeEmpiezaACorrer");
		//NotificationCenter.DefaultCenter().AddObserver(this,"PersonajeHaMuerto");


		Invoke("Generar",TiempoAGenerar);


	
	}


	void PersonajeHaMuerto(){

		fin = true;

		}

	







	// Update is called once per frame
	void Update () {
	
	}

	void Generar(){
		if (!fin) {
						


						Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
						Invoke ("Generar", Random.Range (tiempomin, tiempomax));
				}
	}






}
