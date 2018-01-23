using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MapScript : MonoBehaviour {
	public Canvas AmperaC;
	public Canvas Pasar16C;
	public Canvas GeloraC;
	public Canvas PulauKemaroC;
	public Canvas UnsriC;
	public Canvas Story;

	public Button backtoMenu;
	public Button Info;
	public Button Ampera;
	public Button Pasar16;
	public Button GeloraSriwijaya;
	public Button PulauKemaro;
	public Button Unsri;
	public Button exitStory;

	public AudioClip[] buttonsfx;

	// Use this for initialization
	void Start () {
		//LoadInformation.LoadAllInformation ();
		backtoMenu		= backtoMenu.GetComponent<Button> ();
		Info 			= Info.GetComponent<Button> ();
		Ampera			= Ampera.GetComponent<Button> ();
		Pasar16			= Pasar16.GetComponent<Button> ();
		GeloraSriwijaya = GeloraSriwijaya.GetComponent<Button> ();
		PulauKemaro 	= PulauKemaro.GetComponent <Button> ();
		Unsri 			= Unsri.GetComponent<Button> ();

		AmperaC		= AmperaC.GetComponent<Canvas> ();
		Pasar16C 	= Pasar16C.GetComponent<Canvas> ();
		GeloraC 	= GeloraC.GetComponent<Canvas> ();
		PulauKemaroC= PulauKemaroC.GetComponent<Canvas> ();
		UnsriC		= UnsriC.GetComponent<Canvas> ();
		Story 		= Story.GetComponent<Canvas> ();
		exitStory 	= exitStory.GetComponent<Button> ();

		Ampera.enabled			= true;
		Pasar16.enabled			= false;
		GeloraSriwijaya.enabled = false;
		PulauKemaro.enabled		= false;
		Unsri.enabled			= false;

		AmperaC.enabled			= false;
		Pasar16C.enabled		= false;
		GeloraC.enabled 		= false;
		PulauKemaroC.enabled	= false;
		UnsriC.enabled			= false;

		Story.enabled 			= false;
		exitStory.enabled		= false;

		if (Level1Script.selesai == 1) {
			Destroy(GameObject.Find("Ampera"));
			AmperaC.enabled = true;
			Pasar16.enabled = true;
		}
		if (Level2Script.selesai == 1) {
			Destroy(GameObject.Find("Pasar16"));
			Pasar16C.enabled = true;
			GeloraSriwijaya.enabled = true;
		}
		if (Level3Script.selesai == 1) {
			Destroy(GameObject.Find("GeloraSriwijaya"));
			GeloraC.enabled = true;
			PulauKemaro.enabled = true;	
		}
		if (Level4Script.selesai == 1) {
			Destroy(GameObject.Find("PulauKemaro"));
			PulauKemaroC.enabled = true;
			Unsri.enabled = true;
		}
		if (Level5Script.selesai == 1) {
			Destroy(GameObject.Find("Unsri"));
			UnsriC.enabled = true;
		}

	}
	
	public void backtoMenupressed(){
		Application.LoadLevel (1);
		PlaySFX (0);
	}

	public void InfoPressed(){
		Story.enabled = true;
		exitStory.enabled = true;
		PlaySFX (0);
	}

	public void exitFromStory(){
		Story.enabled = false;
		exitStory.enabled = false;
		//Application.LoadLevel (1);
		PlaySFX (0);
	}


	public void AmperaPressed(){
		Application.LoadLevel (3);
		PlaySFX (0);
	}

	public void Pasar16Pressed(){
		Application.LoadLevel (4);
		PlaySFX (0);
	}

	public void GeloraSriwijayaPressed(){
		Application.LoadLevel (5);
		PlaySFX (0);
	}

	public void PulauKemaroPressed(){
		Application.LoadLevel (6);
		PlaySFX (0);
	}

	public void UnsriPressed(){
		Application.LoadLevel (7);
		PlaySFX (0);
	}

	void PlaySFX(int clip){
		GetComponent<AudioSource>().clip = buttonsfx [clip];
		GetComponent<AudioSource> ().Play ();
	}
}
