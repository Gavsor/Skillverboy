using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization


	// Update is called once per frame
	public void ChangeToScene (string sceneToChangeTo) {
		PlayerPrefs.SetInt("energia",PlayerPrefs.GetInt("energia") - 1);
		print ("Menos 1");

		Application.LoadLevel (sceneToChangeTo);
	
	}
}
