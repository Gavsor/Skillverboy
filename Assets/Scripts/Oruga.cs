using UnityEngine;
using System.Collections;

public class Oruga : MonoBehaviour {
	public bool Detecta;
	private Animator anim;


	void Awake(){
		anim = GetComponent<Animator>();

		
		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void  OnTriggerEnter2D(Collider2D coll)
	{
		
		anim.SetBool("Detecta",true);

	}
}
