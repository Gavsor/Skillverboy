using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {



	public Text	numeronivel_1;
	public Text numeronivel_2;
	public Text numeronivel_3;
	public Text numeronivel_4;
	public Text numeronivel_5;
	public Text numeronivel_6;
	public Text numeronivel_7;
	public Text numeronivel_8;


	public Text Energia;
	public Text Corazones;
	public Text contador;



	private float tiempoo = 20f;
	


	//public ScoreManager scoremanager;

	// Use this for initialization
	void Start () {
		contador.enabled = true;
	
		//ScoreManager variable = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
		numeronivel_1.text = "% : " + (int)PlayerPrefs.GetFloat("highscore1");
		numeronivel_2.text = "% : " + (int)PlayerPrefs.GetFloat("highscore1");
		numeronivel_3.text = "% : " + (int)PlayerPrefs.GetFloat("highscore1");

		Energia.text = "" + PlayerPrefs.GetInt ("energia")+"/" ;
		Corazones.text = " " + PlayerPrefs.GetInt ("corazon");
	}
	
	// Update is called once per frame
	void Update () {


		tiempoo -= Time.deltaTime;
		contador.text = "" + tiempoo.ToString ("F0"); 
		

		if (PlayerPrefs.GetInt ("energia") >= 42) {
			contador.enabled = false;
			PlayerPrefs.SetInt("energia",42);
				
				
		}
			
		if (tiempoo < 0) {
			
		
			if (PlayerPrefs.GetInt ("energia") < 42) {
			print ("Aumento + 1");	
			
			PlayerPrefs.SetInt("energia",PlayerPrefs.GetInt("energia") + 1);
			Energia.text = "" + PlayerPrefs.GetInt ("energia")+"/" ;
			
			tiempoo = 20 ;
				//contador.text = "10";
			}
		}

	
	}
}
