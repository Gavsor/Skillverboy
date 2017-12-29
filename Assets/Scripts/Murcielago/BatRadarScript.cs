using UnityEngine;
using System.Collections;

public class BatRadarScript : MonoBehaviour {


	private MurcielagoIA script ;

	void Start () {
		
		script = (MurcielagoIA)GetComponentInParent (typeof(MurcielagoIA));
		
	}
	
	void OnTriggerEnter2D(Collider2D col )
	{
		
		if (col.tag == "Player") {
			//script.GoToPlayer();
			script.lostPlayer = false;
			script.canFly = true;
		}
	}
	
	void OnTriggerExit2D(Collider2D col)
	{
		
		
		if (col.tag == "Player") {
			script.BackToHome();
			script.lostPlayer = true;
			script.canFly = true;
		}
	}
	
}
