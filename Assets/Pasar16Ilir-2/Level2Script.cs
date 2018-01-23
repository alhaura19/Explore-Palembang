using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level2Script : MonoBehaviour {
	public Button backtoMap;
	
	public Canvas pertanyaan10;
	public Canvas pertanyaan11;
	public Canvas pertanyaan12;
	public Canvas pertanyaan13;
	public Canvas pertanyaan14;
	public Canvas pertanyaan15;
	public Canvas pertanyaan16;
	public Canvas pertanyaan17;
	public Canvas pertanyaan18;
	
	public Button no1;
	public Button no2;
	public Button no3;
	public Button no4;
	public Button no5;
	public Button no6;
	public Button no7;
	public Button no8;
	public Button no9;
	
	public Button exitfrom10;
	public Button exitfrom11;
	public Button exitfrom12;
	public Button exitfrom13;
	public Button exitfrom14;
	public Button exitfrom15;
	public Button exitfrom16;
	public Button exitfrom17;
	public Button exitfrom18;
	
	public InputField no10box;
	public InputField no11box;
	public InputField no12box;
	public InputField no13box;
	public InputField no14box;
	public InputField no15box;
	public InputField no16box;
	public InputField no17box;
	public InputField no18box;
	
	public Button Checkno10;
	public Button Checkno11;
	public Button Checkno12;
	public Button Checkno13;
	public Button Checkno14;
	public Button Checkno15;
	public Button Checkno16;
	public Button Checkno17;
	public Button Checkno18;
	
	public InputField Level2Box;
	public Button CheckLevel2;
	public Text AnswerPasar;
	
	public Text ScoreDisplay;
	public int score;
	public static int finalscore;

	public static int selesai;
	public static int buka1;
	public static int buka2;
	public static int buka3;
	public static int buka4;
	public static int buka5;
	public static int buka6;
	public static int buka7;
	public static int buka8;
	public static int buka9;
	
	public AudioClip[] buttonsfx;
	
	// Use this for initialization
	void Start () {
		//LoadInformation.LoadAllInformation ();

		backtoMap = backtoMap.GetComponent<Button> ();
		
		pertanyaan10 = pertanyaan10.GetComponent<Canvas> ();
		pertanyaan11 = pertanyaan11.GetComponent<Canvas> ();
		pertanyaan12 = pertanyaan12.GetComponent<Canvas> ();
		pertanyaan13 = pertanyaan13.GetComponent<Canvas> ();
		pertanyaan14 = pertanyaan14.GetComponent<Canvas> ();
		pertanyaan15 = pertanyaan15.GetComponent<Canvas> ();
		pertanyaan16 = pertanyaan16.GetComponent<Canvas> ();
		pertanyaan17 = pertanyaan17.GetComponent<Canvas> ();
		pertanyaan18 = pertanyaan18.GetComponent<Canvas> ();
		
		no1 = no1.GetComponent<Button> ();
		no2 = no2.GetComponent<Button> ();
		no3 = no3.GetComponent<Button> ();
		no4 = no4.GetComponent<Button> ();
		no5 = no5.GetComponent<Button> ();
		no6 = no6.GetComponent<Button> ();
		no7 = no7.GetComponent<Button> ();
		no8 = no8.GetComponent<Button> ();
		no9 = no9.GetComponent<Button> ();
		
		exitfrom10 = exitfrom10.GetComponent<Button> ();
		exitfrom11 = exitfrom11.GetComponent<Button> ();
		exitfrom12 = exitfrom12.GetComponent<Button> ();
		exitfrom13 = exitfrom13.GetComponent<Button> ();
		exitfrom14 = exitfrom14.GetComponent<Button> ();
		exitfrom15 = exitfrom15.GetComponent<Button> ();
		exitfrom16 = exitfrom16.GetComponent<Button> ();
		exitfrom17 = exitfrom17.GetComponent<Button> ();
		exitfrom18 = exitfrom18.GetComponent<Button> ();
		
		no10box = no10box.GetComponent<InputField> ();
		no11box = no11box.GetComponent<InputField> ();
		no12box = no12box.GetComponent<InputField> ();
		no13box = no13box.GetComponent<InputField> ();
		no14box = no14box.GetComponent<InputField> ();
		no15box = no15box.GetComponent<InputField> ();
		no16box = no16box.GetComponent<InputField> ();
		no17box = no17box.GetComponent<InputField> ();
		no18box = no18box.GetComponent<InputField> ();
		
		Checkno10 = Checkno10.GetComponent<Button> ();
		Checkno11 = Checkno11.GetComponent<Button> ();
		Checkno12 = Checkno12.GetComponent<Button> ();
		Checkno13 = Checkno13.GetComponent<Button> ();
		Checkno14 = Checkno14.GetComponent<Button> ();
		Checkno15 = Checkno15.GetComponent<Button> ();
		Checkno16 = Checkno16.GetComponent<Button> ();
		Checkno17 = Checkno17.GetComponent<Button> ();
		Checkno18 = Checkno18.GetComponent<Button> ();
		
		pertanyaan10.enabled = false;
		pertanyaan11.enabled = false;
		pertanyaan12.enabled = false;
		pertanyaan13.enabled = false;
		pertanyaan14.enabled = false;
		pertanyaan15.enabled = false;
		pertanyaan16.enabled = false;
		pertanyaan17.enabled = false;
		pertanyaan18.enabled = false;
		
		Level2Box = Level2Box.GetComponent<InputField> ();
		CheckLevel2 = CheckLevel2.GetComponent<Button> ();
		AnswerPasar = AnswerPasar.GetComponent<Text> ();
		AnswerPasar.enabled = false;
		
		ScoreDisplay = ScoreDisplay.GetComponent<Text> ();
		score = 100;


		if (buka1 == 1) {
			Destroy (GameObject.Find ("no 1"));
		}
		if (buka2 == 1) {
			Destroy (GameObject.Find ("no 2"));
		}
		if (buka3 == 1) {
			Destroy (GameObject.Find ("no 3"));
		}
		if (buka4 == 1) {
			Destroy (GameObject.Find ("no 4"));
		}
		if (buka5 == 1) {
			Destroy (GameObject.Find ("no 5"));
		}
		if (buka6 == 1) {
			Destroy (GameObject.Find ("no 6"));
		}
		if (buka7 == 1) {
			Destroy (GameObject.Find ("no 7"));
		}
		if (buka8 == 1) {
			Destroy (GameObject.Find ("no 8"));
		}
		if (buka9 == 1) {
			Destroy (GameObject.Find ("no 9"));
		}
		if (selesai == 1) {
			Destroy (GameObject.Find ("no 1"));
			Destroy (GameObject.Find ("no 2"));
			Destroy (GameObject.Find ("no 3"));
			Destroy (GameObject.Find ("no 4"));
			Destroy (GameObject.Find ("no 5"));
			Destroy (GameObject.Find ("no 6"));
			Destroy (GameObject.Find ("no 7"));
			Destroy (GameObject.Find ("no 8"));
			Destroy (GameObject.Find ("no 9"));
			Destroy (GameObject.Find ("InputFieldLevel2"));
			Destroy (GameObject.Find ("CheckLevel2"));
			AnswerPasar.enabled = true;
			SetScore();
		}
	}
	
	public void backtoMapPressed(){
		Application.LoadLevel (2);
		PlaySFX (0);
	}
	
	public void No1Pressed(){
		pertanyaan10.enabled = true;
		if (no1.IsDestroyed () == false) {
			no1.enabled = false;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = false;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = false;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = false;
		}
		if (no5.IsDestroyed () == false) {
			no5.enabled = false;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = false;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = false;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = false;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = false;
		}
		backtoMap.enabled = false;
		PlaySFX (0);
	}
	
	public void No2Pressed(){
		pertanyaan11.enabled = true;
		if (no1.IsDestroyed () == false) {
			no1.enabled = false;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = false;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = false;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = false;
		}
		if (no5.IsDestroyed () == false) {
			no5.enabled = false;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = false;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = false;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = false;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = false;
		}
		backtoMap.enabled = false;
		PlaySFX (0);
	}
	
	public void No3Pressed(){
		pertanyaan12.enabled = true;
		if (no1.IsDestroyed () == false) {
			no1.enabled = false;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = false;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = false;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = false;
		}
		if (no5.IsDestroyed () == false) {
			no5.enabled = false;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = false;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = false;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = false;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = false;
		}
		backtoMap.enabled = false;
		PlaySFX (0);
	}
	
	public void No4Pressed(){
		pertanyaan13.enabled = true;
		if (no1.IsDestroyed () == false) {
			no1.enabled = false;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = false;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = false;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = false;
		}
		if (no5.IsDestroyed () == false) {
			no5.enabled = false;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = false;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = false;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = false;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = false;
		}
		backtoMap.enabled = false;
		PlaySFX (0);
	}
	
	public void No5Pressed(){
		pertanyaan14.enabled = true;
		if (no1.IsDestroyed () == false) {
			no1.enabled = false;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = false;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = false;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = false;
		}
		if (no5.IsDestroyed () == false) {
			no5.enabled = false;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = false;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = false;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = false;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = false;
		}
		backtoMap.enabled = false;
		PlaySFX (0);
	}
	
	public void No6Pressed(){
		pertanyaan15.enabled = true;
		if (no1.IsDestroyed () == false) {
			no1.enabled = false;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = false;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = false;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = false;
		}
		if (no5.IsDestroyed () == false) {
			no5.enabled = false;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = false;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = false;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = false;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = false;
		}
		backtoMap.enabled = false;
		PlaySFX (0);
	}
	
	public void No7Pressed(){
		pertanyaan16.enabled = true;
		if (no1.IsDestroyed () == false) {
			no1.enabled = false;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = false;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = false;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = false;
		}
		if (no5.IsDestroyed () == false) {
			no5.enabled = false;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = false;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = false;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = false;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = false;
		}
		backtoMap.enabled = false;
		PlaySFX (0);
	}
	
	public void No8Pressed(){
		pertanyaan17.enabled = true;
		if (no1.IsDestroyed () == false) {
			no1.enabled = false;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = false;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = false;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = false;
		}
		if (no5.IsDestroyed () == false) {
			no5.enabled = false;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = false;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = false;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = false;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = false;
		}
		backtoMap.enabled = false;
		PlaySFX (0);
	}
	
	public void No9Pressed(){
		pertanyaan18.enabled = true;
		if (no1.IsDestroyed () == false) {
			no1.enabled = false;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = false;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = false;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = false;
		}
		if (no5.IsDestroyed () == false) {
			no5.enabled = false;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = false;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = false;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = false;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = false;
		}
		backtoMap.enabled = false;
		PlaySFX (0);
	}
	
	public void Checkno10Pressed(){
		if (no10box.text == "AMPERA") {
			Destroy (GameObject.Find ("no 1"));
			score = score - 10;
			buka1 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}
	
	public void Checkno11Pressed(){
		if (no11box.text == "Pempek") {
			Destroy(GameObject.Find ("no 2"));
			score = score - 10;
			buka2 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}
	
	public void Checkno12Pressed(){
		if (no12box.text == "Joe Taslim") {
			Destroy(GameObject.Find ("no 3"));
			score = score - 10;
			buka3 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}
	
	public void Checkno13Pressed(){
		if (no13box.text == "Mohammad Hatta") {
			Destroy(GameObject.Find("no 4"));
			score = score - 10;
			buka4 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}
	
	public void Checkno14Pressed(){
		if (no14box.text == "Joko Widodo") {
			Destroy(GameObject.Find ("no 5"));
			score = score - 10;
			buka5 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}
	
	public void Checkno15Pressed(){
		if (no15box.text == "Sulawesi") {
			Destroy(GameObject.Find ("no 6"));
			score = score - 10;
			buka6 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}
	
	public void Checkno16Pressed(){
		if (no16box.text == "Ki Hajar Dewantara") {
			Destroy(GameObject.Find ("no 7"));
			score = score - 10;
			buka7 = 1;
			PlaySFX (1);
			//level = level + 1;
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}
	
	public void Checkno17Pressed(){
		if(no17box.text == "22 Juni"){
			Destroy(GameObject.Find ("no 8"));
			score = score - 10;
			buka8 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}
	
	public void Checkno18Pressed(){
		if (no18box.text == "Gunung Kelimutu") {
			Destroy (GameObject.Find ("no 9"));
			score = score - 10;
			buka9 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}
	
	public void CheckLevel2Pressed(){
		if (Level2Box.text == "Pasar 16 Ilir") {
			Destroy (GameObject.Find ("no 1"));
			Destroy (GameObject.Find ("no 2"));
			Destroy (GameObject.Find ("no 3"));
			Destroy (GameObject.Find ("no 4"));
			Destroy (GameObject.Find ("no 5"));
			Destroy (GameObject.Find ("no 6"));
			Destroy (GameObject.Find ("no 7"));
			Destroy (GameObject.Find ("no 8"));
			Destroy (GameObject.Find ("no 9"));
			Destroy (GameObject.Find ("InputFieldLevel2"));
			Destroy (GameObject.Find ("CheckLevel2"));
			AnswerPasar.enabled = true;
			finalscore = score;
			selesai = 1;
			SetScore ();
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		} else {
			PlaySFX (2);
		}
	}
	
	public void exitfrom10Pressed(){
		pertanyaan10.enabled = false;
		if (no1.IsDestroyed () == false) {
			no1.enabled = true;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = true;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = true;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = true;
		}
		if (no5.IsDestroyed () == false) {
			
			no5.enabled = true;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = true;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = true;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = true;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = true;
		}
		backtoMap.enabled = true;
		PlaySFX (0);
	}
	
	
	public void exitfrom11Pressed(){
		pertanyaan11.enabled = false;
		if (no1.IsDestroyed () == false) {
			no1.enabled = true;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = true;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = true;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = true;
		}
		if (no5.IsDestroyed () == false) {
			
			no5.enabled = true;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = true;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = true;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = true;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = true;
		}
		backtoMap.enabled = true;
		PlaySFX (0);
	}
	
	
	public void exitfrom12Pressed(){
		pertanyaan12.enabled = false;
		if (no1.IsDestroyed () == false) {
			no1.enabled = true;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = true;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = true;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = true;
		}
		if (no5.IsDestroyed () == false) {
			
			no5.enabled = true;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = true;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = true;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = true;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = true;
		}
		backtoMap.enabled = true;
		PlaySFX (0);
	}
	
	public void exitfrom13Pressed(){
		pertanyaan13.enabled = false;
		if (no1.IsDestroyed () == false) {
			no1.enabled = true;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = true;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = true;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = true;
		}
		if (no5.IsDestroyed () == false) {
			
			no5.enabled = true;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = true;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = true;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = true;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = true;
		}
		backtoMap.enabled = true;
		PlaySFX (0);
	}
	
	public void exitfrom14Pressed(){
		pertanyaan14.enabled = false;
		if (no1.IsDestroyed () == false) {
			no1.enabled = true;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = true;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = true;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = true;
		}
		if (no5.IsDestroyed () == false) {
			
			no5.enabled = true;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = true;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = true;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = true;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = true;
		}
		backtoMap.enabled = true;
		PlaySFX (0);
	}
	
	public void exitfrom15Pressed(){
		pertanyaan15.enabled = false;
		if (no1.IsDestroyed () == false) {
			no1.enabled = true;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = true;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = true;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = true;
		}
		if (no5.IsDestroyed () == false) {
			
			no5.enabled = true;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = true;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = true;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = true;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = true;
		}
		backtoMap.enabled = true;
		PlaySFX (0);
	}
	
	public void exitfrom16Pressed(){
		pertanyaan16.enabled = false;
		if (no1.IsDestroyed () == false) {
			no1.enabled = true;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = true;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = true;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = true;
		}
		if (no5.IsDestroyed () == false) {
			
			no5.enabled = true;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = true;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = true;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = true;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = true;
		}
		backtoMap.enabled = true;
		PlaySFX (0);
	}
	
	public void exitfrom17Pressed(){
		pertanyaan17.enabled = false;
		if (no1.IsDestroyed () == false) {
			no1.enabled = true;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = true;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = true;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = true;
		}
		if (no5.IsDestroyed () == false) {
			
			no5.enabled = true;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = true;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = true;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = true;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = true;
		}
		backtoMap.enabled = true;
		PlaySFX (0);
	}
	
	public void exitfrom18Pressed(){
		pertanyaan18.enabled = false;
		if (no1.IsDestroyed () == false) {
			no1.enabled = true;
		}
		if (no2.IsDestroyed () == false) {
			no2.enabled = true;
		}
		if (no3.IsDestroyed () == false) {
			no3.enabled = true;
		}
		if (no4.IsDestroyed () == false) {
			no4.enabled = true;
		}
		if (no5.IsDestroyed () == false) {
			
			no5.enabled = true;
		}
		if (no6.IsDestroyed () == false) {
			no6.enabled = true;
		}
		if (no7.IsDestroyed () == false) {
			no7.enabled = true;
		}
		if (no8.IsDestroyed () == false) {
			no8.enabled = true;
		}
		if (no9.IsDestroyed () == false) {
			no9.enabled = true;
		}
		backtoMap.enabled = true;
		PlaySFX (0);
	}
	
	public void SetScore(){
		ScoreDisplay.text = finalscore.ToString ();
	}

	void PlaySFX(int clip){
		GetComponent<AudioSource>().clip = buttonsfx [clip];
		GetComponent<AudioSource> ().Play ();
	}

	/*void StoreAllInformation(){
		GameInformation.Score = Level2Script.score;
		GameInformation.Level = Level2Script.level;
	}*/
}
