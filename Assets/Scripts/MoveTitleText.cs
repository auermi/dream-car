using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveTitleText : MonoBehaviour {

	public GameObject titleText_Container;
	private Vector3 scene11_position = new Vector3 (0f, 0f);
	private Vector3 scene12_position = new Vector3 (0f, -600f);
	
	private GameObject name_Text;
	private GameObject car_Text;

	public GameObject name_text_field;
	public GameObject car_text_field;

	public GameObject screen12;
	public GameObject screen11;
	public GameObject hidden_container;

	public GameObject name_text_object;
	public GameObject car_text_object;

	//Tracking scene index here
	private int sceneIndex;
	public GameObject next_Button;
	public GameObject previous_Button;
	public GameObject restart_Button;
	public GameObject start_Button;
	public GameObject no_button;

	// Use this for initialization
	void Start () 
	{

		sceneIndex = 0;
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; CheckToMoveTitleText(); });
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0;CheckToMoveTitleText();  ResetTextFields(); });
		no_button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; CheckToMoveTitleText(); ResetTextFields(); });
		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++;  CheckToMoveTitleText(); CheckText(); LogText(); });
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {
			sceneIndex--;
			CheckToMoveTitleText(); 
			if (sceneIndex < 11) { 
				ResetTextFields();
			} 
		});
	}
	//Move title text and disable interactivity on the fields
	void CheckToMoveTitleText()
	{
		if (sceneIndex == 12) {
			titleText_Container.transform.SetParent(screen12.transform, false);
			titleText_Container.transform.localPosition = scene12_position;
			name_text_field.GetComponent<InputField>().interactable = false;
			car_text_field.GetComponent<InputField>().interactable = false;
		}
		else
		{
			titleText_Container.transform.SetParent(screen11.transform);
			titleText_Container.transform.localPosition = scene11_position;
			name_text_field.GetComponent<InputField>().interactable = true;
			car_text_field.GetComponent<InputField>().interactable = true;
		}
	}

	void ResetTextFields()
	{

	}

	void LogText() {
		if (sceneIndex == 12) {
			if (name_text_object.GetComponent<Text> ().text.Length == 0 || car_text_object.GetComponent<Text> ().text.Length == 0) {
				Debug.Log ("I found you out" + name_text_object.GetComponent<Text> ().text);
				Debug.Log (name_text_object.GetComponent<Text> ().text.Length);
				titleText_Container.transform.SetParent (hidden_container.transform);
			}	
		}
	
	}

	void CheckText() {


		/*
		if (sceneIndex == 12) {
			if (car_Text.GetComponent<Text> ().text.Length == 0) {
				Debug.Log ("Success!");
				titleText_Container.transform.SetParent(hidden_container.transform);
			}
			else {
				Debug.Log ("Fail!");
				titleText_Container.transform.SetParent(screen11.transform);
			}
		}*/
	}

}
