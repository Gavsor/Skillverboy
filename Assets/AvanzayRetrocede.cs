using UnityEngine;
using System.Collections;

public class AvanzayRetrocede : MonoBehaviour {

	public PlataformaMovil plataformamovil;
	Animator anim;

	public float DetieneVel = 5f;
	public float AnimacionParar = 4f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetBool ("RobotActivado", true);

	
	}
	
		
	void DetieneVelocidad(){

		plataformamovil.VelocidadH = 20;
		plataformamovil.SentidoH = DireccionH.Izquierda;

	}
	void AnimacionPara(){
	
		anim.SetBool ("RobotActivado", false);
	}



	// Update is called once per frame
	void Update () {

			anim.SetBool ("CorrienteDesactivada", true);
	}


	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
		
			Invoke ("DetieneVelocidad",DetieneVel);
			Invoke ("AnimacionPara",AnimacionParar);

		}
	}
}
