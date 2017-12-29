using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControladorAraña : MonoBehaviour {



	public float fuerzaSalto = 100f;

	public bool gravityNormal;


	public float fuerzaSalgoNegativo = -100f;
	private bool enSuelo = true;
	public Transform comprobadorSuelo;
	private float comprobadorRadio = 0.07f;
	public LayerMask mascaraSuelo;
	private bool corriendo = false;

	//private bool gravedadnoNormal = false;
	
	//private bool dobleSalto = false;
	public float velocidad = 1f;
	public bool slice = false;
	private Animator animator;
	
	public float fuerzaslice = -10f;
	
	public GameObject personaje;



	public GameObject Seguidme;





	//public Rigidbody2D mygravedad;



	public float VelocidadX;
	public float VelocidadY;
	
	//public float arriba = -13f;
	public Vector2 Direccion;
	
	private Vector2 Movimiento;











	public Transform ara;

	public float scal =  -1f;



	Animator anim;
	Rigidbody2D rb2d;
	
	public bool Deslizar;
	
	public float VelocidadNormal = 5f;
	public float VelocidadQuitaDeslizar = 0.1f;
	
	
	
	
	void Awake(){
		animator = GetComponent<Animator>();
		//mygravedad = GetComponent<Rigidbody2D>();
		
		
	}





	// Use this for initialization
	void Start () {
	

		rb2d = GetComponent<Rigidbody2D> ();
		gravityNormal = true;

		corriendo = true;
		
		NotificationCenter.DefaultCenter().PostNotification(this,"PersonajeEmpiezaACorrer");
		
		
		Deslizar = true;

		//gravedadnoNormal = false;
		
		
		anim = GetComponent<Animator>();
		//rigid = GetComponent<Rigidbody2D>();

	}

	void FixedUpdate(){
		
		if (corriendo) {
			rigidbody2D.velocity = new Vector2 (velocidad, rigidbody2D.velocity.y);
			
			
			
		}


		
	




		
		
		
		animator.SetFloat ("VelX", rigidbody2D.velocity.x);
		enSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
		animator.SetBool("isGrounded", enSuelo);
		
		
		
	}


	IEnumerator DetieneLuz(){
		
		Seguidme.SetActive (false);
		yield return new WaitForSeconds (0.7f);
		Seguidme.SetActive (true);
		
		
	}


	IEnumerator Espera()
	{	
		
		anim.SetBool("Dezlizar",true);
		yield return new WaitForSeconds(1);
		anim.SetBool("Dezlizar", false);
	}

	
	// Update is called once per frame
	void Update () {
			
		//Deslizar = anim.GetBool("Dezlizar");

		if (Input.mousePosition.x < Screen.width / 2) {

						if (enSuelo && Input.GetMouseButtonDown (0)) {


			

								rb2d.gravityScale = -rb2d.gravityScale;
								gravityNormal = !gravityNormal;

								if (gravityNormal) {
									//	rb2d.velocity = Vector2.up * fuerzaSalto;
										personaje.transform.localScale = new Vector3 (1.2F, 1.2F, 1.2F);

				
										
								}



								if (!gravityNormal) {
				
				
										personaje.transform.localScale = new Vector3 (1.2F, -1.2F, 1.2F);
					//rb2d.velocity = -Vector2.up * fuerzaSalto;
								}

						}
	
				} else {

		

						if (enSuelo && Input.GetMouseButton (0)) {

							

			




								if (gravityNormal) {


										rb2d.velocity = Vector2.up * fuerzaSalto;
		
								} else {
										rb2d.velocity = -Vector2.up * fuerzaSalto;


				
								}




						

							
			
						}
				}


	}
}
