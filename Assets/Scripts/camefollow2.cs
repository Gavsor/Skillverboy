using UnityEngine;
using System.Collections;

public class camefollow2 : MonoBehaviour {
	
	private Vector2 velocity;
	
	public float smoothTimeY;
	public float smoothTimeX;
	
	
	public GameObject player;
	
	
	public Transform velozity;
	
	public bool bounds;
	
	public Vector3 minCameraPos;
	
	public Vector3 maxCameraPos;
	
	public float separacion = 3f;
	
	public float separacion1 = 0f;
	
	public float separacionveloz = 10f;
	
	public bool playe;
	
	
	public AudioClip myClip;
	
	// Use this for initialization
	void Start () {
		
		
		
		//audio.PlayOneShot(myClip);
		audio.clip = myClip;
		audio.Play ();
		playe = true;
		
		//player = GameObject.FindGameObjectWithTag ("Player");
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (playe == true) {
			
			
			float posX = Mathf.SmoothDamp (transform.position.x, player.transform.position.x + separacion, ref velocity.x, smoothTimeX);
			float posY = Mathf.SmoothDamp (transform.position.y, player.transform.position.y + separacion1 , ref velocity.y, smoothTimeY);
			
			
			transform.position = new Vector3 (posX, posY, transform.position.z);
			
			if (bounds) {
				
				transform.position = new Vector3 (Mathf.Clamp (transform.position.x, minCameraPos.x, maxCameraPos.x),
				                                  Mathf.Clamp (transform.position.y, minCameraPos.y, maxCameraPos.y),
				                                  Mathf.Clamp (transform.position.z, minCameraPos.z, maxCameraPos.z));
			}

			
			
		} 
		
		
		
		
		
		
		if (playe == false) {
			
			
			float posX = Mathf.SmoothDamp (transform.position.x, velozity.transform.position.x + separacionveloz, ref velocity.x, smoothTimeX);
			float posY = Mathf.SmoothDamp (transform.position.y, transform.position.y , ref velocity.y, smoothTimeY);
			
			
			transform.position = new Vector3 (posX, posY, transform.position.z);
			
			if (bounds) {
				
				transform.position = new Vector3 (Mathf.Clamp (transform.position.x, minCameraPos.x, maxCameraPos.x),
				                                  Mathf.Clamp (transform.position.y, minCameraPos.y, maxCameraPos.y),
				                                  Mathf.Clamp (transform.position.z, minCameraPos.z, maxCameraPos.z));
			}
			
			
			
			
			
			
			
			
			
		}
		
		
		
	}
	
	
	
	
	
}
