using UnityEngine;
using System.Collections;

public class Empujar : MonoBehaviour {

	public ControladorPersonaje personaje;
	public GameObject humano;
	public float velocidadEmpuje = 70f;
	public float direccionn = 1f;

	private Animator animator;
	// Use this for initialization


	void Awake(){
		
		animator = GetComponent<Animator> ();
		animator.SetBool ("AumentaVelocidad", false);
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			

		



	}

	IEnumerator Espera()
	{	
		
		animator.SetBool ("AumentaVelocidad", true);
		personaje.velocidad = velocidadEmpuje;
		yield return new WaitForSeconds(0.5f);
		personaje.velocidad = 18f;
		humano.transform.localScale= new Vector3(1,1,1);
		animator.SetBool ("AumentaVelocidad", false);

	}


	void OnTriggerEnter2D(Collider2D other){
		
				if (other.tag == "Player") {


			humano.transform.localScale= new Vector3(direccionn,1,1);
			StartCoroutine ("Espera");
					
				}
		}
}
