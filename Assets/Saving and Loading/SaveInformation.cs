using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation(){
		PlayerPrefs.SetInt ("BUKA1LEVEL1", GameInformation.BUKA1LEVEL1);
		//PlayerPrefs.SetInt ("LEVEL", GameInformation.Level);
	}
}
