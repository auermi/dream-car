using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour {
	
	public GameObject selectionBox;
	
	//Tracking scene index here
	public GameObject next_Button;
	public GameObject previous_Button;
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
		next_Button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex++;  CheckToHideSelectionColor();});
		previous_Button.GetComponent<Button>().onClick.AddListener(()=> {sceneIndex--; CheckToHideSelectionColor(); RealignSelectionBox(); });
		no_button.GetComponent<Button> ().onClick.AddListener (() => {sceneIndex = 0; CheckToHideSelectionColor(); });
		//If color button is pressed, change box color and move it to position behind specified color button
		redButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = savedPosition = new Vector3(-700f,-425f);} );
		greenButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(-560f, -425f);} );
		yellowButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = savedPosition =  new Vector3(-420f,-425f);} );
		orangeButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(-280f, -425f);} );
		turquoiseButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(-140f,-425f);} );
		carrotButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(0f, -425f);} );
		pinkButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = savedPosition =  new Vector3(140f,-425f);} );
		greyButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(280f, -425f);} );
		limeButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(420f,-425f);} );
		navyButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(560f, -425f);} );
		glaucousButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition =  savedPosition = new Vector3(700f, -425f);} );
	}
	void CheckToHideSelectionColor()
	{
		if (sceneIndex == 9)
		{
			selectionBox.transform.SetParent(colorSelection_Parent.transform);
		}
		else if (sceneIndex > 9)
		{
			selectionBox.transform.SetParent(hidden_Parent.transform);
		}
		else
		{
			selectionBox.transform.SetParent(hidden_Parent.transform);
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
