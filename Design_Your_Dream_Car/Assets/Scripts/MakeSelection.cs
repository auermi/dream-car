//Written by Michael Andrew Auer for the Indianapolis Museum of Art Dream Car iPad Application
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MakeSelection : MonoBehaviour {

	//All Buttons that will affect the visibility of the "Please Make A Selection" text and invisible button
	public GameObject gas_Button;
	public GameObject electric_Button;
	public GameObject hybrid_Button;
	public GameObject twoWheelDrive_Button;
	public GameObject allWheelDrive_Button;
	public GameObject automatic_Button;
	public GameObject manual_Button;
	public GameObject coupe_Button;
	public GameObject compact_Button;
	public GameObject minivan_Button;
	public GameObject truck_Button;
	public GameObject suv_Button;
	public GameObject sportyWheel_Button;
	public GameObject luxuryWheel_Button;
	public GameObject basicWheel_Button;
	public GameObject redColor_Button;
	public GameObject greenColor_Button;
	public GameObject yellowColor_Button;
	public GameObject orangeColor_Button;
	public GameObject turquoiseColor_Button;
	public GameObject carrotColor_Button;
	public GameObject pinkColor_Button;
	public GameObject greyColor_Button;
	public GameObject limeColor_Button;
	public GameObject blueColor_Button;
	public GameObject glaucousColor_Button;

	//Transparent Button Overlaying the Next Button which activates the Please make a selection text
	public GameObject makeASelection_Button;
	//Text
	public GameObject makeASelection_Text;
	//Scene index tracks when we need the make a selection message
	private int scene_Index;
	//Parent Objects to hide/unhide objects
	public GameObject hidden_Parent;
	public GameObject navigation_Parent;
	public GameObject interface_Parent;
	//Tracking scene index here
	public GameObject next_Button;
	public GameObject previous_Button;
	public GameObject done_Button;
	public GameObject restart_Button;
	public GameObject start_Button;

	// Use this for initialization
	void Start () {
		scene_Index = 0;
		/*Keeping track of which screen is which here
		 * Removing the text first before we enable it as a precaution
		 */
		next_Button.GetComponent<Button> ().onClick.AddListener (() => { scene_Index++; RemoveMessageButtonText(); EnableMessageButton(); });
		previous_Button.GetComponent<Button> ().onClick.AddListener (() => { scene_Index--; RemoveMessageButtonText(); EnableMessageButton(); });
		done_Button.GetComponent<Button> ().onClick.AddListener (() => {scene_Index = 0;RemoveMessageButtonText();});
		restart_Button.GetComponent<Button>().onClick.AddListener(()=>{scene_Index = 0;RemoveMessageButtonText();});
		start_Button.GetComponent<Button> ().onClick.AddListener (() => {scene_Index++;});

		//Making a selection on any of these buttons removes the selection text as well as the selection button
		gas_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		electric_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		hybrid_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		manual_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		automatic_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		allWheelDrive_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		twoWheelDrive_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		truck_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		suv_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		minivan_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		coupe_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		compact_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		basicWheel_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		luxuryWheel_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		sportyWheel_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		redColor_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		greenColor_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		yellowColor_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		orangeColor_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		pinkColor_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		greyColor_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		limeColor_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		carrotColor_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		blueColor_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		glaucousColor_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		turquoiseColor_Button.GetComponent<Button> ().onClick.AddListener (() => {RemoveMessageButtonText();});
		
		//Pressing the transparent Button brings up the text
		makeASelection_Button.GetComponent<Button> ().onClick.AddListener (() => {makeASelection_Text.transform.parent = interface_Parent.transform; });

	}

	void EnableMessageButton()
	{
		if (scene_Index == 2 || scene_Index == 3 || scene_Index == 4 || scene_Index == 6 || scene_Index == 8 || scene_Index == 9) {
			makeASelection_Button.transform.parent = interface_Parent.transform;
			//makeASelection_Text.transform.parent = interface_Parent.transform;
		}
		else
		{
			makeASelection_Button.transform.parent = hidden_Parent.transform;
			makeASelection_Text.transform.parent = hidden_Parent.transform;
		}
	}
	void RemoveMessageButtonText()
	{
		makeASelection_Button.transform.parent = hidden_Parent.transform;
		makeASelection_Text.transform.parent = hidden_Parent.transform;
	}
}
