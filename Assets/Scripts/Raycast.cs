using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {



	// Use this for initialization

	private Camaleon camaleon;
	
	void awake(){
		camaleon = GetComponentInChildren<Camaleon>();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool scared = Physics2D.Raycast(transform.position, new Vector2 (0, -13f), 13f, 1 << LayerMask.NameToLayer ("ovni"));
		Debug.DrawRay (transform.position, new Vector2 (0, -13), Color.magenta);
		if (scared) {
		
				Debug.Log ("hay");
		
			//camaleon.StopCoroutine("ColliderActivate");
				} else {
						
		
				}


	}
}
