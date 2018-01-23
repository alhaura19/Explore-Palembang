using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {
	public Button play;
	public Button ExitGame;
	public Button Info;
	public Button ExitCredit;
	public AudioClip[] buttonsfx;
	public Canvas Credit;
	// Use this for initialization
	void Start () {
		LoadInformation.LoadAllInformation ();
		play = play.GetComponent<Button> ();
		ExitGame = ExitGame.GetComponent<Button> ();
		Info = Info.GetComponent<Button> ();
		ExitCredit = ExitCredit.GetComponent<Button> ();
		Credit = Credit.GetComponent<Canvas> ();

		Credit.enabled = false;
	}

	public void PlayPressed(){
		Application.LoadLevel (2); 
		PlaySFX (0);
	}

	public void ExitGamePressed(){
		Application.Quit();
	}

	public void InfoPressed(){
		Credit.enabled = true;
		PlaySFX (0);
	}

	public void ExitCreditPressed(){
		Credit.enabled = false;
		PlaySFX (0);
	}

	void PlaySFX(int clip){
		GetComponent<AudioSource>().clip = buttonsfx [clip];
		GetComponent<AudioSource> ().Play ();
	}
}
