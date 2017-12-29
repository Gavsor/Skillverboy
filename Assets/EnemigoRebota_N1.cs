	using UnityEngine;
using System.Collections;

public class EnemigoRebota_N1 : MonoBehaviour {

	public PlataformaMovil MovimientoDerecha;
	public PlataformaMovil MovimientoIzquierda;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
			StartCoroutine ("Accion");	
	
		}
	}


	IEnumerator Accion()
	{	
		MovimientoDerecha.enabled = true;
		yield return new WaitForSeconds(2f);
		transform.Rotate (0, 0, -70);
		MovimientoDerecha.enabled = false;
		MovimientoIzquierda.enabled = true;
		yield return new WaitForSeconds(0.6f);
		transform.Rotate (0, 0, 120);

		//https://www.youtube.com/watch?v=srxEGEiosUU
	}

}
