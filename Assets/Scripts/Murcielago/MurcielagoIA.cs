using UnityEngine;
using System.Collections;

public class MurcielagoIA : MonoBehaviour {

	public Transform batHome;
	private Transform player;
	private Vector3 positionPlayerLost;
	private Vector3 positionPlayerFind;
	private Transform bat;
	
	public  float speed;
	private float startTime;
	private float journeyLenght; 
	
	public bool lostPlayer = true;
	public bool canFly = false;
	
	// Use this for initialization
	void Start () {
		
		//GetComponentInParent<Transform> ();
		bat = GetComponent<Transform>();
		batHome = bat.transform.parent;
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		positionPlayerLost = batHome.position;
		BackToHome ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (canFly)
			if (lostPlayer) 
		{
			float dist = (Time.time - startTime) * speed;
			float journey = dist / journeyLenght;
			
			if (bat.position == batHome.position)
				canFly = false;
			
			bat.position = Vector3.Lerp (positionPlayerLost, batHome.position, journey);
		}
		else //Ainda esta perseguindo jogador
		{				
			bat.position = Vector3.Lerp (bat.position, player.position,0.05f);
		}	
	}
	
	public void BackToHome()
	{	
		startTime = Time.time;
		positionPlayerLost = bat.position;
		journeyLenght = Vector3.Distance (positionPlayerLost, batHome.position);
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player") 
		{
			lostPlayer = false;			
			Debug.Log("Player perdeu vida!");
		}		
	}
	
	
	
	
	
	
	
}
