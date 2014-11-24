using UnityEngine;
using System.Collections;

public class InterfaceParenter : MonoBehaviour {

	public GameObject interface1;
	public GameObject interface2;
	public GameObject interfaceContainer;

	void interfaceSwap()
	{
		interfaceContainer.transform.parent = interface2.transform;
	}

	void resetInterface()
	{
		interfaceContainer.transform.parent = interface1.transform;
	}
}
