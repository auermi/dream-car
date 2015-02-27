using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoKeyboardPull : MonoBehaviour {

	//Tracking scene index here
	public GameObject next_Button;
	public GameObject previous_Button;
	public GameObject restart_Button;
	public GameObject start_Button;
	public GameObject no_button;

	
	private int sceneIndex;

	void Start () {
		sceneIndex = 0;
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; });
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; });
		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; CheckPull(); });
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {sceneIndex--; CheckPull(); });
		no_button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; });
	}

	void CheckPull() {
		if (sceneIndex == 11) {
			TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false, false);                     

		}
	}
}
