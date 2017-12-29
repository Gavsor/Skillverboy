using UnityEngine;
using System.Collections;

public class PartColl : MonoBehaviour {

	void OnParticleCollision(GameObject other)
	{
		Debug.Log("Particle hit");
	}


}
