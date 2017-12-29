using UnityEngine;
using System.Collections;

public class MurcielagoPisado : MonoBehaviour {

	public bool Pisando;
	private Animator animator;
	Rigidbody2D rb2d;
	// Use this for initialization

	void Awake(){
		animator = GetComponent<Animator>();
		
		
	}

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll)
	{

		animator.SetBool("Pisando",true);
		rb2d.gravityScale = 10f;
	}
}
