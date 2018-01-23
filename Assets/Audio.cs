using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Audio : MonoBehaviour {
	private static Audio instance = null;
	public Canvas MuteButton;
	public Canvas UnmuteButton;
	public Button Mute;
	public Button Unmute;
	public bool muted;
	public static Audio Instance {
		get { return instance; }
	}

	void Start(){
		Mute = Mute.GetComponent<Button> ();
		Unmute = Unmute.GetComponent<Button> ();
		MuteButton = MuteButton.GetComponent<Canvas> ();
		UnmuteButton = UnmuteButton.GetComponent<Canvas> ();
		
		UnmuteButton.enabled = false;
	}

	void Awake(){
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad (transform.gameObject);
	}

	public void MutePressed(){
		UnmuteButton.enabled = true;
		MuteButton.enabled = false;
		Destroy (this.gameObject);
		muted = true;
	}
	
	public void UnmutePressed(){
		UnmuteButton.enabled = false;
		MuteButton.enabled = true;
		muted = false;
	}
}
