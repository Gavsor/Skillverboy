using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class PauseMenu : MonoBehaviour {

	public GameObject PauseUI;
	public string levelselect;
	private bool paused = false;



	public AudioClip buttonsource;

	public CameraFollow camerafollow;

	// Use this for initialization
	void Start () {
			
		PauseUI.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {


		if (paused) {
			
			PauseUI.SetActive(true);
			Time.timeScale = 0;
		}
		
		if (!paused) {
			
			PauseUI.SetActive(false);
			Time.timeScale = 1;
		}
		
	}




	public void BotonPause(){
			




		audio.clip = camerafollow.myClip;
		audio.Pause ();
	


				paused = true;	


		}


	public void SetGameVolume(float vol)


	{


	}


	public void Resume(){
	


		audio.clip = camerafollow.myClip;
		audio.Play ();

		paused = false;
	}

	public void Restart(){
		PlayerPrefs.SetInt("energia",PlayerPrefs.GetInt("energia") - 1);
		print ("- 1");
		paused = false;

		Application.LoadLevel (Application.loadedLevel);	
		Time.timeScale = 1;

	}

	public void MainMenu(){
	
		audio.PlayOneShot (buttonsource);
		Application.LoadLevel (levelselect);
				//paused = false;
			
	//	Invoke ("CargarNivelJuego",0.1f);

	}

	//void CargarNivelJuego(){
	
	



	//}




	public void Exit(){
	
		Application.Quit();
	
	}
}
