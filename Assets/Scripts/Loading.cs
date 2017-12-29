using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Loading : MonoBehaviour {

	public float loadingTime;
	public Image loadingBar;
	public Text percent;
	public float porcentaje;
	public ScoreManager scoremanager;
	public float currentscore;

	// Use this for initialization
	void Start () {
		loadingBar.fillAmount = 0;

		currentscore = PlayerPrefs.GetFloat("score",scoremanager.scoreCount);
	}
	
	// Update is called once per frame.
	void Update () {
	

		if (loadingBar.fillAmount <= currentscore/100) {
				if(currentscore <=20){

				loadingBar.fillAmount += 1f / 8 * Time.deltaTime;

				}
				else if(currentscore <=40){
				
				loadingBar.fillAmount += 1f / 6 * Time.deltaTime;
				
				}	
				else if(currentscore <=60){
				
				loadingBar.fillAmount += 1f / 4 * Time.deltaTime;
				
				}
				else if(currentscore <=80){
				
				loadingBar.fillAmount += 1f / 2 * Time.deltaTime;
				
				}
				else if(currentscore <=100){
				
				loadingBar.fillAmount += 1f / 0.5f * Time.deltaTime;
				
				}

				
			//loadingBar.fillAmount = 0.5f;
				}


	
		//if (loadingBar.fillAmount == 1.0f) {
		
		//	Application.LoadLevel("PersonaScene");
						
		//}

		percent.text = (loadingBar.fillAmount*100).ToString("f0");
	
	}
}
