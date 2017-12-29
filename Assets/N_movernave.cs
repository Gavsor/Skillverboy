using UnityEngine;
using System.Collections;

public class N_movernave : MonoBehaviour {
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	// Use this for initialization

	public float fuerzaSalto ;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.mousePosition.x > Screen.width / 2) {
			
			
			if (Input.GetMouseButton(0)) {
				//transform.RotateAround (PuntoEje.transform.position, Vector3.back, -direccion * Time.deltaTime);
				
				fuerzaSalto += 0.1f;
				rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, fuerzaSalto);
				
				
			}else{
				
				fuerzaSalto =1f;
			}
			
		}else{

			
			
		}
	}
}
