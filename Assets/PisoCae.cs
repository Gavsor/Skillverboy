using UnityEngine;
using System.Collections;

public class PisoCae : MonoBehaviour {

	Rigidbody2D rb2d;
	public float grabedad = 5f;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D cambio){
		
		if (cambio.tag == "Player") {
			
			rb2d.gravityScale = grabedad;

		}
		
	}
}
