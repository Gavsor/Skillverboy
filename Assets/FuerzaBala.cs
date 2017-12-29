using UnityEngine;
using System.Collections;

public class FuerzaBala : MonoBehaviour {

	public float fuerzabala_X;
	public float fuerzabala_Y;
	public Rigidbody2D rig;


	//Use this for initialization
	void Start () {
		rig.AddForce (new Vector3(fuerzabala_X,fuerzabala_Y,0));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
