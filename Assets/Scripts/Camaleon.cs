using UnityEngine;
using System.Collections;

public class Camaleon : MonoBehaviour {

	
	public float fuerzaSalto = 100f;
	private bool enSuelo = true;
	public Transform comprobadorSuelo;
	private float comprobadorRadio = 0.07f;
	public LayerMask mascaraSuelo;
	


	
	private bool corriendo = false;
	
	//private bool dobleSalto = false;
	public float velocidad = 1f;
	public bool slice = false;
	private Animator animator;
	
	public float fuerzaslice = -10f;
	
	
	
	
	private PlataformaAparece plataformaaparece;
	

		
	
	Animator anim;
	//Rigidbody2D rigid;
	
	public bool Deslizar;
	
	public float VelocidadNormal = 5f;
	public float VelocidadQuitaDeslizar = 0.1f;
	
	
	
	
	
	void Awake(){
		animator = GetComponent<Animator>();

			
		
	}
	
	// Use this for initialization
	void Start () {
		corriendo = true;
		
		NotificationCenter.DefaultCenter().PostNotification(this,"PersonajeEmpiezaACorrer");
	
		
		Deslizar = true;
		
		
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
	

	
	IEnumerator ColliderActivate()
	{	
		

		collider2D.enabled = false;
		yield return new WaitForSeconds(0.28f);
		collider2D.enabled = true;
	
	}

	IEnumerator ColliderActivate2()
	{	
		
		rigidbody2D.gravityScale = 28;
		collider2D.enabled = false;
		yield return new WaitForSeconds(0.20f);
		collider2D.enabled = true;
		rigidbody2D.gravityScale = 18;
	}
	
	void Update () {
		
		Deslizar = anim.GetBool("Dezlizar");
		plataformaaparece = GameObject.Find ("Plataforma").GetComponent<PlataformaAparece> ();
		//colliderplataforma = GetComponent<ColliderPlataforma>();
		if (Input.mousePosition.x < Screen.width / 2) {
						bool scared = Physics2D.Raycast (transform.position, new Vector2 (0, -33f), 33f, 1 << LayerMask.NameToLayer ("ovni"));
						Debug.DrawRay (transform.position, new Vector2 (0, -33), Color.magenta);

						if (scared == true) {
								animator.SetBool ("SaltoArriba", false);
								Debug.Log ("hay objeto abajo");
								if (enSuelo && Input.GetMouseButton (0)){
										StartCoroutine ("ColliderActivate2");
										}
								} else {
								
										Debug.Log ("no hay objeto abajo");
								}

			} else {

						bool scared2 = Physics2D.Raycast (transform.position, new Vector2 (0, 33f), 33f, 1 << LayerMask.NameToLayer ("ovni"));
						Debug.DrawRay (transform.position, new Vector2 (0, 33), Color.magenta);

						if (scared2 == false) {		
							animator.SetBool ("SaltoArriba", false);
								if (enSuelo && Input.GetMouseButton (0)) {
	
								StartCoroutine ("ColliderActivate");
								rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, fuerzaSalto);

								Debug.Log ("no hay objeto arriba");
								}

							}else{
									

										Debug.Log (" hay objeto arriba");
								if (enSuelo && Input.GetMouseButton (0)) {
									animator.SetBool ("SaltoArriba", true);

										StartCoroutine ("ColliderActivate");
										rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, fuerzaSalto);
				
								}
			
						}
		
		
				}
		
		
	}		
	
	
	
}
