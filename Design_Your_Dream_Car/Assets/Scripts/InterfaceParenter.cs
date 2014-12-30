//Written by Michael Andrew Auer for the Indianapolis Museum of Art Dream Car iPad Application
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InterfaceParenter : MonoBehaviour {

	//Referencing the app slider which contains the game object we want to access
	public GameObject appSlider_ref;

	//Parents for keeping the dashboard hidden on the right screens
	public GameObject hidden_Parent;
	public GameObject interface_Parent;

	//Interface container
	public GameObject interface_Container;

	/*First we grab the updated transition script value
	Then, we check each frame to see if we need to change the visibility of the dashboard*/
	void Update()
	{
		Transition transition_script = appSlider_ref.GetComponent<Transition>();

		if (transition_script.scene_index == 0 || transition_script.scene_index == 1 || transition_script.scene_index == 5)
		{
			interface_Container.transform.parent = hidden_Parent.transform;
		}
		else
		{
			interface_Container.transform.parent = interface_Parent.transform;
		}
	}
}
