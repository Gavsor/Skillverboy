using UnityEngine;
using System.Collections;

public class SaltoAlto : MonoBehaviour {

	public ControladorPersonaje controladorpersonaje ;
	private Animator animator;


	void Awake(){
		animator = GetComponent<Animator>();
		
		
		
	}
	// Use this for initialization
	void Start () {
	

		animator.SetBool ("impulsorActivado", false);
	}


	IEnumerator ColliderActivate()
	{	
		
		controladorpersonaje.fuerzaSalto= 60f;
		yield return new WaitForSeconds(0.30f);
		controladorpersonaje.fuerzaSalto= 42f;
	}


	// Update is called once per frame
	void Update () {
	
			
	}

	void OnTriggerEnter2D(Collider2D cambio){
		if (cambio.tag == "Player") {
			
			StartCoroutine ("ColliderActivate");
			animator.SetBool ("impulsorActivado", true);
			controladorpersonaje.rigidbody2D.velocity = new Vector2 (controladorpersonaje.rigidbody2D.velocity.x, controladorpersonaje.fuerzaSalto);
			
		}
	}
}
