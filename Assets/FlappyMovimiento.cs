using UnityEngine;
using System.Collections;

public class FlappyMovimiento : MonoBehaviour {

	Vector3 velocity = Vector3.zero;

	private bool corriendo = false;
	Rigidbody2D rb2d;
	public float flapSpeed = 400f;
	float forwardSpeed = 5f;
	public float velocidad = 30f;
	private Animator animator;

	bool didFlap = false;




	void Awake(){
		animator = GetComponent<Animator>();
		
		
	}

	// Use this for initialization
	void Start () {
		corriendo = true;
		rb2d = GetComponent<Rigidbody2D> ();

	}



	IEnumerator Espera()
	{	
		


	
		flapSpeed = 1000f;
		rb2d.gravityScale = 7f;
		transform.localScale = new Vector3(0.5f,0.5f,0);
		yield return new WaitForSeconds(6);
		transform.localScale = new Vector3(1f,1f,1f);
		flapSpeed = 1800f;
		rb2d.gravityScale = 9f;
	
	}




	// Update is called once per frame
	void Update () {

		if (Input.mousePosition.x < Screen.width / 2) {


			if (Input.GetMouseButtonDown(0)) {
				
				StartCoroutine ("Espera");
					
					
				}

	
		}else{


			if (Input.GetMouseButtonDown(0)) {


			didFlap = true;
				
			}
		
			}


	
	}


	void FixedUpdate(){
			
		rigidbody2D.AddForce (Vector2.right * forwardSpeed);


		if (corriendo) {
			rigidbody2D.velocity = new Vector2 (velocidad, rigidbody2D.velocity.y);
		}




		if (didFlap) {
			rigidbody2D.AddForce(Vector2.up * flapSpeed);

			didFlap = false;	
		}


		if (rigidbody2D.velocity.y > 0) {
			
			transform.rotation = Quaternion.Euler(0,0,0);


			
		} else {
			float angle = Mathf.Lerp(0,-10f, (-rigidbody2D.velocity.y /20f)); // velocidad para rotation

			transform.rotation = Quaternion.Euler(0,0,angle);

		}
		
		
	}


		

}

