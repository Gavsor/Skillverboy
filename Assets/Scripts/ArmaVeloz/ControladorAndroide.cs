using UnityEngine;
using System.Collections;

public class ControladorAndroide : MonoBehaviour {

	public float fuerzaSalto = 100f;
	private bool enSuelo = true;
	public Transform comprobadorSuelo;
	float comprobadorRadio = 0.07f;
	public LayerMask mascaraSuelo;
	private Animator animator;
	
	private bool corriendo = false;
	public float velocidad = 1f;


	Rigidbody2D rb2d;


	public bool Volteado;
	public bool Voltear;
	
	void Awake(){
		
		animator = GetComponent<Animator> ();
	}
	
	// Use this for initialization
	void Start () {
		corriendo = true;
		rb2d = GetComponent<Rigidbody2D> ();
		Volteado = false;

		Voltear = false;
	
	}
	
	void FixedUpdate(){
		
		if (corriendo) {
			rigidbody2D.velocity = new Vector2(velocidad,rigidbody2D.velocity.y);
		}
		
		animator.SetFloat ("VelX", rigidbody2D.velocity.x);
		enSuelo = Physics2D.OverlapCircle (comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
		animator.SetBool ("isGrounded", enSuelo);
		
		
	}
	// Update is called once per frame
	void Update () {


		if (Voltear == true) {	
						
			animator.SetBool ("Volteado", true);
			Debug.Log("Volteooo");

				} else {
	
			animator.SetBool ("Volteado", false);
			Debug.Log("Normal");
		}





		if (Input.mousePosition.x < Screen.width / 2) {


			
			
			if (Input.GetMouseButtonDown (0)) {
				
				
				Voltear=!Voltear;
				

				
			}
			
			
		}else {



			if (Input.GetMouseButton (0)) {
				
				rb2d.gravityScale = 0f;
				rb2d.mass = 0.2f;


				rigidbody2D.AddForce (new Vector2 (0, fuerzaSalto));


						}else{
				
					rb2d.gravityScale = 8f;
					rb2d.mass = 4f;


				
				
			}





		
		
				

		
	}
	
}
}
