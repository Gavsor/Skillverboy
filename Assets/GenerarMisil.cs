using UnityEngine;
using System.Collections;

public class GenerarMisil : MonoBehaviour {
	
	public float tiempomin;
	public float tiempomax;
	public float TiempoAGenerar;

	public GameObject Misil;

	// Use this for initialization
	void Start () {
		Invoke("Generar",TiempoAGenerar);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void Generar(){
		
		
		

		
		Instantiate (Misil,transform.position,transform.rotation);
		Invoke ("Generar", Random.Range (tiempomin, tiempomax));
		
		Debug.Log ("Generado");
		
		
	}
}
