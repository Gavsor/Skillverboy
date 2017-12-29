	using UnityEngine;
using System.Collections;

public class FlappyControlador : MonoBehaviour {

	private bool isDead;
	private Rigidbody2D rb2d;
	public float upForce = 200f;
	// Use this for initialization


	void Awake(){

		rb2d = GetComponent<Rigidbody2D>();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isDead == false) {
			if(Input.GetMouseButtonDown(0))
			{
			
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce(new Vector2(0, upForce));
			}
			
		
		}

	}
}
