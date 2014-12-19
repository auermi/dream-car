using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class colorSelection : MonoBehaviour {

	public GameObject selectionBox;
	public GameObject nextButtonColor;

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


	private Color32 selectionColor = new Color32(0, 118, 192, 255);

	// Use this for initialization
	void Start () {

		//If color button is pressed, change box color and move it to position behind specified color button
		redButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(-350f,-212.9f);} );
		greenButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(-280f, -212.9f);} );
		yellowButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(-210f,-212.9f);} );
		orangeButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(-140f, -212.9f);} );
		turquoiseButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(-70f,-212.9f);} );
		carrotButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(0f, -212.9f);} );
		pinkButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(70f,-212.9f);} );
		greyButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(140f, -212.9f);} );
		limeButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(210f,-212.9f);} );
		navyButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(280f, -212.9f);} );
		glaucousButton.GetComponent<Button>().onClick.AddListener(() => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(350f, -212.9f);} );

		//Reset selectionBox out of sight
		nextButtonColor.GetComponent<Button>().onClick.AddListener( () => { selectionBox.GetComponent<Image>().color = selectionColor; selectionBox.transform.localPosition = new Vector3(0f, -1000f); });
	}
	

}
