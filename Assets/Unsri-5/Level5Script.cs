using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level5Script : MonoBehaviour {
	public Button backtoMap;
	
	public Canvas pertanyaan37;
	public Canvas pertanyaan38;
	public Canvas pertanyaan39;
	public Canvas pertanyaan40;
	public Canvas pertanyaan41;
	public Canvas pertanyaan42;
	public Canvas pertanyaan43;
	public Canvas pertanyaan44;
	public Canvas pertanyaan45;
	
	public Button no1;
	public Button no2;
	public Button no3;
	public Button no4;
	public Button no5;
	public Button no6;
	public Button no7;
	public Button no8;
	public Button no9;
	
	public Button exitfrom37;
	public Button exitfrom38;
	public Button exitfrom39;
	public Button exitfrom40;
	public Button exitfrom41;
	public Button exitfrom42;
	public Button exitfrom43;
	public Button exitfrom44;
	public Button exitfrom45;
	
	public InputField no37box;
	public InputField no38box;
	public InputField no39box;
	public InputField no40box;
	public InputField no41box;
	public InputField no42box;
	public InputField no43box;
	public InputField no44box;
	public InputField no45box;
	
	public Button Checkno37;
	public Button Checkno38;
	public Button Checkno39;
	public Button Checkno40;
	public Button Checkno41;
	public Button Checkno42;
	public Button Checkno43;
	public Button Checkno44;
	public Button Checkno45;
	
	public InputField Level5Box;
	public Button CheckLevel5;
	public Text Answer;
	
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
		
		pertanyaan37 = pertanyaan37.GetComponent<Canvas> ();
		pertanyaan38 = pertanyaan38.GetComponent<Canvas> ();
		pertanyaan39 = pertanyaan39.GetComponent<Canvas> ();
		pertanyaan40 = pertanyaan40.GetComponent<Canvas> ();
		pertanyaan41 = pertanyaan41.GetComponent<Canvas> ();
		pertanyaan42 = pertanyaan42.GetComponent<Canvas> ();
		pertanyaan43 = pertanyaan43.GetComponent<Canvas> ();
		pertanyaan44 = pertanyaan44.GetComponent<Canvas> ();
		pertanyaan45 = pertanyaan45.GetComponent<Canvas> ();
		
		no1 = no1.GetComponent<Button> ();
		no2 = no2.GetComponent<Button> ();
		no3 = no3.GetComponent<Button> ();
		no4 = no4.GetComponent<Button> ();
		no5 = no5.GetComponent<Button> ();
		no6 = no6.GetComponent<Button> ();
		no7 = no7.GetComponent<Button> ();
		no8 = no8.GetComponent<Button> ();
		no9 = no9.GetComponent<Button> ();
		
		exitfrom37 = exitfrom37.GetComponent<Button> ();
		exitfrom38 = exitfrom38.GetComponent<Button> ();
		exitfrom39 = exitfrom39.GetComponent<Button> ();
		exitfrom40 = exitfrom40.GetComponent<Button> ();
		exitfrom41 = exitfrom41.GetComponent<Button> ();
		exitfrom42 = exitfrom42.GetComponent<Button> ();
		exitfrom43 = exitfrom43.GetComponent<Button> ();
		exitfrom44 = exitfrom44.GetComponent<Button> ();
		exitfrom45 = exitfrom45.GetComponent<Button> ();
		
		no37box = no37box.GetComponent<InputField> ();
		no38box = no38box.GetComponent<InputField> ();
		no39box = no39box.GetComponent<InputField> ();
		no40box = no40box.GetComponent<InputField> ();
		no41box = no41box.GetComponent<InputField> ();
		no42box = no42box.GetComponent<InputField> ();
		no43box = no43box.GetComponent<InputField> ();
		no44box = no44box.GetComponent<InputField> ();
		no45box = no45box.GetComponent<InputField> ();
		
		Checkno37 = Checkno37.GetComponent<Button> ();
		Checkno38 = Checkno38.GetComponent<Button> ();
		Checkno39 = Checkno39.GetComponent<Button> ();
		Checkno40 = Checkno40.GetComponent<Button> ();
		Checkno41 = Checkno41.GetComponent<Button> ();
		Checkno42 = Checkno42.GetComponent<Button> ();
		Checkno43 = Checkno43.GetComponent<Button> ();
		Checkno44 = Checkno44.GetComponent<Button> ();
		Checkno45 = Checkno45.GetComponent<Button> ();
		
		pertanyaan37.enabled = false;
		pertanyaan38.enabled = false;
		pertanyaan39.enabled = false;
		pertanyaan40.enabled = false;
		pertanyaan41.enabled = false;
		pertanyaan42.enabled = false;
		pertanyaan43.enabled = false;
		pertanyaan44.enabled = false;
		pertanyaan45.enabled = false;
		
		Level5Box = Level5Box.GetComponent<InputField> ();
		CheckLevel5 = CheckLevel5.GetComponent<Button> ();
		Answer = Answer.GetComponent<Text> ();
		Answer.enabled = false;
		
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
			Destroy (GameObject.Find ("InputFieldLevel5"));
			Destroy (GameObject.Find ("CheckLevel5"));
			Answer.enabled = true;
			SetScore();
		}
	}
	
	public void backtoMapPressed(){
		Application.LoadLevel (2);
		PlaySFX (0);
	}
	
	public void No1Pressed(){
		pertanyaan37.enabled = true;
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
		pertanyaan38.enabled = true;
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
		pertanyaan39.enabled = true;
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
		pertanyaan40.enabled = true;
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
		pertanyaan41.enabled = true;
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
		pertanyaan42.enabled = true;
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
		pertanyaan43.enabled = true;
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
		pertanyaan44.enabled = true;
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
		pertanyaan45.enabled = true;
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
	
	public void Checkno37Pressed(){
		if (no37box.text == "1960") {
			Destroy (GameObject.Find ("no 1"));
			score = score - 10;
			buka1 = 1;
			PlaySFX(1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX(2);
		}
	}
	
	public void Checkno38Pressed(){
		if (no38box.text == "17 Juni") {
			Destroy(GameObject.Find ("no 2"));
			score = score - 10;
			buka2 = 1;
			PlaySFX(1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX(2);
		}
	}
	
	public void Checkno39Pressed(){
		if (no39box.text == "1965") {
			Destroy(GameObject.Find ("no 3"));
			score = score - 10;
			buka3 = 1;
			PlaySFX(1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX(2);
		}
	}
	
	public void Checkno40Pressed(){
		if (no40box.text == "Kain Songket") {
			Destroy(GameObject.Find("no 4"));
			score = score - 10;
			buka4 = 1;
			PlaySFX(1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX(2);
		}
	}
	
	public void Checkno41Pressed(){
		if (no41box.text == "Palembang") {
			Destroy(GameObject.Find ("no 5"));
			score = score - 10; 
			buka5 = 1;
			PlaySFX(1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX(2);
		}
	}
	
	public void Checkno42Pressed(){
		if (no42box.text == "Sultan Mahmud Badaruddin II") {
			Destroy(GameObject.Find ("no 6"));
			score = score - 10;
			buka6 = 1;
			PlaySFX(1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX(2);
		}
	}
	
	public void Checkno43Pressed(){
		if (no43box.text == "TransMusi") {
			Destroy(GameObject.Find ("no 7"));
			score = score - 10;
			buka7 = 1;
			PlaySFX(1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX(2);
		}
	}
	
	public void Checkno44Pressed(){
		if(no44box.text == "Bandung Lautan Api"){
			Destroy(GameObject.Find ("no 8"));
			score = score - 10;
			buka8 = 1;
			PlaySFX(1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX(2);
		}
	}
	
	public void Checkno45Pressed(){
		if (no45box.text == "Candi Borobudur") {
			Destroy (GameObject.Find ("no 9"));
			score = score - 10;
			buka9 = 1;
			PlaySFX(1);
			//SaveInformation.SaveAllInformation();
		}else {
			PlaySFX(2);
		}
	}
	
	public void CheckLevel5Pressed(){
		if (Level5Box.text == "Universitas Sriwijaya") {
			Destroy (GameObject.Find ("no 1"));
			Destroy (GameObject.Find ("no 2"));
			Destroy (GameObject.Find ("no 3"));
			Destroy (GameObject.Find ("no 4"));
			Destroy (GameObject.Find ("no 5"));
			Destroy (GameObject.Find ("no 6"));
			Destroy (GameObject.Find ("no 7"));
			Destroy (GameObject.Find ("no 8"));
			Destroy (GameObject.Find ("no 9"));
			Destroy (GameObject.Find ("InputFieldLevel5"));
			Destroy (GameObject.Find ("CheckLevel5"));
			Answer.enabled = true;
			finalscore = score;
			selesai = 1;
			PlaySFX(1);
			SetScore ();
			//SaveInformation.SaveAllInformation();
		} else {
			PlaySFX(2);
		}
	}
	
	public void exitfrom37Pressed(){
		pertanyaan37.enabled = false;
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
	
	
	public void exitfrom38Pressed(){
		pertanyaan38.enabled = false;
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
	
	
	public void exitfrom39Pressed(){
		pertanyaan39.enabled = false;
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
	
	public void exitfrom40Pressed(){
		pertanyaan40.enabled = false;
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
	
	public void exitfrom41Pressed(){
		pertanyaan41.enabled = false;
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
	
	public void exitfrom42Pressed(){
		pertanyaan42.enabled = false;
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
	
	public void exitfrom43Pressed(){
		pertanyaan43.enabled = false;
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
	
	public void exitfrom44Pressed(){
		pertanyaan44.enabled = false;
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
	
	public void exitfrom45Pressed(){
		pertanyaan45.enabled = false;
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
		GameInformation.Score = Level5Script.score;
		GameInformation.Level = Level5Script.level;
	}*/
}
