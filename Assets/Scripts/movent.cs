 using UnityEngine;
using System.Collections;

public class movent : MonoBehaviour {

	
	public float VelocidadX;
	public float VelocidadY;

	//public float arriba = -13f;
	public Vector2 Direccion;
	
	private Vector2 Movimiento;
	
	private Rigidbody2D mRbd;
	public bool derecho;

	// Use this for initialization
	void Start () {
		
		mRbd = GetComponent<Rigidbody2D> ();
		derecho = true;
	}



	
	IEnumerator Espera()
	{	

		transform.rotation = Quaternion.Euler(0,0,40);
		transform.localScale = new Vector3(0.5f,0f,0.5f);

		yield return new WaitForSeconds(0.01f);

		transform.rotation = Quaternion.Euler(0,0,-40);
		transform.localScale = new Vector3(1f,1f,1f);



	
	}




	IEnumerator NoEspera()
	{	
		
		transform.rotation = Quaternion.Euler(0,0,-40);
		transform.localScale = new Vector3(0.5f,0f,0.5f);
		
		yield return new WaitForSeconds(0.01f);

		transform.rotation = Quaternion.Euler(0,0,40);
		transform.localScale = new Vector3(1f,1f,1f);




	}

	

	// Update is called once per frame
	void FixedUpdate () {
		
		Movimiento = new Vector2 (Direccion.x * VelocidadX, Direccion.y * VelocidadY);
		
		mRbd.velocity = Movimiento;
	}





	
	void Update () {



	

		
		if (Input.mousePosition.x < Screen.width / 2) {
			
			
			if (Input.GetMouseButtonDown(0)) {

			
				Direccion.x = 4f;
			

				Direccion.y = 0f;
					
				transform.rotation = Quaternion.Euler(0,0,0);
					
				}

			
		}else{
			
			
			if (Input.GetMouseButtonDown(0)) {
			//transform.rotation = Quaternion.Euler(0,0,25);
			

				if (derecho == true) {
					Direccion.x = 2;
					Direccion.y = -2;		
					StartCoroutine ("Espera");
				} else {
					
					Direccion.x = 2;
					Direccion.y = 2;
					StartCoroutine ("NoEspera");
				}



				derecho = !derecho;	
			//Direccion.y = 2;
				
				
			}
			
		}
		
		
		
		
		
	}
}