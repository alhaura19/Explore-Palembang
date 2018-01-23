using UnityEngine;
using System.Collections;

public class LoadInformation {

	public static void LoadAllInformation(){
		GameInformation.BUKA1LEVEL1 = PlayerPrefs.GetInt ("BUKA1LEVEL1");
		//GameInformation.Level = PlayerPrefs.GetInt ("LEVEL");
	}
}
