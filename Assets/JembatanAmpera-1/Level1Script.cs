using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level1Script : MonoBehaviour {
	public Canvas pertanyaan1;
	public Canvas pertanyaan2;
	public Canvas pertanyaan3;
	public Canvas pertanyaan4;
	public Canvas pertanyaan5;
	public Canvas pertanyaan6;
	public Canvas pertanyaan7;
	public Canvas pertanyaan8;
	public Canvas pertanyaan9;

	public Button no1;
	public Button no2;
	public Button no3;
	public Button no4;
	public Button no5;
	public Button no6;
	public Button no7;
	public Button no8;
	public Button no9;

	public Button exitfrom1;
	public Button exitfrom2;
	public Button exitfrom3;
	public Button exitfrom4;
	public Button exitfrom5;
	public Button exitfrom6;
	public Button exitfrom7;
	public Button exitfrom8;
	public Button exitfrom9;
	public Button backtoMap;

	public InputField no1box;
	public InputField no2box;
	public InputField no3box;
	public InputField no4box;
	public InputField no5box;
	public InputField no6box;
	public InputField no7box;
	public InputField no8box;
	public InputField no9box;

	public Button Checkno1;
	public Button Checkno2;
	public Button Checkno3;
	public Button Checkno4;
	public Button Checkno5;
	public Button Checkno6;
	public Button Checkno7;
	public Button Checkno8;
	public Button Checkno9;

	public InputField Level1Box;
	public Button CheckLevel1;
	public Text AnswerAmpera;

	public Text ScoreDisplay;
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
	public int score;
	public static int finalscore;

	public AudioClip[] buttonsfx;
	

	// Use this for initialization
	void Start () {
		LoadInformation.LoadAllInformation ();

		pertanyaan1 = pertanyaan1.GetComponent<Canvas> ();
		pertanyaan2 = pertanyaan2.GetComponent<Canvas> ();
		pertanyaan3 = pertanyaan3.GetComponent<Canvas> ();
		pertanyaan4 = pertanyaan4.GetComponent<Canvas> ();
		pertanyaan5 = pertanyaan5.GetComponent<Canvas> ();
		pertanyaan6 = pertanyaan6.GetComponent<Canvas> ();
		pertanyaan7 = pertanyaan7.GetComponent<Canvas> ();
		pertanyaan8 = pertanyaan8.GetComponent<Canvas> ();
		pertanyaan9 = pertanyaan9.GetComponent<Canvas> ();

		no1 = no1.GetComponent<Button> ();
		no2 = no2.GetComponent<Button> ();
		no3 = no3.GetComponent<Button> ();
		no4 = no4.GetComponent<Button> ();
		no5 = no5.GetComponent<Button> ();
		no6 = no6.GetComponent<Button> ();
		no7 = no7.GetComponent<Button> ();
		no8 = no8.GetComponent<Button> ();
		no9 = no9.GetComponent<Button> ();

		exitfrom1 = exitfrom1.GetComponent<Button> ();
		exitfrom2 = exitfrom2.GetComponent<Button> ();
		exitfrom3 = exitfrom3.GetComponent<Button> ();
		exitfrom4 = exitfrom4.GetComponent<Button> ();
		exitfrom5 = exitfrom5.GetComponent<Button> ();
		exitfrom6 = exitfrom6.GetComponent<Button> ();
		exitfrom7 = exitfrom7.GetComponent<Button> ();
		exitfrom8 = exitfrom8.GetComponent<Button> ();
		exitfrom9 = exitfrom9.GetComponent<Button> ();

		backtoMap = backtoMap.GetComponent<Button> ();

		no1box = no1box.GetComponent<InputField> ();
		no2box = no2box.GetComponent<InputField> ();
		no3box = no3box.GetComponent<InputField> ();
		no4box = no4box.GetComponent<InputField> ();
		no5box = no5box.GetComponent<InputField> ();
		no6box = no6box.GetComponent<InputField> ();
		no7box = no7box.GetComponent<InputField> ();
		no8box = no8box.GetComponent<InputField> ();
		no9box = no9box.GetComponent<InputField> ();

		Checkno1 = Checkno1.GetComponent<Button> ();
		Checkno2 = Checkno2.GetComponent<Button> ();
		Checkno3 = Checkno3.GetComponent<Button> ();
		Checkno4 = Checkno4.GetComponent<Button> ();
		Checkno5 = Checkno5.GetComponent<Button> ();
		Checkno6 = Checkno6.GetComponent<Button> ();
		Checkno7 = Checkno7.GetComponent<Button> ();
		Checkno8 = Checkno8.GetComponent<Button> ();
		Checkno9 = Checkno9.GetComponent<Button> ();

		pertanyaan1.enabled = false;
		pertanyaan2.enabled = false;
		pertanyaan3.enabled = false;
		pertanyaan4.enabled = false;
		pertanyaan5.enabled = false;
		pertanyaan6.enabled = false;
		pertanyaan7.enabled = false;
		pertanyaan8.enabled = false;
		pertanyaan9.enabled = false;

		Level1Box = Level1Box.GetComponent<InputField> ();
		CheckLevel1 = CheckLevel1.GetComponent<Button> ();
		AnswerAmpera = AnswerAmpera.GetComponent<Text> ();
		AnswerAmpera.enabled = false;

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
			Destroy (GameObject.Find ("InputFieldLevel1"));
			Destroy (GameObject.Find ("CheckLevel1"));
			AnswerAmpera.enabled = true;
			SetScore();
		}
	}
	

	public void No1Pressed(){
		pertanyaan1.enabled = true;
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
		pertanyaan2.enabled = true;
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
		pertanyaan3.enabled = true;
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
		pertanyaan4.enabled = true;
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
		pertanyaan5.enabled = true;
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
		pertanyaan6.enabled = true;
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
		pertanyaan7.enabled = true;
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
		pertanyaan8.enabled = true;
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
		pertanyaan9.enabled = true;
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

	public void Checkno1Pressed(){
		if (no1box.text == "Aceh") {
			Destroy (GameObject.Find ("no 1"));
			score = score - 10;
			buka1 = 1;
			PlaySFX (1);
			SaveInformation.SaveAllInformation();
		} else {
			PlaySFX (2);
		}
	}

	public void Checkno2Pressed(){
		if (no2box.text == "Jawa Tengah") {
			Destroy(GameObject.Find ("no 2"));
			score = score - 10;
			buka2 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}

	public void Checkno3Pressed(){
		if (no3box.text == "Nusa Tenggara Timur") {
			Destroy(GameObject.Find ("no 3"));
			score = score - 10;
			buka3 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}

	public void Checkno4Pressed(){
		if (no4box.text == "Ir. Soekarno") {
			Destroy(GameObject.Find("no 4"));
			score = score - 10;
			buka4 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}
	
	public void Checkno5Pressed(){
		if (no5box.text == "PETA") {
			Destroy(GameObject.Find ("no 5"));
			score = score - 10;
			buka5 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}

	public void Checkno6Pressed(){
		if (no6box.text == "Rodi") {
			Destroy(GameObject.Find ("no 6"));
			score = score - 10;
			buka6 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}

	public void Checkno7Pressed(){
		if (no7box.text == "Sumatera Barat") {
			Destroy(GameObject.Find ("no 7"));
			score = score - 10;
			buka7 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}

	public void Checkno8Pressed(){
		if(no8box.text == "Yogyakarta"){
			Destroy(GameObject.Find ("no 8"));
			score = score - 10;
			buka8 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}

	public void Checkno9Pressed(){
		if (no9box.text == "Kalimantan") {
			Destroy (GameObject.Find ("no 9"));
			score = score - 10;
			buka9 = 1;
			PlaySFX (1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}

	public void CheckLevel1Pressed(){
		if (Level1Box.text == "Jembatan Ampera") {
			Destroy (GameObject.Find ("no 1"));
			Destroy (GameObject.Find ("no 2"));
			Destroy (GameObject.Find ("no 3"));
			Destroy (GameObject.Find ("no 4"));
			Destroy (GameObject.Find ("no 5"));
			Destroy (GameObject.Find ("no 6"));
			Destroy (GameObject.Find ("no 7"));
			Destroy (GameObject.Find ("no 8"));
			Destroy (GameObject.Find ("no 9"));
			Destroy (GameObject.Find ("InputFieldLevel1"));
			Destroy (GameObject.Find ("CheckLevel1"));
			AnswerAmpera.enabled = true;
			selesai = 1;
			finalscore = score;
			PlaySFX (1);
			SetScore ();
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX (2);
		}
	}

	public void exitfrom1Pressed(){
		pertanyaan1.enabled = false;
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

	
	public void exitfrom2Pressed(){
		pertanyaan2.enabled = false;
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

	
	public void exitfrom3Pressed(){
		pertanyaan3.enabled = false;
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

	public void exitfrom4Pressed(){
		pertanyaan4.enabled = false;
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

	public void exitfrom5Pressed(){
		pertanyaan5.enabled = false;
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

	public void exitfrom6Pressed(){
		pertanyaan6.enabled = false;
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

	public void exitfrom7Pressed(){
		pertanyaan7.enabled = false;
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

	public void exitfrom8Pressed(){
		pertanyaan8.enabled = false;
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

	public void exitfrom9Pressed(){
		pertanyaan9.enabled = false;
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
	

	public void backtoMapPressed(){
		Application.LoadLevel (2);
		PlaySFX (0);
	}

	public void SetScore(){
		ScoreDisplay.text = finalscore.ToString ();
	}

	void PlaySFX(int clip){
		GetComponent<AudioSource>().clip = buttonsfx [clip];
		GetComponent<AudioSource> ().Play ();
	}


	void StoreAllInformation(){
		GameInformation.BUKA1LEVEL1 = buka1;
		//GameInformation.Level = level;
	}
}
