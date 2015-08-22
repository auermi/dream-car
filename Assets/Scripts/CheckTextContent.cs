using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckTextContent : MonoBehaviour {

	//Tracking scene index here
	public GameObject next_Button;
	public GameObject previous_Button;
	public GameObject restart_Button;
	public GameObject start_Button;
	public GameObject no_button;
	
	private int sceneIndex;
	public GameObject name_textfield;
	public GameObject car_textfield;

	public GameObject hidden_container;
	public GameObject screen_12;
	public GameObject screen_11;

	public GameObject title_container;

	// Use this for initialization
	void Start () {
		sceneIndex = 0;
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; });
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; });
		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; CheckText();  });
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {sceneIndex--; });
		no_button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; });
	}
	
	void CheckText() {
		if (sceneIndex == 12) {
			if (car_textfield.GetComponent<Text> ().text == "") {
				title_container.transform.SetParent(hidden_container.transform);
			}
			else {
				title_container.transform.SetParent(screen_11.transform);
			}
		}
	}
}
