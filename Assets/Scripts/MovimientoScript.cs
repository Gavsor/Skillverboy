using UnityEngine;
using System.Collections;

public class MovimientoScript : MonoBehaviour {


	public Vector2 velocidad = new Vector2(5,5);

	private Vector2 movimiento;

	public Vector2 direccion = new Vector2(-1,0);

	


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			
				movimiento = new Vector2 (

			velocidad.x * direccion.x,
			velocidad.y * direccion.y);

		}

	void FixedUpdate(){
		
		rigidbody2D.velocity = movimiento;
		}
	
	}

