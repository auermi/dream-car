using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveTitleText : MonoBehaviour {

	public GameObject titleText_Container;
	private Vector3 scene11_position = new Vector3 (0f, 0f);
	private Vector3 scene12_position = new Vector3 (0f, -300f);
	
	private GameObject name_Text;
	private GameObject car_Text;

	public GameObject name_text_field_prefab;
	public GameObject car_text_field_prefab;

	public GameObject screen12;
	public GameObject screen11;

	//Tracking scene index here
	private int sceneIndex;
	public GameObject next_Button;
	public GameObject previous_Button;
	public GameObject done_Button;
	public GameObject restart_Button;
	public GameObject start_Button;
	public GameObject no_button;

	// Use this for initialization
	void Start () 
	{
		name_Text = Instantiate (name_text_field_prefab) as GameObject;
		car_Text = Instantiate (car_text_field_prefab) as GameObject;
		name_Text.transform.SetParent (titleText_Container.transform, false);
		car_Text.transform.SetParent (titleText_Container.transform, false);
		name_Text.transform.localPosition = new Vector3 (135f, 95f);
		car_Text.transform.localPosition = new Vector3 (-135f, 95f);
		sceneIndex = 0;
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; CheckToMoveTitleText(); });
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0;CheckToMoveTitleText();  ResetTextFields(); });
		done_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; CheckToMoveTitleText(); ResetTextFields(); });
		no_button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; CheckToMoveTitleText(); ResetTextFields(); });
		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++;  CheckToMoveTitleText(); });
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
			name_Text.GetComponent<InputField>().interactable = false;
			car_Text.GetComponent<InputField>().interactable = false;
		}
		else
		{
			titleText_Container.transform.parent = screen11.transform;
			titleText_Container.transform.localPosition = scene11_position;
			name_Text.GetComponent<InputField>().interactable = true;
			car_Text.GetComponent<InputField>().interactable = true;
		}
	}

	void ResetTextFields()
	{
		Destroy (name_Text);
		Destroy (car_Text);
		name_Text = Instantiate (name_text_field_prefab) as GameObject;
		car_Text = Instantiate (car_text_field_prefab) as GameObject;
		name_Text.transform.SetParent (titleText_Container.transform, false);
		car_Text.transform.SetParent (titleText_Container.transform, false);
		name_Text.transform.localPosition = new Vector3 (135f, 95f);
		car_Text.transform.localPosition = new Vector3 (-135f, 95f);
		Debug.Log("Reset The Field!");
	}


}
