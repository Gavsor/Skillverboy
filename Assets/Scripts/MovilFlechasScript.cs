using UnityEngine;
using System.Collections;

public class MovilFlechasScript : MonoBehaviour {
public Vector2 velocidadd = new Vector2(50,50);
private Vector2 movimiento;

//	void Update(){
	
	
//		float inputX = Input.GetAxis ("Horizontal");
//		float InputY = Input.GetAxis ("Vertical");

//		movimiento = new Vector2 (velocidadd.x * inputX,
		        //                 velocidadd.y * InputY);
//}


	//void FixedUpdate(){
	
//		rigidbody2D.velocity = movimiento;
//	}

	public bool hola;



	public float fuerzaSalto = 100f;
	private bool enSuelo = true;
	public Transform comprobadorSuelo;
	float comprobadorRadio = 0.07f;
	public LayerMask mascaraSuelo;
	private Animator animator;
	
	private bool corriendo = false;
	public float velocidad = 1f;
	
	
	Rigidbody2D rb2d;
	
	
	
	
	void Awake(){
		
		animator = GetComponent<Animator> ();
	}
	
	// Use this for initialization
	void Start () {
		corriendo = true;
		rb2d = GetComponent<Rigidbody2D> ();
		
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
		
		
		
		
		
		if (Input.mousePosition.x < Screen.width / 2) {
			
			if (Input.GetMouseButton (0)) {
				

				if(Input.GetAxisRaw("Vertical")> 0){
				
				}

				//rigidbody2D.AddForce (new Vector2 (0, -fuerzaSalto));
				
			}
			
		}else {
			
			
			
			if (Input.GetMouseButton (0)) {
				
				
				
				
				
				rigidbody2D.AddForce (new Vector2 (0, fuerzaSalto));
				
				
				
				
				
			}
			
			
			
			
			
			
			
			
			
			
		}
		
	}

}
