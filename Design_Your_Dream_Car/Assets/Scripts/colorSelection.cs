//Written by Michael Andrew Auer for the Indianapolis Museum of Art Dream Car iPad Application
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorSelection : MonoBehaviour {

	public GameObject selectionBox;

	//Tracking scene index here
	public GameObject next_Button;
	public GameObject previous_Button;
	public GameObject done_Button;
	public GameObject restart_Button;
	public GameObject start_Button;
	public GameObject no_button;

	private int sceneIndex;

	public GameObject redButton;
	public GameObject greenButton;
	public GameObject yellowButton;
	public GameObject orangeButton;
	public GameObject turquoiseButton;
	public GameObject carrotButton;
	public GameObject pinkButton;
	public GameObject greyButton;
	public GameObject limeButton;
	public GameObject navyButton;
	public GameObject glaucousButton;

	public GameObject hidden_Parent;
	public GameObject colorSelection_Parent;

	private Color32 selectionColor = new Color32(0, 118, 192, 255);
	private Vector3 defaultSelectionColor_Position = new Vector3(0f, -1000f, 0f);
	private Vector3 savedPosition;

	// Use this for initialization
	void Start () {
		sceneIndex = 0;
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++; CheckToHideSelectionColor();});
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; CheckToHideSelectionColor();});
		done_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; CheckToHideSelectionColor(); });
		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++;  CheckToHideSelectionColor();});
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {sceneIndex--; CheckToHideSelectionColor(); RealignSelectionBox(); });
		no_button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; CheckToHideSelectionColor(); });
		//If color button is pressed, change box color and move it to position behind specified color button
		redButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = savedPosition = new Vector3(-350f,-212.9f);} );
		greenButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(-280f, -212.9f);} );
		yellowButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = savedPosition =  new Vector3(-210f,-212.9f);} );
		orangeButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(-140f, -212.9f);} );
		turquoiseButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(-70f,-212.9f);} );
		carrotButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(0f, -212.9f);} );
		pinkButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = savedPosition =  new Vector3(70f,-212.9f);} );
		greyButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(140f, -212.9f);} );
		limeButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(210f,-212.9f);} );
		navyButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(280f, -212.9f);} );
		glaucousButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(350f, -212.9f);} );
	}
	void CheckToHideSelectionColor()
	{
		if (sceneIndex == 9)
		{
			selectionBox.transform.parent = colorSelection_Parent.transform;
		}
		else if (sceneIndex > 9)
		{
			selectionBox.transform.parent = hidden_Parent.transform;
		}
		else
		{
			selectionBox.transform.parent = hidden_Parent.transform;
			selectionBox.transform.localPosition = defaultSelectionColor_Position;
		}

	}
	void RealignSelectionBox()
	{
		if (sceneIndex == 9)
		{
			selectionBox.transform.localPosition = savedPosition;
		}
	}

}
