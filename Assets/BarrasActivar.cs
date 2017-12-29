using UnityEngine;
using System.Collections;

public class BarrasActivar : MonoBehaviour {

	public ActivarElectricidad ActivarElectricidad;
	public ActivarElectricidad ActivarElectricidad2;
	public ActivarBarra ActivarBarra;
	public ActivarBarra ActivaBarra2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
			
			
			ActivarBarra.BarraActivado = true;
			ActivaBarra2.BarraActivado = true;
	
			ActivarElectricidad.CorrienteActivada = true;
			ActivarElectricidad2.CorrienteActivada = true;
			
		}
		
		
		
	}
}
