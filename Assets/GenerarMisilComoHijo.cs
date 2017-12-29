using UnityEngine;
using System.Collections;

public class GenerarMisilComoHijo : MonoBehaviour {
	public float tiempomin;
	public float tiempomax;
	public float TiempoAGenerar;
	
	public GameObject Misil;
	public GameObject padre;
	// Use this for initialization
	void Start () {
		Invoke("Generar",TiempoAGenerar);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Generar(){
		
		//Instancia el objeto como hijo del otro objeto
		GameObject objetoHijo = Instantiate(Misil) as GameObject;
		
		objetoHijo.transform.parent = padre.transform;
		objetoHijo.transform.position = padre.transform.position;
		
		//Genera mas alarmas
		
		Invoke ("Generar", Random.Range (tiempomin, tiempomax));
		
		
		
	}
}
