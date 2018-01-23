using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
	}

	public static int BUKA1LEVEL1 { get; set; }
	//public static int Level { get; set; }
}
