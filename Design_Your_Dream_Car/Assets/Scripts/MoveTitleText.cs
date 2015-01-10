using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveTitleText : MonoBehaviour {

	public GameObject titleText_Container;
	private Vector3 scene11_position = new Vector3 (0f, 0f);
	private Vector3 scene12_position = new Vector3 (0f, -300f);

	public GameObject name_TextField;
	public GameObject car_TextField;

	public GameObject screen12;
	public GameObject screen11;

	//Tracking scene index here
	private int sceneIndex;
	public GameObject next_Button;
	public GameObject previous_Button;
	public GameObject done_Button;
	public GameObject restart_Button;
	public GameObject start_Button;

	// Use this for initialization
	void Start () 
	{
		sceneIndex = 0;
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; CheckToMoveTitleText();});
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0;CheckToMoveTitleText();});
		done_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; CheckToMoveTitleText();});
		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++;  CheckToMoveTitleText();});
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {sceneIndex--;CheckToMoveTitleText(); });
	}

	void CheckToMoveTitleText()
	{
		if (sceneIndex == 12) {
			titleText_Container.transform.parent = screen12.transform;
			titleText_Container.transform.localPosition = scene12_position;
		}
		else
		{
			titleText_Container.transform.parent = screen11.transform;
			titleText_Container.transform.localPosition = scene11_position;
		}
	}

	void ResetTextFields()
	{
		name_TextField.GetComponent<Text> ().text = "";
		car_TextField.GetComponent<Text> ().text = "";
	}

}
