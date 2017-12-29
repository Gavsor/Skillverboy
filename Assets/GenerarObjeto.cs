using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerarObjeto : MonoBehaviour {


	public GameObject alarma;

	public GameObject padre;


	public float tiempomin;
	public float tiempomax;
	public float TiempoAGenerar;


	public CameraFollow camera;

	public Transform padree;

	public GenerarObjeto generarObjeto;

	// Use this for initialization
	void Start () {

		Invoke("Generar",TiempoAGenerar);
		

	}
	
	// Update is called once per frame
	void Update () {
		if (generarObjeto.enabled == false) {

			Destroy(alarma);
			Debug.Log("Destruido");
		
		}
	}


	void Generar(){
		
		//Instancia el objeto como hijo del otro objeto
		GameObject objetoHijo = Instantiate(alarma) as GameObject;

		objetoHijo.transform.parent = padre.transform;
		objetoHijo.transform.position = padre.transform.position;
						
		//Genera mas alarmas
						
		Invoke ("Generar", Random.Range (tiempomin, tiempomax));


	
	}
}
