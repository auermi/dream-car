//Written by Michael Andrew Auer for the Indianapolis Museum of Art Dream Car iPad Application
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InterfaceParenter : MonoBehaviour {

	//Tracking the slide number so we can hide the interface as necessary
	private int scene_Index;

	//Parents for keeping the dashboard hidden on the right screens
	public GameObject hidden_Parent;
	public GameObject interface_Parent;

	//Interface container
	public GameObject interface_Container;

	//Tracking scene Index with these buttons
	public GameObject next_Button;
	public GameObject previous_Button;
	public GameObject restart_Button;
	public GameObject start_Button;

	//Event Listeners to track scene index and update interface visibility
	void Start ()
	{
		scene_Index = 0;
		CheckInterfaceVisibility ();
		next_Button.GetComponent<Button> ().onClick.AddListener (() => { scene_Index++; CheckInterfaceVisibility(); });
		previous_Button.GetComponent<Button>().onClick.AddListener ( () => { scene_Index--; CheckInterfaceVisibility();  });
		restart_Button.GetComponent<Button> ().onClick.AddListener (() => { scene_Index = 0; CheckInterfaceVisibility(); });
		start_Button.GetComponent<Button> ().onClick.AddListener (() => { scene_Index++; CheckInterfaceVisibility(); });
	}

	//Checking to see if the interface needs to be hidden or unhidden
	//We parent flanking the ones we want to hide on so as to unhide the interface as needed
	void CheckInterfaceVisibility()
	{
		switch (scene_Index) 
		{
		case 0:
			interface_Container.transform.parent = hidden_Parent.transform;
			break;
		case 1:
			interface_Container.transform.parent = hidden_Parent.transform;
			break;
		case 2:
			interface_Container.transform.parent = interface_Parent.transform;
			break;
		case 4:
			interface_Container.transform.parent = interface_Parent.transform;
			break;
		case 5:
			interface_Container.transform.parent = hidden_Parent.transform;
			break;
		case 6:
			interface_Container.transform.parent = interface_Parent.transform;
			break;
		case 11:
			interface_Container.transform.parent = hidden_Parent.transform;
			break;
		//We only track up until 11 because the interface should stay hidden throughout the rest of the app
		default:
			break;
		}
	}

}
